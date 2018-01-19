# Microsoft.Batch/batchAccounts/certificates template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Batch/batchAccounts/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Batch/batchAccounts/certificates",
  "apiVersion": "2017-09-01",
  "properties": {
    "thumbprintAlgorithm": "string",
    "thumbprint": "string",
    "format": "string",
    "data": "string",
    "password": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Batch/batchAccounts/certificates" />
### Microsoft.Batch/batchAccounts/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5. |
|  type | enum | Yes | Microsoft.Batch/batchAccounts/certificates |
|  apiVersion | enum | Yes | 2017-09-01 |
|  properties | object | Yes | The properties associated with the certificate. - [CertificateCreateOrUpdateProperties object](#CertificateCreateOrUpdateProperties) |


<a id="CertificateCreateOrUpdateProperties" />
### CertificateCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thumbprintAlgorithm | string | No | This must match the first portion of the certificate name. Currently required to be 'SHA1'. |
|  thumbprint | string | No | This must match the thumbprint from the name. |
|  format | enum | No | The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. - Pfx or Cer |
|  data | string | Yes | The maximum size is 10KB. |
|  password | string | No | This is required if the certificate format is pfx and must be omitted if the certificate format is cer. |

