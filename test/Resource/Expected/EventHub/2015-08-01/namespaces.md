# Microsoft.EventHub/namespaces template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.EventHub/namespaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces",
  "apiVersion": "2015-08-01",
  "location": "string",
  "sku": {
    "name": "string",
    "tier": "string",
    "capacity": "integer"
  },
  "tags": {},
  "properties": {
    "status": "string",
    "provisioningState": "string",
    "createdAt": "string",
    "updatedAt": "string",
    "serviceBusEndpoint": "string",
    "enabled": "boolean"
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
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Namespace location. |
|  sku | object | No | [Sku object](#Sku) |
|  tags | object | No | Namespace tags. |
|  properties | object | Yes | [NamespaceProperties object](#NamespaceProperties) |
|  resources | array | No | [eventhubs](./namespaces/eventhubs.md) [AuthorizationRules](./namespaces/AuthorizationRules.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Name of this SKU. - Basic or Standard |
|  tier | enum | Yes | The billing tier of this particular SKU. - Basic, Standard, Premium |
|  capacity | integer | No | The Event Hubs throughput units. |


<a id="NamespaceProperties" />
### NamespaceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | State of the Namespace. - Unknown, Creating, Created, Activating, Enabling, Active, Disabling, Disabled, SoftDeleting, SoftDeleted, Removing, Removed, Failed |
|  provisioningState | string | No | Provisioning state of the Namespace. |
|  createdAt | string | No | The time the Namespace was created. |
|  updatedAt | string | No | The time the Namespace was updated. |
|  serviceBusEndpoint | string | No | Endpoint you can use to perform Service Bus operations. |
|  enabled | boolean | No | Specifies whether this instance is enabled. |

