# Microsoft.RecoveryServices/vaults/certificates template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.RecoveryServices/vaults/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.RecoveryServices/vaults/certificates",
  "apiVersion": "2016-06-01",
  "properties": {
    "authType": "string",
    "certificate": [
      "integer"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.RecoveryServices/vaults/certificates" />
### Microsoft.RecoveryServices/vaults/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.RecoveryServices/vaults/certificates |
|  apiVersion | enum | Yes | 2016-06-01 |
|  properties | object | Yes | [RawCertificateData object](#RawCertificateData) |


<a id="RawCertificateData" />
### RawCertificateData object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authType | enum | No | Specifies the authentication type. - Invalid, ACS, AAD, AccessControlService, AzureActiveDirectory |
|  certificate | array | No | The base64 encoded certificate raw data string - integer |

