# Microsoft.Relay/namespaces template reference
API Version: 2016-07-01
## Template format

To create a Microsoft.Relay/namespaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces",
  "apiVersion": "2016-07-01",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "Standard",
    "tier": "Standard"
  },
  "properties": {},
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Relay/namespaces" />
### Microsoft.Relay/namespaces object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The Namespace Name |
|  type | enum | Yes | Microsoft.Relay/namespaces |
|  apiVersion | enum | Yes | 2016-07-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  sku | object | No | Sku of the Namespace. - [Sku object](#Sku) |
|  properties | object | Yes | Description of Relay Namespace - [RelayNamespaceProperties object](#RelayNamespaceProperties) |
|  resources | array | No | [WcfRelays](./namespaces/WcfRelays.md) [HybridConnections](./namespaces/HybridConnections.md) [AuthorizationRules](./namespaces/AuthorizationRules.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of this Sku - Standard |
|  tier | enum | Yes | The tier of this particular SKU - Standard |

