namespace AutoRest.AzureResourceSchema.Models
{
    using System;
    using System.Collections.Generic;

    public class ProviderDefinition
    {
        public string Namespace { get; set; }

        public string ApiVersion { get; set; }

        public IDictionary<string, JsonSchema> SchemaDefinitions { get; } = new Dictionary<string, JsonSchema>(StringComparer.OrdinalIgnoreCase);

        public IList<ResourceDefinition> ResourceDefinitions { get; } = new List<ResourceDefinition>();
    }
}