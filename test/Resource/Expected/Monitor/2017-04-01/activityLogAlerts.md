# microsoft.insights/activityLogAlerts template reference
API Version: 2017-04-01
## Template format

To create a microsoft.insights/activityLogAlerts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/activityLogAlerts",
  "apiVersion": "2017-04-01",
  "location": "string",
  "tags": {},
  "properties": {
    "scopes": [
      "string"
    ],
    "enabled": "boolean",
    "condition": {
      "allOf": [
        {
          "field": "string",
          "equals": "string"
        }
      ]
    },
    "actions": {
      "actionGroups": [
        {
          "actionGroupId": "string",
          "webhookProperties": {}
        }
      ]
    },
    "description": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/activityLogAlerts" />
### microsoft.insights/activityLogAlerts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the activity log alert. |
|  type | enum | Yes | microsoft.insights/activityLogAlerts |
|  apiVersion | enum | Yes | 2017-04-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | The activity log alert properties of the resource. - [ActivityLogAlert object](#ActivityLogAlert) |


<a id="ActivityLogAlert" />
### ActivityLogAlert object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  scopes | array | Yes | A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item. - string |
|  enabled | boolean | No | Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated. |
|  condition | object | Yes | The condition that will cause this alert to activate. - [ActivityLogAlertAllOfCondition object](#ActivityLogAlertAllOfCondition) |
|  actions | object | Yes | The actions that will activate when the condition is met. - [ActivityLogAlertActionList object](#ActivityLogAlertActionList) |
|  description | string | No | A description of this activity log alert. |


<a id="ActivityLogAlertAllOfCondition" />
### ActivityLogAlertAllOfCondition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allOf | array | Yes | The list of activity log alert conditions. - [ActivityLogAlertLeafCondition object](#ActivityLogAlertLeafCondition) |


<a id="ActivityLogAlertActionList" />
### ActivityLogAlertActionList object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  actionGroups | array | No | The list of activity log alerts. - [ActivityLogAlertActionGroup object](#ActivityLogAlertActionGroup) |


<a id="ActivityLogAlertLeafCondition" />
### ActivityLogAlertLeafCondition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  field | string | Yes | The name of the field that this condition will examine. The possible values for this field are (case-insensitive): 'resourceId', 'category', 'caller', 'level', 'operationName', 'resourceGroup', 'resourceProvider', 'status', 'subStatus', 'resourceType', or anything beginning with 'properties.'. |
|  equals | string | Yes | The field value will be compared to this value (case-insensitive) to determine if the condition is met. |


<a id="ActivityLogAlertActionGroup" />
### ActivityLogAlertActionGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  actionGroupId | string | Yes | The resourceId of the action group. This cannot be null or empty. |
|  webhookProperties | object | No | the dictionary of custom properties to include with the post operation. These data are appended to the webhook payload. |

