# Microsoft.ServiceBus/namespaces/topics/subscriptions/rules template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/topics/subscriptions/rules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/topics/subscriptions/rules",
  "apiVersion": "2017-04-01",
  "properties": {
    "action": {
      "sqlExpression": "string",
      "compatibilityLevel": "integer",
      "requiresPreprocessing": "boolean"
    },
    "filterType": "string",
    "sqlFilter": {
      "sqlExpression": "string",
      "requiresPreprocessing": "boolean"
    },
    "correlationFilter": {
      "correlationId": "string",
      "messageId": "string",
      "to": "string",
      "replyTo": "string",
      "label": "string",
      "sessionId": "string",
      "replyToSessionId": "string",
      "contentType": "string",
      "requiresPreprocessing": "boolean"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces/topics/subscriptions/rules" />
### Microsoft.ServiceBus/namespaces/topics/subscriptions/rules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The rule name. |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/topics/subscriptions/rules |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties of Rule resource - [Ruleproperties object](#Ruleproperties) |


<a id="Ruleproperties" />
### Ruleproperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  action | object | No | Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression. - [Action object](#Action) |
|  filterType | enum | No | Filter type that is evaluated against a BrokeredMessage. - SqlFilter or CorrelationFilter |
|  sqlFilter | object | No | Properties of sqlFilter - [SqlFilter object](#SqlFilter) |
|  correlationFilter | object | No | Properties of correlationFilter - [CorrelationFilter object](#CorrelationFilter) |


<a id="Action" />
### Action object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sqlExpression | string | No | SQL expression. e.g. MyProperty='ABC' |
|  compatibilityLevel | integer | No | This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20. |
|  requiresPreprocessing | boolean | No | Value that indicates whether the rule action requires preprocessing. |


<a id="SqlFilter" />
### SqlFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sqlExpression | string | No | The SQL expression. e.g. MyProperty='ABC' |
|  requiresPreprocessing | boolean | No | Value that indicates whether the rule action requires preprocessing. |


<a id="CorrelationFilter" />
### CorrelationFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  correlationId | string | No | Identifier of the correlation. |
|  messageId | string | No | Identifier of the message. |
|  to | string | No | Address to send to. |
|  replyTo | string | No | Address of the queue to reply to. |
|  label | string | No | Application specific label. |
|  sessionId | string | No | Session identifier. |
|  replyToSessionId | string | No | Session identifier to reply to. |
|  contentType | string | No | Content type of the message. |
|  requiresPreprocessing | boolean | No | Value that indicates whether the rule action requires preprocessing. |

