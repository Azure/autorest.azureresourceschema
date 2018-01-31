# Microsoft.Compute/virtualMachines/extensions template reference
API Version: 2017-12-01
## Template format

To create a Microsoft.Compute/virtualMachines/extensions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/virtualMachines/extensions",
  "apiVersion": "2017-12-01",
  "location": "string",
  "tags": {},
  "properties": {
    "forceUpdateTag": "string",
    "publisher": "string",
    "type": "string",
    "typeHandlerVersion": "string",
    "autoUpgradeMinorVersion": boolean,
    "settings": {},
    "protectedSettings": {},
    "instanceView": {
      "name": "string",
      "type": "string",
      "typeHandlerVersion": "string",
      "substatuses": [
        {
          "code": "string",
          "level": "string",
          "displayStatus": "string",
          "message": "string",
          "time": "string"
        }
      ],
      "statuses": [
        {
          "code": "string",
          "level": "string",
          "displayStatus": "string",
          "message": "string",
          "time": "string"
        }
      ]
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/virtualMachines/extensions" />
### Microsoft.Compute/virtualMachines/extensions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Compute/virtualMachines/extensions |
|  apiVersion | enum | Yes | 2017-12-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | [VirtualMachineExtensionProperties object](#VirtualMachineExtensionProperties) |


<a id="VirtualMachineExtensionProperties" />
### VirtualMachineExtensionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  forceUpdateTag | string | No | How the extension handler should be forced to update even if the extension configuration has not changed. |
|  publisher | string | No | The name of the extension handler publisher. |
|  type | string | No | Specifies the type of the extension; an example is "CustomScriptExtension". |
|  typeHandlerVersion | string | No | Specifies the version of the script handler. |
|  autoUpgradeMinorVersion | boolean | No | Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. |
|  settings | object | No | Json formatted public settings for the extension. |
|  protectedSettings | object | No | The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. |
|  instanceView | object | No | The virtual machine extension instance view. - [VirtualMachineExtensionInstanceView object](#VirtualMachineExtensionInstanceView) |


<a id="VirtualMachineExtensionInstanceView" />
### VirtualMachineExtensionInstanceView object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The virtual machine extension name. |
|  type | string | No | Specifies the type of the extension; an example is "CustomScriptExtension". |
|  typeHandlerVersion | string | No | Specifies the version of the script handler. |
|  substatuses | array | No | The resource status information. - [InstanceViewStatus object](#InstanceViewStatus) |
|  statuses | array | No | The resource status information. - [InstanceViewStatus object](#InstanceViewStatus) |


<a id="InstanceViewStatus" />
### InstanceViewStatus object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  code | string | No | The status code. |
|  level | enum | No | The level code. - Info, Warning, Error |
|  displayStatus | string | No | The short localizable label for the status. |
|  message | string | No | The detailed status message, including for alerts and error messages. |
|  time | string | No | The time of the status. |

