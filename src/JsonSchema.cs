// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRest.AzureResourceSchema
{
    [Flags]
    public enum SchemaConfiguration
    {
        None = 0,
        OmitExpressionRef = 1 << 0,
    }

    /// <summary>
    /// An object representing a JSON schema. Each property of a JSON schema ($schema, title, and
    /// description are metadata, not properties) is also a JSON schema, so the class is recursive.
    /// </summary>
    public class JsonSchema
    {
        private string resourceType;

        /// <summary>
        /// A reference to the location in the parent schema where this schema's definition can be
        /// found.
        /// </summary>
        public string Ref { get; set; }

        /// <summary>
        /// The JSONSchema that will be applied to the elements of this schema, assuming this
        /// schema is an array schema type.
        /// </summary>
        public JsonSchema Items { get; set; }

        /// <summary>
        /// The format of the value that matches this schema. This only applies to string values.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// The description metadata that describes this schema.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The type metadata of this schema that describes what type matching JSON values must be.
        /// For example, this value will be either "object", "string", "array", "integer",
        /// "number", or "boolean".
        /// </summary>
        public string JsonType { get; set; }

        /// <summary>
        /// Gets or sets the resource type of this JsonSchema.
        /// </summary>
        public string ResourceType
        {
            get
            {
                return resourceType;
            }
            set
            {
                resourceType = value;
                if (Properties != null && Properties.ContainsKey("type"))
                {
                    // update the value of the type enum.  we have to be careful though that we don't
                    // stomp over some other enum that happens to have the name "type".  this code path
                    // is typically hit when building a child resource definition from a cloned parent.
                    if (Properties["type"].Enum.Count > 1)
                        throw new InvalidOperationException("Attempt to update 'type' enum that contains more than one member (possible collision).");
                    if (!Properties["type"].Enum[0].EndsWith(value))
                        throw new InvalidOperationException($"The updated type value '{value}' is not a child of type value '{Properties["type"].Enum[0]}'");

                    Properties["type"].Enum[0] = value;
                }
            }
        }

        /// <summary>
        /// The number that a numeric value matching this schema must be a multiple of
        /// </summary>
        public double? MultipleOf { get; set; }

        /// <summary>
        /// The minimum value that a numeric value matching this schema can have.
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// The maximum value that a numeric value matching this schema can have.
        /// </summary>
        public double? Maximum { get; set; }

        /// <summary>
        /// The regular expression pattern that a string value matching this schema must match.
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// The minimum length that a string or an array matching this schema can have.
        /// </summary>
        public double? MinLength { get; set; }

        /// <summary>
        /// The maximum length that a string or an array matching this schema can have.
        /// </summary>
        public double? MaxLength { get; set; }

        /// <summary>
        /// The maximum length that a string or an array matching this schema can have.
        /// </summary>
        public string Default { get; set; }

        /// <summary>
        /// The schema that matches additional properties that have not been specified in the
        /// Properties dictionary.
        /// </summary>
        public JsonSchema AdditionalProperties { get; set; }

        /// <summary>
        /// An enumeration of values that will match this JSON schema. Any value not in this
        /// enumeration will not match this schema.
        /// </summary>
        public IList<string> Enum { get; private set;} 

        /// <summary>
        /// The list of oneOf options that exist for this JSON schema.
        /// </summary>
        public IList<JsonSchema> OneOf { get; private set;} 

        /// <summary>
        /// The list of anyOf options that exist for this JSON schema.
        /// </summary>
        public IList<JsonSchema> AnyOf { get; private set;} 

        /// <summary>
        /// The list of allOf options that exist for this JSON schema.
        /// </summary>
        public IList<JsonSchema> AllOf { get; private set;}

        /// <summary>
        /// The schemas that describe the properties of a matching JSON value.
        /// </summary>
        public IDictionary<string, JsonSchema> Properties { get; private set; }

        /// <summary>
        /// The names of the properties that are required for a matching JSON value.
        /// </summary>
        public IList<string> Required { get; private set; }

        /// <summary>
        /// Configuration to override default schema serialization behavior.
        /// </summary>
        public SchemaConfiguration Configuration { get; set; }

        public bool IsEmpty()
        {
            return Ref == null &&
                   Items == null &&
                   AdditionalProperties == null &&
                   MultipleOf == null &&
                   Minimum == null &&
                   Maximum == null &&
                   Pattern == null &&
                   MinLength == null &&
                   MaxLength == null &&
                   IsEmpty(Enum) &&
                   IsEmpty(Properties) &&
                   IsEmpty(Required) &&
                   IsEmpty(OneOf) &&
                   IsEmpty(AnyOf) &&
                   IsEmpty(AllOf);
        }

        private static bool IsEmpty<T>(IEnumerable<T> values)
        {
            return values == null || !values.Any();
        }

        /// <summary>
        /// Add a new value (or values) to this JsonSchema's enum list. This JsonSchema (with the
        /// new value(s)) is then returned so that additional changes can be chained together.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <param name="extraEnumValues"></param>
        /// <returns></returns>
        public JsonSchema AddEnum(string enumValue, params string[] extraEnumValues)
        {
            if (Enum == null)
            {
                Enum = new List<string>();
            }

            if (Enum.Contains(enumValue))
            {
                throw new ArgumentException("enumValue (" + enumValue + ") already exists in the list of allowed values.", "enumValue");
            }
            Enum.Add(enumValue);

            if (extraEnumValues != null && extraEnumValues.Length > 0)
            {
                foreach (string extraEnumValue in extraEnumValues)
                {
                    if (Enum.Contains(extraEnumValue))
                    {
                        throw new ArgumentException("extraEnumValue (" + extraEnumValue + ") already exists in the list of allowed values.", "extraEnumValues");
                    }
                    Enum.Add(extraEnumValue);
                }
            }

            return this;
        }

        public JsonSchema AddPropertyWithOverwrite(string propertyName, JsonSchema propertyDefinition, bool isRequired)
        {
            if (Properties != null && Properties.ContainsKey(propertyName))
            {
                Properties.Remove(propertyName);
            }

            if (Required != null && Required.Contains(propertyName))
            {
                Required.Remove(propertyName);
            }

            AddProperty(propertyName, propertyDefinition, isRequired);

            return this;
        }

        /// <summary>
        /// Add a new property to this JsonSchema, and then return this JsonSchema so that
        /// additional changes can be chained together.
        /// </summary>
        /// <param name="propertyName">The name of the property to add.</param>
        /// <param name="propertyDefinition">The JsonSchema definition of the property to add.</param>
        /// <param name="isRequired">Whether this property is required or not.</param>
        /// <returns></returns>
        public JsonSchema AddProperty(string propertyName, JsonSchema propertyDefinition, bool isRequired = false)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }
            if (propertyDefinition == null)
            {
                throw new ArgumentNullException("propertyDefinition");
            }
            
            if (Properties == null)
            {
                // Making insensitive dictionary to capture duplicate property keys.
                Properties = new Dictionary<string, JsonSchema>(StringComparer.OrdinalIgnoreCase);
            }

            if (Properties.ContainsKey(propertyName))
            {
                throw new ArgumentException("A property with the name \"" + propertyName + "\" already exists in this JSONSchema", "propertyName");
            }

            Properties[propertyName] = propertyDefinition;

            if (isRequired)
            {
                AddRequired(propertyName);
            }

            return this;
        }

        /// <summary>
        /// Add the provided required property names to this JSON schema's list of required property names.
        /// </summary>
        /// <param name="requiredPropertyName"></param>
        /// <param name="extraRequiredPropertyNames"></param>
        public JsonSchema AddRequired(string requiredPropertyName, params string[] extraRequiredPropertyNames)
        {
            if (Properties == null || !Properties.ContainsKey(requiredPropertyName))
            {
                throw new ArgumentException("No property exists with the provided requiredPropertyName (" + requiredPropertyName + ")", nameof(requiredPropertyName));
            }

            if (Required == null)
            {
                Required = new List<string>();
            }

            if (Required.Contains(requiredPropertyName))
            {
                throw new ArgumentException("'" + requiredPropertyName + "' is already a required property.", "requiredPropertyName");
            }
            Required.Add(requiredPropertyName);

            if (extraRequiredPropertyNames != null)
            {
                foreach (string extraRequiredPropertyName in extraRequiredPropertyNames)
                {
                    if (Properties == null || !Properties.ContainsKey(extraRequiredPropertyName))
                    {
                        throw new ArgumentException("No property exists with the provided extraRequiredPropertyName (" + extraRequiredPropertyName + ")", "extraRequiredPropertyNames");
                    }
                    if (Required.Contains(extraRequiredPropertyName))
                    {
                        throw new ArgumentException("'" + extraRequiredPropertyName + "' is already a required property.", "extraRequiredPropertyNames");
                    }
                    Required.Add(extraRequiredPropertyName);
                }
            }

            return this;
        }

        /// <summary>
        /// Add the provided JSON schema as an option for the anyOf property of this JSON schema.
        /// </summary>
        /// <param name="anyOfOption"></param>
        /// <returns></returns>
        public JsonSchema AddAnyOf(JsonSchema anyOfOption)
        {
            if (anyOfOption == null)
            {
                throw new ArgumentNullException(nameof(anyOfOption));
            }

            if (AnyOf == null)
            {
                AnyOf = new List<JsonSchema>();
            }

            AnyOf.Add(anyOfOption);

            return this;
        }

        /// <summary>
        /// Add the provided JSON schema as an option for the oneOf property of this JSON schema.
        /// </summary>
        /// <param name="oneOfOption"></param>
        /// <returns></returns>
        public JsonSchema AddOneOf(JsonSchema oneOfOption)
        {
            if (oneOfOption == null)
            {
                throw new ArgumentNullException(nameof(oneOfOption));
            }

            if (OneOf == null)
            {
                OneOf = new List<JsonSchema>();
            }

            OneOf.Add(oneOfOption);

            return this;
        }

        /// <summary>
        /// Add the provided JSON schema as an option for the allOf property of this JSON schema.
        /// </summary>
        /// <param name="allOfOption"></param>
        /// <returns></returns>
        public JsonSchema AddAllOf(JsonSchema allOfOption)
        {
            if (allOfOption == null)
            {
                throw new ArgumentNullException(nameof(allOfOption));
            }

            if (AllOf == null)
            {
                AllOf = new List<JsonSchema>();
            }

            AllOf.Add(allOfOption);

            return this;
        }

        /// <summary>
        /// Create a new JsonSchema that is an exact copy of this one.
        /// </summary>
        /// <returns></returns>
        public JsonSchema Clone()
        {
            JsonSchema result = new JsonSchema();
            result.Ref = Ref;
            result.Items = Clone(Items);
            result.Description = Description;
            result.JsonType = JsonType;
            result.AdditionalProperties = Clone(AdditionalProperties);
            result.MultipleOf = MultipleOf;
            result.Minimum = Minimum;
            result.Maximum = Maximum;
            result.Pattern = Pattern;
            result.MinLength = MinLength;
            result.MaxLength = MaxLength;
            result.Default = Default;
            result.Enum = Clone(Enum);
            result.Properties = Clone(Properties);
            result.Required = Clone(Required);
            result.OneOf = Clone(OneOf);
            result.AnyOf = Clone(AnyOf);
            result.AllOf = Clone(AllOf);
            result.Configuration = Configuration;
            return result;
        }

        private static JsonSchema Clone(JsonSchema toClone)
            => toClone?.Clone();

        private static IList<string> Clone(IList<string> toClone)
            => toClone?.Select(x => x).ToList();

        private static IList<JsonSchema> Clone(IList<JsonSchema> toClone)
            => toClone?.Select(x => Clone(x)).ToList();

        private static IDictionary<string, JsonSchema> Clone(IDictionary<string, JsonSchema> toClone)
            => toClone?.ToDictionary(kvp => kvp.Key, kvp => Clone(kvp.Value));

        public static JsonSchema CreateSingleValuedEnum(string enumValue)
        {
            var result = new JsonSchema
            {
                JsonType = "string",
                Configuration = SchemaConfiguration.OmitExpressionRef,
            };
            result.AddEnum(enumValue);

            return result;
        }
    }
}
