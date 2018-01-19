# Microsoft.RecoveryServices/vaults/backupPolicies template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.RecoveryServices/vaults/backupPolicies resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.RecoveryServices/vaults/backupPolicies",
  "apiVersion": "2016-06-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "eTag": "string",
  "properties": {
    "protectedItemsCount": "integer"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.RecoveryServices/vaults/backupPolicies" />
### Microsoft.RecoveryServices/vaults/backupPolicies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.RecoveryServices/vaults/backupPolicies |
|  apiVersion | enum | Yes | 2016-06-01 |
|  id | string | No | Resource ID represents the complete path to the resource. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  eTag | string | No | Optional ETag. |
|  properties | object | Yes | [ProtectionPolicy object](#ProtectionPolicy) |


<a id="ProtectionPolicy" />
### ProtectionPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  protectedItemsCount | integer | No | The number of items associated with this policy. |

