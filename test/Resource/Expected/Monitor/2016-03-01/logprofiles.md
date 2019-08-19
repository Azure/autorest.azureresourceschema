# microsoft.insights/logprofiles template reference
API Version: 2016-03-01
## Template format

To create a microsoft.insights/logprofiles resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/logprofiles",
  "apiVersion": "2016-03-01",
  "location": "string",
  "tags": {},
  "properties": {
    "storageAccountId": "string",
    "serviceBusRuleId": "string",
    "locations": [
      "string"
    ],
    "categories": [
      "string"
    ],
    "retentionPolicy": {
      "enabled": "boolean",
      "days": "integer"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/logprofiles" />
### microsoft.insights/logprofiles object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the log profile. |
|  type | enum | Yes | microsoft.insights/logprofiles |
|  apiVersion | enum | Yes | 2016-03-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | The log profile properties of the resource. - [LogProfileProperties object](#LogProfileProperties) |


<a id="LogProfileProperties" />
### LogProfileProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountId | string | No | the resource id of the storage account to which you would like to send the Activity Log. |
|  serviceBusRuleId | string | No | The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: '{service bus resource ID}/authorizationrules/{key name}'. |
|  locations | array | Yes | List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location. - string |
|  categories | array | Yes | the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.' - string |
|  retentionPolicy | object | Yes | the retention policy for the events in the log. - [RetentionPolicy object](#RetentionPolicy) |


<a id="RetentionPolicy" />
### RetentionPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | Yes | a value indicating whether the retention policy is enabled. |
|  days | integer | Yes | the number of days for the retention in days. A value of 0 will retain the events indefinitely. |

