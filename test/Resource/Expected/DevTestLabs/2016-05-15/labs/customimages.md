# Microsoft.DevTestLab/labs/customimages template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/customimages resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/customimages",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "vm": {
      "sourceVmId": "string",
      "windowsOsInfo": {
        "windowsOsState": "string"
      },
      "linuxOsInfo": {
        "linuxOsState": "string"
      }
    },
    "vhd": {
      "imageName": "string",
      "sysPrep": "boolean",
      "osType": "string"
    },
    "description": "string",
    "author": "string",
    "managedImageId": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/customimages" />
### Microsoft.DevTestLab/labs/customimages object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/customimages |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [CustomImageProperties object](#CustomImageProperties) |


<a id="CustomImageProperties" />
### CustomImageProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vm | object | No | The virtual machine from which the image is to be created. - [CustomImagePropertiesFromVm object](#CustomImagePropertiesFromVm) |
|  vhd | object | No | The VHD from which the image is to be created. - [CustomImagePropertiesCustom object](#CustomImagePropertiesCustom) |
|  description | string | No | The description of the custom image. |
|  author | string | No | The author of the custom image. |
|  managedImageId | string | No | The Managed Image Id backing the custom image. |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="CustomImagePropertiesFromVm" />
### CustomImagePropertiesFromVm object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceVmId | string | No | The source vm identifier. |
|  windowsOsInfo | object | No | The Windows OS information of the VM. - [WindowsOsInfo object](#WindowsOsInfo) |
|  linuxOsInfo | object | No | The Linux OS information of the VM. - [LinuxOsInfo object](#LinuxOsInfo) |


<a id="CustomImagePropertiesCustom" />
### CustomImagePropertiesCustom object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  imageName | string | No | The image name. |
|  sysPrep | boolean | No | Indicates whether sysprep has been run on the VHD. |
|  osType | enum | Yes | The OS type of the custom image (i.e. Windows, Linux). - Windows, Linux, None |


<a id="WindowsOsInfo" />
### WindowsOsInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  windowsOsState | enum | No | The state of the Windows OS (i.e. NonSysprepped, SysprepRequested, SysprepApplied). - NonSysprepped, SysprepRequested, SysprepApplied |


<a id="LinuxOsInfo" />
### LinuxOsInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  linuxOsState | enum | No | The state of the Linux OS (i.e. NonDeprovisioned, DeprovisionRequested, DeprovisionApplied). - NonDeprovisioned, DeprovisionRequested, DeprovisionApplied |

