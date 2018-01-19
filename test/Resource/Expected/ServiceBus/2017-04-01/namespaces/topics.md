# Microsoft.ServiceBus/namespaces/topics template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/topics resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/topics",
  "apiVersion": "2017-04-01",
  "properties": {
    "defaultMessageTimeToLive": "string",
    "maxSizeInMegabytes": "integer",
    "requiresDuplicateDetection": boolean,
    "duplicateDetectionHistoryTimeWindow": "string",
    "enableBatchedOperations": boolean,
    "status": "string",
    "supportOrdering": boolean,
    "autoDeleteOnIdle": "string",
    "enablePartitioning": boolean,
    "enableExpress": boolean
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
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties of topic resource. - [SBTopicProperties object](#SBTopicProperties) |
|  resources | array | No | [subscriptions](./topics/subscriptions.md) [authorizationRules](./topics/authorizationRules.md) |


<a id="SBTopicProperties" />
### SBTopicProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  defaultMessageTimeToLive | string | No | ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. |
|  maxSizeInMegabytes | integer | No | Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024. |
|  requiresDuplicateDetection | boolean | No | Value indicating if this topic requires duplicate detection. |
|  duplicateDetectionHistoryTimeWindow | string | No | ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. |
|  enableBatchedOperations | boolean | No | Value that indicates whether server-side batched operations are enabled. |
|  status | enum | No | Enumerates the possible values for the status of a messaging entity. - Active, Disabled, Restoring, SendDisabled, ReceiveDisabled, Creating, Deleting, Renaming, Unknown |
|  supportOrdering | boolean | No | Value that indicates whether the topic supports ordering. |
|  autoDeleteOnIdle | string | No | ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. |
|  enablePartitioning | boolean | No | Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. |
|  enableExpress | boolean | No | Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. |

