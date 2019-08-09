# Microsoft.Automation/automationAccounts/certificates template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/certificates",
  "apiVersion": "2015-10-31",
  "properties": {
    "base64Value": "string",
    "description": "string",
    "thumbprint": "string",
    "isExportable": "boolean"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/certificates" />
### Microsoft.Automation/automationAccounts/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/certificates |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the properties of the certificate. - [CertificateCreateOrUpdateProperties object](#CertificateCreateOrUpdateProperties) |


<a id="CertificateCreateOrUpdateProperties" />
### CertificateCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  base64Value | string | Yes | Gets or sets the base64 encoded value of the certificate. |
|  description | string | No | Gets or sets the description of the certificate. |
|  thumbprint | string | No | Gets or sets the thumbprint of the certificate. |
|  isExportable | boolean | No | Gets or sets the is exportable flag of the certificate. |

