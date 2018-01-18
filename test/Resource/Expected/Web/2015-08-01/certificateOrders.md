# Microsoft.CertificateRegistration/certificateOrders template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.CertificateRegistration/certificateOrders resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CertificateRegistration/certificateOrders",
  "apiVersion": "2015-08-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "certificates": {},
    "distinguishedName": "string",
    "validityInYears": "integer",
    "keySize": "integer",
    "productType": "string",
    "autoRenew": boolean,
    "csr": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CertificateRegistration/certificateOrders" />
### Microsoft.CertificateRegistration/certificateOrders object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CertificateRegistration/certificateOrders |
|  apiVersion | enum | Yes | 2015-08-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | AppServiceCertificateOrder resource specific properties - [AppServiceCertificateOrder_properties object](#AppServiceCertificateOrder_properties) |
|  resources | array | No | [certificates](./certificateOrders/certificates.md) |


<a id="AppServiceCertificateOrder_properties" />
### AppServiceCertificateOrder_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  certificates | object | No | State of the Key Vault secret. |
|  distinguishedName | string | No | Certificate distinguished name. |
|  validityInYears | integer | No | Duration in years (must be between 1 and 3). |
|  keySize | integer | No | Certificate key size. |
|  productType | enum | Yes | Certificate product type. - StandardDomainValidatedSsl or StandardDomainValidatedWildCardSsl |
|  autoRenew | boolean | No | <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>. |
|  csr | string | No | Last CSR that was created for this order. |

