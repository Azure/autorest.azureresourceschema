# Microsoft.Web/sites/slots/hostNameBindings template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/slots/hostNameBindings resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/slots/hostNameBindings",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "siteName": "string",
    "domainId": "string",
    "azureResourceName": "string",
    "azureResourceType": "string",
    "customHostNameDnsRecordType": "string",
    "hostNameType": "string",
    "sslState": "string",
    "thumbprint": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/slots/hostNameBindings" />
### Microsoft.Web/sites/slots/hostNameBindings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/slots/hostNameBindings |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | HostNameBinding resource specific properties - [HostNameBinding_properties object](#HostNameBinding_properties) |


<a id="HostNameBinding_properties" />
### HostNameBinding_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  siteName | string | No | App Service app name. |
|  domainId | string | No | Fully qualified ARM domain resource URI. |
|  azureResourceName | string | No | Azure resource name. |
|  azureResourceType | enum | No | Azure resource type. - Website or TrafficManager |
|  customHostNameDnsRecordType | enum | No | Custom DNS record type. - CName or A |
|  hostNameType | enum | No | Hostname type. - Verified or Managed |
|  sslState | enum | No | SSL type. - Disabled, SniEnabled, IpBasedEnabled |
|  thumbprint | string | No | SSL certificate thumbprint |

