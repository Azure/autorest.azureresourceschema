# Microsoft.Automation/automationAccounts/credentials template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/credentials resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/credentials",
  "apiVersion": "2015-10-31",
  "properties": {
    "userName": "string",
    "password": "string",
    "description": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/credentials" />
### Microsoft.Automation/automationAccounts/credentials object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/credentials |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the properties of the credential. - [CredentialCreateOrUpdateProperties object](#CredentialCreateOrUpdateProperties) |


<a id="CredentialCreateOrUpdateProperties" />
### CredentialCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userName | string | Yes | Gets or sets the user name of the credential. |
|  password | string | Yes | Gets or sets the password of the credential. |
|  description | string | No | Gets or sets the description of the credential. |

