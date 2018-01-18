# Microsoft.Automation/automationAccounts/variables template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/variables resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/variables",
  "apiVersion": "2015-10-31",
  "properties": {
    "value": "string",
    "description": "string",
    "isEncrypted": boolean
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/variables" />
### Microsoft.Automation/automationAccounts/variables object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/variables |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the properties of the variable. - [VariableCreateOrUpdateProperties object](#VariableCreateOrUpdateProperties) |


<a id="VariableCreateOrUpdateProperties" />
### VariableCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  value | string | No | Gets or sets the value of the variable. |
|  description | string | No | Gets or sets the description of the variable. |
|  isEncrypted | boolean | No | Gets or sets the encrypted flag of the variable. |

