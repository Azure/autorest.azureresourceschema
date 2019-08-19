# microsoft.insights/diagnosticSettings template reference
API Version: 2017-05-01-preview
## Template format

To create a microsoft.insights/diagnosticSettings resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/diagnosticSettings",
  "apiVersion": "2017-05-01-preview",
  "properties": {
    "storageAccountId": "string",
    "eventHubAuthorizationRuleId": "string",
    "eventHubName": "string",
    "metrics": [
      {
        "timeGrain": "string",
        "category": "string",
        "enabled": "boolean",
        "retentionPolicy": {
          "enabled": "boolean",
          "days": "integer"
        }
      }
    ],
    "logs": [
      {
        "category": "string",
        "enabled": "boolean",
        "retentionPolicy": {
          "enabled": "boolean",
          "days": "integer"
        }
      }
    ],
    "workspaceId": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/diagnosticSettings" />
### microsoft.insights/diagnosticSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the diagnostic setting. |
|  type | enum | Yes | microsoft.insights/diagnosticSettings |
|  apiVersion | enum | Yes | 2017-05-01-preview |
|  properties | object | Yes | [DiagnosticSettings object](#DiagnosticSettings) |


<a id="DiagnosticSettings" />
### DiagnosticSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountId | string | No | The resource ID of the storage account to which you would like to send Diagnostic Logs. |
|  eventHubAuthorizationRuleId | string | No | The resource Id for the event hub authorization rule. |
|  eventHubName | string | No | The name of the event hub. If none is specified, the default event hub will be selected. |
|  metrics | array | No | the list of metric settings. - [MetricSettings object](#MetricSettings) |
|  logs | array | No | the list of logs settings. - [LogSettings object](#LogSettings) |
|  workspaceId | string | No | The workspace ID (resource ID of a Log Analytics workspace) for a Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2 |


<a id="MetricSettings" />
### MetricSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  timeGrain | string | No | the timegrain of the metric in ISO8601 format. |
|  category | string | No | Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic metric categories for a resource, first perform a GET diagnostic settings operation. |
|  enabled | boolean | Yes | a value indicating whether this category is enabled. |
|  retentionPolicy | object | No | the retention policy for this category. - [RetentionPolicy object](#RetentionPolicy) |


<a id="LogSettings" />
### LogSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  category | string | No | Name of a Diagnostic Log category for a resource type this setting is applied to. To obtain the list of Diagnostic Log categories for a resource, first perform a GET diagnostic settings operation. |
|  enabled | boolean | Yes | a value indicating whether this log is enabled. |
|  retentionPolicy | object | No | the retention policy for this log. - [RetentionPolicy object](#RetentionPolicy) |


<a id="RetentionPolicy" />
### RetentionPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | Yes | a value indicating whether the retention policy is enabled. |
|  days | integer | Yes | the number of days for the retention in days. A value of 0 will retain the events indefinitely. |

