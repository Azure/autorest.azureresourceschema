# Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules template reference
API Version: 2014-09-01
## Template format

To create a Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules",
  "apiVersion": "2014-09-01",
  "location": "string",
  "properties": {
    "primaryKey": "string",
    "secondaryKey": "string",
    "keyName": "string",
    "claimType": "string",
    "claimValue": "string",
    "rights": [
      "string"
    ],
    "createdTime": "string",
    "modifiedTime": "string",
    "revision": "integer"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules" />
### Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules |
|  apiVersion | enum | Yes | 2014-09-01 |
|  location | string | No | Gets or sets Namespace data center location. |
|  properties | object | Yes | Gets or sets properties of the Namespace AuthorizationRules. - [SharedAccessAuthorizationRuleProperties object](#SharedAccessAuthorizationRuleProperties) |


<a id="SharedAccessAuthorizationRuleProperties" />
### SharedAccessAuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  primaryKey | string | No | The primary key that was used. |
|  secondaryKey | string | No | The secondary key that was used. |
|  keyName | string | No | The name of the key that was used. |
|  claimType | string | No | The type of the claim. |
|  claimValue | string | No | The value of the claim. |
|  rights | array | No | The rights associated with the rule. - Manage, Send, Listen |
|  createdTime | string | No | The time at which the authorization rule was created. |
|  modifiedTime | string | No | The most recent time the rule was updated. |
|  revision | integer | No | The revision number for the rule. |

