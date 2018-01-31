# Microsoft.ApiManagement/service/loggers template reference
API Version: 2017-03-01
## Template format

To create a Microsoft.ApiManagement/service/loggers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/loggers",
  "apiVersion": "2017-03-01",
  "properties": {
    "loggerType": "azureEventHub",
    "description": "string",
    "credentials": {},
    "isBuffered": boolean
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/loggers" />
### Microsoft.ApiManagement/service/loggers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Logger identifier. Must be unique in the API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/loggers |
|  apiVersion | enum | Yes | 2017-03-01 |
|  properties | object | Yes | Logger entity contract properties. - [LoggerContractProperties object](#LoggerContractProperties) |


<a id="LoggerContractProperties" />
### LoggerContractProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  loggerType | enum | Yes | Logger type. - azureEventHub |
|  description | string | No | Logger description. |
|  credentials | object | Yes | The name and SendRule connection string of the event hub. |
|  isBuffered | boolean | No | Whether records are buffered in the logger before publishing. Default is assumed to be true. |

