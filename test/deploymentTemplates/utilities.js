"use strict";

const assert = require("assert");
const fs = require("fs");
const path = require("path");
const tv4 = require("tv4");

module.exports.forEachFile = forEachFile;
/**
 * Execute the provided callback for each of the files recursively found in the provided folderPath.
 * @param {String} folderPath The path to recursively find files in.
 * @param callback (filePath: string) => void, The callback to call for each file.
 */
function forEachFile(folderPath, callback) {
    const folderEntryNames = fs.readdirSync(folderPath);
    for (const entryName of folderEntryNames) {
        const entryPath = path.join(folderPath, entryName);

        const entryStats = fs.statSync(entryPath);
        if (entryStats.isDirectory()) {
            forEachFile(entryPath, callback);
        }
        else {
            assert(entryStats.isFile());
            callback(entryPath);
        }
    }
}

function children(folderPath, folder) {
    const folderEntryNames = fs.readdirSync(folderPath);
    const result = [];
    for (const entryName of folderEntryNames) {
        const entryPath = path.join(folderPath, entryName);

        const entryStats = fs.statSync(entryPath);
        if (entryStats.isDirectory() === folder) {
            result.push(entryPath);
        }
    }
    return result;
}

module.exports.folders = folderPath => children(folderPath, true);
module.exports.files = folderPath => children(folderPath, false);

module.exports.getJsonFiles = getJsonFiles;
function getJsonFiles(folderPath) {
    const result = [];
    forEachFile(folderPath, filePath => filePath.endsWith(".json") && result.push(filePath));
    return result;
}

module.exports.getSchemasFolderPath = () => path.resolve(__dirname, "../Resource/Expected");
module.exports.getTestsFolderPath = () => path.resolve(__dirname, "../Resource/DeploymentTemplates");

module.exports.pathExists = pathExists;
/**
 * Determine if the provided path (file or folder) exists.
 * @param {string} path The path to check.
 * @returns {boolean} Whether the path exists or not.
 */
function pathExists(path) {
    assert(path, "Cannot check if a null, undefined, or empty path exists.");

    let result = true;
    try {
        fs.statSync(path);
    }
    catch (error) {
        result = false;
    }
    return result;
}

module.exports.stripUTF8BOM = stripUTF8BOM;
/**
 * Strip away the UTF-8 Byte Order Mark (BOM) from the provided string.
 * @param {string} value The string value to remove the UTF-8 BOM from.
 * @returns {string} The provided value without a UTF-8 BOM, if it had one.
 */
function stripUTF8BOM(value) {
    return value ? value.replace(/^\uFEFF/, '') : value;
}

module.exports.readJSONPath = readJSONPath;
/**
 * Read the JSON file that is at the provided path.
 * @param {string} jsonUri The uri or file path to the JSON file.
 * @param {string} [schemaFolderPath] The path to the local schemas folder that can be used if an
 *          Azure resource schema is being requested.
 */
function readJSONPath(jsonUri, schemaFolderPath) {
    if (schemaFolderPath && (!schemaFolderPath.endsWith('/') && !schemaFolderPath.endsWith('\\'))) {
        schemaFolderPath += "/";
    }

    const azurePrefix = /^https?:\/\/schema.management.azure.com\/schemas\//

    const hashIndex = jsonUri.indexOf("#");
    if (hashIndex !== -1) {
        jsonUri = jsonUri.substring(0, hashIndex);
    }

    let jsonPath;
    if (jsonUri.endsWith("deploymentTemplate.json")) {
        jsonPath = path.join(__dirname, "deploymentTemplate.json");
    }
    else if (jsonUri.endsWith("/schema")) {
        jsonPath = path.join(__dirname, "jsonSchemaSchema.json");
    }
    else if (jsonUri.match(azurePrefix) && schemaFolderPath && pathExists(schemaFolderPath)) {
        jsonPath = jsonUri.replace(azurePrefix, schemaFolderPath);
    }
    else {
        jsonPath = jsonUri;
    }

    let jsonContents = fs.readFileSync(jsonPath, "utf8");

    return JSON.parse(stripUTF8BOM(jsonContents));
}

