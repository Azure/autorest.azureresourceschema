# Microsoft.Relay/namespaces template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.Relay/namespaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces",
  "apiVersion": "2017-04-01",
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
|  name | string | Yes | The namespace name |
|  type | enum | Yes | Microsoft.Relay/namespaces |
|  apiVersion | enum | Yes | 2017-04-01 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  sku | object | No | SKU of the namespace. - [Sku object](#Sku) |
|  properties | object | Yes | Description of Relay namespace - [RelayNamespaceProperties object](#RelayNamespaceProperties) |
|  resources | array | No | [wcfRelays](./namespaces/wcfRelays.md) [hybridConnections](./namespaces/hybridConnections.md) [authorizationRules](./namespaces/authorizationRules.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of this SKU. - Standard |
|  tier | enum | No | The tier of this SKU. - Standard |

