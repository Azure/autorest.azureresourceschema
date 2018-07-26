# Microsoft.Web/sourcecontrols template reference
API Version: 2016-03-01
## Template format

To create a Microsoft.Web/sourcecontrols resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sourcecontrols",
  "apiVersion": "2016-03-01",
  "kind": "string",
  "properties": {
    "name": "string",
    "token": "string",
    "tokenSecret": "string",
    "refreshToken": "string",
    "expirationTime": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sourcecontrols" />
### Microsoft.Web/sourcecontrols object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sourcecontrols |
|  apiVersion | enum | Yes | 2016-03-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | SourceControl resource specific properties - [SourceControlProperties object](#SourceControlProperties) |


<a id="SourceControlProperties" />
### SourceControlProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name or source control type. |
|  token | string | No | OAuth access token. |
|  tokenSecret | string | No | OAuth access token secret. |
|  refreshToken | string | No | OAuth refresh token. |
|  expirationTime | string | No | OAuth token expiration. |

