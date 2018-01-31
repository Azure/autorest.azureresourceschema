﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using System.Text.RegularExpressions;

namespace AutoRest.AzureResourceSchema
{
    /// <summary>
    /// The ResourceSchemaParser class is responsible for converting a ServiceClient object into a
    /// ResourceSchemaModel.
    /// </summary>
    public static class ResourceSchemaParser
    {
        private const string resourceMethodPrefix = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/";
        private static Regex resourceMethodPrefixRx = new Regex( "^/subscriptions/{subscriptionId}/resourceGroups/{\\w*}/providers/",RegexOptions.IgnoreCase );

        /// <summary>
        /// Parse a ResourceSchemaModel from the provided ServiceClient.
        /// </summary>
        /// <param name="serviceClient"></param>
        /// <returns></returns>
        public static IDictionary<string, ResourceSchema> Parse(CodeModel serviceClient, string version)
        {
            
            if (serviceClient == null)
            {
                throw new ArgumentNullException(nameof(serviceClient));
            }

            Dictionary<string, ResourceSchema> resourceSchemas = new Dictionary<string, ResourceSchema>();

            foreach (Method method in serviceClient.Methods.Where( method => method.Parameters.FirstOrDefault(p => p.SerializedName == "api-version")?.DefaultValue.Value == version || version == serviceClient.ApiVersion))
            {
                if (method.HttpMethod != HttpMethod.Put ||
                    string.IsNullOrWhiteSpace(method.Url) ||
                    !resourceMethodPrefixRx.IsMatch(method.Url) || 
                    !method.Url.EndsWith("}", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                string afterPrefix = method.Url.Substring(resourceMethodPrefixRx.Match(method.Url).Length);
                int forwardSlashIndexAfterProvider = afterPrefix.IndexOf('/');
                string resourceProvider = afterPrefix.Substring(0, forwardSlashIndexAfterProvider);

                if (IsPathVariable(resourceProvider))
                {
                    // If the resourceProvider is a path variable, such as {someValue}, then this
                    // is not a create resource method. Skip it.
                    continue;
                }

                // extract API version
                string apiVersion = serviceClient.ApiVersion.Else(method.Parameters.FirstOrDefault(p => p.SerializedName == "api-version")?.DefaultValue);
                if (string.IsNullOrWhiteSpace(apiVersion))
                {
                    throw new ArgumentException("No API version is provided in the swagger document or the method.");
                }

                ResourceSchema resourceSchema;
                if (!resourceSchemas.ContainsKey(resourceProvider))
                {
                    resourceSchema = new ResourceSchema();
                    resourceSchema.Id = string.Format(CultureInfo.InvariantCulture, "https://schema.management.azure.com/schemas/{0}/{1}.json#", apiVersion, resourceProvider);
                    resourceSchema.Title = resourceProvider;
                    resourceSchema.Description = resourceProvider.Replace('.', ' ') + " Resource Types";
                    resourceSchema.Schema = "http://json-schema.org/draft-04/schema#";

                    resourceSchemas.Add(resourceProvider, resourceSchema);
                }
                else
                {
                    resourceSchema = resourceSchemas[resourceProvider];
                }

                string methodUrlPathAfterProvider = afterPrefix.Substring(forwardSlashIndexAfterProvider + 1);
                string[] resourceTypes = ParseResourceTypes(resourceProvider, methodUrlPathAfterProvider, method);
                foreach (string resourceType in resourceTypes)
                {
                    JsonSchema resourceDefinition = new JsonSchema();
                    resourceDefinition.JsonType = "object";
                    resourceDefinition.ResourceType = resourceType;

                    // get the resource name parameter, e.g. {fooName}
                    var resNameParam = methodUrlPathAfterProvider.Substring(methodUrlPathAfterProvider.LastIndexOf('/') + 1);
                    if (IsPathVariable(resNameParam))
                    {
                        // strip the enclosing braces
                        resNameParam = resNameParam.Trim(new[] { '{', '}' });

                        // look up the type
                        var param = method.Parameters.Where(p => p.SerializedName == resNameParam).FirstOrDefault();
                        if (param != null)
                        {
                            // create a schema for it
                            var nameParamSchema = ParseType(param.ClientProperty, param.ModelType, resourceSchema.Definitions, serviceClient.ModelTypes);
                            nameParamSchema.ResourceType = resNameParam;

                            // add it as the name property
                            resourceDefinition.AddProperty("name", nameParamSchema, true);
                        }
                    }

                    resourceDefinition.AddProperty("type", JsonSchema.CreateStringEnum(resourceType), true);
                    resourceDefinition.AddProperty("apiVersion", JsonSchema.CreateStringEnum(apiVersion), true);

                    if (method.Body != null)
                    {
                        CompositeType body = method.Body.ModelType as CompositeType;
                        // Debug.Assert(body != null, "The create resource method's body must be a CompositeType and cannot be null.");
                        if (body != null)
                        {
                            foreach (Property property in body.ComposedProperties)
                            {
                                if (property.SerializedName != null && !resourceDefinition.Properties.Keys.Contains(property.SerializedName))
                                {
                                    JsonSchema propertyDefinition = ParseType(property, property.ModelType, resourceSchema.Definitions, serviceClient.ModelTypes);
                                    if (propertyDefinition != null)
                                    {
                                        resourceDefinition.AddProperty(property.SerializedName, propertyDefinition, property.IsRequired || property.SerializedName == "properties");
                                    }
                                }
                            }
                        }
                    }

                    resourceDefinition.Description = resourceType;

                    string resourcePropertyName = resourceType.Substring(resourceProvider.Length + 1).Replace('/', '_');

                    Debug.Assert(!resourceSchema.ResourceDefinitions.ContainsKey(resourcePropertyName));
                    resourceSchema.AddResourceDefinition(resourcePropertyName, resourceDefinition);
                }
            }

            // This loop adds child resource schemas to their parent resource schemas. We can't do
            // this until we're done adding all resources as top level resources, though, because
            // it's possible that we will parse a child resource before we parse the parent
            // resource.
            foreach (ResourceSchema resourceSchema in resourceSchemas.Values)
            {
                // By iterating over the reverse order of the defined resource definitions, I'm
                // counting on the resource definitions being in sorted order. That way I'm
                // guaranteed to visit child resource definitions before I visit their parent
                // resource definitions. By doing this, I've guaranteed that grandchildren resource
                // definitions will be added to their grandparent (and beyond) ancestor
                // resource definitions.
                foreach (string resourcePropertyName in resourceSchema.ResourceDefinitions.Keys.Reverse())
                {
                    JsonSchema resourceDefinition = resourceSchema.ResourceDefinitions[resourcePropertyName];

                    string resourceType = resourceDefinition.ResourceType;
                    int lastSlashIndex = resourceType.LastIndexOf('/');
                    string parentResourceType = resourceType.Substring(0, lastSlashIndex);
                    JsonSchema parentResourceDefinition = resourceSchema.GetResourceDefinitionByResourceType(parentResourceType);
                    if (parentResourceDefinition != null)
                    {
                        string childResourceType = resourceType.Substring(lastSlashIndex + 1);
                        JsonSchema childResourceDefinition = resourceDefinition.Clone();
                        childResourceDefinition.ResourceType = childResourceType;

                        string childResourceDefinitionPropertyName = string.Join("_", resourcePropertyName, "childResource");
                        resourceSchema.AddDefinition(childResourceDefinitionPropertyName, childResourceDefinition);

                        JsonSchema childResources;
                        if (parentResourceDefinition.Properties.ContainsKey("resources"))
                        {
                            childResources = parentResourceDefinition.Properties["resources"];
                        }
                        else
                        {
                            childResources = new JsonSchema()
                            {
                                JsonType = "array",
                                Items = new JsonSchema()
                            };
                            parentResourceDefinition.AddProperty("resources", childResources);
                        }

                        childResources.Items.AddOneOf(new JsonSchema()
                        {
                            Ref = "#/definitions/" + childResourceDefinitionPropertyName,
                        });
                    }
                }
            }

            return resourceSchemas;
        }

        private static string[] ParseResourceTypes(string resourceProvider, string methodUrlPathAfterProvider, Method method)
        {
            // Gather the list of resource types defined by this method url. Usually this will
            // result in only one resource type, but if the method url contains an enumerated
            // resource type parameter, then multiple resource types could be declared from a
            // single method url.
            List<string> resourceTypes = new List<string>();
            resourceTypes.Add(resourceProvider);
            string[] pathSegments = methodUrlPathAfterProvider.Split(new char[] { '/' });
            for (int i = 0; i < pathSegments.Length; i += 2)
            {
                string pathSegment = pathSegments[i];
                if (IsPathVariable(pathSegment))
                {
                    string parameterName = pathSegment.Substring(1, pathSegment.Length - 2);
                    Parameter parameter = method.Parameters.FirstOrDefault(methodParameter => methodParameter.SerializedName == parameterName);
                    if (parameter == null)
                    {
                        throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Found undefined parameter reference {0} in create resource method \"{1}/{2}/{3}\".", pathSegment, resourceMethodPrefix, resourceProvider, methodUrlPathAfterProvider));
                    }

                    if (parameter.ModelType == null)
                    {
                        throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Parameter reference {0} has no defined type.", pathSegment));
                    }

                    EnumType parameterType = parameter.ModelType as EnumType;
                    if (parameterType == null)
                    {
                        // If we encounter a parameter in the URL that isn't an enumeration, then
                        // we can't create a resource from this URL.
                        resourceTypes.Clear();
                        break;
                    }

                    if (parameterType.Values == null || parameterType.Values.Count == 0)
                    {
                        string errorMessage = string.Format(CultureInfo.CurrentCulture, "Parameter reference {0} is defined as an enum type, but it doesn't have any specified values.", pathSegment);
                        throw new ArgumentException(errorMessage);
                    }

                    List<string> newResourceTypes = new List<string>();
                    foreach (string resourceType in resourceTypes)
                    {
                        foreach (EnumValue parameterValue in parameterType.Values)
                        {
                            newResourceTypes.Add(string.Join("/", resourceType, parameterValue.SerializedName));
                        }
                    }

                    resourceTypes = newResourceTypes;
                }
                else
                {
                    for (int j = 0; j < resourceTypes.Count; ++j)
                    {
                        resourceTypes[j] = string.Join("/", resourceTypes[j], pathSegment);
                    }
                }
            }

            return resourceTypes.ToArray();
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

                string discriminatorPropertyName = compositeType.BasePolymorphicDiscriminator;
                if (!string.IsNullOrWhiteSpace(discriminatorPropertyName))
                {
                    definition.AddProperty(discriminatorPropertyName, new JsonSchema() { JsonType = "string" }, true);

                    Func<CompositeType, bool> isSubTypeOrSelf = type => type == compositeType || type.BaseModelType == compositeType;
                    CompositeType[] subTypes = modelTypes.Where(isSubTypeOrSelf).ToArray();

                    foreach (CompositeType subType in subTypes)
                    {
                        JsonSchema derivedTypeDefinitionRef = new JsonSchema();

                        JsonSchema discriminatorDefinition = new JsonSchema() { JsonType = "string" };
                        discriminatorDefinition.AddEnum(subType.SerializedName);
                        derivedTypeDefinitionRef.AddProperty(discriminatorPropertyName, discriminatorDefinition);

                        if (subType != compositeType)
                        {
                            // Sub-types are never referenced directly in the Swagger
                            // discriminator scenario, so they wouldn't be added to the
                            // produced resource schema. By calling ParseCompositeType() on the
                            // sub-type we add the sub-type to the resource schema.
                            ParseCompositeType(null, subType, false, definitions, modelTypes);

                            derivedTypeDefinitionRef.AddAllOf(new JsonSchema()
                            {
                                Ref = "#/definitions/" + subType.Name,
                            });
                        }

                        definition.AddOneOf(derivedTypeDefinitionRef);
                    }
                }
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
                    result.JsonType = "array";
                    result.Items =  new JsonSchema()
                    {
                        JsonType = "integer"
                    };
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
    }
}
