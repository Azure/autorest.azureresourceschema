# Microsoft.ContainerRegistry/registries template reference
API Version: 2017-03-01
## Template format

To create a Microsoft.ContainerRegistry/registries resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ContainerRegistry/registries",
  "apiVersion": "2017-03-01",
  "tags": {},
  "location": "string",
  "sku": {
    "name": "string"
  },
  "properties": {
    "adminUserEnabled": boolean,
    "storageAccount": {
      "name": "string",
      "accessKey": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ContainerRegistry/registries" />
### Microsoft.ContainerRegistry/registries object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the container registry. |
|  type | enum | Yes | Microsoft.ContainerRegistry/registries |
|  apiVersion | enum | Yes | 2017-03-01 |
|  tags | object | No | The tags for the container registry. |
|  location | string | Yes | The location of the container registry. This cannot be changed after the resource is created. |
|  sku | object | Yes | The SKU of the container registry. - [Sku object](#Sku) |
|  properties | object | Yes | The properties that the container registry will be created with. - [RegistryPropertiesCreateParameters object](#RegistryPropertiesCreateParameters) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The SKU name of the container registry. Required for registry creation. Allowed value: Basic. |


<a id="RegistryPropertiesCreateParameters" />
### RegistryPropertiesCreateParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  adminUserEnabled | boolean | No | The value that indicates whether the admin user is enabled. |
|  storageAccount | object | Yes | The parameters of a storage account for the container registry. If specified, the storage account must be in the same physical location as the container registry. - [StorageAccountParameters object](#StorageAccountParameters) |


<a id="StorageAccountParameters" />
### StorageAccountParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the storage account. |
|  accessKey | string | Yes | The access key to the storage account. |

