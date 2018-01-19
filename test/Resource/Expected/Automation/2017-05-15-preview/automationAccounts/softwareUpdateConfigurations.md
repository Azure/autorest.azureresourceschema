# Microsoft.Automation/automationAccounts/softwareUpdateConfigurations template reference
API Version: 2017-05-15-preview
## Template format

To create a Microsoft.Automation/automationAccounts/softwareUpdateConfigurations resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/softwareUpdateConfigurations",
  "apiVersion": "2017-05-15-preview",
  "properties": {
    "updateConfiguration": {
      "operatingSystem": "string",
      "windows": {
        "includedUpdateClassifications": "string",
        "excludedKbNumbers": [
          "string"
        ]
      },
      "linux": {
        "includedPackageClassifications": "string",
        "excludedPackageNameMasks": [
          "string"
        ]
      },
      "duration": "string",
      "azureVirtualMachines": [
        "string"
      ],
      "nonAzureComputerNames": [
        "string"
      ]
    },
    "scheduleInfo": {
      "startTime": "string",
      "expiryTime": "string",
      "expiryTimeOffsetMinutes": "number",
      "isEnabled": boolean,
      "nextRun": "string",
      "nextRunOffsetMinutes": "number",
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
      },
      "creationTime": "string",
      "lastModifiedTime": "string",
      "description": "string"
    },
    "error": {
      "code": "string",
      "message": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/softwareUpdateConfigurations" />
### Microsoft.Automation/automationAccounts/softwareUpdateConfigurations object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/softwareUpdateConfigurations |
|  apiVersion | enum | Yes | 2017-05-15-preview |
|  properties | object | Yes | Software update configuration properties. - [SoftwareUpdateConfigurationProperties object](#SoftwareUpdateConfigurationProperties) |


<a id="SoftwareUpdateConfigurationProperties" />
### SoftwareUpdateConfigurationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  updateConfiguration | object | Yes | update specific properties for the Software update configuration - [UpdateConfiguration object](#UpdateConfiguration) |
|  scheduleInfo | object | Yes | Schedule information for the Software update configuration - [ScheduleProperties object](#ScheduleProperties) |
|  error | object | No | detailes of provisioning error - [ErrorResponse object](#ErrorResponse) |


<a id="UpdateConfiguration" />
### UpdateConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  operatingSystem | enum | Yes | operating system of target machines. - Windows or Linux |
|  windows | object | No | Windows specific update configuration. - [WindowsProperties object](#WindowsProperties) |
|  linux | object | No | Linux specific update configuration. - [LinuxProperties object](#LinuxProperties) |
|  duration | string | No | Maximum time allowed for the software update configuration run. Duration needs to be specified using the format PT[n]H[n]M[n]S as per ISO8601 |
|  azureVirtualMachines | array | No | List of azure resource Ids for azure virtual machines targeted by the software update configuration. - string |
|  nonAzureComputerNames | array | No | List of names of non-azure machines targeted by the software update configuration. - string |


<a id="ScheduleProperties" />
### ScheduleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  startTime | string | No | Gets or sets the start time of the schedule. |
|  expiryTime | string | No | Gets or sets the end time of the schedule. |
|  expiryTimeOffsetMinutes | number | No | Gets or sets the expiry time's offset in minutes. |
|  isEnabled | boolean | No | Gets or sets a value indicating whether this schedule is enabled. |
|  nextRun | string | No | Gets or sets the next run time of the schedule. |
|  nextRunOffsetMinutes | number | No | Gets or sets the next run time's offset in minutes. |
|  interval | object | No | Gets or sets the interval of the schedule. |
|  frequency | enum | No | Gets or sets the frequency of the schedule. - OneTime, Day, Hour, Week, Month |
|  timeZone | string | No | Gets or sets the time zone of the schedule. |
|  advancedSchedule | object | No | Gets or sets the advanced schedule. - [AdvancedSchedule object](#AdvancedSchedule) |
|  creationTime | string | No | Gets or sets the creation time. |
|  lastModifiedTime | string | No | Gets or sets the last modified time. |
|  description | string | No | Gets or sets the description. |


<a id="ErrorResponse" />
### ErrorResponse object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  code | string | No | Error code |
|  message | string | No | Error message indicating why the operation failed. |


<a id="WindowsProperties" />
### WindowsProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  includedUpdateClassifications | enum | No | Update classification included in the software update configuration. A comma separated string with required values. - Unclassified, Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools, Updates |
|  excludedKbNumbers | array | No | KB numbers excluded from the software update configuration. - string |


<a id="LinuxProperties" />
### LinuxProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  includedPackageClassifications | enum | No | Update classifications included in the software update configuration. - Unclassified, Critical, Security, Other |
|  excludedPackageNameMasks | array | No | packages excluded from the software update configuration. - string |


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

