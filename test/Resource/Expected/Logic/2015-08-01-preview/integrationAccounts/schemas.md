# Microsoft.Logic/integrationAccounts/schemas template reference
API Version: 2015-08-01-preview
## Template format

To create a Microsoft.Logic/integrationAccounts/schemas resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/schemas",
  "apiVersion": "2015-08-01-preview",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "schemaType": "string",
    "targetNamespace": "string",
    "content": {},
    "contentType": "string",
    "metadata": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts/schemas" />
### Microsoft.Logic/integrationAccounts/schemas object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts/schemas |
|  apiVersion | enum | Yes | 2015-08-01-preview |
|  id | string | No | The resource id. |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account schema properties. - [IntegrationAccountSchemaProperties object](#IntegrationAccountSchemaProperties) |


<a id="IntegrationAccountSchemaProperties" />
### IntegrationAccountSchemaProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  schemaType | enum | No | The schema type. - NotSpecified or Xml |
|  targetNamespace | string | No | The target namespace. |
|  content | object | No | The content. |
|  contentType | string | No | The content type. |
|  metadata | object | No | The metadata. |

