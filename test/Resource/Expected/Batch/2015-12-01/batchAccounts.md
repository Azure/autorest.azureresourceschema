# Microsoft.Batch/batchAccounts template reference
API Version: 2015-12-01
## Template format

To create a Microsoft.Batch/batchAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Batch/batchAccounts",
  "apiVersion": "2015-12-01",
  "location": "string",
  "tags": {},
  "properties": {
    "autoStorage": {
      "storageAccountId": "string"
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
|  apiVersion | enum | Yes | 2015-12-01 |
|  location | string | Yes | The region in which to create the account. |
|  tags | object | No | The user specified tags associated with the account. |
|  properties | object | Yes | The properties of the account. - [BatchAccountBaseProperties object](#BatchAccountBaseProperties) |
|  resources | array | No | [applications](./batchAccounts/applications.md) |


<a id="BatchAccountBaseProperties" />
### BatchAccountBaseProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  autoStorage | object | No | The properties related to auto storage account. - [AutoStorageBaseProperties object](#AutoStorageBaseProperties) |


<a id="AutoStorageBaseProperties" />
### AutoStorageBaseProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountId | string | Yes | The resource ID of the storage account to be used for auto storage account. |

