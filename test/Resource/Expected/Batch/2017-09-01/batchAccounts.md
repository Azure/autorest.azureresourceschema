# Microsoft.Batch/batchAccounts template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Batch/batchAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Batch/batchAccounts",
  "apiVersion": "2017-09-01",
  "location": "string",
  "tags": {},
  "properties": {
    "autoStorage": {
      "storageAccountId": "string"
    },
    "poolAllocationMode": "string",
    "keyVaultReference": {
      "id": "string",
      "url": "string"
    }
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Batch/batchAccounts" />
### Microsoft.Batch/batchAccounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Batch/batchAccounts |
|  apiVersion | enum | Yes | 2017-09-01 |
|  location | string | Yes | The region in which to create the account. |
|  tags | object | No | The user-specified tags associated with the account. |
|  properties | object | Yes | The properties of the Batch account. - [BatchAccountCreateProperties object](#BatchAccountCreateProperties) |
|  resources | array | No | [pools](./batchAccounts/pools.md) [certificates](./batchAccounts/certificates.md) [applications](./batchAccounts/applications.md) |


<a id="BatchAccountCreateProperties" />
### BatchAccountCreateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  autoStorage | object | No | The properties related to the auto-storage account. - [AutoStorageBaseProperties object](#AutoStorageBaseProperties) |
|  poolAllocationMode | enum | No | The pool allocation mode also affects how clients may authenticate to the Batch Service API. If the mode is BatchService, clients may authenticate using access keys or Azure Active Directory. If the mode is UserSubscription, clients must use Azure Active Directory. The default is BatchService. - BatchService or UserSubscription |
|  keyVaultReference | object | No | A reference to the Azure key vault associated with the Batch account. - [KeyVaultReference object](#KeyVaultReference) |


<a id="AutoStorageBaseProperties" />
### AutoStorageBaseProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountId | string | Yes | The resource ID of the storage account to be used for auto-storage account. |


<a id="KeyVaultReference" />
### KeyVaultReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes | The resource ID of the Azure key vault associated with the Batch account. |
|  url | string | Yes | The URL of the Azure key vault associated with the Batch account. |

