# Microsoft.Relay/namespaces/wcfRelays/authorizationRules template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.Relay/namespaces/wcfRelays/authorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/wcfRelays/authorizationRules",
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

<a id="Microsoft.Relay/namespaces/wcfRelays/authorizationRules" />
### Microsoft.Relay/namespaces/wcfRelays/authorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorization rule name. |
|  type | enum | Yes | Microsoft.Relay/namespaces/wcfRelays/authorizationRules |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Authorization rule properties. - [AuthorizationRuleProperties object](#AuthorizationRuleProperties) |


<a id="AuthorizationRuleProperties" />
### AuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

