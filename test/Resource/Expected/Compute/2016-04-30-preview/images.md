# Microsoft.Compute/images template reference
API Version: 2016-04-30-preview
## Template format

To create a Microsoft.Compute/images resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/images",
  "apiVersion": "2016-04-30-preview",
  "location": "string",
  "tags": {},
  "properties": {
    "sourceVirtualMachine": {
      "id": "string"
    },
    "storageProfile": {
      "osDisk": {
        "osType": "string",
        "osState": "string",
        "snapshot": {
          "id": "string"
        },
        "managedDisk": {
          "id": "string"
        },
        "blobUri": "string",
        "caching": "string",
        "diskSizeGB": "integer"
      },
      "dataDisks": [
        {
          "lun": "integer",
          "snapshot": {
            "id": "string"
          },
          "managedDisk": {
            "id": "string"
          },
          "blobUri": "string",
          "caching": "string",
          "diskSizeGB": "integer"
        }
      ]
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/images" />
### Microsoft.Compute/images object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Compute/images |
|  apiVersion | enum | Yes | 2016-04-30-preview |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | [ImageProperties object](#ImageProperties) |


<a id="ImageProperties" />
### ImageProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceVirtualMachine | object | No | The source virtual machine from which Image is created. - [SubResource object](#SubResource) |
|  storageProfile | object | No | Specifies the storage settings for the virtual machine disks. - [ImageStorageProfile object](#ImageStorageProfile) |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |


<a id="ImageStorageProfile" />
### ImageStorageProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osDisk | object | Yes | Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). - [ImageOSDisk object](#ImageOSDisk) |
|  dataDisks | array | No | Specifies the parameters that are used to add a data disk to a virtual machine. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). - [ImageDataDisk object](#ImageDataDisk) |


<a id="ImageOSDisk" />
### ImageOSDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osType | enum | Yes | This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**. - Windows or Linux |
|  osState | enum | Yes | The OS State. - Generalized or Specialized |
|  snapshot | object | No | The snapshot. - [SubResource object](#SubResource) |
|  managedDisk | object | No | The managedDisk. - [SubResource object](#SubResource) |
|  blobUri | string | No | The Virtual Hard Disk. |
|  caching | enum | No | Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**. - None, ReadOnly, ReadWrite |
|  diskSizeGB | integer | No | Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB |


<a id="ImageDataDisk" />
### ImageDataDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lun | integer | Yes | Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. |
|  snapshot | object | No | The snapshot. - [SubResource object](#SubResource) |
|  managedDisk | object | No | The managedDisk. - [SubResource object](#SubResource) |
|  blobUri | string | No | The Virtual Hard Disk. |
|  caching | enum | No | Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**. - None, ReadOnly, ReadWrite |
|  diskSizeGB | integer | No | Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB |

