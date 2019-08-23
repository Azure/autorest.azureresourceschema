// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.AzureResourceSchema.Models
{
    public enum ScopeType
    {
        Unknown = 0,
        Tenant,
        Subcription,
        ResourceGroup,
        ManagementGroup,
        Extension,
    }
}