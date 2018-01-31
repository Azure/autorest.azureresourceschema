# Microsoft.EventHub/namespaces/eventhubs/authorizationRules template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.EventHub/namespaces/eventhubs/authorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces/eventhubs/authorizationRules",
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

<a id="Microsoft.EventHub/namespaces/eventhubs/authorizationRules" />
### Microsoft.EventHub/namespaces/eventhubs/authorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorization rule name. |
|  type | enum | Yes | Microsoft.EventHub/namespaces/eventhubs/authorizationRules |
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | No | Data center location. |
|  properties | object | Yes | [SharedAccessAuthorizationRuleProperties object](#SharedAccessAuthorizationRuleProperties) |


<a id="SharedAccessAuthorizationRuleProperties" />
### SharedAccessAuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

