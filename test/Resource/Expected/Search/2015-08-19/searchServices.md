# Microsoft.Search/searchServices template reference
API Version: 2015-08-19
## Template format

To create a Microsoft.Search/searchServices resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Search/searchServices",
  "apiVersion": "2015-08-19",
  "location": "string",
  "tags": {},
  "properties": {
    "replicaCount": "integer",
    "partitionCount": "integer",
    "hostingMode": "string"
  },
  "sku": {
    "name": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Search/searchServices" />
### Microsoft.Search/searchServices object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Search/searchServices |
|  apiVersion | enum | Yes | 2015-08-19 |
|  location | string | No | The geographic location of the resource. This must be one of the supported and registered Azure Geo Regions (for example, West US, East US, Southeast Asia, and so forth). This property is required when creating a new resource. |
|  tags | object | No | Tags to help categorize the resource in the Azure portal. |
|  properties | object | Yes | Properties of the Search service. - [SearchServiceProperties object](#SearchServiceProperties) |
|  sku | object | No | The SKU of the Search Service, which determines price tier and capacity limits. This property is required when creating a new Search Service. - [Sku object](#Sku) |


<a id="SearchServiceProperties" />
### SearchServiceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  replicaCount | integer | No | The number of replicas in the Search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. |
|  partitionCount | integer | No | The number of partitions in the Search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. |
|  hostingMode | enum | No | Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. - default or highDensity |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | The SKU of the Search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': Offers maximum capacity per search unit with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). - free, basic, standard, standard2, standard3 |

