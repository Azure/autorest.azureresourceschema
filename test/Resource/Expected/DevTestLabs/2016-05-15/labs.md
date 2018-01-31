# Microsoft.DevTestLab/labs template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "labStorageType": "string",
    "premiumDataDisks": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs" />
### Microsoft.DevTestLab/labs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [LabProperties object](#LabProperties) |
|  resources | array | No | [virtualnetworks](./labs/virtualnetworks.md) [virtualmachines](./labs/virtualmachines.md) [users](./labs/users.md) [servicerunners](./labs/servicerunners.md) [schedules](./labs/schedules.md) [notificationchannels](./labs/notificationchannels.md) [formulas](./labs/formulas.md) [customimages](./labs/customimages.md) [costs](./labs/costs.md) [artifactsources](./labs/artifactsources.md) |


<a id="LabProperties" />
### LabProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  labStorageType | enum | No | Type of storage used by the lab. It can be either Premium or Standard. Default is Premium. - Standard or Premium |
|  premiumDataDisks | enum | No | The setting to enable usage of premium data disks.
When its value is 'Enabled', creation of standard or premium data disks is allowed.
When its value is 'Disabled', only creation of standard data disks is allowed. - Disabled or Enabled |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |

