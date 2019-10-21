﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using AutoRest.AzureResourceSchema.Models;
using AutoRest.Core.Model;
using Xunit;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.AzureResourceSchema.Tests
{
    public class ResourceSchemaParserTests
    {
        [Fact]
        public void ParseWithCodeModelWithCreateResourceMethod()
        {
            CodeModel codeModel = New<CodeModel>();

            codeModel.ApiVersion = "2016-01-01";

            Parameter body = New<Parameter>(new
            {
                Location = ParameterLocation.Body,
                Type = New<CompositeType>(),
            });

            CompositeType responseBody = New<CompositeType>();
            responseBody.Extensions.Add("x-ms-azure-resource", true);

            const string url = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Mock.Provider/mockResourceNames/{mockResourceName}";

            Method method = New<Method>(new
            {
                HttpMethod = HttpMethod.Put,
                ReturnType = new Response(responseBody, null),
                Url = url,
            });
            method.Add(body);

            codeModel.Add(method);

            var schemas = ResourceSchemaParser.Parse(codeModel, codeModel.ApiVersion);
            Assert.NotNull(schemas);
            Assert.Equal(1, schemas.Count);

            ResourceSchema schema = schemas["Mock.Provider"];
            Assert.Equal("https://schema.management.azure.com/schemas/2016-01-01/Mock.Provider.json#", schema.Id);
            Assert.Equal("http://json-schema.org/draft-04/schema#", schema.Schema);
            Assert.Equal("Mock.Provider", schema.Title);
            Assert.Equal("Mock Provider Resource Types", schema.Description);
            Assert.Equal(1, schema.ResourceDefinitions.Count);
            Assert.Equal("mockResourceNames", schema.ResourceDefinitions.Keys.Single().UnqualifiedType);
            Assert.Equal(
                new JsonSchema()
                {
                    JsonType = "object",
                    Description = "Mock.Provider/mockResourceNames"
                }
                .AddProperty("type", JsonSchema.CreateSingleValuedEnum("Mock.Provider/mockResourceNames"), true)
                .AddProperty("apiVersion", JsonSchema.CreateSingleValuedEnum("2016-01-01"), true),
                schema.ResourceDefinitions.Values.Single());
            Assert.NotNull(schema.Definitions);
            Assert.Equal(0, schema.Definitions.Count);
        }
    }
}
