# Microsoft.Relay/namespaces/WcfRelays/authorizationRules template reference
API Version: 2016-07-01
## Template format

To create a Microsoft.Relay/namespaces/WcfRelays/authorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/WcfRelays/authorizationRules",
  "apiVersion": "2016-07-01",
  "properties": {
    "rights": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Relay/namespaces/WcfRelays/authorizationRules" />
### Microsoft.Relay/namespaces/WcfRelays/authorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorizationRule name. |
|  type | enum | Yes | Microsoft.Relay/namespaces/WcfRelays/authorizationRules |
|  apiVersion | enum | Yes | 2016-07-01 |
|  properties | object | Yes | Authorization Rule properties - [AuthorizationRuleProperties object](#AuthorizationRuleProperties) |


<a id="AuthorizationRuleProperties" />
### AuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

