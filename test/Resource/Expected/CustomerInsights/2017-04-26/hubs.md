# Microsoft.CustomerInsights/hubs template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs",
  "apiVersion": "2017-04-26",
  "location": "string",
  "tags": {},
  "properties": {
    "tenantFeatures": "integer",
    "hubBillingInfo": {
      "skuName": "string",
      "minUnits": "integer",
      "maxUnits": "integer"
    }
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs" />
### Microsoft.CustomerInsights/hubs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs |
|  apiVersion | enum | Yes | 2017-04-26 |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [HubPropertiesFormat object](#HubPropertiesFormat) |
|  resources | array | No | [predictions](./hubs/predictions.md) [roleAssignments](./hubs/roleAssignments.md) [links](./hubs/links.md) [views](./hubs/views.md) [kpi](./hubs/kpi.md) [connectors](./hubs/connectors.md) [authorizationPolicies](./hubs/authorizationPolicies.md) [relationshipLinks](./hubs/relationshipLinks.md) [relationships](./hubs/relationships.md) [interactions](./hubs/interactions.md) [profiles](./hubs/profiles.md) |


<a id="HubPropertiesFormat" />
### HubPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  tenantFeatures | integer | No | The bit flags for enabled hub features. Bit 0 is set to 1 indicates graph is enabled, or disabled if set to 0. Bit 1 is set to 1 indicates the hub is disabled, or enabled if set to 0. |
|  hubBillingInfo | object | No | Billing settings of the hub. - [HubBillingInfoFormat object](#HubBillingInfoFormat) |


<a id="HubBillingInfoFormat" />
### HubBillingInfoFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  skuName | string | No | The sku name. |
|  minUnits | integer | No | The minimum number of units will be billed. One unit is 10,000 Profiles and 100,000 Interactions. |
|  maxUnits | integer | No | The maximum number of units can be used.  One unit is 10,000 Profiles and 100,000 Interactions. |

