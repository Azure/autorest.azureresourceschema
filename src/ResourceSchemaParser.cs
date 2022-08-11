// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using System.Text.RegularExpressions;
using AutoRest.AzureResourceSchema.Models;
using AutoRest.Core.Logging;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Collections;
using System.Drawing;
using YamlDotNet.Core.Tokens;
using System.IO;
using AutoRest.Modeler.Model;

namespace AutoRest.AzureResourceSchema
{
    /// <summary>
    /// The ResourceSchemaParser class is responsible for converting a ServiceClient object into a
    /// ResourceSchemaModel.
    /// </summary>
    public static class ResourceSchemaParser
    {
        public static void LogMessage(string message)
            => Logger.Instance.Log(new LogMessage(Category.Information, message));

        public static void LogWarning(string message)
            => Logger.Instance.Log(new LogMessage(Category.Warning, message));

        public static void LogError(string message)
            => Logger.Instance.Log(new LogMessage(Category.Error, message));

        private static readonly Regex parentScopePrefix = new Regex("^.*/providers/", RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
        private static readonly Regex managementGroupPrefix = new Regex("^/providers/Microsoft.Management/managementGroups/{\\w+}/$", RegexOptions.IgnoreCase);
        private static readonly Regex tenantPrefix = new Regex("^/$", RegexOptions.IgnoreCase);
        private static readonly Regex subscriptionPrefix = new Regex("^/subscriptions/{\\w+}/$", RegexOptions.IgnoreCase);
        private static readonly Regex resourceGroupPrefix = new Regex("^/subscriptions/{\\w+}/resourceGroups/{\\w+}/$", RegexOptions.IgnoreCase);

        private static bool ShouldProcess(CodeModel codeModel, Method method, string apiVersion)
        {
            if (method.HttpMethod != HttpMethod.Put)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(method.Url))
            {
                return false;
            }

            return Array.Exists(method.XMsMetadata.apiVersions, v => v.Equals(apiVersion));
        }

        private static (bool success, string failureReason, IEnumerable<ResourceDescriptor> resourceDescriptors) ParseMethod(Method method, string apiVersion)
        {
            var finalProvidersMatch = parentScopePrefix.Match(method.Url);
            if (!finalProvidersMatch.Success)
            {
                return (false, "Unable to locate '/providers/' segment", Enumerable.Empty<ResourceDescriptor>());
            }

            var parentScope = method.Url.Substring(0, finalProvidersMatch.Length - "providers/".Length);
            var routingScope = method.Url.Substring(finalProvidersMatch.Length);

            var providerNamespace = routingScope.Substring(0, routingScope.IndexOf('/'));
            if (IsPathVariable(providerNamespace))
            {
                return (false, $"Unable to process parameterized provider namespace '{providerNamespace}'", Enumerable.Empty<ResourceDescriptor>());
            }

            var (success, failureReason, resourceTypesFound) = ParseResourceTypes(method, routingScope);
            if (!success)
            {
                return (false, failureReason, Enumerable.Empty<ResourceDescriptor>());
            }

            var resNameParam = routingScope.Substring(routingScope.LastIndexOf('/') + 1);
            var hasVariableName = IsPathVariable(resNameParam);

            var scopeType = ScopeType.Unknown;
            if (tenantPrefix.IsMatch(parentScope))
            {
                scopeType = ScopeType.Tenant;
            }
            else if (managementGroupPrefix.IsMatch(parentScope))
            {
                scopeType = ScopeType.ManagementGroup;
            }
            else if (resourceGroupPrefix.IsMatch(parentScope))
            {
                scopeType = ScopeType.ResourceGroup;
            }
            else if (subscriptionPrefix.IsMatch(parentScope))
            {
                scopeType = ScopeType.Subscription;
            }
            else if (parentScopePrefix.IsMatch(parentScope))
            {
                scopeType = ScopeType.Extension;
            }

            return (true, string.Empty, resourceTypesFound.Select(type => new ResourceDescriptor
            {
                ScopeType = scopeType,
                ProviderNamespace = providerNamespace,
                ResourceTypeSegments = type.ToList(),
                ApiVersion = apiVersion,
                HasVariableName = hasVariableName,
                XmsMetadata = method.XMsMetadata,
            }));
        }

