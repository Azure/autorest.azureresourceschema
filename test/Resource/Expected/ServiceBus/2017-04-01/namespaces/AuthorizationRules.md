# Microsoft.ServiceBus/namespaces/AuthorizationRules template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/AuthorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/AuthorizationRules",
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

<a id="Microsoft.ServiceBus/namespaces/AuthorizationRules" />
### Microsoft.ServiceBus/namespaces/AuthorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorizationrule name. |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/AuthorizationRules |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | AuthorizationRule properties. - [SBAuthorizationRuleProperties object](#SBAuthorizationRuleProperties) |


<a id="SBAuthorizationRuleProperties" />
### SBAuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

