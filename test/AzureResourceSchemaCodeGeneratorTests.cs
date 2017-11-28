﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using Newtonsoft.Json.Linq;
using Xunit;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.AzureResourceSchema.Tests
{
    [Collection("AutoRest Tests")]
    public class AzureResourceSchemaCodeGeneratorTests
    {
        [Fact]
        public void ImplementationFileExtension()
        {
            Assert.Equal(".json", CreatePlugin().CodeGenerator.ImplementationFileExtension);
        }

        private static PluginArs CreatePlugin()
        {
            return new PluginArs();
        }

        private static async Task TestGenerate(string apiVersion, string[] methodUrls, string expectedJsonString)
        {
            using (NewContext) {
                MemoryFileSystem fileSystem = new MemoryFileSystem();

                Settings settings = new Settings();
                settings.FileSystemOutput = fileSystem;

                CodeModel serviceClient = New<CodeModel>();
                serviceClient.ApiVersion = apiVersion;
                foreach (string methodUrl in methodUrls) {
                    serviceClient.Add(New<Method>(new {
                        Url = methodUrl,
                        HttpMethod = HttpMethod.Put,
                    }));
                }
                await CreatePlugin().CodeGenerator.Generate(serviceClient);

                Assert.Equal(2, fileSystem.VirtualStore.Count);

                string folderPath = fileSystem.VirtualStore.Keys.First();
                Assert.Equal("Folder", fileSystem.VirtualStore[folderPath].ToString());

                JObject expectedJSON = JObject.Parse(expectedJsonString);

                string fileContents = fileSystem.VirtualStore[fileSystem.VirtualStore.Keys.Skip(1).First()].ToString();
                JObject actualJson = JObject.Parse(fileContents);

                Assert.Equal(expectedJSON, actualJson);
            }
        }
    }
}
