# Microsoft.CustomerInsights/hubs/predictions template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/predictions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/predictions",
  "apiVersion": "2017-04-26",
  "properties": {
    "description": {},
    "displayName": {},
    "involvedInteractionTypes": [
      "string"
    ],
    "involvedKpiTypes": [
      "string"
    ],
    "involvedRelationships": [
      "string"
    ],
    "negativeOutcomeExpression": "string",
    "positiveOutcomeExpression": "string",
    "primaryProfileType": "string",
    "predictionName": "string",
    "scopeExpression": "string",
    "autoAnalyze": boolean,
    "mappings": {
      "score": "string",
      "grade": "string",
      "reason": "string"
    },
    "scoreLabel": "string",
    "grades": [
      {
        "gradeName": "string",
        "minScoreThreshold": "integer",
        "maxScoreThreshold": "integer"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/predictions" />
### Microsoft.CustomerInsights/hubs/predictions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/predictions |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [Prediction object](#Prediction) |


<a id="Prediction" />
### Prediction object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | object | No | Description of the prediction. |
|  displayName | object | No | Display name of the prediction. |
|  involvedInteractionTypes | array | No | Interaction types involved in the prediction. - string |
|  involvedKpiTypes | array | No | KPI types involved in the prediction. - string |
|  involvedRelationships | array | No | Relationships involved in the prediction. - string |
|  negativeOutcomeExpression | string | Yes | Negative outcome expression. |
|  positiveOutcomeExpression | string | Yes | Positive outcome expression. |
|  primaryProfileType | string | Yes | Primary profile type. |
|  predictionName | string | No | Name of the prediction. |
|  scopeExpression | string | Yes | Scope expression. |
|  autoAnalyze | boolean | Yes | Whether do auto analyze. |
|  mappings | object | Yes | Definition of the link mapping of prediction. - [Prediction_mappings object](#Prediction_mappings) |
|  scoreLabel | string | Yes | Score label. |
|  grades | array | No | The prediction grades. - [Prediction_gradesItem object](#Prediction_gradesItem) |


<a id="Prediction_mappings" />
### Prediction_mappings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  score | string | Yes | The score of the link mapping. |
|  grade | string | Yes | The grade of the link mapping. |
|  reason | string | Yes | The reason of the link mapping. |


<a id="Prediction_gradesItem" />
### Prediction_gradesItem object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  gradeName | string | No | Name of the grade. |
|  minScoreThreshold | integer | No | Minimum score threshold. |
|  maxScoreThreshold | integer | No | Maximum score threshold. |

