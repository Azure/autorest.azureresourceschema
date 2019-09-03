# Microsoft.TimeSeriesInsights/environments/eventSources template reference
API Version: 2017-11-15
## Template format

To create a Microsoft.TimeSeriesInsights/environments/eventSources resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.TimeSeriesInsights/environments/eventSources",
  "apiVersion": "2017-11-15",
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.TimeSeriesInsights/environments/eventSources" />
### Microsoft.TimeSeriesInsights/environments/eventSources object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.TimeSeriesInsights/environments/eventSources |
|  apiVersion | enum | Yes | 2017-11-15 |
|  location | string | Yes | The location of the resource. |
|  tags | object | No | Key-value pairs of additional properties for the resource. |

