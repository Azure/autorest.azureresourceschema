# Microsoft.Compute/availabilitySets template reference
API Version: 2016-03-30
## Template format

To create a Microsoft.Compute/availabilitySets resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/availabilitySets",
  "apiVersion": "2016-03-30",
  "location": "string",
  "tags": {},
  "properties": {
    "platformUpdateDomainCount": "integer",
    "platformFaultDomainCount": "integer",
    "virtualMachines": [
      {
        "id": "string"
      }
    ]
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
|  apiVersion | enum | Yes | 2016-03-30 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | [AvailabilitySetProperties object](#AvailabilitySetProperties) |


<a id="AvailabilitySetProperties" />
### AvailabilitySetProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  platformUpdateDomainCount | integer | No | Update Domain count. |
|  platformFaultDomainCount | integer | No | Fault Domain count. |
|  virtualMachines | array | No | A list of references to all virtual machines in the availability set. - [SubResource object](#SubResource) |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |

