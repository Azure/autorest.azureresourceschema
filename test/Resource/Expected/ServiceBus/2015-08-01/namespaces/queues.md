# Microsoft.ServiceBus/namespaces/queues template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.ServiceBus/namespaces/queues resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/queues",
  "apiVersion": "2015-08-01",
  "location": "string",
  "properties": {
    "lockDuration": "string",
    "autoDeleteOnIdle": "string",
    "entityAvailabilityStatus": "string",
    "defaultMessageTimeToLive": "string",
    "duplicateDetectionHistoryTimeWindow": "string",
    "enableBatchedOperations": boolean,
    "deadLetteringOnMessageExpiration": boolean,
    "enableExpress": boolean,
    "enablePartitioning": boolean,
    "isAnonymousAccessible": boolean,
    "maxDeliveryCount": "integer",
    "maxSizeInMegabytes": "integer",
    "requiresDuplicateDetection": boolean,
    "requiresSession": boolean,
    "status": "string",
    "supportOrdering": boolean
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
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | location of the resource. |
|  properties | object | Yes | [QueueProperties object](#QueueProperties) |
|  resources | array | No | [authorizationRules](./queues/authorizationRules.md) |


<a id="QueueProperties" />
### QueueProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lockDuration | string | No | The duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute. |
|  autoDeleteOnIdle | string | No | the TimeSpan idle interval after which the queue is automatically deleted. The minimum duration is 5 minutes. |
|  entityAvailabilityStatus | enum | No | Entity availability status for the queue. - Available, Limited, Renaming, Restoring, Unknown |
|  defaultMessageTimeToLive | string | No | The default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. |
|  duplicateDetectionHistoryTimeWindow | string | No | TimeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. |
|  enableBatchedOperations | boolean | No | A value that indicates whether server-side batched operations are enabled. |
|  deadLetteringOnMessageExpiration | boolean | No | A value that indicates whether this queue has dead letter support when a message expires. |
|  enableExpress | boolean | No | A value that indicates whether Express Entities are enabled. An express queue holds a message in memory temporarily before writing it to persistent storage. |
|  enablePartitioning | boolean | No | A value that indicates whether the queue is to be partitioned across multiple message brokers. |
|  isAnonymousAccessible | boolean | No | A value that indicates whether the message is accessible anonymously. |
|  maxDeliveryCount | integer | No | The maximum delivery count. A message is automatically deadlettered after this number of deliveries. |
|  maxSizeInMegabytes | integer | No | The maximum size of the queue in megabytes, which is the size of memory allocated for the queue. |
|  requiresDuplicateDetection | boolean | No | A value indicating if this queue requires duplicate detection. |
|  requiresSession | boolean | No | A value that indicates whether the queue supports the concept of sessions. |
|  status | enum | No | Enumerates the possible values for the status of a messaging entity. - Active, Creating, Deleting, Disabled, ReceiveDisabled, Renaming, Restoring, SendDisabled, Unknown |
|  supportOrdering | boolean | No | A value that indicates whether the queue supports ordering. |

