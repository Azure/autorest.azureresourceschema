# Microsoft.DevTestLab/labs/servicerunners template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/servicerunners resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/servicerunners",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "identity": {
    "type": "string",
    "principalId": "string",
    "tenantId": "string",
    "clientSecretUrl": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/servicerunners" />
### Microsoft.DevTestLab/labs/servicerunners object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/servicerunners |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  identity | object | No | The identity of the resource. - [IdentityProperties object](#IdentityProperties) |


<a id="IdentityProperties" />
### IdentityProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | string | No | Managed identity. |
|  principalId | string | No | The principal id of resource identity. |
|  tenantId | string | No | The tenant identifier of resource. |
|  clientSecretUrl | string | No | The client secret URL of the identity. |

