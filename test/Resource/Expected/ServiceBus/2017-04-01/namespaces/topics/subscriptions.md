# Microsoft.ServiceBus/namespaces/topics/subscriptions template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/topics/subscriptions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/topics/subscriptions",
  "apiVersion": "2017-04-01",
  "properties": {
    "lockDuration": "string",
    "requiresSession": "boolean",
    "defaultMessageTimeToLive": "string",
    "deadLetteringOnMessageExpiration": "boolean",
    "duplicateDetectionHistoryTimeWindow": "string",
    "maxDeliveryCount": "integer",
    "status": "string",
    "enableBatchedOperations": "boolean",
    "autoDeleteOnIdle": "string",
    "forwardTo": "string",
    "forwardDeadLetteredMessagesTo": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces/topics/subscriptions" />
### Microsoft.ServiceBus/namespaces/topics/subscriptions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The subscription name. |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/topics/subscriptions |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties of subscriptions resource. - [SBSubscriptionProperties object](#SBSubscriptionProperties) |
|  resources | array | No | [rules](./subscriptions/rules.md) |


<a id="SBSubscriptionProperties" />
### SBSubscriptionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lockDuration | string | No | ISO 8061 lock duration timespan for the subscription. The default value is 1 minute. |
|  requiresSession | boolean | No | Value indicating if a subscription supports the concept of sessions. |
|  defaultMessageTimeToLive | string | No | ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. |
|  deadLetteringOnMessageExpiration | boolean | No | Value that indicates whether a subscription has dead letter support when a message expires. |
|  duplicateDetectionHistoryTimeWindow | string | No | ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. |
|  maxDeliveryCount | integer | No | Number of maximum deliveries. |
|  status | enum | No | Enumerates the possible values for the status of a messaging entity. - Active, Disabled, Restoring, SendDisabled, ReceiveDisabled, Creating, Deleting, Renaming, Unknown |
|  enableBatchedOperations | boolean | No | Value that indicates whether server-side batched operations are enabled. |
|  autoDeleteOnIdle | string | No | ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. |
|  forwardTo | string | No | Queue/Topic name to forward the messages |
|  forwardDeadLetteredMessagesTo | string | No | Queue/Topic name to forward the Dead Letter message |

