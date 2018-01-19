# Microsoft.Web/sites/publicCertificates template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/publicCertificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/publicCertificates",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "blob": [
      "integer"
    ],
    "publicCertificateLocation": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/publicCertificates" />
### Microsoft.Web/sites/publicCertificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/publicCertificates |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | PublicCertificate resource specific properties - [PublicCertificateProperties object](#PublicCertificateProperties) |


<a id="PublicCertificateProperties" />
### PublicCertificateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  blob | array | No | Public Certificate byte array - integer |
|  publicCertificateLocation | enum | No | Public Certificate Location. - CurrentUserMy, LocalMachineMy, Unknown |

