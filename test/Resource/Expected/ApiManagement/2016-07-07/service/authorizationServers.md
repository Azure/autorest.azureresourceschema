# Microsoft.ApiManagement/service/authorizationServers template reference
API Version: 2016-07-07
## Template format

To create a Microsoft.ApiManagement/service/authorizationServers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/authorizationServers",
  "apiVersion": "2016-07-07",
  "description": "string",
  "clientRegistrationEndpoint": "string",
  "authorizationEndpoint": "string",
  "authorizationMethods": [
    "string"
  ],
  "clientAuthenticationMethod": [
    "string"
  ],
  "tokenBodyParameters": [
    {
      "name": "string",
      "value": "string"
    }
  ],
  "tokenEndpoint": "string",
  "supportState": boolean,
  "defaultScope": "string",
  "grantTypes": [
    "string"
  ],
  "bearerTokenSendingMethods": [
    "string"
  ],
  "clientId": "string",
  "clientSecret": "string",
  "resourceOwnerUsername": "string",
  "resourceOwnerPassword": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/authorizationServers" />
### Microsoft.ApiManagement/service/authorizationServers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.ApiManagement/service/authorizationServers |
|  apiVersion | enum | Yes | 2016-07-07 |
|  description | string | No | Description of the authorization server. Can contain HTML formatting tags. |
|  clientRegistrationEndpoint | string | Yes | Optional reference to a page where client or app registration for this authorization server is performed. Contains absolute URL to entity being referenced. |
|  authorizationEndpoint | string | Yes | OAuth authorization endpoint. See http://tools.ietf.org/html/rfc6749#section-3.2. |
|  authorizationMethods | array | No | HTTP verbs supported by the authorization endpoint. GET must be always present. POST is optional. - HEAD, OPTIONS, TRACE, GET, POST, PUT, PATCH, DELETE |
|  clientAuthenticationMethod | array | No | Method of authentication supported by the token endpoint of this authorization server. Possible values are Basic and/or Body. When Body is specified, client credentials and other parameters are passed within the request body in the application/x-www-form-urlencoded format. - Basic or Body |
|  tokenBodyParameters | array | No | Additional parameters required by the token endpoint of this authorization server represented as an array of JSON objects with name and value string properties, i.e. {"name" : "name value", "value": "a value"}. - [TokenBodyParameterContract object](#TokenBodyParameterContract) |
|  tokenEndpoint | string | No | OAuth token endpoint. Contains absolute URI to entity being referenced. |
|  supportState | boolean | No | If true, authorization server will include state parameter from the authorization request to its response. Client may use state parameter to raise protocol security. |
|  defaultScope | string | No | Access token scope that is going to be requested by default. Can be overridden at the API level. Should be provided in the form of a string containing space-delimited values. |
|  grantTypes | array | Yes | Form of an authorization grant, which the client uses to request the access token. - authorizationCode, implicit, resourceOwnerPassword, clientCredentials |
|  bearerTokenSendingMethods | array | No | Specifies the mechanism by which access token is passed to the API.  - authorizationHeader or query |
|  clientId | string | Yes | Client or app id registered with this authorization server. |
|  clientSecret | string | No | Client or app secret registered with this authorization server. |
|  resourceOwnerUsername | string | No | Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner username. |
|  resourceOwnerPassword | string | No | Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner password. |


<a id="TokenBodyParameterContract" />
### TokenBodyParameterContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | body parameter name. |
|  value | string | Yes | body parameter value. |

