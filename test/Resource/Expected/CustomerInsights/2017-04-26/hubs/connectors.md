# Microsoft.CustomerInsights/hubs/connectors template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/connectors resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/connectors",
  "apiVersion": "2017-04-26",
  "properties": {
    "connectorName": "string",
    "connectorType": "string",
    "displayName": "string",
    "description": "string",
    "connectorProperties": {},
    "isInternal": "boolean"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/connectors" />
### Microsoft.CustomerInsights/hubs/connectors object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/connectors |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [Connector object](#Connector) |
|  resources | array | No | [mappings](./connectors/mappings.md) |


<a id="Connector" />
### Connector object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  connectorName | string | No | Name of the connector. |
|  connectorType | enum | Yes | Type of connector. - None, CRM, AzureBlob, Salesforce, ExchangeOnline, Outbound |
|  displayName | string | No | Display name of the connector. |
|  description | string | No | Description of the connector. |
|  connectorProperties | object | Yes | The connector properties. |
|  isInternal | boolean | No | If this is an internal connector. |

