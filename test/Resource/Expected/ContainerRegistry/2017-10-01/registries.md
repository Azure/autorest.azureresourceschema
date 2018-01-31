# Microsoft.ContainerRegistry/registries template reference
API Version: 2017-10-01
## Template format

To create a Microsoft.ContainerRegistry/registries resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ContainerRegistry/registries",
  "apiVersion": "2017-10-01",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string"
  },
  "properties": {
    "adminUserEnabled": boolean,
    "storageAccount": {
      "id": "string"
    }
  },
  "resources": []
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
|  apiVersion | enum | Yes | 2017-10-01 |
|  location | string | Yes | The location of the resource. This cannot be changed after the resource is created. |
|  tags | object | No | The tags of the resource. |
|  sku | object | Yes | The SKU of the container registry. - [Sku object](#Sku) |
|  properties | object | Yes | The properties of the container registry. - [RegistryProperties object](#RegistryProperties) |
|  resources | array | No | [webhooks](./registries/webhooks.md) [replications](./registries/replications.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | The SKU name of the container registry. Required for registry creation. - Classic, Basic, Standard, Premium |


<a id="RegistryProperties" />
### RegistryProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  adminUserEnabled | boolean | No | The value that indicates whether the admin user is enabled. |
|  storageAccount | object | No | The properties of the storage account for the container registry. Only applicable to Classic SKU. - [StorageAccountProperties object](#StorageAccountProperties) |


<a id="StorageAccountProperties" />
### StorageAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes | The resource ID of the storage account. |

