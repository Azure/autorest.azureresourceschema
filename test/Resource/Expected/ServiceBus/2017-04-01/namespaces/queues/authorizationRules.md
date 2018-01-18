# Microsoft.ServiceBus/namespaces/queues/authorizationRules template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/queues/authorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/queues/authorizationRules",
  "apiVersion": "2017-04-01",
  "properties": {
    "rights": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces/queues/authorizationRules" />
### Microsoft.ServiceBus/namespaces/queues/authorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorizationrule name. |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/queues/authorizationRules |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | AuthorizationRule properties. - [SBAuthorizationRule_properties object](#SBAuthorizationRule_properties) |


<a id="SBAuthorizationRule_properties" />
### SBAuthorizationRule_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

