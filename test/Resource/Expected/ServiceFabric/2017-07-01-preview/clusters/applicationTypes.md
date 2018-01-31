# Microsoft.ServiceFabric/clusters/applicationTypes template reference
API Version: 2017-07-01-preview
## Template format

To create a Microsoft.ServiceFabric/clusters/applicationTypes resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceFabric/clusters/applicationTypes",
  "apiVersion": "2017-07-01-preview",
  "location": "string",
  "properties": {},
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceFabric/clusters/applicationTypes" />
### Microsoft.ServiceFabric/clusters/applicationTypes object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the application type name resource |
|  type | enum | Yes | Microsoft.ServiceFabric/clusters/applicationTypes |
|  apiVersion | enum | Yes | 2017-07-01-preview |
|  location | string | Yes | Resource location. |
|  properties | object | Yes | [ApplicationTypeProperties object](#ApplicationTypeProperties) |
|  resources | array | No | [versions](./applicationTypes/versions.md) |