        private static (bool success, string failureReason, IEnumerable<IEnumerable<string>> resourceTypesFound) ParseResourceTypes(Method method, string routingScope)
        {
            var nameSegments = routingScope.Split('/').Skip(1).Where((_, i) => i % 2 == 0);

            if (nameSegments.Count() == 0)
            {
                return (false, $"Unable to find name segments", Enumerable.Empty<IEnumerable<string>>());
            }

            IEnumerable<IEnumerable<string>> resourceTypes = new[] { Enumerable.Empty<string>() };
            foreach (var nameSegment in nameSegments)
            {
                if (IsPathVariable(nameSegment))
                {
                    var parameterName = TrimParamBraces(nameSegment);
                    var parameter = method.Parameters.FirstOrDefault(methodParameter => methodParameter.SerializedName == parameterName);
                    if (parameter == null)
                    {
                        return (false, $"Found undefined parameter reference {nameSegment}", Enumerable.Empty<IEnumerable<string>>());
                    }

                    if (parameter.ModelType == null || !(parameter.ModelType is EnumType parameterType))
                    {
                        return (false, $"Parameter reference {nameSegment} is not defined as an enum", Enumerable.Empty<IEnumerable<string>>());
                    }

                    if (parameterType.Values == null || parameterType.Values.Count == 0)
                    {
                        return (false, $"Parameter reference {nameSegment} is defined as an enum, but doesn't have any specified values", Enumerable.Empty<IEnumerable<string>>());
                    }

                    resourceTypes = resourceTypes.SelectMany(type => parameterType.Values.Select(v => type.Append(v.SerializedName)));
                }
                else
                {
                    resourceTypes = resourceTypes.Select(type => type.Append(nameSegment));
                }
            }

            return (true, string.Empty, resourceTypes);
        }

        private static ResourceName CreateConstantResourceName(ResourceDescriptor descriptor, string nameValue, string description = null)
        {
            var constantNameSchema = descriptor.IsRootType ?
                JsonSchema.CreateSingleValuedEnum(nameValue) :
                new JsonSchema
                {
                    JsonType = "string",
                    Pattern = $"^.*/{Regex.Escape(nameValue)}$",
                };

            constantNameSchema.Description = description;

            return new ResourceName
            {
                HasConstantName = true,
                NameString = nameValue,
                NameSchema = constantNameSchema,
            };
        }

        private static (bool success, string failureReason, ResourceName name) ParseNameSchema(CodeModel codeModel, Method method, ProviderDefinition providerDefinition, ResourceDescriptor descriptor)
        {
            var finalProvidersMatch = parentScopePrefix.Match(method.Url);
            var routingScope = method.Url.Substring(finalProvidersMatch.Length);

            // get the resource name parameter, e.g. {fooName}
            var resNameParam = routingScope.Substring(routingScope.LastIndexOf('/') + 1);

            if (IsPathVariable(resNameParam))
            {
                // strip the enclosing braces
                resNameParam = TrimParamBraces(resNameParam);

                // look up the type
                var param = method.Parameters.FirstOrDefault(p => p.SerializedName == resNameParam);

                if (param == null)
                {
                    return (false, $"Unable to locate parameter with name '{resNameParam}'", null);
                }

                var nameSchema = ParseType(param.ClientProperty, param.ModelType, providerDefinition.SchemaDefinitions, codeModel.ModelTypes);
                nameSchema.ResourceType = resNameParam;

                if (!string.IsNullOrEmpty(param.Documentation))
                {
                    nameSchema.Description = RemovePossibleValuesFromDescription(param.Documentation);
                }

                if (nameSchema?.Enum?.Count == 1)
                {
                    // Resource name is a constant
                    return (true, string.Empty, CreateConstantResourceName(descriptor, nameSchema.Enum.Single(), nameSchema.Description));
                }

                return (true, string.Empty, new ResourceName
                {
                    HasConstantName = false,
                    NameString = string.Empty,
                    NameSchema = nameSchema,
                });
            }

            if (!resNameParam.All(c => char.IsLetterOrDigit(c)))
            {
                return (false, $"Unable to process non-alphanumeric name '{resNameParam}'", null);
            }

            // Resource name is a constant
            return (true, string.Empty, CreateConstantResourceName(descriptor, resNameParam));
        }

