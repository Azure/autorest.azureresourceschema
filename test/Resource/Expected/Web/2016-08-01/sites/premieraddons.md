# Microsoft.Web/sites/premieraddons template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/premieraddons resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/premieraddons",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "sku": "string",
    "product": "string",
    "vendor": "string",
    "name": "string",
    "location": "string",
    "tags": {},
    "marketplacePublisher": "string",
    "marketplaceOffer": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/premieraddons" />
### Microsoft.Web/sites/premieraddons object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/premieraddons |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | PremierAddOn resource specific properties - [PremierAddOnProperties object](#PremierAddOnProperties) |


<a id="PremierAddOnProperties" />
### PremierAddOnProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sku | string | No | Premier add on SKU. |
|  product | string | No | Premier add on Product. |
|  vendor | string | No | Premier add on Vendor. |
|  name | string | No | Premier add on Name. |
|  location | string | No | Premier add on Location. |
|  tags | object | No | Premier add on Tags. |
|  marketplacePublisher | string | No | Premier add on Marketplace publisher. |
|  marketplaceOffer | string | No | Premier add on Marketplace offer. |

