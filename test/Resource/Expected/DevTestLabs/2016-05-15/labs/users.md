# Microsoft.DevTestLab/labs/users template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/users resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/users",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "identity": {
      "principalName": "string",
      "principalId": "string",
      "tenantId": "string",
      "objectId": "string",
      "appId": "string"
    },
    "secretStore": {
      "keyVaultUri": "string",
      "keyVaultId": "string"
    },
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/users" />
### Microsoft.DevTestLab/labs/users object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/users |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [UserProperties object](#UserProperties) |
|  resources | array | No | [secrets](./users/secrets.md) [environments](./users/environments.md) [disks](./users/disks.md) |


<a id="UserProperties" />
### UserProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  identity | object | No | The identity of the user. - [UserIdentity object](#UserIdentity) |
|  secretStore | object | No | The secret store of the user. - [UserSecretStore object](#UserSecretStore) |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="UserIdentity" />
### UserIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  principalName | string | No | Set to the principal name / UPN of the client JWT making the request. |
|  principalId | string | No | Set to the principal Id of the client JWT making the request. Service principal will not have the principal Id. |
|  tenantId | string | No | Set to the tenant ID of the client JWT making the request. |
|  objectId | string | No | Set to the object Id of the client JWT making the request. Not all users have object Id. For CSP (reseller) scenarios for example, object Id is not available. |
|  appId | string | No | Set to the app Id of the client JWT making the request. |


<a id="UserSecretStore" />
### UserSecretStore object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyVaultUri | string | No | The URI of the user's Key vault. |
|  keyVaultId | string | No | The ID of the user's Key vault. |

