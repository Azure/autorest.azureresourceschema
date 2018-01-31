# Microsoft.Logic/integrationAccounts template reference
API Version: 2015-08-01-preview
## Template format

To create a Microsoft.Logic/integrationAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts",
  "apiVersion": "2015-08-01-preview",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {},
  "sku": {
    "name": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts" />
### Microsoft.Logic/integrationAccounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts |
|  apiVersion | enum | Yes | 2015-08-01-preview |
|  id | string | No | The resource id. |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account properties. |
|  sku | object | No | The sku. - [IntegrationAccountSku object](#IntegrationAccountSku) |
|  resources | array | No | [certificates](./integrationAccounts/certificates.md) [agreements](./integrationAccounts/agreements.md) [partners](./integrationAccounts/partners.md) [maps](./integrationAccounts/maps.md) [schemas](./integrationAccounts/schemas.md) |


<a id="IntegrationAccountSku" />
### IntegrationAccountSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | The sku name. - NotSpecified, Free, Shared, Basic, Standard, Premium |