        /// <summary>
        /// Parse a ResourceSchemaModel from the provided ServiceClient.
        /// </summary>
        /// <param name="serviceClient"></param>
        /// <returns></returns>
        public static IDictionary<string, ResourceSchema> Parse(CodeModel serviceClient, string apiVersion)
        {
            if (serviceClient == null)
            {
                throw new ArgumentNullException(nameof(serviceClient));
            }

            var providerDefinitions = new Dictionary<string, ProviderDefinition>(StringComparer.OrdinalIgnoreCase);

            foreach (var method in serviceClient.Methods.Where(method => ShouldProcess(serviceClient, method, apiVersion)))
            {
                var (success, failureReason, resourceDescriptors) = ParseMethod(method, apiVersion);
                if (!success)
                {
                    LogWarning($"Skipping path '{method.Url}': {failureReason}");
                    continue;
                }

                foreach (var descriptor in resourceDescriptors)
                {
                    if (!providerDefinitions.ContainsKey(descriptor.ProviderNamespace))
                    {
                        providerDefinitions[descriptor.ProviderNamespace] = new ProviderDefinition
                        {
                            Namespace = descriptor.ProviderNamespace,
                            ApiVersion = apiVersion,
                        };
                    }
                    var providerDefinition = providerDefinitions[descriptor.ProviderNamespace];

                    var baseSchema = new JsonSchema
                    {
                        JsonType = "object",
                        ResourceType = descriptor.FullyQualifiedType,
                        Description = descriptor.FullyQualifiedType,
                    };

                    ResourceName resourceName;
                    (success, failureReason, resourceName) = ParseNameSchema(serviceClient, method, providerDefinition, descriptor);
                    if (!success)
                    {
                        LogWarning($"Skipping resource type {descriptor.FullyQualifiedType} under path '{method.Url}': {failureReason}");
                        continue;
                    }

                    if (method.Body?.ModelType is CompositeType body)
                    {
                        foreach (var property in body.ComposedProperties)
                        {
                            if (property.SerializedName == null)
                            {
                                continue;
                            }

                            if (baseSchema.Properties != null && baseSchema.Properties.Keys.Contains(property.SerializedName))
                            {
                                continue;
                            }

                            var propertyDefinition = ParseType(property, property.ModelType, providerDefinition.SchemaDefinitions, serviceClient.ModelTypes);
                            if (propertyDefinition != null)
                            {
                                baseSchema.AddProperty(property.SerializedName, propertyDefinition, property.IsRequired);
                            }
                        }

                        HandlePolymorphicType(baseSchema, body, providerDefinition.SchemaDefinitions, serviceClient.ModelTypes);
                    }

                    providerDefinition.ResourceDefinitions.Add(new ResourceDefinition
                    {
                        BaseSchema = baseSchema,
                        Descriptor = descriptor,
                        Name = resourceName,
                    });
                }
            }

            return providerDefinitions.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateSchema(kvp.Value),
                StringComparer.OrdinalIgnoreCase);
        }

