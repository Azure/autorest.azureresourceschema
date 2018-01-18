# Microsoft.ApiManagement/service/certificates template reference
API Version: 2016-07-07
## Template format

To create a Microsoft.ApiManagement/service/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/certificates",
  "apiVersion": "2016-07-07",
  "data": "string",
  "password": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/certificates" />
### Microsoft.ApiManagement/service/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.ApiManagement/service/certificates |
|  apiVersion | enum | Yes | 2016-07-07 |
|  data | string | Yes | Base 64 encoded certificate using the application/x-pkcs12 representation. |
|  password | string | Yes | Password for the Certificate |

