# Microsoft.Automation/automationAccounts/jobs template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/jobs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/jobs",
  "apiVersion": "2015-10-31",
  "properties": {
    "runbook": {
      "name": "string"
    },
    "parameters": {},
    "runOn": "string"
  },
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/jobs" />
### Microsoft.Automation/automationAccounts/jobs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | globally unique identifier |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/jobs |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the list of job properties. - [JobCreateProperties object](#JobCreateProperties) |
|  location | string | No | Gets or sets the location of the resource. |
|  tags | object | No | Gets or sets the tags attached to the resource. |


<a id="JobCreateProperties" />
### JobCreateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  runbook | object | Yes | Gets or sets the runbook. - [RunbookAssociationProperty object](#RunbookAssociationProperty) |
|  parameters | object | No | Gets or sets the parameters of the job. |
|  runOn | string | No | Gets or sets the runOn which specifies the group name where the job is to be executed. |


<a id="RunbookAssociationProperty" />
### RunbookAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the runbook. |

