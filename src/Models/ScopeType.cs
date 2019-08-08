// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.AzureResourceSchema.Models
{
    using System;

    [Flags]
    public enum ScopeType
    {
        Unknown = 0,
        Tenant = 1 << 0,
        Subcription = 1 << 1,
        ResourceGroup = 1 << 2,
        ManagementGroup = 1 << 3,
        Extension = 1 << 4,
    }
}