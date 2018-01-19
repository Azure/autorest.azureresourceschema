# Microsoft.ApiManagement/service/apis template reference
API Version: 2016-10-10
## Template format

To create a Microsoft.ApiManagement/service/apis resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/apis",
  "apiVersion": "2016-10-10",
  "description": "string",
  "authenticationSettings": {
    "oAuth2": {
      "authorizationServerId": "string",
      "scope": "string"
    }
  },
  "subscriptionKeyParameterNames": {
    "header": "string",
    "query": "string"
  },
  "serviceUrl": "string",
  "path": "string",
  "protocols": [
    "string"
  ],
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/apis" />
### Microsoft.ApiManagement/service/apis object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | API identifier. Must be unique in the current API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/apis |
|  apiVersion | enum | Yes | 2016-10-10 |
|  description | string | No | Description of the API. May include HTML formatting tags. |
|  authenticationSettings | object | No | Collection of authentication settings included into this API. - [AuthenticationSettingsContract object](#AuthenticationSettingsContract) |
|  subscriptionKeyParameterNames | object | No | Protocols over which API is made available. - [SubscriptionKeyParameterNamesContract object](#SubscriptionKeyParameterNamesContract) |
|  serviceUrl | string | Yes | Absolute URL of the backend service implementing this API. |
|  path | string | Yes | Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API. |
|  protocols | array | Yes | Describes on which protocols the operations in this API can be invoked. - Http or Https |
|  resources | array | No | [operations](./apis/operations.md) |


<a id="AuthenticationSettingsContract" />
### AuthenticationSettingsContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  oAuth2 | object | No | [OAuth2AuthenticationSettingsContract object](#OAuth2AuthenticationSettingsContract) |


<a id="SubscriptionKeyParameterNamesContract" />
### SubscriptionKeyParameterNamesContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  header | string | No | Subscription key header name. |
|  query | string | No | Subscription key query string parameter name. |


<a id="OAuth2AuthenticationSettingsContract" />
### OAuth2AuthenticationSettingsContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationServerId | string | No | OAuth authorization server identifier. |
|  scope | string | No | operations scope. |