        private static ResourceSchema CreateSchema(ProviderDefinition providerDefinition)
        {
            var processedSchemas = new Dictionary<string, JsonSchema>(StringComparer.OrdinalIgnoreCase);
            var resourceDefinitions = new Dictionary<ResourceDescriptor, JsonSchema>(ResourceDescriptor.Comparer);

            // Order by resource type length to process parent resources before child resources
            var definitionsByDescriptor = providerDefinition
                .ResourceDefinitions.ToLookup(x => x.Descriptor, ResourceDescriptor.Comparer)
                .OrderBy(grouping => grouping.Key.ResourceTypeSegments.Count);

            foreach (var definitionGrouping in definitionsByDescriptor)
            {
                var descriptor = definitionGrouping.Key;
                var definitions = definitionGrouping.ToArray();

                if (processedSchemas.ContainsKey(descriptor.FullyQualifiedTypeWithScope))
                {
                    LogWarning($"Found duplicate definition for type {descriptor.FullyQualifiedType} in scope {descriptor.ScopeType}");
                    continue;
                }

                if (definitions.Length > 1 && descriptor.HasVariableName)
                {
                    var selectedDefinition = definitions.First();

                    foreach (var definition in definitions.Skip(1))
                    {
                        LogWarning($"Found duplicate definition for variable-named type {descriptor.FullyQualifiedType}. Skipping definition with path '{definition.Descriptor.XmsMetadata.path}'.");
                    }
                    LogWarning($"Found duplicate definition for variable-named type {descriptor.FullyQualifiedType}. Using definition with path '{selectedDefinition.Descriptor.XmsMetadata.path}'.");

                    definitions = new[] { selectedDefinition };
                }

                // Add schema to global resources
                {
                    JsonSchema schema;
                    if (definitions.Length == 1)
                    {
                        schema = definitions.Single().BaseSchema.Clone();

                        schema.AddPropertyWithOverwrite("name", definitions.Single().Name.NameSchema.Clone(), true);
                        schema.AddPropertyWithOverwrite("type", JsonSchema.CreateSingleValuedEnum(descriptor.FullyQualifiedType), true);
                        schema.AddPropertyWithOverwrite("apiVersion", JsonSchema.CreateSingleValuedEnum(descriptor.ApiVersion), true);
                    }
                    else
                    {
                        schema = new JsonSchema
                        {
                            JsonType = "object",
                            Description = descriptor.FullyQualifiedType,
                        };

                        foreach (var definition in definitions)
                        {
                            if (!definition.Name.HasConstantName)
                            {
                                throw new InvalidOperationException($"Unable to reconcile variable-named resource {descriptor.FullyQualifiedType}");
                            }

                            var oneOfSchema = definition.BaseSchema.Clone();

                            oneOfSchema.AddPropertyWithOverwrite("name", definition.Name.NameSchema.Clone(), true);

                            schema.AddOneOf(oneOfSchema);
                        }

                        schema.AddPropertyWithOverwrite("type", JsonSchema.CreateSingleValuedEnum(descriptor.FullyQualifiedType), true);
                        schema.AddPropertyWithOverwrite("apiVersion", JsonSchema.CreateSingleValuedEnum(descriptor.ApiVersion), true);
                    }

                    processedSchemas[descriptor.FullyQualifiedTypeWithScope] = schema;
                    resourceDefinitions[descriptor] = schema;
                }

                // Add schema to parent resources if necessary
                if (!descriptor.IsRootType && processedSchemas.TryGetValue(ResourceDescriptor.FormatParentFullyQualifiedTypeWithScope(descriptor), out var parentSchema))
                {
                    if (!parentSchema.Properties.ContainsKey("resources"))
                    {
                        parentSchema.AddProperty("resources", new JsonSchema
                        {
                            JsonType = "array",
                            Items = new JsonSchema(),
                        });
                    }

                    JsonSchema childSchema;
                    if (definitions.Length == 1)
                    {
                        childSchema = definitions.Single().BaseSchema.Clone();

                        var resourceName = definitions.Single().Name;
                        var nameSchema = resourceName.HasConstantName ? JsonSchema.CreateSingleValuedEnum(resourceName.NameString) : resourceName.NameSchema;
                        nameSchema.Description = resourceName.NameSchema?.Description;

                        childSchema.AddPropertyWithOverwrite("name", nameSchema, true);
                        childSchema.AddPropertyWithOverwrite("type", JsonSchema.CreateSingleValuedEnum(descriptor.ResourceTypeSegments.Last()), true);
                        childSchema.AddPropertyWithOverwrite("apiVersion", JsonSchema.CreateSingleValuedEnum(descriptor.ApiVersion), true);
                    }
                    else
                    {
                        childSchema = new JsonSchema
                        {
                            JsonType = "object",
                            Description = descriptor.FullyQualifiedType,
                        };

                        foreach (var definition in definitions)
                        {
                            if (!definition.Name.HasConstantName)
                            {
                                throw new InvalidOperationException($"Unable to reconcile variable-named resource {descriptor.FullyQualifiedType}");
                            }

                            var oneOfSchema = definition.BaseSchema.Clone();

                            var nameSchema = JsonSchema.CreateSingleValuedEnum(definition.Name.NameString);
                            nameSchema.Description = definition.Name.NameSchema?.Description;

                            oneOfSchema.AddPropertyWithOverwrite("name", nameSchema, true);

                            childSchema.AddOneOf(oneOfSchema);
                        }

                        childSchema.AddPropertyWithOverwrite("type", JsonSchema.CreateSingleValuedEnum(descriptor.ResourceTypeSegments.Last()), true);
                        childSchema.AddPropertyWithOverwrite("apiVersion", JsonSchema.CreateSingleValuedEnum(descriptor.ApiVersion), true);
                    }

                    var childDefinitionName = ResourceSchema.FormatResourceSchemaKey(descriptor.ResourceTypeSegments) + "_childResource";
                    if (!providerDefinition.SchemaDefinitions.ContainsKey(childDefinitionName))
                    {
                        providerDefinition.SchemaDefinitions.Add(childDefinitionName, childSchema);
                    }

                    parentSchema.Properties["resources"].Items.AddOneOf(new JsonSchema
                    {
                        Ref = "#/definitions/" + childDefinitionName,
                    });
                }
            }

            return new ResourceSchema
            {
                Id = $"https://schema.management.azure.com/schemas/{providerDefinition.ApiVersion}/{providerDefinition.Namespace}.json#",
                Title = providerDefinition.Namespace,
                Description = providerDefinition.Namespace.Replace('.', ' ') + " Resource Types",
                Schema = "http://json-schema.org/draft-04/schema#",
                Definitions = providerDefinition.SchemaDefinitions,
                ResourceDefinitions = resourceDefinitions,
            };
        }

