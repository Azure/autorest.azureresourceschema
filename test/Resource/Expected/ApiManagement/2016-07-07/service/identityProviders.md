# Microsoft.ApiManagement/service/identityProviders template reference
API Version: 2016-07-07
## Template format

To create a Microsoft.ApiManagement/service/identityProviders resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/identityProviders",
  "apiVersion": "2016-07-07",
  "clientId": "string",
  "clientSecret": "string",
  "allowedTenants": [
    "string"
  ]
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/identityProviders" />
### Microsoft.ApiManagement/service/identityProviders object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Identity Provider Type identifier. - facebook, google, microsoft, twitter, aad |
|  type | enum | Yes | Microsoft.ApiManagement/service/identityProviders |
|  apiVersion | enum | Yes | 2016-07-07 |
|  clientId | string | Yes | Client Id of the Application in the external Identity Provider. It is App ID for Facebook login, Client ID for Google login, App ID for Microsoft. |
|  clientSecret | string | Yes | Client secret of the Application in external Identity Provider, used to authenticate login request. For example, it is App Secret for Facebook login, API Key for Google login, Public Key for Microsoft. |
|  allowedTenants | array | No | List of Allowed Tenants when configuring Azure Active Directory login. - string |

