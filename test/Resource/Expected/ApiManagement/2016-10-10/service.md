# Microsoft.ApiManagement/service template reference
API Version: 2016-10-10
## Template format

To create a Microsoft.ApiManagement/service resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service",
  "apiVersion": "2016-10-10",
  "location": "string",
  "tags": {},
  "properties": {
    "publisherEmail": "string",
    "publisherName": "string",
    "addresserEmail": "string",
    "hostnameConfigurations": [
      {
        "type": "string",
        "hostname": "string",
        "certificate": {
          "expiry": "string",
          "thumbprint": "string",
          "subject": "string"
        }
      }
    ],
    "vpnconfiguration": {
      "subnetResourceId": "string",
      "location": "string"
    },
    "additionalLocations": [
      {
        "location": "string",
        "skuType": "string",
        "skuUnitCount": "integer",
        "vpnconfiguration": {
          "subnetResourceId": "string",
          "location": "string"
        }
      }
    ],
    "customProperties": {},
    "vpnType": "string"
  },
  "sku": {
    "name": "string",
    "capacity": "integer"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service" />
### Microsoft.ApiManagement/service object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the API Management service. |
|  type | enum | Yes | Microsoft.ApiManagement/service |
|  apiVersion | enum | Yes | 2016-10-10 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Properties of the API Management service. - [ApiManagementServiceProperties object](#ApiManagementServiceProperties) |
|  sku | object | Yes | SKU properties of the API Management service. - [ApiManagementServiceSkuProperties object](#ApiManagementServiceSkuProperties) |
|  resources | array | No | [users](./service/users.md) [subscriptions](./service/subscriptions.md) [properties](./service/properties.md) [products](./service/products.md) [openidConnectProviders](./service/openidConnectProviders.md) [loggers](./service/loggers.md) [identityProviders](./service/identityProviders.md) [groups](./service/groups.md) [certificates](./service/certificates.md) [backends](./service/backends.md) [authorizationServers](./service/authorizationServers.md) [apis](./service/apis.md) |


<a id="ApiManagementServiceProperties" />
### ApiManagementServiceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publisherEmail | string | Yes | Publisher email. |
|  publisherName | string | Yes | Publisher name. |
|  addresserEmail | string | No | Addresser email. |
|  hostnameConfigurations | array | No | Custom hostname configuration of the API Management service. - [HostnameConfiguration object](#HostnameConfiguration) |
|  vpnconfiguration | object | No | Virtual network configuration of the API Management service. - [VirtualNetworkConfiguration object](#VirtualNetworkConfiguration) |
|  additionalLocations | array | No | Additional datacenter locations of the API Management service. - [AdditionalRegion object](#AdditionalRegion) |
|  customProperties | object | No | Custom properties of the API Management service, like disabling TLS 1.0. |
|  vpnType | enum | No | The type of VPN in which API Managemet service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only. - None, External, Internal |


<a id="ApiManagementServiceSkuProperties" />
### ApiManagementServiceSkuProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of the Sku. - Developer, Standard, Premium |
|  capacity | integer | No | Capacity of the SKU (number of deployed units of the SKU). The default value is 1. |


<a id="HostnameConfiguration" />
### HostnameConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | Yes | Hostname type. - Proxy, Portal, Management, Scm |
|  hostname | string | Yes | Hostname. |
|  certificate | object | Yes | Certificate information. - [CertificateInformation object](#CertificateInformation) |


<a id="VirtualNetworkConfiguration" />
### VirtualNetworkConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  subnetResourceId | string | No | The full resource ID of a subnet in a virtual network to deploy the API Management service in. |
|  location | string | No | The location of the virtual network. |


<a id="AdditionalRegion" />
### AdditionalRegion object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  location | string | Yes | The location name of the additional region among Azure Data center regions. |
|  skuType | enum | Yes | The SKU type in the location. - Developer, Standard, Premium |
|  skuUnitCount | integer | No | The SKU Unit count at the location. The maximum SKU Unit count depends on the SkuType. Maximum allowed for Developer SKU is 1, for Standard SKU is 4, and for Premium SKU is 10, at a location. |
|  vpnconfiguration | object | No | Virtual network configuration for the location. - [VirtualNetworkConfiguration object](#VirtualNetworkConfiguration) |


<a id="CertificateInformation" />
### CertificateInformation object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  expiry | string | Yes | Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard. |
|  thumbprint | string | Yes | Thumbprint of the certificate. |
|  subject | string | Yes | Subject of the certificate. |

