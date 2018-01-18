# Microsoft.Storage/storageAccounts template reference
API Version: 2015-06-15
## Template format

To create a Microsoft.Storage/storageAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Storage/storageAccounts",
  "apiVersion": "2015-06-15",
  "location": "string",
  "tags": {},
  "properties": {
    "accountType": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Storage/storageAccounts" />
### Microsoft.Storage/storageAccounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Storage/storageAccounts |
|  apiVersion | enum | Yes | 2015-06-15 |
|  location | string | Yes | The location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed. |
|  tags | object | No | A list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters. |
|  properties | object | Yes | [StorageAccountPropertiesCreateParameters object](#StorageAccountPropertiesCreateParameters) |


<a id="StorageAccountPropertiesCreateParameters" />
### StorageAccountPropertiesCreateParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  accountType | enum | Yes | The sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType. - Standard_LRS, Standard_ZRS, Standard_GRS, Standard_RAGRS, Premium_LRS |

