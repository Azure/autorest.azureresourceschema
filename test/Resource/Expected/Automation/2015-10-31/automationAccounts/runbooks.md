# Microsoft.Automation/automationAccounts/runbooks template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/runbooks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/runbooks",
  "apiVersion": "2015-10-31",
  "properties": {
    "logVerbose": boolean,
    "logProgress": boolean,
    "runbookType": "string",
    "draft": {
      "inEdit": boolean,
      "draftContentLink": {
        "uri": "string",
        "contentHash": {
          "algorithm": "string",
          "value": "string"
        },
        "version": "string"
      },
      "creationTime": "string",
      "lastModifiedTime": "string",
      "parameters": {},
      "outputTypes": [
        "string"
      ]
    },
    "publishContentLink": {
      "uri": "string",
      "contentHash": {
        "algorithm": "string",
        "value": "string"
      },
      "version": "string"
    },
    "description": "string",
    "logActivityTrace": "integer"
  },
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/runbooks" />
### Microsoft.Automation/automationAccounts/runbooks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/runbooks |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets runbook create or update properties. - [RunbookCreateOrUpdateProperties object](#RunbookCreateOrUpdateProperties) |
|  location | string | No | Gets or sets the location of the resource. |
|  tags | object | No | Gets or sets the tags attached to the resource. |


<a id="RunbookCreateOrUpdateProperties" />
### RunbookCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  logVerbose | boolean | No | Gets or sets verbose log option. |
|  logProgress | boolean | No | Gets or sets progress log option. |
|  runbookType | enum | Yes | Gets or sets the type of the runbook. - Script, Graph, PowerShellWorkflow, PowerShell, GraphPowerShellWorkflow, GraphPowerShell |
|  draft | object | No | Gets or sets the draft runbook properties. - [RunbookDraft object](#RunbookDraft) |
|  publishContentLink | object | No | Gets or sets the published runbook content link. - [ContentLink object](#ContentLink) |
|  description | string | No | Gets or sets the description of the runbook. |
|  logActivityTrace | integer | No | Gets or sets the activity-level tracing options of the runbook. |


<a id="RunbookDraft" />
### RunbookDraft object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  inEdit | boolean | No | Gets or sets whether runbook is in edit mode. |
|  draftContentLink | object | No | Gets or sets the draft runbook content link. - [ContentLink object](#ContentLink) |
|  creationTime | string | No | Gets or sets the creation time of the runbook draft. |
|  lastModifiedTime | string | No | Gets or sets the last modified time of the runbook draft. |
|  parameters | object | No | Gets or sets the runbook draft parameters. |
|  outputTypes | array | No | Gets or sets the runbook output types. - string |


<a id="ContentLink" />
### ContentLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uri | string | No | Gets or sets the uri of the runbook content. |
|  contentHash | object | No | Gets or sets the hash. - [ContentHash object](#ContentHash) |
|  version | string | No | Gets or sets the version of the content. |


<a id="ContentHash" />
### ContentHash object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  algorithm | string | Yes | Gets or sets the content hash algorithm used to hash the content. |
|  value | string | Yes | Gets or sets expected hash value of the content. |

