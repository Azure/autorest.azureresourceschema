# Microsoft.Authorization/locks template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Authorization/locks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Authorization/locks",
  "apiVersion": "2016-09-01",
  "properties": {
    "level": "string",
    "notes": "string",
    "owners": [
      {
        "applicationId": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Authorization/locks" />
### Microsoft.Authorization/locks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Authorization/locks |
|  apiVersion | enum | Yes | 2016-09-01 |
|  properties | object | Yes | The properties of the lock. - [ManagementLockProperties object](#ManagementLockProperties) |


<a id="ManagementLockProperties" />
### ManagementLockProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  level | enum | Yes | The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can't modify or delete it. - NotSpecified, CanNotDelete, ReadOnly |
|  notes | string | No | Notes about the lock. Maximum of 512 characters. |
|  owners | array | No | The owners of the lock. - [ManagementLockOwner object](#ManagementLockOwner) |


<a id="ManagementLockOwner" />
### ManagementLockOwner object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  applicationId | string | No | The application ID of the lock owner. |

