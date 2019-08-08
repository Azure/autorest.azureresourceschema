# Microsoft.TimeSeriesInsights/environments template reference
API Version: 2017-11-15
## Template format

To create a Microsoft.TimeSeriesInsights/environments resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.TimeSeriesInsights/environments",
  "apiVersion": "2017-11-15",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string",
    "capacity": "integer"
  },
  "properties": {
    "dataRetentionTime": "string",
    "storageLimitExceededBehavior": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.TimeSeriesInsights/environments" />
### Microsoft.TimeSeriesInsights/environments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.TimeSeriesInsights/environments |
|  apiVersion | enum | Yes | 2017-11-15 |
|  location | string | Yes | The location of the resource. |
|  tags | object | No | Key-value pairs of additional properties for the resource. |
|  sku | object | Yes | [Sku object](#Sku) |
|  properties | object | Yes | [EnvironmentCreationProperties object](#EnvironmentCreationProperties) |
|  resources | array | No | [accessPolicies](./environments/accessPolicies.md) [referenceDataSets](./environments/referenceDataSets.md) [eventSources](./environments/eventSources.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | The name of this SKU. - S1 or S2 |
|  capacity | integer | Yes | The capacity of the sku. This value can be changed to support scale out of environments after they have been created. |


<a id="EnvironmentCreationProperties" />
### EnvironmentCreationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  dataRetentionTime | string | Yes | ISO8601 timespan specifying the minimum number of days the environment's events will be available for query. |
|  storageLimitExceededBehavior | enum | No | The behavior the Time Series Insights service should take when the environment's capacity has been exceeded. If "PauseIngress" is specified, new events will not be read from the event source. If "PurgeOldData" is specified, new events will continue to be read and old events will be deleted from the environment. The default behavior is PurgeOldData. - PurgeOldData or PauseIngress |

