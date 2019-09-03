# Microsoft.TimeSeriesInsights/environments/accessPolicies template reference
API Version: 2017-11-15
## Template format

To create a Microsoft.TimeSeriesInsights/environments/accessPolicies resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.TimeSeriesInsights/environments/accessPolicies",
  "apiVersion": "2017-11-15",
  "properties": {
    "principalObjectId": "string",
    "description": "string",
    "roles": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.TimeSeriesInsights/environments/accessPolicies" />
### Microsoft.TimeSeriesInsights/environments/accessPolicies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.TimeSeriesInsights/environments/accessPolicies |
|  apiVersion | enum | Yes | 2017-11-15 |
|  properties | object | Yes | [AccessPolicyResourceProperties object](#AccessPolicyResourceProperties) |


<a id="AccessPolicyResourceProperties" />
### AccessPolicyResourceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  principalObjectId | string | No | The objectId of the principal in Azure Active Directory. |
|  description | string | No | An description of the access policy. |
|  roles | array | No | The list of roles the principal is assigned on the environment. - Reader or Contributor |

