# Microsoft.Devices/IotHubs/certificates template reference
API Version: 2017-07-01
## Template format

To create a Microsoft.Devices/IotHubs/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Devices/IotHubs/certificates",
  "apiVersion": "2017-07-01",
  "certificate": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Devices/IotHubs/certificates" />
### Microsoft.Devices/IotHubs/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the certificate |
|  type | enum | Yes | Microsoft.Devices/IotHubs/certificates |
|  apiVersion | enum | Yes | 2017-07-01 |
|  certificate | string | No | base-64 representation of the X509 leaf certificate .cer file or just .pem file content. |

