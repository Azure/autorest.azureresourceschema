# Microsoft.Compute/snapshots template reference
API Version: 2017-03-30
## Template format

To create a Microsoft.Compute/snapshots resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/snapshots",
  "apiVersion": "2017-03-30",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string"
  },
  "properties": {
    "osType": "string",
    "creationData": {
      "createOption": "string",
      "storageAccountId": "string",
      "imageReference": {
        "id": "string",
        "lun": "integer"
      },
      "sourceUri": "string",
      "sourceResourceId": "string"
    },
    "diskSizeGB": "integer",
    "encryptionSettings": {
      "enabled": boolean,
      "diskEncryptionKey": {
        "sourceVault": {
          "id": "string"
        },
        "secretUrl": "string"
      },
      "keyEncryptionKey": {
        "sourceVault": {
          "id": "string"
        },
        "keyUrl": "string"
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/snapshots" />
### Microsoft.Compute/snapshots object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the snapshot within the given subscription and resource group. |
|  type | enum | Yes | Microsoft.Compute/snapshots |
|  apiVersion | enum | Yes | 2017-03-30 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  sku | object | No | [DiskSku object](#DiskSku) |
|  properties | object | Yes | [DiskProperties object](#DiskProperties) |


<a id="DiskSku" />
### DiskSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | The sku name. - Standard_LRS or Premium_LRS |


<a id="DiskProperties" />
### DiskProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osType | enum | No | The Operating System type. - Windows or Linux |
|  creationData | object | Yes | Disk source information. CreationData information cannot be changed after the disk has been created. - [CreationData object](#CreationData) |
|  diskSizeGB | integer | No | If creationData.createOption is Empty, this field is mandatory and it indicates the size of the VHD to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size. |
|  encryptionSettings | object | No | Encryption settings for disk or snapshot - [EncryptionSettings object](#EncryptionSettings) |


<a id="CreationData" />
### CreationData object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  createOption | enum | Yes | This enumerates the possible sources of a disk's creation. - Empty, Attach, FromImage, Import, Copy |
|  storageAccountId | string | No | If createOption is Import, the Azure Resource Manager identifier of the storage account containing the blob to import as a disk. Required only if the blob is in a different subscription |
|  imageReference | object | No | Disk source information. - [ImageDiskReference object](#ImageDiskReference) |
|  sourceUri | string | No | If createOption is Import, this is the URI of a blob to be imported into a managed disk. |
|  sourceResourceId | string | No | If createOption is Copy, this is the ARM id of the source snapshot or disk. |


<a id="EncryptionSettings" />
### EncryptionSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | No | Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. |
|  diskEncryptionKey | object | No | Key Vault Secret Url and vault id of the disk encryption key - [KeyVaultAndSecretReference object](#KeyVaultAndSecretReference) |
|  keyEncryptionKey | object | No | Key Vault Key Url and vault id of the key encryption key - [KeyVaultAndKeyReference object](#KeyVaultAndKeyReference) |


<a id="ImageDiskReference" />
### ImageDiskReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes | A relative uri containing either a Platform Imgage Repository or user image reference. |
|  lun | integer | No | If the disk is created from an image's data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. |


<a id="KeyVaultAndSecretReference" />
### KeyVaultAndSecretReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceVault | object | Yes | Resource id of the KeyVault containing the key or secret - [SourceVault object](#SourceVault) |
|  secretUrl | string | Yes | Url pointing to a key or secret in KeyVault |


<a id="KeyVaultAndKeyReference" />
### KeyVaultAndKeyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceVault | object | Yes | Resource id of the KeyVault containing the key or secret - [SourceVault object](#SourceVault) |
|  keyUrl | string | Yes | Url pointing to a key or secret in KeyVault |


<a id="SourceVault" />
### SourceVault object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |

