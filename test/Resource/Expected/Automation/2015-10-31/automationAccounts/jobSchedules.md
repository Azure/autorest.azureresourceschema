# Microsoft.Automation/automationAccounts/jobSchedules template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/jobSchedules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/jobSchedules",
  "apiVersion": "2015-10-31",
  "properties": {
    "schedule": {
      "name": "string"
    },
    "runbook": {
      "name": "string"
    },
    "runOn": "string",
    "parameters": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/jobSchedules" />
### Microsoft.Automation/automationAccounts/jobSchedules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | globally unique identifier |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/jobSchedules |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the list of job schedule properties. - [JobScheduleCreateProperties object](#JobScheduleCreateProperties) |


<a id="JobScheduleCreateProperties" />
### JobScheduleCreateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  schedule | object | Yes | Gets or sets the schedule. - [ScheduleAssociationProperty object](#ScheduleAssociationProperty) |
|  runbook | object | Yes | Gets or sets the runbook. - [RunbookAssociationProperty object](#RunbookAssociationProperty) |
|  runOn | string | No | Gets or sets the hybrid worker group that the scheduled job should run on. |
|  parameters | object | No | Gets or sets a list of job properties. |


<a id="ScheduleAssociationProperty" />
### ScheduleAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the schedule. |


<a id="RunbookAssociationProperty" />
### RunbookAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the runbook. |

