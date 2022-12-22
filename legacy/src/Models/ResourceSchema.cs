// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.AzureResourceSchema.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// An object representing an Azure Resource Schema. It is important to note that an Azure
    /// resource schema is actually not a valid JSON schema by itself. It is part of the
    /// deploymentTemplate.json schema.
    /// </summary>
    public class ResourceSchema
    {
        /// <summary>
        /// The id metadata that uniquely identifies this schema. Usually this will be the URL to
        /// the permanent location of this schema in schema.management.azure.com/schemas/.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The JSON schema metadata url that points to the schema that can be used to validate
        /// this schema.
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// The title metadata for this schema.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description metadata that describes this schema.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The named JSON schemas that define the resources of this resource schema.
        /// </summary>
        public IDictionary<ResourceDescriptor, JsonSchema> ResourceDefinitions { get; set; } = new Dictionary<ResourceDescriptor, JsonSchema>();

        /// <summary>
        /// The named reusable JSON schemas that the resource definitions reference. These
        /// definitions can also reference each other or themselves.
        /// </summary>
        public IDictionary<string, JsonSchema> Definitions { get; set; } = new Dictionary<string, JsonSchema>();

        public static string FormatResourceSchemaKey(IEnumerable<string> resourceTypeSegments)
            => string.Join('_', resourceTypeSegments);
    }
}
