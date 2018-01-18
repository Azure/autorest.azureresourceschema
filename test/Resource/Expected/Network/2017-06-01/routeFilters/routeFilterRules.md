# Microsoft.Network/routeFilters/routeFilterRules template reference
API Version: 2017-06-01
## Template format

To create a Microsoft.Network/routeFilters/routeFilterRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/routeFilters/routeFilterRules",
  "apiVersion": "2017-06-01",
  "id": "string",
  "properties": {
    "access": "string",
    "routeFilterRuleType": "Community",
    "communities": [
      "string"
    ]
  },
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/routeFilters/routeFilterRules" />
### Microsoft.Network/routeFilters/routeFilterRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/routeFilters/routeFilterRules |
|  apiVersion | enum | Yes | 2017-06-01 |
|  id | string | No | Resource ID. |
|  properties | object | Yes | [RouteFilterRulePropertiesFormat object](#RouteFilterRulePropertiesFormat) |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |


<a id="RouteFilterRulePropertiesFormat" />
### RouteFilterRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  access | enum | Yes | The access type of the rule. Valid values are: 'Allow', 'Deny'. - Allow or Deny |
|  routeFilterRuleType | enum | Yes | The rule type of the rule. Valid value is: 'Community' - Community |
|  communities | array | Yes | The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020'] - string |

