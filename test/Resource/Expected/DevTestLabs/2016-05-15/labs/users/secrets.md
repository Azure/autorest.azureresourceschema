# Microsoft.DevTestLab/labs/users/secrets template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/users/secrets resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/users/secrets",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "value": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/users/secrets" />
### Microsoft.DevTestLab/labs/users/secrets object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/users/secrets |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [SecretProperties object](#SecretProperties) |


<a id="SecretProperties" />
### SecretProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  value | string | No | The value of the secret for secret creation. |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |

