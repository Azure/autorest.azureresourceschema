# Microsoft.Logic/integrationAccounts/sessions template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.Logic/integrationAccounts/sessions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/sessions",
  "apiVersion": "2016-06-01",
  "location": "string",
  "tags": {},
  "properties": {
    "content": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts/sessions" />
### Microsoft.Logic/integrationAccounts/sessions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts/sessions |
|  apiVersion | enum | Yes | 2016-06-01 |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account session properties. - [IntegrationAccountSessionProperties object](#IntegrationAccountSessionProperties) |


<a id="IntegrationAccountSessionProperties" />
### IntegrationAccountSessionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  content | object | No | The session content. |

