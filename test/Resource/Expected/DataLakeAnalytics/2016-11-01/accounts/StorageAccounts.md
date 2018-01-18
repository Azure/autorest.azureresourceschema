# Microsoft.DataLakeAnalytics/accounts/StorageAccounts template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeAnalytics/accounts/StorageAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeAnalytics/accounts/StorageAccounts",
  "apiVersion": "2016-11-01",
  "properties": {
    "accessKey": "string",
    "suffix": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeAnalytics/accounts/StorageAccounts" />
### Microsoft.DataLakeAnalytics/accounts/StorageAccounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeAnalytics/accounts/StorageAccounts |
|  apiVersion | enum | Yes | 2016-11-01 |
|  properties | object | Yes | the properties for the Azure Storage account being added. - [StorageAccountProperties object](#StorageAccountProperties) |


<a id="StorageAccountProperties" />
### StorageAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  accessKey | string | Yes | the access key associated with this Azure Storage account that will be used to connect to it. |
|  suffix | string | No | the optional suffix for the storage account. |

