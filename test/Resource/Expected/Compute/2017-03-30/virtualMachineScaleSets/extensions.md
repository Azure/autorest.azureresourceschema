# Microsoft.Compute/virtualMachineScaleSets/extensions template reference
API Version: 2017-03-30
## Template format

To create a Microsoft.Compute/virtualMachineScaleSets/extensions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/virtualMachineScaleSets/extensions",
  "apiVersion": "2017-03-30",
  "properties": {
    "forceUpdateTag": "string",
    "publisher": "string",
    "type": "string",
    "typeHandlerVersion": "string",
    "autoUpgradeMinorVersion": boolean,
    "settings": {},
    "protectedSettings": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/virtualMachineScaleSets/extensions" />
### Microsoft.Compute/virtualMachineScaleSets/extensions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Compute/virtualMachineScaleSets/extensions |
|  apiVersion | enum | Yes | 2017-03-30 |
|  properties | object | Yes | [VirtualMachineScaleSetExtensionProperties object](#VirtualMachineScaleSetExtensionProperties) |


<a id="VirtualMachineScaleSetExtensionProperties" />
### VirtualMachineScaleSetExtensionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  forceUpdateTag | string | No | If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed. |
|  publisher | string | No | The name of the extension handler publisher. |
|  type | string | No | Specifies the type of the extension; an example is "CustomScriptExtension". |
|  typeHandlerVersion | string | No | Specifies the version of the script handler. |
|  autoUpgradeMinorVersion | boolean | No | Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. |
|  settings | object | No | Json formatted public settings for the extension. |
|  protectedSettings | object | No | The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. |

