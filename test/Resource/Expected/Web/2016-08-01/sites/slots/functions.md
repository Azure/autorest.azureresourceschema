# Microsoft.Web/sites/slots/functions template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/slots/functions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/slots/functions",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "scriptRootPathHref": "string",
    "scriptHref": "string",
    "configHref": "string",
    "secretsFileHref": "string",
    "href": "string",
    "config": {},
    "files": {},
    "testData": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/slots/functions" />
### Microsoft.Web/sites/slots/functions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/slots/functions |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | FunctionEnvelope resource specific properties - [FunctionEnvelopeProperties object](#FunctionEnvelopeProperties) |


<a id="FunctionEnvelopeProperties" />
### FunctionEnvelopeProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  scriptRootPathHref | string | No | Script root path URI. |
|  scriptHref | string | No | Script URI. |
|  configHref | string | No | Config URI. |
|  secretsFileHref | string | No | Secrets file URI. |
|  href | string | No | Function URI. |
|  config | object | No | Config information. |
|  files | object | No | File list. |
|  testData | string | No | Test data used when testing via the Azure Portal. |

