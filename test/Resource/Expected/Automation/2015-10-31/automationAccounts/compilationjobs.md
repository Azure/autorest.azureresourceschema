# Microsoft.Automation/automationAccounts/compilationjobs template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/compilationjobs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/compilationjobs",
  "apiVersion": "2015-10-31",
  "properties": {
    "configuration": {
      "name": "string"
    },
    "parameters": {},
    "newNodeConfigurationBuildVersionRequired": boolean
  },
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/compilationjobs" />
### Microsoft.Automation/automationAccounts/compilationjobs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | globally unique identifier |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/compilationjobs |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the list of compilation job properties. - [DscCompilationJobCreateProperties object](#DscCompilationJobCreateProperties) |
|  location | string | No | Gets or sets the location of the resource. |
|  tags | object | No | Gets or sets the tags attached to the resource. |


<a id="DscCompilationJobCreateProperties" />
### DscCompilationJobCreateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  configuration | object | Yes | Gets or sets the configuration. - [DscConfigurationAssociationProperty object](#DscConfigurationAssociationProperty) |
|  parameters | object | No | Gets or sets the parameters of the job. |
|  newNodeConfigurationBuildVersionRequired | boolean | No | If a new build version of NodeConfiguration is required. |


<a id="DscConfigurationAssociationProperty" />
### DscConfigurationAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the Dsc configuration. |

