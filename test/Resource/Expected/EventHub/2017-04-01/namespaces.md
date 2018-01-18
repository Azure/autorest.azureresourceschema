# Microsoft.EventHub/namespaces template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.EventHub/namespaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces",
  "apiVersion": "2017-04-01",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string",
    "tier": "string",
    "capacity": "integer"
  },
  "properties": {
    "isAutoInflateEnabled": boolean,
    "maximumThroughputUnits": "integer"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.EventHub/namespaces" />
### Microsoft.EventHub/namespaces object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The Namespace name |
|  type | enum | Yes | Microsoft.EventHub/namespaces |
|  apiVersion | enum | Yes | 2017-04-01 |
|  location | string | No | Resource location |
|  tags | object | No | Resource tags |
|  sku | object | No | Properties of sku resource - [Sku object](#Sku) |
|  properties | object | Yes | Namespace properties supplied for create namespace operation. - [EHNamespace_properties object](#EHNamespace_properties) |
|  resources | array | No | [eventhubs](./namespaces/eventhubs.md) [disasterRecoveryConfigs](./namespaces/disasterRecoveryConfigs.md) [AuthorizationRules](./namespaces/AuthorizationRules.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of this SKU. - Basic or Standard |
|  tier | enum | No | The billing tier of this particular SKU. - Basic or Standard |
|  capacity | integer | No | The Event Hubs throughput units, vaule should be 0 to 20 throughput units. |


<a id="EHNamespace_properties" />
### EHNamespace_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isAutoInflateEnabled | boolean | No | Value that indicates whether AutoInflate is enabled for eventhub namespace. |
|  maximumThroughputUnits | integer | No | Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true) |

