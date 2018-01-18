# Microsoft.DataLakeAnalytics/accounts/computePolicies template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeAnalytics/accounts/computePolicies resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeAnalytics/accounts/computePolicies",
  "apiVersion": "2016-11-01",
  "properties": {
    "objectId": "string",
    "objectType": "string",
    "maxDegreeOfParallelismPerJob": "integer",
    "minPriorityPerJob": "integer"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeAnalytics/accounts/computePolicies" />
### Microsoft.DataLakeAnalytics/accounts/computePolicies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeAnalytics/accounts/computePolicies |
|  apiVersion | enum | Yes | 2016-11-01 |
|  properties | object | Yes | The policy properties to use when creating a new compute policy - [ComputePolicyPropertiesCreateParameters object](#ComputePolicyPropertiesCreateParameters) |


<a id="ComputePolicyPropertiesCreateParameters" />
### ComputePolicyPropertiesCreateParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  objectId | string | Yes | The AAD object identifier for the entity to create a policy for. - globally unique identifier |
|  objectType | enum | Yes | The type of AAD object the object identifier refers to. - User, Group, ServicePrincipal |
|  maxDegreeOfParallelismPerJob | integer | No | The maximum degree of parallelism per job this user can use to submit jobs. This property, the min priority per job property, or both must be passed. |
|  minPriorityPerJob | integer | No | The minimum priority per job this user can use to submit jobs. This property, the max degree of parallelism per job property, or both must be passed. |

