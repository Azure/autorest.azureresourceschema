"use strict";

const chalk = require("chalk");
const path = require("path");

const utilities = require("./utilities.js");

const schemasFolderPath = utilities.getSchemasFolderPath();

const schemaFilePaths = utilities.getJsonFiles(schemasFolderPath);

const metaSchemaPaths = [
    path.join(__dirname, "ResourceMetaSchema.json"),
    path.join(__dirname, "jsonSchemaSchema.json")
];

const metaSchemas = [];
for (const metaSchemaPath of metaSchemaPaths) {
    metaSchemas.push({
        path: metaSchemaPath,
        json: utilities.readJSONPath(metaSchemaPath)
    });
}

for (const schemaFilePath of schemaFilePaths) {
    console.log(schemaFilePath);

    const schemaJSON = utilities.readJSONPath(schemaFilePath);

    for (const metaSchema of metaSchemas) {
        const validationResult = utilities.validate(schemaJSON, metaSchema.json, schemasFolderPath);

        console.log(`    Using schema: ${metaSchema.path}`);
        if (!validationResult.valid) {
            console.log(chalk.red("        Failed"));
            for (let errorIndex = 0; errorIndex < validationResult.errors.length; ++errorIndex) {
                const error = validationResult.errors[errorIndex];
                console.log(chalk.red(`        ${errorIndex + 1}. Error at "${error.dataPath}" - ${error.message}`));
            }
        }
        else {
            console.log(chalk.green("        Passed"));
        }
    }
}
