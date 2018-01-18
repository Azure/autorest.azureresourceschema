# Microsoft.NotificationHubs/namespaces/notificationHubs template reference
API Version: 2014-09-01
## Template format

To create a Microsoft.NotificationHubs/namespaces/notificationHubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.NotificationHubs/namespaces/notificationHubs",
  "apiVersion": "2014-09-01",
  "location": "string",
  "tags": {},
  "properties": {
    "name": "string",
    "registrationTtl": "string",
    "authorizationRules": [
      {
        "primaryKey": "string",
        "secondaryKey": "string",
        "keyName": "string",
        "claimType": "string",
        "claimValue": "string",
        "rights": [
          "string"
        ],
        "createdTime": "string",
        "modifiedTime": "string",
        "revision": "integer"
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
|  apiVersion | enum | Yes | 2014-09-01 |
|  location | string | Yes | Gets or sets NotificationHub data center location. |
|  tags | object | No | Gets or sets NotificationHub tags. |
|  properties | object | Yes | Gets or sets properties of the NotificationHub. - [NotificationHubProperties object](#NotificationHubProperties) |
|  resources | array | No | [AuthorizationRules](./notificationHubs/AuthorizationRules.md) |


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
|  primaryKey | string | No | The primary key that was used. |
|  secondaryKey | string | No | The secondary key that was used. |
|  keyName | string | No | The name of the key that was used. |
|  claimType | string | No | The type of the claim. |
|  claimValue | string | No | The value of the claim. |
|  rights | array | No | The rights associated with the rule. - Manage, Send, Listen |
|  createdTime | string | No | The time at which the authorization rule was created. |
|  modifiedTime | string | No | The most recent time the rule was updated. |
|  revision | integer | No | The revision number for the rule. |


<a id="ApnsCredential" />
### ApnsCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Gets or sets properties of NotificationHub ApnsCredential. - [ApnsCredentialProperties object](#ApnsCredentialProperties) |


<a id="WnsCredential" />
### WnsCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Gets or sets properties of NotificationHub WnsCredential. - [WnsCredentialProperties object](#WnsCredentialProperties) |


<a id="GcmCredential" />
### GcmCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Gets or sets properties of NotificationHub GcmCredential. - [GcmCredentialProperties object](#GcmCredentialProperties) |


<a id="MpnsCredential" />
### MpnsCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Gets or sets properties of NotificationHub MpnsCredential. - [MpnsCredentialProperties object](#MpnsCredentialProperties) |


<a id="AdmCredential" />
### AdmCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Gets or sets properties of NotificationHub AdmCredential. - [AdmCredentialProperties object](#AdmCredentialProperties) |


<a id="BaiduCredential" />
### BaiduCredential object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | Gets or sets properties of NotificationHub BaiduCredential. - [BaiduCredentialProperties object](#BaiduCredentialProperties) |


<a id="ApnsCredentialProperties" />
### ApnsCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  apnsCertificate | string | No | Gets or sets the APNS certificate. |
|  certificateKey | string | No | Gets or sets the certificate key. |
|  endpoint | string | No | Gets or sets the endpoint of this credential. |
|  thumbprint | string | No | Gets or sets the Apns certificate Thumbprint |


<a id="WnsCredentialProperties" />
### WnsCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  packageSid | string | No | Gets or sets the package ID for this credential. |
|  secretKey | string | No | Gets or sets the secret key. |
|  windowsLiveEndpoint | string | No | Gets or sets the Windows Live endpoint. |


<a id="GcmCredentialProperties" />
### GcmCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  gcmEndpoint | string | No | Gets or sets the GCM endpoint. |
|  googleApiKey | string | No | Gets or sets the Google API key. |


<a id="MpnsCredentialProperties" />
### MpnsCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  mpnsCertificate | string | No | Gets or sets the MPNS certificate. |
|  certificateKey | string | No | Gets or sets the certificate key for this credential. |
|  thumbprint | string | No | Gets or sets the Mpns certificate Thumbprint |


<a id="AdmCredentialProperties" />
### AdmCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  clientId | string | No | Gets or sets the client identifier. |
|  clientSecret | string | No | Gets or sets the credential secret access key. |
|  authTokenUrl | string | No | Gets or sets the URL of the authorization token. |


<a id="BaiduCredentialProperties" />
### BaiduCredentialProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  baiduApiKey | string | No | Get or Set Baidu Api Key. |
|  baiduEndPoint | string | No | Get or Set Baidu Endpoint. |
|  baiduSecretKey | string | No | Get or Set Baidu Secret Key |

