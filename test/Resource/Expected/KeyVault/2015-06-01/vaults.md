# Microsoft.KeyVault/vaults template reference
API Version: 2015-06-01
## Template format

To create a Microsoft.KeyVault/vaults resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.KeyVault/vaults",
  "apiVersion": "2015-06-01",
  "location": "string",
  "tags": {},
  "properties": {
    "vaultUri": "string",
    "tenantId": "string",
    "sku": {
      "family": "A",
      "name": "string"
    },
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
          ]
        }
      }
    ],
    "enabledForDeployment": boolean,
    "enabledForDiskEncryption": boolean,
    "enabledForTemplateDeployment": boolean,
    "enableSoftDelete": boolean
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.KeyVault/vaults" />
### Microsoft.KeyVault/vaults object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.KeyVault/vaults |
|  apiVersion | enum | Yes | 2015-06-01 |
|  location | string | Yes | The supported Azure location where the key vault should be created. |
|  tags | object | No | The tags that will be assigned to the key vault.  |
|  properties | object | Yes | Properties of the vault - [VaultProperties object](#VaultProperties) |


<a id="VaultProperties" />
### VaultProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vaultUri | string | No | The URI of the vault for performing operations on keys and secrets. |
|  tenantId | string | Yes | The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. - globally unique identifier |
|  sku | object | Yes | SKU details - [Sku object](#Sku) |
|  accessPolicies | array | Yes | An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. - [AccessPolicyEntry object](#AccessPolicyEntry) |
|  enabledForDeployment | boolean | No | Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault. |
|  enabledForDiskEncryption | boolean | No | Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys. |
|  enabledForTemplateDeployment | boolean | No | Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault. |
|  enableSoftDelete | boolean | No | Property to specify whether the 'soft delete' functionality is enabled for this key vault. |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  family | enum | Yes | SKU family name - A |
|  name | enum | Yes | SKU name to specify whether the key vault is a standard vault or a premium vault. - standard or premium |


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
|  keys | array | No | Permissions to keys - all, encrypt, decrypt, wrapKey, unwrapKey, sign, verify, get, list, create, update, import, delete, backup, restore, recover, purge |
|  secrets | array | No | Permissions to secrets - all, get, list, set, delete, backup, restore, recover, purge |
|  certificates | array | No | Permissions to certificates - all, get, list, delete, create, import, update, managecontacts, getissuers, listissuers, setissuers, deleteissuers, manageissuers, recover, purge |

