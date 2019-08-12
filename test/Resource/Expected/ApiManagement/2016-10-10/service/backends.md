# Microsoft.ApiManagement/service/backends template reference
API Version: 2016-10-10
## Template format

To create a Microsoft.ApiManagement/service/backends resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/backends",
  "apiVersion": "2016-10-10",
  "certificate": [
    "string"
  ],
  "query": {},
  "header": {},
  "url": "string",
  "username": "string",
  "password": "string",
  "title": "string",
  "description": "string",
  "resourceId": "string",
  "properties": {
    "skipCertificateChainValidation": "boolean",
    "skipCertificateNameValidation": "boolean"
  },
  "protocol": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/backends" />
### Microsoft.ApiManagement/service/backends object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Identifier of the Backend entity. Must be unique in the current API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/backends |
|  apiVersion | enum | Yes | 2016-10-10 |
|  certificate | array | No | List of Client Certificate Thumbprint. - string |
|  query | object | No | Query Parameter description. |
|  header | object | No | Header Parameter description. |
|  url | string | Yes | WebProxy Server AbsoluteUri property which includes the entire URI stored in the Uri instance, including all fragments and query strings. |
|  username | string | No | Username to connect to the WebProxy server |
|  password | string | No | Password to connect to the WebProxy Server |
|  title | string | No | Backend Title. |
|  description | string | No | Backend Description. |
|  resourceId | string | No | Management Uri of the Resource in External System. This url can be the Arm Resource Id of Logic Apps, Function Apps or Api Apps. |
|  properties | object | Yes | [BackendProperties object](#BackendProperties) |
|  protocol | enum | Yes | Backend communication protocol. - http or soap |


<a id="BackendProperties" />
### BackendProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  skipCertificateChainValidation | boolean | No | Flag indicating whether SSL certificate chain validation should be skipped when using self-signed certificates for this backend host. |
|  skipCertificateNameValidation | boolean | No | Flag indicating whether SSL certificate name validation should be skipped when using self-signed certificates for this backend host. |

