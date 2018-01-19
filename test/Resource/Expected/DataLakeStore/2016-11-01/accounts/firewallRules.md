# Microsoft.DataLakeStore/accounts/firewallRules template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeStore/accounts/firewallRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeStore/accounts/firewallRules",
  "apiVersion": "2016-11-01",
  "properties": {
    "startIpAddress": "string",
    "endIpAddress": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeStore/accounts/firewallRules" />
### Microsoft.DataLakeStore/accounts/firewallRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeStore/accounts/firewallRules |
|  apiVersion | enum | Yes | 2016-11-01 |
|  properties | object | Yes | the properties of the firewall rule. - [FirewallRuleProperties object](#FirewallRuleProperties) |


<a id="FirewallRuleProperties" />
### FirewallRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  startIpAddress | string | Yes | the start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. |
|  endIpAddress | string | Yes | the end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. |

