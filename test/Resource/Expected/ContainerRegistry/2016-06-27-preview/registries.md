# Microsoft.ContainerRegistry/registries template reference
API Version: 2016-06-27-preview
## Template format

To create a Microsoft.ContainerRegistry/registries resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ContainerRegistry/registries",
  "apiVersion": "2016-06-27-preview",
  "location": "string",
  "tags": {},
  "properties": {
    "adminUserEnabled": "boolean",
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
|  apiVersion | enum | Yes | 2016-06-27-preview |
|  location | string | Yes | The location of the resource. This cannot be changed after the resource is created. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the container registry. - [RegistryProperties object](#RegistryProperties) |


<a id="RegistryProperties" />
### RegistryProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  adminUserEnabled | boolean | No | The value that indicates whether the admin user is enabled. This value is false by default. |
|  storageAccount | object | Yes | The properties of the storage account for the container registry. If specified, the storage account must be in the same physical location as the container registry. - [StorageAccountProperties object](#StorageAccountProperties) |


<a id="StorageAccountProperties" />
### StorageAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the storage account. |
|  accessKey | string | Yes | The access key to the storage account. |

