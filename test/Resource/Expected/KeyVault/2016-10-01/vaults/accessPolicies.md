# Microsoft.KeyVault/vaults/accessPolicies template reference
API Version: 2016-10-01
## Template format

To create a Microsoft.KeyVault/vaults/accessPolicies resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.KeyVault/vaults/accessPolicies",
  "apiVersion": "2016-10-01",
  "properties": {
    "accessPolicies": [
      {
        "tenantId": "string",
        "objectId": "string",
        "applicationId": "string",
        "permissions": {
          "keys": [
            "string"
          ],
          "secrets": [
            "string"
          ],
          "certificates": [
            "string"
          ],
          "storage": [
            "string"
          ]
        }
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.KeyVault/vaults/accessPolicies" />
### Microsoft.KeyVault/vaults/accessPolicies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | add, replace, remove |
|  type | enum | Yes | Microsoft.KeyVault/vaults/accessPolicies |
|  apiVersion | enum | Yes | 2016-10-01 |
|  properties | object | Yes | Properties of the access policy - [VaultAccessPolicyProperties object](#VaultAccessPolicyProperties) |


<a id="VaultAccessPolicyProperties" />
### VaultAccessPolicyProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  accessPolicies | array | Yes | An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. - [AccessPolicyEntry object](#AccessPolicyEntry) |


<a id="AccessPolicyEntry" />
### AccessPolicyEntry object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  tenantId | string | Yes | The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. - globally unique identifier |
|  objectId | string | Yes | The object ID of a user, service principal or security group in the Azure Active Directory tenant for the vault. The object ID must be unique for the list of access policies. |
|  applicationId | string | No |  Application ID of the client making request on behalf of a principal - globally unique identifier |
|  permissions | object | Yes | Permissions the identity has for keys, secrets and certificates. - [Permissions object](#Permissions) |


<a id="Permissions" />
### Permissions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keys | array | No | Permissions to keys - encrypt, decrypt, wrapKey, unwrapKey, sign, verify, get, list, create, update, import, delete, backup, restore, recover, purge |
|  secrets | array | No | Permissions to secrets - get, list, set, delete, backup, restore, recover, purge |
|  certificates | array | No | Permissions to certificates - get, list, delete, create, import, update, managecontacts, getissuers, listissuers, setissuers, deleteissuers, manageissuers, recover, purge |
|  storage | array | No | Permissions to storage accounts - get, list, delete, set, update, regeneratekey, setsas, listsas, getsas, deletesas |

