# Microsoft.DevTestLab/labs/schedules template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/schedules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/schedules",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "status": "string",
    "taskType": "string",
    "weeklyRecurrence": {
      "weekdays": [
        "string"
      ],
      "time": "string"
    },
    "dailyRecurrence": {
      "time": "string"
    },
    "hourlyRecurrence": {
      "minute": "integer"
    },
    "timeZoneId": "string",
    "notificationSettings": {
      "status": "string",
      "timeInMinutes": "integer",
      "webhookUrl": "string"
    },
    "targetResourceId": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/schedules" />
### Microsoft.DevTestLab/labs/schedules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/schedules |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [ScheduleProperties object](#ScheduleProperties) |


<a id="ScheduleProperties" />
### ScheduleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | The status of the schedule (i.e. Enabled, Disabled). - Enabled or Disabled |
|  taskType | string | No | The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart). |
|  weeklyRecurrence | object | No | If the schedule will occur only some days of the week, specify the weekly recurrence. - [WeekDetails object](#WeekDetails) |
|  dailyRecurrence | object | No | If the schedule will occur once each day of the week, specify the daily recurrence. - [DayDetails object](#DayDetails) |
|  hourlyRecurrence | object | No | If the schedule will occur multiple times a day, specify the hourly recurrence. - [HourDetails object](#HourDetails) |
|  timeZoneId | string | No | The time zone ID (e.g. Pacific Standard time). |
|  notificationSettings | object | No | Notification settings. - [NotificationSettings object](#NotificationSettings) |
|  targetResourceId | string | No | The resource ID to which the schedule belongs |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="WeekDetails" />
### WeekDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  weekdays | array | No | The days of the week for which the schedule is set (e.g. Sunday, Monday, Tuesday, etc.). - string |
|  time | string | No | The time of the day the schedule will occur. |


<a id="DayDetails" />
### DayDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  time | string | No | The time of day the schedule will occur. |


<a id="HourDetails" />
### HourDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  minute | integer | No | Minutes of the hour the schedule will run. |


<a id="NotificationSettings" />
### NotificationSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | If notifications are enabled for this schedule (i.e. Enabled, Disabled). - Disabled or Enabled |
|  timeInMinutes | integer | No | Time in minutes before event at which notification will be sent. |
|  webhookUrl | string | No | The webhook URL to which the notification will be sent. |

