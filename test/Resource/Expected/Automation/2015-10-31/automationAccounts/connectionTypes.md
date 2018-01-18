# Microsoft.Automation/automationAccounts/connectionTypes template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/connectionTypes resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/connectionTypes",
  "apiVersion": "2015-10-31",
  "properties": {
    "isGlobal": boolean,
    "fieldDefinitions": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/connectionTypes" />
### Microsoft.Automation/automationAccounts/connectionTypes object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/connectionTypes |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the value of the connection type. - [ConnectionTypeCreateOrUpdateProperties object](#ConnectionTypeCreateOrUpdateProperties) |


<a id="ConnectionTypeCreateOrUpdateProperties" />
### ConnectionTypeCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isGlobal | boolean | No | Gets or sets a Boolean value to indicate if the connection type is global. |
|  fieldDefinitions | object | Yes | Gets or sets the field definitions of the connection type. |

