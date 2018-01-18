# Microsoft.EventHub/namespaces/AuthorizationRules template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.EventHub/namespaces/AuthorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces/AuthorizationRules",
  "apiVersion": "2015-08-01",
  "location": "string",
  "properties": {
    "rights": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.EventHub/namespaces/AuthorizationRules" />
### Microsoft.EventHub/namespaces/AuthorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorization rule name. |
|  type | enum | Yes | Microsoft.EventHub/namespaces/AuthorizationRules |
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | No | Data center location. |
|  properties | object | Yes | [SharedAccessAuthorizationRuleProperties object](#SharedAccessAuthorizationRuleProperties) |


<a id="SharedAccessAuthorizationRuleProperties" />
### SharedAccessAuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

