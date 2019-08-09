# Microsoft.ServiceBus/namespaces/topics template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.ServiceBus/namespaces/topics resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/topics",
  "apiVersion": "2015-08-01",
  "location": "string",
  "properties": {
    "autoDeleteOnIdle": "string",
    "entityAvailabilityStatus": "string",
    "defaultMessageTimeToLive": "string",
    "duplicateDetectionHistoryTimeWindow": "string",
    "enableBatchedOperations": "boolean",
    "enableExpress": "boolean",
    "enablePartitioning": "boolean",
    "enableSubscriptionPartitioning": "boolean",
    "filteringMessagesBeforePublishing": "boolean",
    "isAnonymousAccessible": "boolean",
    "isExpress": "boolean",
    "maxSizeInMegabytes": "integer",
    "requiresDuplicateDetection": "boolean",
    "status": "string",
    "supportOrdering": "boolean"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces/topics" />
### Microsoft.ServiceBus/namespaces/topics object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The topic name. |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/topics |
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Location of the resource. |
|  properties | object | Yes | [TopicProperties object](#TopicProperties) |
|  resources | array | No | [subscriptions](./topics/subscriptions.md) [authorizationRules](./topics/authorizationRules.md) |


<a id="TopicProperties" />
### TopicProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  autoDeleteOnIdle | string | No | TimeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. |
|  entityAvailabilityStatus | enum | No | Entity availability status for the topic. - Available, Limited, Renaming, Restoring, Unknown |
|  defaultMessageTimeToLive | string | No | Default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. |
|  duplicateDetectionHistoryTimeWindow | string | No | TimeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. |
|  enableBatchedOperations | boolean | No | Value that indicates whether server-side batched operations are enabled. |
|  enableExpress | boolean | No | Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. |
|  enablePartitioning | boolean | No | Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. |
|  enableSubscriptionPartitioning | boolean | No | Value that indicates whether partitioning is enabled or disabled. NOTE: This property is unsupported, and may be deprecated. |
|  filteringMessagesBeforePublishing | boolean | No | Whether messages should be filtered before publishing. |
|  isAnonymousAccessible | boolean | No | Value that indicates whether the message is accessible anonymously. |
|  isExpress | boolean | No |  |
|  maxSizeInMegabytes | integer | No | Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. |
|  requiresDuplicateDetection | boolean | No | Value indicating if this topic requires duplicate detection. |
|  status | enum | No | Enumerates the possible values for the status of a messaging entity. - Active, Creating, Deleting, Disabled, ReceiveDisabled, Renaming, Restoring, SendDisabled, Unknown |
|  supportOrdering | boolean | No | Value that indicates whether the topic supports ordering. |

