# Microsoft.ServerManagement/nodes/sessions template reference
API Version: 2016-07-01-preview
## Template format

To create a Microsoft.ServerManagement/nodes/sessions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServerManagement/nodes/sessions",
  "apiVersion": "2016-07-01-preview",
  "properties": {
    "userName": "string",
    "password": "string",
    "retentionPeriod": "string",
    "credentialDataFormat": "RsaEncrypted",
    "EncryptionCertificateThumbprint": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServerManagement/nodes/sessions" />
### Microsoft.ServerManagement/nodes/sessions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.ServerManagement/nodes/sessions |
|  apiVersion | enum | Yes | 2016-07-01-preview |
|  properties | object | Yes | Collection of properties - [SessionParametersProperties object](#SessionParametersProperties) |


<a id="SessionParametersProperties" />
### SessionParametersProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userName | string | No | Encrypted User name to be used to connect to node. |
|  password | string | No | Encrypted Password associated with user name. |
|  retentionPeriod | enum | No | Session retention period. - Session or Persistent |
|  credentialDataFormat | enum | No | Credential data format. - RsaEncrypted |
|  EncryptionCertificateThumbprint | string | No | Encryption certificate thumbprint. |

