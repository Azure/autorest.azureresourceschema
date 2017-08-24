# Microsoft.NotificationHubs/namespaces/notificationHubs template reference
API Version: 2016-03-01
## Template format

To create a Microsoft.NotificationHubs/namespaces/notificationHubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.NotificationHubs/namespaces/notificationHubs",
  "apiVersion": "2016-03-01",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string",
    "tier": "string",
    "size": "string",
    "family": "string",
    "capacity": "integer"
  },
  "properties": {
    "name": "string",
    "registrationTtl": "string",
    "authorizationRules": [
      {
        "rights": [
          "string"
        ]
      }
    ],
    "apnsCredential": {
      "properties": {
        "apnsCertificate": "string",
        "certificateKey": "string",
        "endpoint": "string",
        "thumbprint": "string"
      }
    },
    "wnsCredential": {
      "properties": {
        "packageSid": "string",
        "secretKey": "string",
        "windowsLiveEndpoint": "string"
      }
    },
    "gcmCredential": {
      "properties": {
        "gcmEndpoint": "string",
        "googleApiKey": "string"
      }
    },
    "mpnsCredential": {
      "properties": {
        "mpnsCertificate": "string",
        "certificateKey": "string",
        "thumbprint": "string"
      }
    },
    "admCredential": {
      "properties": {
        "clientId": "string",
        "clientSecret": "string",
        "authTokenUrl": "string"
      }
    },
    "baiduCredential": {
      "properties": {
        "baiduApiKey": "string",
        "baiduEndPoint": "string",
        "baiduSecretKey": "string"
      }
    }
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.NotificationHubs/namespaces/notificationHubs" />
### Microsoft.NotificationHubs/namespaces/notificationHubs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.NotificationHubs/namespaces/notificationHubs |
|  apiVersion | enum | Yes | 2016-03-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  sku | object | No | The sku of the created namespace - [Sku object](#Sku) |
|  properties | object | Yes | Properties of the NotificationHub. - [NotificationHubProperties object](#NotificationHubProperties) |
|  resources | array | No | [AuthorizationRules](./notificationHubs/AuthorizationRules.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of the notification hub sku. - Free, Basic, Standard |
|  tier | string | No | The tier of particular sku |
|  size | string | No | The Sku size |
|  family | string | No | The Sku Family |
|  capacity | integer | No | The capacity of the resource |


<a id="NotificationHubProperties" />
### NotificationHubProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The NotificationHub name. |
|  registrationTtl | string | No | The RegistrationTtl of the created NotificationHub |
|  authorizationRules | array | No | The AuthorizationRules of the created NotificationHub - [SharedAccessAuthorizationRuleProperties object](#SharedAccessAuthorizationRuleProperties) |
|  apnsCredential | object | No | The ApnsCredential of the created NotificationHub - [ApnsCredential object](#ApnsCredential) |
|  wnsCredential | object | No | The WnsCredential of the created NotificationHub - [WnsCredential object](#WnsCredential) |
|  gcmCredential | object | No | The GcmCredential of the created NotificationHub - [GcmCredential object](#GcmCredential) |
|  mpnsCredential | object | No | The MpnsCredential of the created NotificationHub - [MpnsCredential object](#MpnsCredential) |
|  admCredential | object | No | The AdmCredential of the created NotificationHub - [AdmCredential object](#AdmCredential) |
|  baiduCredential | object | No | The BaiduCredential of the created NotificationHub - [BaiduCredential object](#BaiduCredential) |


<a id="SharedAccessAuthorizationRuleProperties" />
### SharedAccessAuthorizationRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rights | array | No | The rights associated with the rule. - Manage, Send, Listen |


<a id="ApnsCredential" />
### ApnsCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Properties of NotificationHub ApnsCredential. - [ApnsCredentialProperties object](#ApnsCredentialProperties) |


<a id="WnsCredential" />
### WnsCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Properties of NotificationHub WnsCredential. - [WnsCredentialProperties object](#WnsCredentialProperties) |


<a id="GcmCredential" />
### GcmCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Properties of NotificationHub GcmCredential. - [GcmCredentialProperties object](#GcmCredentialProperties) |


<a id="MpnsCredential" />
### MpnsCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Properties of NotificationHub MpnsCredential. - [MpnsCredentialProperties object](#MpnsCredentialProperties) |


<a id="AdmCredential" />
### AdmCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Properties of NotificationHub AdmCredential. - [AdmCredentialProperties object](#AdmCredentialProperties) |


<a id="BaiduCredential" />
### BaiduCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Properties of NotificationHub BaiduCredential. - [BaiduCredentialProperties object](#BaiduCredentialProperties) |


<a id="ApnsCredentialProperties" />
### ApnsCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  apnsCertificate | string | No | The APNS certificate. |
|  certificateKey | string | No | The certificate key. |
|  endpoint | string | No | The endpoint of this credential. |
|  thumbprint | string | No | The Apns certificate Thumbprint |


<a id="WnsCredentialProperties" />
### WnsCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  packageSid | string | No | The package ID for this credential. |
|  secretKey | string | No | The secret key. |
|  windowsLiveEndpoint | string | No | The Windows Live endpoint. |


<a id="GcmCredentialProperties" />
### GcmCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  gcmEndpoint | string | No | The GCM endpoint. |
|  googleApiKey | string | No | The Google API key. |


<a id="MpnsCredentialProperties" />
### MpnsCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  mpnsCertificate | string | No | The MPNS certificate. |
|  certificateKey | string | No | The certificate key for this credential. |
|  thumbprint | string | No | The Mpns certificate Thumbprint |


<a id="AdmCredentialProperties" />
### AdmCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  clientId | string | No | The client identifier. |
|  clientSecret | string | No | The credential secret access key. |
|  authTokenUrl | string | No | The URL of the authorization token. |


<a id="BaiduCredentialProperties" />
### BaiduCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  baiduApiKey | string | No | Baidu Api Key. |
|  baiduEndPoint | string | No | Baidu Endpoint. |
|  baiduSecretKey | string | No | Baidu Secret Key |

