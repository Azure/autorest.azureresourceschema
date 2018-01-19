# Microsoft.Web/connections template reference
API Version: 2015-08-01-preview
## Template format

To create a Microsoft.Web/connections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/connections",
  "apiVersion": "2015-08-01-preview",
  "id": "string",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "name": "string",
    "displayName": "string",
    "statuses": [
      {
        "id": "string",
        "name": "string",
        "kind": "string",
        "location": "string",
        "type": "string",
        "tags": {},
        "properties": {
          "status": "string",
          "target": "string",
          "error": {
            "id": "string",
            "name": "string",
            "kind": "string",
            "location": "string",
            "type": "string",
            "tags": {},
            "properties": {
              "code": "string",
              "message": "string"
            }
          }
        }
      }
    ],
    "customParameterValues": {},
    "tenantId": "string",
    "parameterValues": {},
    "nonSecretParameterValues": {},
    "metadata": {},
    "firstExpirationTime": "string",
    "keywords": [
      "string"
    ],
    "createdTime": "string",
    "changedTime": "string",
    "api": {
      "id": "string",
      "name": "string",
      "kind": "string",
      "location": "string",
      "type": "string",
      "tags": {},
      "properties": {
        "id": "string",
        "entity": {
          "id": "string",
          "name": "string",
          "type": "string",
          "location": "string",
          "tags": {},
          "plan": {
            "name": "string",
            "publisher": "string",
            "product": "string",
            "promotionCode": "string",
            "version": "string"
          },
          "properties": {
            "id": "string",
            "name": "string",
            "kind": "string",
            "location": "string",
            "type": "string",
            "tags": {},
            "properties": {
              "name": "string",
              "generalInformation": {
                "id": "string",
                "name": "string",
                "kind": "string",
                "location": "string",
                "type": "string",
                "tags": {},
                "properties": {
                  "iconUrl": "string",
                  "displayName": "string",
                  "description": "string",
                  "termsOfUseUrl": "string",
                  "connectionDisplayName": "string",
                  "connectionPortalUrl": {}
                }
              },
              "path": "string",
              "runtimeUrls": [
                "string"
              ],
              "protocols": [
                "string"
              ],
              "policies": {
                "id": "string",
                "name": "string",
                "kind": "string",
                "location": "string",
                "type": "string",
                "tags": {},
                "properties": {
                  "content": "string"
                }
              },
              "backendService": {
                "id": "string",
                "name": "string",
                "kind": "string",
                "location": "string",
                "type": "string",
                "tags": {},
                "properties": {
                  "serviceUrl": "string",
                  "hostingEnvironmentServiceUrls": [
                    {
                      "hostingEnvironmentId": "string",
                      "hostId": "string",
                      "serviceUrl": "string",
                      "useInternalRouting": boolean
                    }
                  ]
                }
              },
              "apiDefinitionUrl": "string",
              "metadata": {},
              "capabilities": [
                "string"
              ],
              "connectionParameters": {},
              "createdTime": "string",
              "changedTime": "string"
            }
          },
          "sku": {
            "name": "string",
            "tier": "string",
            "size": "string",
            "family": "string",
            "capacity": "integer"
          }
        }
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/connections" />
### Microsoft.Web/connections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/connections |
|  apiVersion | enum | Yes | 2015-08-01-preview |
|  id | string | No | Resource Id |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | [ConnectionProperties object](#ConnectionProperties) |


<a id="ConnectionProperties" />
### ConnectionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | connection name |
|  displayName | string | No | display name |
|  statuses | array | No | Status of the connection - [ConnectionStatus object](#ConnectionStatus) |
|  customParameterValues | object | No | Custom login setting values. |
|  tenantId | string | No |  |
|  parameterValues | object | No | Tokens/Claim |
|  nonSecretParameterValues | object | No | Tokens/Claim |
|  metadata | object | No |  |
|  firstExpirationTime | string | No | Time in UTC when the first expiration of OAuth tokens |
|  keywords | array | No | List of Keywords that tag the acl - string |
|  createdTime | string | No | Timestamp of the connection creation |
|  changedTime | string | No | Timestamp of last connection change. |
|  api | object | No | expanded connection provider name - [ExpandedParentApiEntity object](#ExpandedParentApiEntity) |


<a id="ConnectionStatus" />
### ConnectionStatus object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [ConnectionStatusProperties object](#ConnectionStatusProperties) |


<a id="ExpandedParentApiEntity" />
### ExpandedParentApiEntity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [ExpandedParentApiEntityProperties object](#ExpandedParentApiEntityProperties) |


<a id="ConnectionStatusProperties" />
### ConnectionStatusProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | string | No | Status |
|  target | string | No | Target of the error |
|  error | object | No | Error details - [ConnectionError object](#ConnectionError) |


<a id="ExpandedParentApiEntityProperties" />
### ExpandedParentApiEntityProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Id of connection provider |
|  entity | object | No | Id of connection provider - [ResponseMessageEnvelopeApiEntity object](#ResponseMessageEnvelopeApiEntity) |


<a id="ConnectionError" />
### ConnectionError object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [ConnectionErrorProperties object](#ConnectionErrorProperties) |


<a id="ResponseMessageEnvelopeApiEntity" />
### ResponseMessageEnvelopeApiEntity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id. Typically id is populated only for responses to GET requests. Caller is responsible for passing in this
            value for GET requests only.
            For example: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupId}/providers/Microsoft.Web/sites/{sitename} |
|  name | string | No | Name of resource |
|  type | string | No | Type of resource e.g Microsoft.Web/sites |
|  location | string | No | Geo region resource belongs to e.g. SouthCentralUS, SouthEastAsia |
|  tags | object | No | Tags associated with resource |
|  plan | object | No | Azure resource manager plan - [ArmPlan object](#ArmPlan) |
|  properties | object | No | Resource specific properties - [ApiEntity object](#ApiEntity) |
|  sku | object | No | Sku description of the resource - [SkuDescription object](#SkuDescription) |


<a id="ConnectionErrorProperties" />
### ConnectionErrorProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  code | string | No | code of the status |
|  message | string | No | Description of the status |


<a id="ArmPlan" />
### ArmPlan object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name |
|  publisher | string | No | The publisher |
|  product | string | No | The product |
|  promotionCode | string | No | The promotion code |
|  version | string | No | Version of product |


<a id="ApiEntity" />
### ApiEntity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [ApiEntityProperties object](#ApiEntityProperties) |


<a id="SkuDescription" />
### SkuDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name of the resource sku |
|  tier | string | No | Service Tier of the resource sku |
|  size | string | No | Size specifier of the resource sku |
|  family | string | No | Family code of the resource sku |
|  capacity | integer | No | Current number of instances assigned to the resource |


<a id="ApiEntityProperties" />
### ApiEntityProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name of the API
            the URL path of this API when exposed via APIM |
|  generalInformation | object | No | the URL path of this API when exposed via APIM - [GeneralApiInformation object](#GeneralApiInformation) |
|  path | string | No | the URL path of this API when exposed via APIM |
|  runtimeUrls | array | No | Read only property returning the runtime endpoints where the API can be called - string |
|  protocols | array | No | Protocols supported by the front end - http/https - string |
|  policies | object | No | Api polcies - [ApiPolicies object](#ApiPolicies) |
|  backendService | object | No | Backend service definition - [BackendServiceDefinition object](#BackendServiceDefinition) |
|  apiDefinitionUrl | string | No | Api definition Url - url where the swagger can be downloaded from |
|  metadata | object | No | Free form object for the data caller wants to store |
|  capabilities | array | No | Capabilities - string |
|  connectionParameters | object | No | Connection parameters |
|  createdTime | string | No | Timestamp of the connection creation |
|  changedTime | string | No | Timestamp of last connection change. |


<a id="GeneralApiInformation" />
### GeneralApiInformation object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [GeneralApiInformationProperties object](#GeneralApiInformationProperties) |


<a id="ApiPolicies" />
### ApiPolicies object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [ApiPoliciesProperties object](#ApiPoliciesProperties) |


<a id="BackendServiceDefinition" />
### BackendServiceDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | No | Resource Name |
|  kind | string | No | Kind of resource |
|  location | string | Yes | Resource Location |
|  type | string | No | Resource type |
|  tags | object | No | Resource tags |
|  properties | object | No | [BackendServiceDefinitionProperties object](#BackendServiceDefinitionProperties) |


<a id="GeneralApiInformationProperties" />
### GeneralApiInformationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  iconUrl | string | No | Icon Url |
|  displayName | string | No | Display Name |
|  description | string | No | Description |
|  termsOfUseUrl | string | No | a public accessible url of the Terms Of Use Url of this API |
|  connectionDisplayName | string | No | DefaultConnectionNameTemplate |
|  connectionPortalUrl | object | No | ConnectionPortalUrl |


<a id="ApiPoliciesProperties" />
### ApiPoliciesProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  content | string | No | Content of xml policy |


<a id="BackendServiceDefinitionProperties" />
### BackendServiceDefinitionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceUrl | string | No | Url from which the swagger payload will be fetched |
|  hostingEnvironmentServiceUrls | array | No | Service Urls per Hosting environment - [HostingEnvironmentServiceDescriptions object](#HostingEnvironmentServiceDescriptions) |


<a id="HostingEnvironmentServiceDescriptions" />
### HostingEnvironmentServiceDescriptions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  hostingEnvironmentId | string | No | Hosting environment Id |
|  hostId | string | No | Host Id |
|  serviceUrl | string | No | service url to use |
|  useInternalRouting | boolean | No | When the backend url is in same ASE, for performance reason this flag can be set to true
            If WebApp.DisableHostNames is also set it improves the security by making the back end accesible only
            via API calls
            Note: calls will fail if this option is used but back end is not on the same ASE |

