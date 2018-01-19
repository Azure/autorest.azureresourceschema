# Microsoft.DevTestLab/labs/policysets/policies template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/policysets/policies resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/policysets/policies",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "description": "string",
    "status": "string",
    "factName": "string",
    "factData": "string",
    "threshold": "string",
    "evaluatorType": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/policysets/policies" />
### Microsoft.DevTestLab/labs/policysets/policies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/policysets/policies |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [PolicyProperties object](#PolicyProperties) |


<a id="PolicyProperties" />
### PolicyProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | The description of the policy. |
|  status | enum | No | The status of the policy. - Enabled or Disabled |
|  factName | enum | No | The fact name of the policy (e.g. LabVmCount, LabVmSize, MaxVmsAllowedPerLab, etc. - UserOwnedLabVmCount, UserOwnedLabPremiumVmCount, LabVmCount, LabPremiumVmCount, LabVmSize, GalleryImage, UserOwnedLabVmCountInSubnet, LabTargetCost |
|  factData | string | No | The fact data of the policy. |
|  threshold | string | No | The threshold of the policy (i.e. a number for MaxValuePolicy, and a JSON array of values for AllowedValuesPolicy). |
|  evaluatorType | enum | No | The evaluator type of the policy (i.e. AllowedValuesPolicy, MaxValuePolicy). - AllowedValuesPolicy or MaxValuePolicy |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |

