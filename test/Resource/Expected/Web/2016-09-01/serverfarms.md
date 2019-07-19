# Microsoft.Web/serverfarms template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Web/serverfarms resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/serverfarms",
  "apiVersion": "2016-09-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "name": "string",
    "workerTierName": "string",
    "adminSiteName": "string",
    "hostingEnvironmentProfile": {
      "id": "string"
    },
    "perSiteScaling": "boolean",
    "isSpot": "boolean",
    "spotExpirationTime": "string",
    "reserved": "boolean",
    "targetWorkerCount": "integer",
    "targetWorkerSizeId": "integer"
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

<a id="Microsoft.Web/serverfarms" />
### Microsoft.Web/serverfarms object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/serverfarms |
|  apiVersion | enum | Yes | 2016-09-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | AppServicePlan resource specific properties - [AppServicePlanProperties object](#AppServicePlanProperties) |
|  sku | object | No | [SkuDescription object](#SkuDescription) |


<a id="AppServicePlanProperties" />
### AppServicePlanProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Name for the App Service plan. |
|  workerTierName | string | No | Target worker tier assigned to the App Service plan. |
|  adminSiteName | string | No | App Service plan administration site. |
|  hostingEnvironmentProfile | object | No | Specification for the App Service Environment to use for the App Service plan. - [HostingEnvironmentProfile object](#HostingEnvironmentProfile) |
|  perSiteScaling | boolean | No | If <code>true</code>, apps assigned to this App Service plan can be scaled independently.If <code>false</code>, apps assigned to this App Service plan will scale to all instances of the plan. |
|  isSpot | boolean | No | If <code>true</code>, this App Service Plan owns spot instances. |
|  spotExpirationTime | string | No | The time when the server farm expires. Valid only if it is a spot server farm. |
|  reserved | boolean | No | If Linux app service plan <code>true</code>, <code>false</code> otherwise. |
|  targetWorkerCount | integer | No | Scaling worker count. |
|  targetWorkerSizeId | integer | No | Scaling worker size ID. |


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


<a id="HostingEnvironmentProfile" />
### HostingEnvironmentProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID of the App Service Environment. |


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

