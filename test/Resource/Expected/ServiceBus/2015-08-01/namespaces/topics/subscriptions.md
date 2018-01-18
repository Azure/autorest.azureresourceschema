# Microsoft.ServiceBus/namespaces/topics/subscriptions template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.ServiceBus/namespaces/topics/subscriptions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/topics/subscriptions",
  "apiVersion": "2015-08-01",
  "location": "string",
  "properties": {
    "autoDeleteOnIdle": "string",
    "defaultMessageTimeToLive": "string",
    "deadLetteringOnFilterEvaluationExceptions": boolean,
    "deadLetteringOnMessageExpiration": boolean,
    "enableBatchedOperations": boolean,
    "entityAvailabilityStatus": "string",
    "isReadOnly": boolean,
    "lockDuration": "string",
    "maxDeliveryCount": "integer",
    "requiresSession": boolean,
    "status": "string"
  }
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
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Subscription data center location. |
|  properties | object | Yes | [SubscriptionProperties object](#SubscriptionProperties) |


<a id="SubscriptionProperties" />
### SubscriptionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  autoDeleteOnIdle | string | No | TimeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. |
|  defaultMessageTimeToLive | string | No | Default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. |
|  deadLetteringOnFilterEvaluationExceptions | boolean | No | Value that indicates whether a subscription has dead letter support on filter evaluation exceptions. |
|  deadLetteringOnMessageExpiration | boolean | No | Value that indicates whether a subscription has dead letter support when a message expires. |
|  enableBatchedOperations | boolean | No | Value that indicates whether server-side batched operations are enabled. |
|  entityAvailabilityStatus | enum | No | Entity availability status for the topic. - Available, Limited, Renaming, Restoring, Unknown |
|  isReadOnly | boolean | No | Value that indicates whether the entity description is read-only. |
|  lockDuration | string | No | The lock duration time span for the subscription. |
|  maxDeliveryCount | integer | No | Number of maximum deliveries. |
|  requiresSession | boolean | No | Value indicating if a subscription supports the concept of sessions. |
|  status | enum | No | Enumerates the possible values for the status of a messaging entity. - Active, Creating, Deleting, Disabled, ReceiveDisabled, Renaming, Restoring, SendDisabled, Unknown |

