# Microsoft.ApiManagement/service/apis/operations template reference
API Version: 2016-10-10
## Template format

To create a Microsoft.ApiManagement/service/apis/operations resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/apis/operations",
  "apiVersion": "2016-10-10",
  "templateParameters": [
    {
      "name": "string",
      "description": "string",
      "type": "string",
      "defaultValue": "string",
      "required": "boolean",
      "values": [
        "string"
      ]
    }
  ],
  "description": "string",
  "request": {
    "description": "string",
    "queryParameters": [
      {
        "name": "string",
        "description": "string",
        "type": "string",
        "defaultValue": "string",
        "required": "boolean",
        "values": [
          "string"
        ]
      }
    ],
    "headers": [
      {
        "name": "string",
        "description": "string",
        "type": "string",
        "defaultValue": "string",
        "required": "boolean",
        "values": [
          "string"
        ]
      }
    ],
    "representations": [
      {
        "contentType": "string",
        "sample": "string"
      }
    ]
  },
  "responses": [
    {
      "statusCode": "integer",
      "description": "string",
      "representations": [
        {
          "contentType": "string",
          "sample": "string"
        }
      ]
    }
  ],
  "method": "string",
  "urlTemplate": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/apis/operations" />
### Microsoft.ApiManagement/service/apis/operations object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Operation identifier within an API. Must be unique in the current API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/apis/operations |
|  apiVersion | enum | Yes | 2016-10-10 |
|  templateParameters | array | No | Collection of URL template parameters. - [ParameterContract object](#ParameterContract) |
|  description | string | No | Description of the operation. May include HTML formatting tags. |
|  request | object | No | An entity containing request details. - [RequestContract object](#RequestContract) |
|  responses | array | No | Array of Operation responses. - [ResultContract object](#ResultContract) |
|  method | string | Yes | A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them. |
|  urlTemplate | string | Yes | Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date} |


<a id="ParameterContract" />
### ParameterContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Parameter name. |
|  description | string | No | Parameter description. |
|  type | string | Yes | Parameter type. |
|  defaultValue | string | No | Default parameter value. |
|  required | boolean | No | whether parameter is required or not. |
|  values | array | No | Parameter values. - string |


<a id="RequestContract" />
### RequestContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | Operation request description. |
|  queryParameters | array | No | Collection of operation request query parameters. - [ParameterContract object](#ParameterContract) |
|  headers | array | No | Collection of operation request headers. - [ParameterContract object](#ParameterContract) |
|  representations | array | No | Collection of operation request representations. - [RepresentationContract object](#RepresentationContract) |


<a id="ResultContract" />
### ResultContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  statusCode | integer | Yes | Operation response HTTP status code. |
|  description | string | No | Operation response description. |
|  representations | array | No | Collection of operation response representations. - [RepresentationContract object](#RepresentationContract) |


<a id="RepresentationContract" />
### RepresentationContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  contentType | string | Yes | Specifies a registered or custom content type for this representation, e.g. application/xml. |
|  sample | string | No | An example of the representation. |

