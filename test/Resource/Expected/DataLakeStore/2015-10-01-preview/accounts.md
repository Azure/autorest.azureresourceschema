# Microsoft.DataLakeStore/accounts template reference
API Version: 2015-10-01-preview
## Template format

To create a Microsoft.DataLakeStore/accounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeStore/accounts",
  "apiVersion": "2015-10-01-preview",
  "location": "string",
  "identity": {
    "type": "SystemAssigned"
  },
  "tags": {},
  "properties": {
    "encryptionState": "string",
    "encryptionConfig": {
      "type": "string",
      "keyVaultMetaInfo": {
        "keyVaultResourceId": "string",
        "encryptionKeyName": "string",
        "encryptionKeyVersion": "string"
      }
    },
    "endpoint": "string",
    "defaultGroup": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeStore/accounts" />
### Microsoft.DataLakeStore/accounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeStore/accounts |
|  apiVersion | enum | Yes | 2015-10-01-preview |
|  location | string | No | the account regional location. |
|  identity | object | No | The Key vault encryption identity, if any. - [EncryptionIdentity object](#EncryptionIdentity) |
|  tags | object | No | the value of custom properties. |
|  properties | object | Yes | the Data Lake Store account properties. - [DataLakeStoreAccountProperties object](#DataLakeStoreAccountProperties) |
|  resources | array | No | [firewallRules](./accounts/firewallRules.md) |


<a id="EncryptionIdentity" />
### EncryptionIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | No | The type of encryption being used. Currently the only supported type is 'SystemAssigned'. - SystemAssigned |


<a id="DataLakeStoreAccountProperties" />
### DataLakeStoreAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  encryptionState | enum | No | The current state of encryption for this Data Lake store account. - Enabled or Disabled |
|  encryptionConfig | object | No | The Key vault encryption configuration. - [EncryptionConfig object](#EncryptionConfig) |
|  endpoint | string | No | the gateway host. |
|  defaultGroup | string | No | the default owner group for all new folders and files created in the Data Lake Store account. |


<a id="EncryptionConfig" />
### EncryptionConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | No | The type of encryption configuration being used. Currently the only supported types are 'UserManaged' and 'ServiceManaged'. - UserManaged or ServiceManaged |
|  keyVaultMetaInfo | object | No | The Key vault information for connecting to user managed encryption keys. - [KeyVaultMetaInfo object](#KeyVaultMetaInfo) |


<a id="KeyVaultMetaInfo" />
### KeyVaultMetaInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyVaultResourceId | string | No | The resource identifier for the user managed Key Vault being used to encrypt. |
|  encryptionKeyName | string | No | The name of the user managed encryption key. |
|  encryptionKeyVersion | string | No | The version of the user managed encryption key. |

