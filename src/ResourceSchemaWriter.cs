// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoRest.AzureResourceSchema.Models;
using Newtonsoft.Json;

namespace AutoRest.AzureResourceSchema
{
    public static class ResourceSchemaWriter
    {
        public static void Write(TextWriter writer, ResourceSchema resourceSchema)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (resourceSchema == null)
            {
                throw new ArgumentNullException("resourceSchema");
            }

            using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
            {
                jsonWriter.Formatting = Formatting.Indented;
                jsonWriter.Indentation = 2;
                jsonWriter.IndentChar = ' ';
                jsonWriter.QuoteChar = '\"';

                Write(jsonWriter, resourceSchema);
            }
        }

        private static IDictionary<string, JsonSchema> GetResourceDefinitions(ResourceSchema resourceSchema, ScopeType scopeType)
            => resourceSchema.ResourceDefinitions
                .Where(kvp => kvp.Value.Descriptor.ScopeType == scopeType)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Schema);

        public static void Write(JsonWriter writer, ResourceSchema resourceSchema)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (resourceSchema == null)
            {
                throw new ArgumentNullException("resourceSchema");
            }

            writer.WriteStartObject();

            WriteProperty(writer, "id", resourceSchema.Id);
            WriteProperty(writer, "$schema", resourceSchema.Schema);
            WriteProperty(writer, "title", resourceSchema.Title);
            WriteProperty(writer, "description", resourceSchema.Description);

            var rgDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.ResourceGroup);
            WriteDefinitionMap(writer, "resourceDefinitions", rgDefinitions, sortDefinitions: true, addExpressionReferences: false);

            var subDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Subcription);
            if (subDefinitions.Any())
            {
                WriteDefinitionMap(writer, "subscription_resourceDefinitions", subDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var mgDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.ManagementGroup);
            if (mgDefinitions.Any())
            {
                WriteDefinitionMap(writer, "managementGroup_resourceDefinitions", mgDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var tenantDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Tenant);
            if (tenantDefinitions.Any())
            {
                WriteDefinitionMap(writer, "tenant_resourceDefinitions", tenantDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var extDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Extension);
            if (extDefinitions.Any())
            {
                WriteDefinitionMap(writer, "extension_resourceDefinitions", extDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var unknownDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Unknown);
            if (unknownDefinitions.Any())
            {
                WriteDefinitionMap(writer, "unknown_resourceDefinitions", unknownDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            WriteDefinitionMap(writer, "definitions", resourceSchema.Definitions, sortDefinitions: true, addExpressionReferences: false);

            writer.WriteEndObject();
        }

        private static void WriteDefinitionMap(JsonWriter writer, string definitionMapName, IDictionary<string, JsonSchema> definitionMap, bool sortDefinitions = false, bool addExpressionReferences = false)
        {
            writer.WritePropertyName(definitionMapName);
            writer.WriteStartObject();

            var definitionNames = definitionMap?.Keys ?? Enumerable.Empty<string>();
            if (sortDefinitions)
            {
                definitionNames = definitionNames.OrderBy(key => key, StringComparer.OrdinalIgnoreCase);
            }

            foreach (var definitionName in definitionNames)
            {
                var definition = definitionMap[definitionName];

                var shouldAddExpressionReference = addExpressionReferences && !definition.Configuration.HasFlag(SchemaConfiguration.OmitExpressionRef);
                switch (definition.JsonType)
                {
                    case "object":
                        shouldAddExpressionReference &= !definition.IsEmpty();
                        break;

                    case "string":
                        shouldAddExpressionReference &= (definition.Enum?.Any() == true) || (definition.Pattern != null);
                        break;

                    case "array":
                        shouldAddExpressionReference &= definitionName != "resources";
                        break;

                    default:
                        break;
                }

                if (!shouldAddExpressionReference)
                {
                    WriteDefinition(writer, definitionName, definition);
                }
                else
                {
                    string definitionDescription = null;

                    writer.WritePropertyName(definitionName);
                    writer.WriteStartObject();

                    writer.WritePropertyName(definition.JsonType == "object" && definition.IsEmpty() ? "anyOf" : "oneOf"); // hack, until MultiType thing is enforced across the specs repo!
                    writer.WriteStartArray();

                    if (definition.Description != null)
                    {
                        definitionDescription = definition.Description;

                        definition = definition.Clone();
                        definition.Description = null;
                    }
                    WriteDefinition(writer, definition);

                    WriteDefinition(writer, new JsonSchema()
                    {
                        Ref = "https://schema.management.azure.com/schemas/common/definitions.json#/definitions/expression"
                    });

                    writer.WriteEndArray();

                    WriteProperty(writer, "description", definitionDescription);
                    writer.WriteEndObject();
                }
            }
            writer.WriteEndObject();
        }

        public static void WriteDefinition(JsonWriter writer, string resourceName, JsonSchema definition)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (definition != null)
            {
                writer.WritePropertyName(resourceName);
                WriteDefinition(writer, definition);
            }
        }

        private static object ConvertDefaultValue(string defaultValue, string type)
        {
            switch (type)
            {
                case "boolean":
                    return bool.Parse(defaultValue.ToLowerInvariant());
                case "number":
                    return double.Parse(defaultValue.ToLowerInvariant());
                default:
                    return defaultValue;
            }
        }

        private static void WriteDefinition(JsonWriter writer, JsonSchema definition)
        {
            if (definition == null)
            {
                throw new ArgumentNullException("definition");
            }

            writer.WriteStartObject();

            WriteProperty(writer, "type", definition.JsonType); // move out once MultiType is here
            WriteProperty(writer, "minimum", definition.Minimum);
            WriteProperty(writer, "maximum", definition.Maximum);
            WriteProperty(writer, "pattern", definition.Pattern);
            WriteProperty(writer, "minLength", definition.MinLength);
            WriteProperty(writer, "maxLength", definition.MaxLength);
            if (definition.Default != null)
            {
                WritePropertyRaw(writer, "default", ConvertDefaultValue(definition.Default, definition.JsonType));
            }
            WriteStringArray(writer, "enum", definition.Enum);
            WriteDefinitionArray(writer, "oneOf", definition.OneOf);
            WriteDefinitionArray(writer, "anyOf", definition.AnyOf);
            WriteDefinitionArray(writer, "allOf", definition.AllOf);

            // uuid in format on schemas makes VS cry. just leave it as a string with the pattern.
            if (definition.Format != "uuid")
            {
                WriteProperty(writer, "format", definition.Format);
            }

            WriteProperty(writer, "$ref", definition.Ref);
            WriteDefinition(writer, "items", definition.Items);
            WriteDefinition(writer, "additionalProperties", definition.AdditionalProperties);
            if (definition.JsonType == "object")
            {
                WriteDefinitionMap(writer, "properties", definition.Properties, addExpressionReferences: true);
            }
            WriteStringArray(writer, "required", definition.Required);

            WriteProperty(writer, "description", definition.Description);

            writer.WriteEndObject();
        }

        private static void WriteStringArray(JsonWriter writer, string arrayName, IEnumerable<string> arrayValues)
        {
            if (arrayValues != null && arrayValues.Count() > 0)
            {
                writer.WritePropertyName(arrayName);
                writer.WriteStartArray();
                foreach (string arrayValue in arrayValues)
                {
                    writer.WriteValue(arrayValue);
                }
                writer.WriteEndArray();
            }
        }

        private static void WriteDefinitionArray(JsonWriter writer, string arrayName, IEnumerable<JsonSchema> arrayDefinitions)
        {
            if (arrayDefinitions != null && arrayDefinitions.Count() > 0)
            {
                writer.WritePropertyName(arrayName);

                writer.WriteStartArray();
                foreach (JsonSchema definition in arrayDefinitions)
                {
                    WriteDefinition(writer, definition);
                }
                writer.WriteEndArray();
            }
        }

        public static void WriteProperty(JsonWriter writer, string propertyName, string propertyValue)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }

            if (!string.IsNullOrWhiteSpace(propertyValue))
            {
                writer.WritePropertyName(propertyName);
                writer.WriteValue(propertyValue);
            }
        }

        public static void WritePropertyRaw(JsonWriter writer, string propertyName, object propertyValue)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }

            writer.WritePropertyName(propertyName);
            writer.WriteValue(propertyValue);
        }

        public static void WriteProperty(JsonWriter writer, string propertyName, double? propertyValue)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }

            if (propertyValue != null)
            {
                writer.WritePropertyName(propertyName);

                double doubleValue = propertyValue.Value;
                long longValue = (long)doubleValue;
                if (doubleValue == longValue)
                {
                    writer.WriteValue(longValue);
                }
                else
                {
                    writer.WriteValue(doubleValue);
                }
            }
        }
    }
}
