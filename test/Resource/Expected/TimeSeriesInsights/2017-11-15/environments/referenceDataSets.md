# Microsoft.TimeSeriesInsights/environments/referenceDataSets template reference
API Version: 2017-11-15
## Template format

To create a Microsoft.TimeSeriesInsights/environments/referenceDataSets resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.TimeSeriesInsights/environments/referenceDataSets",
  "apiVersion": "2017-11-15",
  "location": "string",
  "tags": {},
  "properties": {
    "keyProperties": [
      {
        "name": "string",
        "type": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.TimeSeriesInsights/environments/referenceDataSets" />
### Microsoft.TimeSeriesInsights/environments/referenceDataSets object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.TimeSeriesInsights/environments/referenceDataSets |
|  apiVersion | enum | Yes | 2017-11-15 |
|  location | string | Yes | The location of the resource. |
|  tags | object | No | Key-value pairs of additional properties for the resource. |
|  properties | object | Yes | [ReferenceDataSetCreationProperties object](#ReferenceDataSetCreationProperties) |


<a id="ReferenceDataSetCreationProperties" />
### ReferenceDataSetCreationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyProperties | array | Yes | The list of key properties for the reference data set. - [ReferenceDataSetKeyProperty object](#ReferenceDataSetKeyProperty) |


<a id="ReferenceDataSetKeyProperty" />
### ReferenceDataSetKeyProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name of the key property. |
|  type | enum | No | The type of the key property. - String, Double, Bool, DateTime |

