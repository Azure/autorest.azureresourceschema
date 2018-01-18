# Microsoft.CertificateRegistration/certificateOrders/certificates template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.CertificateRegistration/certificateOrders/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CertificateRegistration/certificateOrders/certificates",
  "apiVersion": "2015-08-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "keyVaultId": "string",
    "keyVaultSecretName": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CertificateRegistration/certificateOrders/certificates" />
### Microsoft.CertificateRegistration/certificateOrders/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CertificateRegistration/certificateOrders/certificates |
|  apiVersion | enum | Yes | 2015-08-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Core resource properties - [AppServiceCertificate object](#AppServiceCertificate) |


<a id="AppServiceCertificate" />
### AppServiceCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyVaultId | string | No | Key Vault resource Id. |
|  keyVaultSecretName | string | No | Key Vault secret name. |

