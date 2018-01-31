# Microsoft.Automation/automationAccounts/schedules template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/schedules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/schedules",
  "apiVersion": "2015-10-31",
  "properties": {
    "description": "string",
    "startTime": "string",
    "expiryTime": "string",
    "interval": {},
    "frequency": "string",
    "timeZone": "string",
    "advancedSchedule": {
      "weekDays": [
        "string"
      ],
      "monthDays": [
        "integer"
      ],
      "monthlyOccurrences": [
        {
          "occurrence": "integer",
          "day": "string"
        }
      ]
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/schedules" />
### Microsoft.Automation/automationAccounts/schedules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/schedules |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the list of schedule properties. - [ScheduleCreateOrUpdateProperties object](#ScheduleCreateOrUpdateProperties) |


<a id="ScheduleCreateOrUpdateProperties" />
### ScheduleCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | Gets or sets the description of the schedule. |
|  startTime | string | Yes | Gets or sets the start time of the schedule. |
|  expiryTime | string | No | Gets or sets the end time of the schedule. |
|  interval | object | No | Gets or sets the interval of the schedule. |
|  frequency | enum | Yes | OneTime, Day, Hour, Week, Month |
|  timeZone | string | No | Gets or sets the time zone of the schedule. |
|  advancedSchedule | object | No | Gets or sets the AdvancedSchedule. - [AdvancedSchedule object](#AdvancedSchedule) |


<a id="AdvancedSchedule" />
### AdvancedSchedule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  weekDays | array | No | Days of the week that the job should execute on. - string |
|  monthDays | array | No | Days of the month that the job should execute on. Must be between 1 and 31. - integer |
|  monthlyOccurrences | array | No | Occurrences of days within a month. - [AdvancedScheduleMonthlyOccurrence object](#AdvancedScheduleMonthlyOccurrence) |


<a id="AdvancedScheduleMonthlyOccurrence" />
### AdvancedScheduleMonthlyOccurrence object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  occurrence | integer | No | Occurrence of the week within the month. Must be between 1 and 5 |
|  day | enum | No | Day of the occurrence. Must be one of monday, tuesday, wednesday,thursday, friday, saturday, sunday. - Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday |

