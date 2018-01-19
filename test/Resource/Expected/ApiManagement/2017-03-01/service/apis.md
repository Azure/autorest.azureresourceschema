# Microsoft.ApiManagement/service/apis template reference
API Version: 2017-03-01
## Template format

To create a Microsoft.ApiManagement/service/apis resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/apis",
  "apiVersion": "2017-03-01",
  "properties": {
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
    "type": "string",
    "apiRevision": "string",
    "isCurrent": boolean,
    "isOnline": boolean,
    "displayName": "string",
    "serviceUrl": "string",
    "path": "string",
    "protocols": [
      "string"
    ],
    "contentValue": "string",
    "contentFormat": "string",
    "wsdlSelector": {
      "wsdlServiceName": "string",
      "wsdlEndpointName": "string"
    }
  },
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
|  apiVersion | enum | Yes | 2017-03-01 |
|  properties | object | Yes | Api entity create of update properties. - [ApiCreateOrUpdateProperties object](#ApiCreateOrUpdateProperties) |
|  resources | array | No | [schemas](./apis/schemas.md) [policies](./apis/policies.md) [operations](./apis/operations.md) |


<a id="ApiCreateOrUpdateProperties" />
### ApiCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | Description of the API. May include HTML formatting tags. |
|  authenticationSettings | object | No | Collection of authentication settings included into this API. - [AuthenticationSettingsContract object](#AuthenticationSettingsContract) |
|  subscriptionKeyParameterNames | object | No | Protocols over which API is made available. - [SubscriptionKeyParameterNamesContract object](#SubscriptionKeyParameterNamesContract) |
|  type | enum | No | Type of API. - http or soap |
|  apiRevision | string | No | Describes the Revision of the Api. If no value is provided, default revision 1 is created |
|  isCurrent | boolean | No | Indicates if API revision is current api revision. |
|  isOnline | boolean | No | Indicates if API revision is accessible via the gateway. |
|  displayName | string | No | API name. |
|  serviceUrl | string | No | Absolute URL of the backend service implementing this API. |
|  path | string | Yes | Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API. |
|  protocols | array | No | Describes on which protocols the operations in this API can be invoked. - http or https |
|  contentValue | string | No | Content value when Importing an API. |
|  contentFormat | enum | No | Format of the Content in which the API is getting imported. - wadl-xml, wadl-link-json, swagger-json, swagger-link-json, wsdl, wsdl-link |
|  wsdlSelector | object | No | Criteria to limit import of WSDL to a subset of the document. - [ApiCreateOrUpdatePropertiesWsdlSelector object](#ApiCreateOrUpdatePropertiesWsdlSelector) |


<a id="AuthenticationSettingsContract" />
### AuthenticationSettingsContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  oAuth2 | object | No | OAuth2 Authentication settings - [OAuth2AuthenticationSettingsContract object](#OAuth2AuthenticationSettingsContract) |


<a id="SubscriptionKeyParameterNamesContract" />
### SubscriptionKeyParameterNamesContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  header | string | No | Subscription key header name. |
|  query | string | No | Subscription key query string parameter name. |


<a id="ApiCreateOrUpdatePropertiesWsdlSelector" />
### ApiCreateOrUpdatePropertiesWsdlSelector object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  wsdlServiceName | string | No | Name of service to import from WSDL |
|  wsdlEndpointName | string | No | Name of endpoint(port) to import from WSDL |


<a id="OAuth2AuthenticationSettingsContract" />
### OAuth2AuthenticationSettingsContract object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationServerId | string | No | OAuth authorization server identifier. |
|  scope | string | No | operations scope. |

