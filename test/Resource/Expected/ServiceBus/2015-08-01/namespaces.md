# Microsoft.ServiceBus/namespaces template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.ServiceBus/namespaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces",
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
    "createACSNamespace": boolean,
    "enabled": boolean
  },
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
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Namespace location. |
|  sku | object | No | [Sku object](#Sku) |
|  tags | object | No | Namespace tags. |
|  properties | object | Yes | [NamespaceProperties object](#NamespaceProperties) |
|  resources | array | No | [topics](./namespaces/topics.md) [queues](./namespaces/queues.md) [AuthorizationRules](./namespaces/AuthorizationRules.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Name of this SKU. - Basic, Standard, Premium |
|  tier | enum | Yes | The billing tier of this particular SKU. - Basic, Standard, Premium |
|  capacity | integer | No | The specified messaging units for the tier. |


<a id="NamespaceProperties" />
### NamespaceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | State of the namespace. - Unknown, Creating, Created, Activating, Enabling, Active, Disabling, Disabled, SoftDeleting, SoftDeleted, Removing, Removed, Failed |
|  createACSNamespace | boolean | No | Indicates whether to create an ACS namespace. |
|  enabled | boolean | No | Specifies whether this instance is enabled. |

