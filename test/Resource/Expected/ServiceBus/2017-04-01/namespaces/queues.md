# Microsoft.ServiceBus/namespaces/queues template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/queues resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/queues",
  "apiVersion": "2017-04-01",
  "properties": {
    "lockDuration": "string",
    "maxSizeInMegabytes": "integer",
    "requiresDuplicateDetection": boolean,
    "requiresSession": boolean,
    "defaultMessageTimeToLive": "string",
    "deadLetteringOnMessageExpiration": boolean,
    "duplicateDetectionHistoryTimeWindow": "string",
    "maxDeliveryCount": "integer",
    "status": "string",
    "autoDeleteOnIdle": "string",
    "enablePartitioning": boolean,
    "enableExpress": boolean,
    "forwardTo": "string",
    "forwardDeadLetteredMessagesTo": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces/queues" />
### Microsoft.ServiceBus/namespaces/queues object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The queue name. |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/queues |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Queue Properties - [SBQueueProperties object](#SBQueueProperties) |
|  resources | array | No | [authorizationRules](./queues/authorizationRules.md) |


<a id="SBQueueProperties" />
### SBQueueProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lockDuration | string | No | ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute. |
|  maxSizeInMegabytes | integer | No | The maximum size of the queue in megabytes, which is the size of memory allocated for the queue. Default is 1024. |
|  requiresDuplicateDetection | boolean | No | A value indicating if this queue requires duplicate detection. |
|  requiresSession | boolean | No | A value that indicates whether the queue supports the concept of sessions. |
|  defaultMessageTimeToLive | string | No | ISO 8601 default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. |
|  deadLetteringOnMessageExpiration | boolean | No | A value that indicates whether this queue has dead letter support when a message expires. |
|  duplicateDetectionHistoryTimeWindow | string | No | ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. |
|  maxDeliveryCount | integer | No | The maximum delivery count. A message is automatically deadlettered after this number of deliveries. default value is 10. |
|  status | enum | No | Enumerates the possible values for the status of a messaging entity. - Active, Disabled, Restoring, SendDisabled, ReceiveDisabled, Creating, Deleting, Renaming, Unknown |
|  autoDeleteOnIdle | string | No | ISO 8061 timeSpan idle interval after which the queue is automatically deleted. The minimum duration is 5 minutes. |
|  enablePartitioning | boolean | No | A value that indicates whether the queue is to be partitioned across multiple message brokers. |
|  enableExpress | boolean | No | A value that indicates whether Express Entities are enabled. An express queue holds a message in memory temporarily before writing it to persistent storage. |
|  forwardTo | string | No | Queue/Topic name to forward the messages |
|  forwardDeadLetteredMessagesTo | string | No | Queue/Topic name to forward the Dead Letter message |

