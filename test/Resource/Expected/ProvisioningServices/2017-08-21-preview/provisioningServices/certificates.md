# Microsoft.Devices/provisioningServices/certificates template reference
API Version: 2017-08-21-preview
## Template format

To create a Microsoft.Devices/provisioningServices/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Devices/provisioningServices/certificates",
  "apiVersion": "2017-08-21-preview",
  "certificate": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Devices/provisioningServices/certificates" />
### Microsoft.Devices/provisioningServices/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Devices/provisioningServices/certificates |
|  apiVersion | enum | Yes | 2017-08-21-preview |
|  certificate | string | No | Base-64 representation of the X509 leaf certificate .cer file or just .pem file content. |