        private static JsonSchema ParseType(Property property, IModelType type, IDictionary<string, JsonSchema> definitions, IEnumerable<CompositeType> modelTypes)
        {
            if (property == null || !property.IsReadOnly)
            {
                // A schema that matches a JSON object with specific properties, such as
                // { "name": { "type": "string" }, "age": { "type": "number" } }
                if (type is CompositeType compositeType)
                {
                    return ParseCompositeType(property, compositeType, true, definitions, modelTypes);
                }
                // A schema that matches a "dictionary" JSON object, such as
                // { "additionalProperties": { "type": "string" } }
                if (type is DictionaryType dictionaryType)
                {
                    return ParseDictionaryType(property, dictionaryType, definitions, modelTypes);
                }
                // A schema that matches a single value from a given set of values, such as
                // { "enum": [ "a", "b" ] }
                if (type is EnumType enumType)
                {
                    return ParseEnumType(property, enumType);
                }
                // A schema that matches simple values, such as { "type": "number" }
                if (type is PrimaryType primaryType)
                {
                    return ParsePrimaryType(property, primaryType);
                }
                // A schema that matches an array of values, such as
                // { "items": { "type": "number" } }
                if (type is SequenceType sequenceType)
                {
                    return ParseSequenceType(property, sequenceType, definitions, modelTypes);
                }
                // A schema that matches anything
                if (type is MultiType)
                {
                    return new JsonSchema();
                }
                Debug.Fail("Unrecognized property type: " + type.GetType());
            }
            return null;
        }

