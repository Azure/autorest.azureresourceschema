# Microsoft.DataLakeAnalytics/accounts/DataLakeStoreAccounts template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeAnalytics/accounts/DataLakeStoreAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeAnalytics/accounts/DataLakeStoreAccounts",
  "apiVersion": "2016-11-01",
  "properties": {
    "suffix": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeAnalytics/accounts/DataLakeStoreAccounts" />
### Microsoft.DataLakeAnalytics/accounts/DataLakeStoreAccounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeAnalytics/accounts/DataLakeStoreAccounts |
|  apiVersion | enum | Yes | 2016-11-01 |
|  properties | object | Yes | the properties for the Data Lake Store account being added. - [DataLakeStoreAccountInfoProperties object](#DataLakeStoreAccountInfoProperties) |


<a id="DataLakeStoreAccountInfoProperties" />
### DataLakeStoreAccountInfoProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  suffix | string | No | the optional suffix for the Data Lake Store account. |

