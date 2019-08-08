// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.AzureResourceSchema.Models
{
    using System.Collections.Generic;

    public class ResourceDescriptor
    {
        public ScopeType ScopeType { get; set; }

        public string ProviderNamespace { get; set; }

        public IReadOnlyList<string> ResourceTypeSegments { get; set; }

        public string ApiVersion { get; set; }

        public string RoutingScope { get; set; }

        public string FullyQualifiedType => $"{ProviderNamespace}/{UnQualifiedType}";

        public string UnQualifiedType => $"{string.Join('/', ResourceTypeSegments)}";
    }
}