        private static JsonSchema ParseCompositeType(Property property, CompositeType compositeType, bool includeBaseModelTypeProperties, IDictionary<string, JsonSchema> definitions, IEnumerable<CompositeType> modelTypes)
        {
            string definitionName = compositeType.Name;

            if (!definitions.ContainsKey(definitionName))
            {
                JsonSchema definition = new JsonSchema()
                {
                    JsonType = "object",
                    Description = compositeType.Documentation,
                };

                // This definition must be added to the definition map before we start parsing
                // its properties because its properties may recursively reference back to this
                // definition.
                definitions.Add(definitionName, definition);

                IEnumerable<Property> compositeTypeProperties = includeBaseModelTypeProperties ? compositeType.ComposedProperties : compositeType.Properties;
                foreach (Property subProperty in compositeTypeProperties)
                {
                    JsonSchema subPropertyDefinition = ParseType(subProperty, subProperty.ModelType, definitions, modelTypes);
                    if (subPropertyDefinition != null)
                    {
                        definition.AddProperty(subProperty.SerializedName.Else(subProperty.Name.RawValue), subPropertyDefinition, subProperty.IsRequired);
                    }
                }

                HandlePolymorphicType(definition, compositeType, definitions, modelTypes);
            }

            JsonSchema result = new JsonSchema()
            {
                Ref = "#/definitions/" + definitionName
            };

            if (property != null)
            {
                result.Description = RemovePossibleValuesFromDescription(property.Documentation);
            }

            return result;
        }

        private static void HandlePolymorphicType(JsonSchema definition, CompositeType compositeType, IDictionary<string, JsonSchema> definitions, IEnumerable<CompositeType> modelTypes)
        {
            if (!string.IsNullOrWhiteSpace(compositeType.BasePolymorphicDiscriminator))
            {
                foreach (var subType in modelTypes.Where(type => type.BaseModelType == compositeType))
                {
                    // Sub-types are never referenced directly in the Swagger
                    // discriminator scenario, so they wouldn't be added to the
                    // produced resource schema. By calling ParseCompositeType() on the
                    // sub-type we add the sub-type to the resource schema.
                    var polymorphicTypeRef = ParseCompositeType(null, subType, false, definitions, modelTypes);
                    definitions[subType.Name].AddProperty(compositeType.BasePolymorphicDiscriminator, JsonSchema.CreateSingleValuedEnum(subType.SerializedName), true);

                    definition.AddOneOf(polymorphicTypeRef);
                }
            }
        }

        private static JsonSchema ParseDictionaryType(Property property, DictionaryType dictionaryType, IDictionary<string, JsonSchema> definitions, IEnumerable<CompositeType> modelTypes)
        {
            JsonSchema result = new JsonSchema()
            {
                JsonType = "object",
                AdditionalProperties = ParseType(null, dictionaryType.ValueType, definitions, modelTypes)
            };

            if (property != null)
            {
                result.Description = RemovePossibleValuesFromDescription(property.Documentation);
            }

            return result;
        }

        private static JsonSchema ParseEnumType(Property property, EnumType enumType)
        {
            JsonSchema result = new JsonSchema()
            {
                JsonType = "string"
            };

            foreach (EnumValue enumValue in enumType.Values)
            {
                result.AddEnum(enumValue.SerializedName);
            }

            if (property != null)
            {
                result.Description = RemovePossibleValuesFromDescription(property.Documentation);
            }

            return result;
        }

