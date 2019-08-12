# Microsoft.CustomerInsights/hubs/kpi template reference
API Version: 2017-01-01
## Template format

To create a Microsoft.CustomerInsights/hubs/kpi resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/kpi",
  "apiVersion": "2017-01-01",
  "properties": {
    "entityType": "string",
    "entityTypeName": "string",
    "displayName": {},
    "description": {},
    "calculationWindow": "string",
    "calculationWindowFieldName": "string",
    "function": "string",
    "expression": "string",
    "unit": "string",
    "filter": "string",
    "groupBy": [
      "string"
    ],
    "thresHolds": {
      "lowerLimit": "number",
      "upperLimit": "number",
      "increasingKpi": "boolean"
    },
    "aliases": [
      {
        "aliasName": "string",
        "expression": "string"
      }
    ],
    "extracts": [
      {
        "extractName": "string",
        "expression": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/kpi" />
### Microsoft.CustomerInsights/hubs/kpi object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/kpi |
|  apiVersion | enum | Yes | 2017-01-01 |
|  properties | object | Yes | [KpiDefinition object](#KpiDefinition) |


<a id="KpiDefinition" />
### KpiDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  entityType | enum | Yes | The mapping entity type. - None, Profile, Interaction, Relationship |
|  entityTypeName | string | Yes | The mapping entity name. |
|  displayName | object | No | Localized display name for the KPI. |
|  description | object | No | Localized description for the KPI. |
|  calculationWindow | enum | Yes | The calculation window. - Lifetime, Hour, Day, Week, Month |
|  calculationWindowFieldName | string | No | Name of calculation window field. |
|  function | enum | Yes | The computation function for the KPI. - Sum, Avg, Min, Max, Last, Count, None, CountDistinct |
|  expression | string | Yes | The computation expression for the KPI. |
|  unit | string | No | The unit of measurement for the KPI. |
|  filter | string | No | The filter expression for the KPI. |
|  groupBy | array | No | the group by properties for the KPI. - string |
|  thresHolds | object | No | The KPI thresholds. - [KpiThresholds object](#KpiThresholds) |
|  aliases | array | No | The aliases. - [KpiAlias object](#KpiAlias) |
|  extracts | array | No | The KPI extracts. - [KpiExtract object](#KpiExtract) |


<a id="KpiThresholds" />
### KpiThresholds object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lowerLimit | number | Yes | The lower threshold limit. |
|  upperLimit | number | Yes | The upper threshold limit. |
|  increasingKpi | boolean | Yes | Whether or not the KPI is an increasing KPI. |


<a id="KpiAlias" />
### KpiAlias object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  aliasName | string | Yes | KPI alias name. |
|  expression | string | Yes | The expression. |


<a id="KpiExtract" />
### KpiExtract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  extractName | string | Yes | KPI extract name. |
|  expression | string | Yes | The expression. |

