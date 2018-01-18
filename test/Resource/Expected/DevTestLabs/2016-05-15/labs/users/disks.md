# Microsoft.DevTestLab/labs/users/disks template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/users/disks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/users/disks",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "diskType": "string",
    "diskSizeGiB": "integer",
    "leasedByLabVmId": "string",
    "diskBlobName": "string",
    "diskUri": "string",
    "hostCaching": "string",
    "managedDiskId": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/users/disks" />
### Microsoft.DevTestLab/labs/users/disks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/users/disks |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [DiskProperties object](#DiskProperties) |


<a id="DiskProperties" />
### DiskProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  diskType | enum | No | The storage type for the disk (i.e. Standard, Premium). - Standard or Premium |
|  diskSizeGiB | integer | No | The size of the disk in GibiBytes. |
|  leasedByLabVmId | string | No | The resource ID of the VM to which this disk is leased. |
|  diskBlobName | string | No | When backed by a blob, the name of the VHD blob without extension. |
|  diskUri | string | No | When backed by a blob, the URI of underlying blob. |
|  hostCaching | string | No | The host caching policy of the disk (i.e. None, ReadOnly, ReadWrite). |
|  managedDiskId | string | No | When backed by managed disk, this is the ID of the compute disk resource. |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |

