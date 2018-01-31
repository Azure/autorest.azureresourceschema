# Microsoft.Automation/automationAccounts template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts",
  "apiVersion": "2015-10-31",
  "properties": {
    "sku": {
      "name": "string",
      "family": "string",
      "capacity": "integer"
    }
  },
  "location": "string",
  "tags": {},
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts" />
### Microsoft.Automation/automationAccounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets account create or update properties. - [AutomationAccountCreateOrUpdateProperties object](#AutomationAccountCreateOrUpdateProperties) |
|  location | string | No | Gets or sets the location of the resource. |
|  tags | object | No | Gets or sets the tags attached to the resource. |
|  resources | array | No | [webhooks](./automationAccounts/webhooks.md) [variables](./automationAccounts/variables.md) [schedules](./automationAccounts/schedules.md) [runbooks](./automationAccounts/runbooks.md) [modules](./automationAccounts/modules.md) [jobSchedules](./automationAccounts/jobSchedules.md) [jobs](./automationAccounts/jobs.md) [nodeConfigurations](./automationAccounts/nodeConfigurations.md) [configurations](./automationAccounts/configurations.md) [compilationjobs](./automationAccounts/compilationjobs.md) [credentials](./automationAccounts/credentials.md) [connectionTypes](./automationAccounts/connectionTypes.md) [connections](./automationAccounts/connections.md) [certificates](./automationAccounts/certificates.md) |


<a id="AutomationAccountCreateOrUpdateProperties" />
### AutomationAccountCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sku | object | No | Gets or sets account SKU. - [Sku object](#Sku) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Gets or sets the SKU name of the account. - Free or Basic |
|  family | string | No | Gets or sets the SKU family. |
|  capacity | integer | No | Gets or sets the SKU capacity. |

