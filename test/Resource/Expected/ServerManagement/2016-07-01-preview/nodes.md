# Microsoft.ServerManagement/nodes template reference
API Version: 2016-07-01-preview
## Template format

To create a Microsoft.ServerManagement/nodes resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServerManagement/nodes",
  "apiVersion": "2016-07-01-preview",
  "location": "string",
  "tags": {},
  "properties": {
    "gatewayId": "string",
    "connectionName": "string",
    "userName": "string",
    "password": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServerManagement/nodes" />
### Microsoft.ServerManagement/nodes object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.ServerManagement/nodes |
|  apiVersion | enum | Yes | 2016-07-01-preview |
|  location | string | No | Location of the resource. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Collection of properties. - [NodeParametersProperties object](#NodeParametersProperties) |
|  resources | array | No | [sessions](./nodes/sessions.md) |


<a id="NodeParametersProperties" />
### NodeParametersProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  gatewayId | string | No | Gateway ID which will manage this node. |
|  connectionName | string | No | myhost.domain.com |
|  userName | string | No | User name to be used to connect to node. |
|  password | string | No | Password associated with user name. |

