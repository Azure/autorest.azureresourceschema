﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities.Collections;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.AzureResourceSchema
{
    public class CodeGeneratorArs : CodeGenerator
    {
        public CodeGeneratorArs()
        {
        }

        public override string ImplementationFileExtension => ".json";

        public override string UsageInstructions => $"Your Azure Resource Schema(s) can be found in the specified `output-folder`.";

        public override async Task Generate(CodeModel serviceClient)
        {
            var multiScope = await Settings.Instance.Host?.GetValue<bool?>("multi-scope") ?? false;

            var apiVersions = serviceClient.Methods
                .Select(method => method.Parameters.FirstOrDefault(p => p.SerializedName == "api-version")?.DefaultValue.Value)
                .Concat(new [] { serviceClient.ApiVersion })
                .Where(each => each != null)
                .Distinct().ToArray();

            foreach(var version in apiVersions)
            { 
                var resourceSchemas = ResourceSchemaParser.Parse(serviceClient, version, multiScope);

                foreach (string resourceProvider in resourceSchemas.Keys)
                {
                    var stringWriter = new StringWriter();
                    ResourceSchemaWriter.Write(stringWriter, resourceSchemas[resourceProvider]);
                    await Write(stringWriter.ToString(), Path.Combine(version, resourceProvider + ".json"), true);
/*
                    var md = ResourceMarkdownGenerator.Generate(resourceSchemas[resourceProvider]);

                    foreach (var m in md)
                    {
                        // what the heck was this doing in the first place!??!
                        // var content = m.Content.Replace("\"boolean\"", "boolean");
                        var content = m.Content;
                        // place nested topics in subdirectories
                        await Write(content, Path.Combine(version, m.Type.Replace('_', Path.DirectorySeparatorChar) + ".md"), false);
                    }
*/                    
                }
            }
        }
    }
}
