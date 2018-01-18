# Microsoft.Relay/namespaces/hybridConnections/authorizationRules template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.Relay/namespaces/hybridConnections/authorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/hybridConnections/authorizationRules",
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

<a id="Microsoft.Relay/namespaces/hybridConnections/authorizationRules" />
### Microsoft.Relay/namespaces/hybridConnections/authorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The authorization rule name. |
|  type | enum | Yes | Microsoft.Relay/namespaces/hybridConnections/authorizationRules |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Authorization rule properties. - [AuthorizationRule_properties object](#AuthorizationRule_properties) |


<a id="AuthorizationRule_properties" />
### AuthorizationRule_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | Yes | The rights associated with the rule. - Manage, Send, Listen |

