# Microsoft.ServiceBus/namespaces template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces",
  "apiVersion": "2017-04-01",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string",
    "tier": "string",
    "capacity": "integer"
  },
  "properties": {},
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces" />
### Microsoft.ServiceBus/namespaces object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces |
|  apiVersion | enum | Yes | 2017-04-01 |
|  location | string | Yes | The Geo-location where the resource lives |
|  tags | object | No | Resource tags |
|  sku | object | No | Porperties of Sku - [SBSku object](#SBSku) |
|  properties | object | Yes | Properties of the namespace. - [SBNamespaceProperties object](#SBNamespaceProperties) |
|  resources | array | No | [topics](./namespaces/topics.md) [queues](./namespaces/queues.md) [disasterRecoveryConfigs](./namespaces/disasterRecoveryConfigs.md) [AuthorizationRules](./namespaces/AuthorizationRules.md) |


<a id="SBSku" />
### SBSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of this SKU. - Basic, Standard, Premium |
|  tier | enum | No | The billing tier of this particular SKU. - Basic, Standard, Premium |
|  capacity | integer | No | The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4. |