const singleIndent = "  ";

module.exports.toString = toString;
/**
 * Convert the provided value to a string with the provided indentation.
 * @param {any} value The value to convert to a string.
 * @param {string} [indent=""] The indentation to apply to the generated string.
 * @returns {string} The string version of the provided value.
 */
function toString(value, indent) {
    if (!indent) {
        indent = "";
    }

    let result;
    let addComma = false;
    if (Array.isArray(value)) {
        result = indent + "[";

        for (let index = 0; index < value.length; ++index) {
            if (index > 0) {
                result += ",";
            }

            const elementIndent = indent + singleIndent;
            const elementString = toString(value[index], elementIndent);
            result += `\n${elementIndent}${elementString}`;
        }
        result += `\n${indent}]`;
    }
    else if (typeof value === "object" && value) {
        result = "{";
        for (const propertyName in value) {
            if (addComma) {
                result += ",";
            }
            else {
                addComma = true;
            }

            const propertyIndent = indent + singleIndent;
            const propertyValueString = toString(value[propertyName], propertyIndent);
            result += `\n${propertyIndent}"${propertyName}": ${propertyValueString}`;
        }
        result += "\n" + indent + "}";
    }
    else if (value === undefined) {
        result = "undefined";
    }
    else {
        result = JSON.stringify(value);
    }

    return result;
}



module.exports.validate = validate;
/**
 * Validates the provided JSON object against the provided schema.
 * @param {any} json
 * @param {any} schema
 * @param {string} schemaFolderPath
 * @return {any}
 */
function validate(json, schema, schemaFolderPath) {
    let result;

    if (json === null || json === undefined) {
        logError(getErrorMessage("Cannot validate a", json, "json object."));
        result = { valid: false, errors: [{ message: "Invalid JSON" }], missingSchemas: [] };
    }
    else if (!schema) {
        logError(getErrorMessage("Cannot use a", schema, "schema for validation."));
        result = { valid: false, errors: [{ message: "Invalid schema" }], missingSchemas: [] };
    }
    else {
        tv4.addSchema(json);
        tv4.addSchema(schema);
        addMissingSchemas(tv4.getMissingUris(), schemaFolderPath);
        result = convertTv4ValidationResult(tv4.validateMultiple(json, schema));

        while (result.missingSchemas && result.missingSchemas.length > 0) {
            addMissingSchemas(result.missingSchemas, schemaFolderPath);
            result = convertTv4ValidationResult(tv4.validateMultiple(json, schema));
        }
    }

    return result;
}

/**
 * @param {string[]} missingUris
 * @param {string} schemaFolderPath
 */
function addMissingSchemas(missingUris, schemaFolderPath) {
    while (missingUris && missingUris.length > 0) {
        var missingUri = missingUris.pop();
        if (missingUri && missingUri.length > 0) {
            tv4.addSchema(missingUri, readJSONPath(missingUri, schemaFolderPath));

            missingUris = tv4.getMissingUris();
        }
    }
}

function convertTv4ValidationResult(tv4ValidationResult) {
    const result = {
        valid: tv4ValidationResult.valid,
        errors: [],
        missingSchemas: []
    };

    for (const missingSchema of tv4ValidationResult.missing) {
        assert.notDeepStrictEqual(missingSchema, "", "tv4ValidationResult should not have had any empty missing schemas: " + toString(tv4ValidationResult.missing));

        result.missingSchemas.push(missingSchema);
    }

    for (const error of tv4ValidationResult.errors) {
        result.errors.push(cleanValidationErrorProperties(error));
    }

    return result;
}

function cleanValidationErrorProperties(tv4ValidationError) {
    const result = {};
    if (tv4ValidationError) {
        result.message = tv4ValidationError.message;
        result.dataPath = tv4ValidationError.dataPath ? tv4ValidationError.dataPath : "/";
        result.schemaPath = tv4ValidationError.schemaPath;
        
        if (tv4ValidationError.subErrors) {
            result.subErrors = [];
            
            for (const subError of tv4ValidationError.subErrors) {
                result.subErrors.push(cleanValidationErrorProperties(subError));
            }
        }
    }
    return result;
}