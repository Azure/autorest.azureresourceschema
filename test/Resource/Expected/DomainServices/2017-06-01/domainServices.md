# Microsoft.AAD/domainServices template reference
API Version: 2017-06-01
## Template format

To create a Microsoft.AAD/domainServices resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.AAD/domainServices",
  "apiVersion": "2017-06-01",
  "domainName": "string",
  "subnetId": "string",
  "ldapsSettings": {
    "ldaps": "string",
    "pfxCertificate": "string",
    "pfxCertificatePassword": "string",
    "externalAccess": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.AAD/domainServices" />
### Microsoft.AAD/domainServices object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.AAD/domainServices |
|  apiVersion | enum | Yes | 2017-06-01 |
|  domainName | string | No | The name of the Azure domain that the user would like to deploy Domain Services to. |
|  subnetId | string | No | The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName. |
|  ldapsSettings | object | No | Secure LDAP Settings - [LdapsSettings object](#LdapsSettings) |


<a id="LdapsSettings" />
### LdapsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ldaps | enum | No | A flag to determine whether or not Secure LDAP is enabled or disabled. - Enabled or Disabled |
|  pfxCertificate | string | No | The certificate required to configure Secure LDAP. The parameter passed here should be a base64encoded representation of the certificate pfx file. |
|  pfxCertificatePassword | string | No | The password to decrypt the provided Secure LDAP certificate pfx file. |
|  externalAccess | enum | No | A flag to determine whether or not Secure LDAP access over the internet is enabled or disabled. - Enabled or Disabled |

