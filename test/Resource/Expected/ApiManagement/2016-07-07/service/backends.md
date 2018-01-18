# Microsoft.ApiManagement/service/backends template reference
API Version: 2016-07-07
## Template format

To create a Microsoft.ApiManagement/service/backends resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/backends",
  "apiVersion": "2016-07-07",
  "host": "string",
  "skipCertificateChainValidation": boolean
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/backends" />
### Microsoft.ApiManagement/service/backends object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | User identifier. Must be unique in the current API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/backends |
|  apiVersion | enum | Yes | 2016-07-07 |
|  host | string | Yes | Host attribute of the backend. Host is a pure hostname without a port or suffix, for example backend.contoso.com. Must not be empty. |
|  skipCertificateChainValidation | boolean | No | Flag indicating whether SSL certificate chain validation should be skipped when using self-signed certificates for this backend host. |

