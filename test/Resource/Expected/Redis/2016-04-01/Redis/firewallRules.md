# Microsoft.Cache/Redis/firewallRules template reference
API Version: 2016-04-01
## Template format

To create a Microsoft.Cache/Redis/firewallRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Cache/Redis/firewallRules",
  "apiVersion": "2016-04-01",
  "properties": {
    "startIP": "string",
    "endIP": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Cache/Redis/firewallRules" />
### Microsoft.Cache/Redis/firewallRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Cache/Redis/firewallRules |
|  apiVersion | enum | Yes | 2016-04-01 |
|  properties | object | Yes | redis cache firewall rule properties - [RedisFirewallRuleProperties object](#RedisFirewallRuleProperties) |


<a id="RedisFirewallRuleProperties" />
### RedisFirewallRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  startIP | string | Yes | lowest IP address included in the range |
|  endIP | string | Yes | highest IP address included in the range |

