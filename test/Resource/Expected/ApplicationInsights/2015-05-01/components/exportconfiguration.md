# microsoft.insights/components/exportconfiguration template reference
API Version: 2015-05-01
## Template format

To create a microsoft.insights/components/exportconfiguration resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/components/exportconfiguration",
  "apiVersion": "2015-05-01",
  "RecordTypes": "string",
  "DestinationType": "string",
  "DestinationAddress": "string",
  "IsEnabled": "string",
  "NotificationQueueEnabled": "string",
  "NotificationQueueUri": "string",
  "DestinationStorageSubscriptionId": "string",
  "DestinationStorageLocationId": "string",
  "DestinationAccountId": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/components/exportconfiguration" />
### microsoft.insights/components/exportconfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The Continuous Export configuration ID. This is unique within a Application Insights component. |
|  type | enum | Yes | microsoft.insights/components/exportconfiguration |
|  apiVersion | enum | Yes | 2015-05-01 |
|  RecordTypes | string | No | The document types to be exported, as comma separated values. Allowed values include 'Requests', 'Event', 'Exceptions', 'Metrics', 'PageViews', 'PageViewPerformance', 'Rdd', 'PerformanceCounters', 'Availability', 'Messages'. |
|  DestinationType | string | No | The Continuous Export destination type. This has to be 'Blob'. |
|  DestinationAddress | string | No | The SAS URL for the destination storage container. It must grant write permission. |
|  IsEnabled | string | No | Set to 'true' to create a Continuous Export configuration as enabled, otherwise set it to 'false'. |
|  NotificationQueueEnabled | string | No | Deprecated |
|  NotificationQueueUri | string | No | Deprecated |
|  DestinationStorageSubscriptionId | string | No | The subscription ID of the destination storage container. |
|  DestinationStorageLocationId | string | No | The location ID of the destination storage container. |
|  DestinationAccountId | string | No | The name of destination storage account. |

