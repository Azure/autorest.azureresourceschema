// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.AzureResourceSchema.Models
{
    public class ResourceName
    {
        public bool HasConstantName { get; set; }

        public string NameString { get; set; }

        public JsonSchema NameSchema { get; set; }
    }
}