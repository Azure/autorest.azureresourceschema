// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.AzureResourceSchema.Models
{
    using AutoRest.Core.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ResourceDescriptor
    {
        public ScopeType ScopeType { get; set; }

        public string ProviderNamespace { get; set; }

        public IReadOnlyList<string> ResourceTypeSegments { get; set; }

        public string ApiVersion { get; set; }

        public bool HasVariableName { get; set; }

        public XmsMetadata XmsMetadata { get; set; }

        public string FullyQualifiedType => FormatFullyQualifiedType(ProviderNamespace, ResourceTypeSegments);

        public string UnqualifiedType => FormatUnqualifiedType(ResourceTypeSegments);

        public bool IsRootType => ResourceTypeSegments.Count == 1;

        public static string FormatFullyQualifiedType(string providerNamespace, IEnumerable<string> resourceTypeSegments)
            => $"{providerNamespace}/{FormatUnqualifiedType(resourceTypeSegments)}";

        public static string FormatParentFullyQualifiedType(ResourceDescriptor descriptor)
        {
            if (descriptor.ResourceTypeSegments.Count < 2)
            {
                throw new ArgumentException($"Cannot find parent of root type {descriptor.FullyQualifiedType}");
            }

            return FormatFullyQualifiedType(descriptor.ProviderNamespace, descriptor.ResourceTypeSegments.SkipLast(1));
        }

        public static string FormatUnqualifiedType(IEnumerable<string> resourceTypeSegments)
            => string.Join('/', resourceTypeSegments);

        public static IEqualityComparer<ResourceDescriptor> Comparer { get; }
            = new EqualityComparer();

        private class EqualityComparer : IEqualityComparer<ResourceDescriptor>
        {
            public bool Equals(ResourceDescriptor x, ResourceDescriptor y)
                => x.ScopeType == y.ScopeType &&
                    StringComparer.OrdinalIgnoreCase.Equals(x.FullyQualifiedType, y.FullyQualifiedType) &&
                    StringComparer.OrdinalIgnoreCase.Equals(x.ApiVersion, y.ApiVersion) &&
                    x.HasVariableName == y.HasVariableName;

            public int GetHashCode(ResourceDescriptor obj)
                => obj.ScopeType.GetHashCode() ^
                    StringComparer.OrdinalIgnoreCase.GetHashCode(obj.FullyQualifiedType) ^
                    StringComparer.OrdinalIgnoreCase.GetHashCode(obj.ApiVersion) ^
                    obj.HasVariableName.GetHashCode();
        }
    }
}