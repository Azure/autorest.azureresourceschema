# Microsoft.Web/hostingEnvironments/workerPools template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Web/hostingEnvironments/workerPools resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/hostingEnvironments/workerPools",
  "apiVersion": "2016-09-01",
  "kind": "string",
  "properties": {
    "workerSizeId": "integer",
    "computeMode": "string",
    "workerSize": "string",
    "workerCount": "integer"
  },
  "sku": {
    "name": "string",
    "tier": "string",
    "size": "string",
    "family": "string",
    "capacity": "integer",
    "skuCapacity": {
      "minimum": "integer",
      "maximum": "integer",
      "default": "integer",
      "scaleType": "string"
    },
    "locations": [
      "string"
    ],
    "capabilities": [
      {
        "name": "string",
        "value": "string",
        "reason": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/hostingEnvironments/workerPools" />
### Microsoft.Web/hostingEnvironments/workerPools object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/hostingEnvironments/workerPools |
|  apiVersion | enum | Yes | 2016-09-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | Core resource properties - [WorkerPool object](#WorkerPool) |
|  sku | object | No | [SkuDescription object](#SkuDescription) |


<a id="WorkerPool" />
### WorkerPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  workerSizeId | integer | No | Worker size ID for referencing this worker pool. |
|  computeMode | enum | No | Shared or dedicated app hosting. - Shared, Dedicated, Dynamic |
|  workerSize | string | No | VM size of the worker pool instances. |
|  workerCount | integer | No | Number of instances in the worker pool. |


<a id="SkuDescription" />
### SkuDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name of the resource SKU. |
|  tier | string | No | Service tier of the resource SKU. |
|  size | string | No | Size specifier of the resource SKU. |
|  family | string | No | Family code of the resource SKU. |
|  capacity | integer | No | Current number of instances assigned to the resource. |
|  skuCapacity | object | No | Min, max, and default scale values of the SKU. - [SkuCapacity object](#SkuCapacity) |
|  locations | array | No | Locations of the SKU. - string |
|  capabilities | array | No | Capabilities of the SKU, e.g., is traffic manager enabled? - [Capability object](#Capability) |


<a id="SkuCapacity" />
### SkuCapacity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  minimum | integer | No | Minimum number of workers for this App Service plan SKU. |
|  maximum | integer | No | Maximum number of workers for this App Service plan SKU. |
|  default | integer | No | Default number of workers for this App Service plan SKU. |
|  scaleType | string | No | Available scale configurations for an App Service plan. |


<a id="Capability" />
### Capability object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name of the SKU capability. |
|  value | string | No | Value of the SKU capability. |
|  reason | string | No | Reason of the SKU capability. |