        private static JsonSchema ParsePrimaryType(Property property, PrimaryType primaryType)
        {
            JsonSchema result = new JsonSchema()
            {
                Format = primaryType.Format
            };

            switch (primaryType.KnownPrimaryType)
            {
                case KnownPrimaryType.Boolean:
                    result.JsonType = "boolean";
                    break;

                case KnownPrimaryType.Int:
                case KnownPrimaryType.Long:
                case KnownPrimaryType.UnixTime:
                    result.JsonType = "integer";
                    break;

                case KnownPrimaryType.Double:
                case KnownPrimaryType.Decimal:
                    result.JsonType = "number";
                    break;

                case KnownPrimaryType.Object:
                    result.JsonType = "object";
                    break;

                case KnownPrimaryType.ByteArray:
                    result.JsonType = "string";
                    result.Pattern = @"^(?:[A-Za-z0-9+\/]{4})*(?:[A-Za-z0-9+\/]{2}==|[A-Za-z0-9+\/]{3}=)?$";
                    break;

                case KnownPrimaryType.Base64Url:
                case KnownPrimaryType.Date:
                case KnownPrimaryType.DateTime:
                case KnownPrimaryType.String:
                case KnownPrimaryType.TimeSpan:
                    result.JsonType = "string";
                    break;

                case KnownPrimaryType.Uuid:
                    result.JsonType = "string";
                    result.Pattern = @"^[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}$";
                    break;

                default:
                    Debug.Assert(false, "Unrecognized known property type: " + primaryType.KnownPrimaryType);
                    break;
            }

            if (property != null)
            {
                result.Description = property.Documentation;

                if (property.DefaultValue != null)
                {
                    if (property.IsConstant)
                    {
                        result.AddEnum(property.DefaultValue);
                    }
                    else
                    {
                        result.Default = property.DefaultValue;
                    }
                }

                if (property.Constraints.Count > 0)
                {
                    foreach (KeyValuePair<Constraint, string> entry in property.Constraints)
                    {
                        switch (entry.Key)
                        {
                            case Constraint.InclusiveMinimum:
                                Debug.Assert(result.JsonType == "integer" || result.JsonType == "number", "Expected to only find an InclusiveMinimum constraint on an integer or number property.");
                                result.Minimum = Double.Parse(entry.Value, CultureInfo.CurrentCulture);
                                break;

                            case Constraint.InclusiveMaximum:
                                Debug.Assert(result.JsonType == "integer" || result.JsonType == "number", "Expected to only find an InclusiveMaximum constraint on an integer or number property.");
                                result.Maximum = Double.Parse(entry.Value, CultureInfo.CurrentCulture);
                                break;

                            case Constraint.MultipleOf:
                                Debug.Assert(result.JsonType == "integer" || result.JsonType == "number", "Expected to only find a MultipleOf constraint on an integer or number property");
                                result.MultipleOf = Double.Parse(entry.Value, CultureInfo.CurrentCulture);
                                break;

                            case Constraint.Pattern:
                                Debug.Assert(result.JsonType == "string", "Expected to only find a Pattern constraint on a string property.");
                                result.Pattern = entry.Value;
                                break;

                            case Constraint.MinLength:
                                Debug.Assert(result.JsonType == "string" || result.JsonType == "array", "Expected to only find a MinLength constraint on a string or array property.");
                                result.MinLength = Double.Parse(entry.Value, CultureInfo.CurrentCulture);
                                break;

                            case Constraint.MaxLength:
                                Debug.Assert(result.JsonType == "string" || result.JsonType == "array", "Expected to only find a MaxLength constraint on a string or array property.");
                                result.MaxLength = Double.Parse(entry.Value, CultureInfo.CurrentCulture);
                                break;

                            default:
                                Debug.Fail("Unrecognized property Constraint: " + entry.Key);
                                break;
                        }
                    }
                }
            }

            return result;
        }

        private static JsonSchema ParseSequenceType(Property property, SequenceType sequenceType, IDictionary<string, JsonSchema> definitions, IEnumerable<CompositeType> modelTypes)
        {
            JsonSchema result = new JsonSchema()
            {
                JsonType = "array",
                Items = ParseType(null, sequenceType.ElementType, definitions, modelTypes)
            };

            if (property != null)
            {
                result.Description = RemovePossibleValuesFromDescription(property.Documentation);
            }

            return result;
        }


        /// <summary>
        /// AutoRest has no way of indicating that you don't want Enum properties to have a
        /// "Possible values include: ..." string appended at the end of their descriptions. This
        /// function removes the "Possible values" suffix if it exists.
        /// </summary>
        /// <param name="description">The description to remove the "Possible values" suffix from.</param>
        /// <returns></returns>
        private static string RemovePossibleValuesFromDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                int possibleValuesIndex = description.IndexOf("Possible values include: ", StringComparison.OrdinalIgnoreCase);
                if (possibleValuesIndex > -1)
                {
                    description = description.Substring(0, possibleValuesIndex).TrimEnd();
                }
            }
            return description;
        }

        private static bool IsPathVariable(string pathSegment)
        {
            Debug.Assert(pathSegment != null);

            return pathSegment.StartsWith("{", StringComparison.Ordinal) && pathSegment.EndsWith("}", StringComparison.Ordinal);
        }

        private static string TrimParamBraces(string pathSegment)
            => pathSegment.Substring(1, pathSegment.Length - 2);
    }
}
