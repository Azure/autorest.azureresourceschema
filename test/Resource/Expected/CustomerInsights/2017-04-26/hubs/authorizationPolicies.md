# Microsoft.CustomerInsights/hubs/authorizationPolicies template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/authorizationPolicies resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/authorizationPolicies",
  "apiVersion": "2017-04-26",
  "properties": {
    "permissions": [
      "string"
    ],
    "primaryKey": "string",
    "secondaryKey": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/authorizationPolicies" />
### Microsoft.CustomerInsights/hubs/authorizationPolicies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/authorizationPolicies |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [AuthorizationPolicy object](#AuthorizationPolicy) |


<a id="AuthorizationPolicy" />
### AuthorizationPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  permissions | array | Yes | The permissions associated with the policy. - Read, Write, Manage |
|  primaryKey | string | No | Primary key assiciated with the policy. |
|  secondaryKey | string | No | Secondary key assiciated with the policy. |

