# Microsoft.Compute/availabilitySets template reference
API Version: 2016-04-30-preview
## Template format

To create a Microsoft.Compute/availabilitySets resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/availabilitySets",
  "apiVersion": "2016-04-30-preview",
  "location": "string",
  "tags": {},
  "properties": {
    "platformUpdateDomainCount": "integer",
    "platformFaultDomainCount": "integer",
    "virtualMachines": [
      {
        "id": "string"
      }
    ],
    "managed": boolean
  },
  "sku": {
    "name": "string",
    "tier": "string",
    "capacity": "integer"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/availabilitySets" />
### Microsoft.Compute/availabilitySets object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Compute/availabilitySets |
|  apiVersion | enum | Yes | 2016-04-30-preview |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | [AvailabilitySetProperties object](#AvailabilitySetProperties) |
|  sku | object | No | Sku of the availability set - [Sku object](#Sku) |


<a id="AvailabilitySetProperties" />
### AvailabilitySetProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  platformUpdateDomainCount | integer | No | Update Domain count. |
|  platformFaultDomainCount | integer | No | Fault Domain count. |
|  virtualMachines | array | No | A list of references to all virtual machines in the availability set. - [SubResource object](#SubResource) |
|  managed | boolean | No | If the availability set supports managed disks. |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The sku name. |
|  tier | string | No | Specifies the tier of virtual machines in a scale set.<br /><br /> Possible Values:<br /><br /> **Standard**<br /><br /> **Basic** |
|  capacity | integer | No | Specifies the number of virtual machines in the scale set. |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |

