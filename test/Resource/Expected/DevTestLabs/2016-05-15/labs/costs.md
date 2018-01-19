# Microsoft.DevTestLab/labs/costs template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/costs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/costs",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "targetCost": {
      "status": "string",
      "target": "integer",
      "costThresholds": [
        {
          "thresholdId": "string",
          "percentageThreshold": {
            "thresholdValue": "number"
          },
          "displayOnChart": "string",
          "sendNotificationWhenExceeded": "string",
          "notificationSent": "string"
        }
      ],
      "cycleStartDateTime": "string",
      "cycleEndDateTime": "string",
      "cycleType": "string"
    },
    "currencyCode": "string",
    "startDateTime": "string",
    "endDateTime": "string",
    "createdDate": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/costs" />
### Microsoft.DevTestLab/labs/costs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/costs |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [LabCostProperties object](#LabCostProperties) |


<a id="LabCostProperties" />
### LabCostProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  targetCost | object | No | The target cost properties - [TargetCostProperties object](#TargetCostProperties) |
|  currencyCode | string | No | The currency code of the cost. |
|  startDateTime | string | No | The start time of the cost data. |
|  endDateTime | string | No | The end time of the cost data. |
|  createdDate | string | No | The creation date of the cost. |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="TargetCostProperties" />
### TargetCostProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | Target cost status. - Enabled or Disabled |
|  target | integer | No | Lab target cost |
|  costThresholds | array | No | Cost thresholds. - [CostThresholdProperties object](#CostThresholdProperties) |
|  cycleStartDateTime | string | No | Reporting cycle start date. |
|  cycleEndDateTime | string | No | Reporting cycle end date. |
|  cycleType | enum | No | Reporting cycle type. - CalendarMonth or Custom |


<a id="CostThresholdProperties" />
### CostThresholdProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thresholdId | string | No | The ID of the cost threshold item. |
|  percentageThreshold | object | No | The value of the percentage cost threshold. - [PercentageCostThresholdProperties object](#PercentageCostThresholdProperties) |
|  displayOnChart | enum | No | Indicates whether this threshold will be displayed on cost charts. - Enabled or Disabled |
|  sendNotificationWhenExceeded | enum | No | Indicates whether notifications will be sent when this threshold is exceeded. - Enabled or Disabled |
|  notificationSent | string | No | Indicates the datetime when notifications were last sent for this threshold. |


<a id="PercentageCostThresholdProperties" />
### PercentageCostThresholdProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thresholdValue | number | No | The cost threshold value. |

