# Microsoft.Logic/integrationAccounts/maps template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.Logic/integrationAccounts/maps resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/maps",
  "apiVersion": "2016-06-01",
  "location": "string",
  "tags": {},
  "properties": {
    "mapType": "string",
    "parametersSchema": {
      "ref": "string"
    },
    "content": "string",
    "contentType": "string",
    "metadata": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts/maps" />
### Microsoft.Logic/integrationAccounts/maps object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts/maps |
|  apiVersion | enum | Yes | 2016-06-01 |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account map properties. - [IntegrationAccountMapProperties object](#IntegrationAccountMapProperties) |


<a id="IntegrationAccountMapProperties" />
### IntegrationAccountMapProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  mapType | enum | Yes | The map type. - NotSpecified or Xslt |
|  parametersSchema | object | No | The parameters schema of integration account map. - [IntegrationAccountMapPropertiesParametersSchema object](#IntegrationAccountMapPropertiesParametersSchema) |
|  content | string | No | The content. |
|  contentType | string | No | The content type. |
|  metadata | object | No | The metadata. |


<a id="IntegrationAccountMapPropertiesParametersSchema" />
### IntegrationAccountMapPropertiesParametersSchema object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ref | string | No | The reference name. |

