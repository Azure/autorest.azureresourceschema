# Microsoft.CustomerInsights/hubs/connectors/mappings template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/connectors/mappings resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/connectors/mappings",
  "apiVersion": "2017-04-26",
  "properties": {
    "connectorType": "string",
    "entityType": "string",
    "entityTypeName": "string",
    "displayName": "string",
    "description": "string",
    "mappingProperties": {
      "folderPath": "string",
      "fileFilter": "string",
      "hasHeader": boolean,
      "errorManagement": {
        "errorManagementType": "string",
        "errorLimit": "integer"
      },
      "format": {
        "formatType": "TextFormat",
        "columnDelimiter": "string",
        "acceptLanguage": "string",
        "quoteCharacter": "string",
        "quoteEscapeCharacter": "string",
        "arraySeparator": "string"
      },
      "availability": {
        "frequency": "string",
        "interval": "integer"
      },
      "structure": [
        {
          "propertyName": "string",
          "columnName": "string",
          "customFormatSpecifier": "string",
          "isEncrypted": boolean
        }
      ],
      "completeOperation": {
        "completionOperationType": "string",
        "destinationFolder": "string"
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/connectors/mappings" />
### Microsoft.CustomerInsights/hubs/connectors/mappings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/connectors/mappings |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [ConnectorMapping object](#ConnectorMapping) |


<a id="ConnectorMapping" />
### ConnectorMapping object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  connectorType | enum | No | Type of connector. - None, CRM, AzureBlob, Salesforce, ExchangeOnline, Outbound |
|  entityType | enum | Yes | Defines which entity type the file should map to. - None, Profile, Interaction, Relationship |
|  entityTypeName | string | Yes | The mapping entity name. |
|  displayName | string | No | Display name for the connector mapping. |
|  description | string | No | The description of the connector mapping. |
|  mappingProperties | object | Yes | The properties of the mapping. - [ConnectorMappingProperties object](#ConnectorMappingProperties) |


<a id="ConnectorMappingProperties" />
### ConnectorMappingProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  folderPath | string | No | The folder path for the mapping. |
|  fileFilter | string | No | The file filter for the mapping. |
|  hasHeader | boolean | No | If the file contains a header or not. |
|  errorManagement | object | Yes | The error management setting for the mapping. - [ConnectorMappingErrorManagement object](#ConnectorMappingErrorManagement) |
|  format | object | Yes | The format of mapping property. - [ConnectorMappingFormat object](#ConnectorMappingFormat) |
|  availability | object | Yes | The availability of mapping property. - [ConnectorMappingAvailability object](#ConnectorMappingAvailability) |
|  structure | array | Yes | Ingestion mapping information at property level. - [ConnectorMappingStructure object](#ConnectorMappingStructure) |
|  completeOperation | object | Yes | The operation after import is done. - [ConnectorMappingCompleteOperation object](#ConnectorMappingCompleteOperation) |


<a id="ConnectorMappingErrorManagement" />
### ConnectorMappingErrorManagement object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  errorManagementType | enum | Yes | The type of error management to use for the mapping. - RejectAndContinue, StopImport, RejectUntilLimit |
|  errorLimit | integer | No | The error limit allowed while importing data. |


<a id="ConnectorMappingFormat" />
### ConnectorMappingFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  formatType | enum | Yes | The type mapping format. - TextFormat |
|  columnDelimiter | string | No | The character that signifies a break between columns. |
|  acceptLanguage | string | No | The oData language. |
|  quoteCharacter | string | No | Quote character, used to indicate enquoted fields. |
|  quoteEscapeCharacter | string | No | Escape character for quotes, can be the same as the quoteCharacter. |
|  arraySeparator | string | No | Character separating array elements. |


<a id="ConnectorMappingAvailability" />
### ConnectorMappingAvailability object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frequency | enum | No | The frequency to update. - Minute, Hour, Day, Week, Month |
|  interval | integer | Yes | The interval of the given frequency to use. |


<a id="ConnectorMappingStructure" />
### ConnectorMappingStructure object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  propertyName | string | Yes | The property name of the mapping entity. |
|  columnName | string | Yes | The column name of the import file. |
|  customFormatSpecifier | string | No | Custom format specifier for input parsing. |
|  isEncrypted | boolean | No | Indicates if the column is encrypted. |


<a id="ConnectorMappingCompleteOperation" />
### ConnectorMappingCompleteOperation object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  completionOperationType | enum | No | The type of completion operation. - DoNothing, DeleteFile, MoveFile |
|  destinationFolder | string | No | The destination folder where files will be moved to once the import is done. |

