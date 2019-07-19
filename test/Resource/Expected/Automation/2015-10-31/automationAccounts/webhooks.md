# Microsoft.Automation/automationAccounts/webhooks template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/webhooks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/webhooks",
  "apiVersion": "2015-10-31",
  "properties": {
    "isEnabled": "boolean",
    "uri": "string",
    "expiryTime": "string",
    "parameters": {},
    "runbook": {
      "name": "string"
    },
    "runOn": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/webhooks" />
### Microsoft.Automation/automationAccounts/webhooks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/webhooks |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the properties of the webhook. - [WebhookCreateOrUpdateProperties object](#WebhookCreateOrUpdateProperties) |


<a id="WebhookCreateOrUpdateProperties" />
### WebhookCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isEnabled | boolean | No | Gets or sets the value of the enabled flag of webhook. |
|  uri | string | No | Gets or sets the uri. |
|  expiryTime | string | No | Gets or sets the expiry time. |
|  parameters | object | No | Gets or sets the parameters of the job. |
|  runbook | object | No | Gets or sets the runbook. - [RunbookAssociationProperty object](#RunbookAssociationProperty) |
|  runOn | string | No | Gets or sets the name of the hybrid worker group the webhook job will run on. |


<a id="RunbookAssociationProperty" />
### RunbookAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the runbook. |

