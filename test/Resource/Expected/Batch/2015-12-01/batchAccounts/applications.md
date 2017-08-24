# Microsoft.Batch/batchAccounts/applications template reference
API Version: 2015-12-01
## Template format

To create a Microsoft.Batch/batchAccounts/applications resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Batch/batchAccounts/applications",
  "apiVersion": "2015-12-01",
  "allowUpdates": boolean,
  "displayName": "string",
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Batch/batchAccounts/applications" />
### Microsoft.Batch/batchAccounts/applications object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Batch/batchAccounts/applications |
|  apiVersion | enum | Yes | 2015-12-01 |
|  allowUpdates | boolean | No | A value indicating whether packages within the application may be overwritten using the same version string. |
|  displayName | string | No | The display name for the application. |
|  resources | array | No | [versions](./applications/versions.md) |

