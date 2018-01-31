# Microsoft.Network/routeFilters template reference
API Version: 2016-12-01
## Template format

To create a Microsoft.Network/routeFilters resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/routeFilters",
  "apiVersion": "2016-12-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "rules": [
      {
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
    ]
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/routeFilters" />
### Microsoft.Network/routeFilters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/routeFilters |
|  apiVersion | enum | Yes | 2016-12-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [RouteFilterPropertiesFormat object](#RouteFilterPropertiesFormat) |
|  resources | array | No | [routeFilterRules](./routeFilters/routeFilterRules.md) |


<a id="RouteFilterPropertiesFormat" />
### RouteFilterPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rules | array | No | Collection of RouteFilterRules contained within a route filter. - [RouteFilterRule object](#RouteFilterRule) |


<a id="RouteFilterRule" />
### RouteFilterRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [RouteFilterRulePropertiesFormat object](#RouteFilterRulePropertiesFormat) |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |


<a id="RouteFilterRulePropertiesFormat" />
### RouteFilterRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  access | enum | Yes | The access type of the rule. Valid values are: 'Allow', 'Deny'. - Allow or Deny |
|  routeFilterRuleType | enum | Yes | The rule type of the rule. Valid value is: 'Community' - Community |
|  communities | array | Yes | The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020'] - string |

