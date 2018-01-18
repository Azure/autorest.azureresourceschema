# Microsoft.Automation/automationAccounts/connections template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/connections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/connections",
  "apiVersion": "2015-10-31",
  "properties": {
    "description": "string",
    "connectionType": {
      "name": "string"
    },
    "fieldDefinitionValues": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/connections" />
### Microsoft.Automation/automationAccounts/connections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/connections |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the properties of the connection. - [ConnectionCreateOrUpdateProperties object](#ConnectionCreateOrUpdateProperties) |


<a id="ConnectionCreateOrUpdateProperties" />
### ConnectionCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | Gets or sets the description of the connection. |
|  connectionType | object | Yes | Gets or sets the connectionType of the connection. - [ConnectionTypeAssociationProperty object](#ConnectionTypeAssociationProperty) |
|  fieldDefinitionValues | object | No | Gets or sets the field definition properties of the connection. |


<a id="ConnectionTypeAssociationProperty" />
### ConnectionTypeAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the connection type. |

