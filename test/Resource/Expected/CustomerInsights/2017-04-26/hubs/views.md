# Microsoft.CustomerInsights/hubs/views template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/views resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/views",
  "apiVersion": "2017-04-26",
  "properties": {
    "userId": "string",
    "displayName": {},
    "definition": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/views" />
### Microsoft.CustomerInsights/hubs/views object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/views |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [View object](#View) |


<a id="View" />
### View object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userId | string | No | the user ID. |
|  displayName | object | No | Localized display name for the view. |
|  definition | string | Yes | View definition. |

