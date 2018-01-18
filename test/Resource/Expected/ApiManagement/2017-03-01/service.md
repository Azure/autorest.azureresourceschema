# Microsoft.ApiManagement/service template reference
API Version: 2017-03-01
## Template format

To create a Microsoft.ApiManagement/service resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service",
  "apiVersion": "2017-03-01",
  "tags": {},
  "properties": {
    "notificationSenderEmail": "string",
    "hostnameConfigurations": [
      {
        "type": "string",
        "hostName": "string",
        "keyVaultId": "string",
        "encodedCertificate": "string",
        "certificatePassword": "string",
        "defaultSslBinding": boolean,
        "negotiateClientCertificate": boolean
      }
    ],
    "virtualNetworkConfiguration": {
      "subnetResourceId": "string"
    },
    "additionalLocations": [
      {
        "location": "string",
        "sku": {
          "name": "string",
          "capacity": "integer"
        },
        "virtualNetworkConfiguration": {
          "subnetResourceId": "string"
        }
      }
    ],
    "customProperties": {},
    "certificates": [
      {
        "encodedCertificate": "string",
        "certificatePassword": "string",
        "storeName": "string"
      }
    ],
    "virtualNetworkType": "string",
    "publisherEmail": "string",
    "publisherName": "string"
  },
  "sku": {
    "name": "string",
    "capacity": "integer"
  },
  "identity": {
    "type": "SystemAssigned"
  },
  "location": "string",
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
|  apiVersion | enum | Yes | 2017-03-01 |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Properties of the API Management service. - [ApiManagementServiceProperties object](#ApiManagementServiceProperties) |
|  sku | object | Yes | SKU properties of the API Management service. - [ApiManagementServiceSkuProperties object](#ApiManagementServiceSkuProperties) |
|  identity | object | No | Managed service identity of the Api Management service. - [ApiManagementServiceIdentity object](#ApiManagementServiceIdentity) |
|  location | string | Yes | Resource location. |
|  resources | array | No | [users](./service/users.md) [subscriptions](./service/subscriptions.md) [properties](./service/properties.md) [products](./service/products.md) [openidConnectProviders](./service/openidConnectProviders.md) [notifications](./service/notifications.md) [loggers](./service/loggers.md) [identityProviders](./service/identityProviders.md) [groups](./service/groups.md) [templates](./service/templates.md) [certificates](./service/certificates.md) [backends](./service/backends.md) [authorizationServers](./service/authorizationServers.md) [apis](./service/apis.md) [policies](./service/policies.md) |


<a id="ApiManagementServiceProperties" />
### ApiManagementServiceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  notificationSenderEmail | string | No | Email address from which the notification will be sent. |
|  hostnameConfigurations | array | No | Custom hostname configuration of the API Management service. - [HostnameConfiguration object](#HostnameConfiguration) |
|  virtualNetworkConfiguration | object | No | Virtual network configuration of the API Management service. - [VirtualNetworkConfiguration object](#VirtualNetworkConfiguration) |
|  additionalLocations | array | No | Additional datacenter locations of the API Management service. - [AdditionalLocation object](#AdditionalLocation) |
|  customProperties | object | No | Custom properties of the API Management service. Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2). Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1 and setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API Management service. |
|  certificates | array | No | List of Certificates that need to be installed in the API Management service. Max supported certificates that can be installed is 10. - [CertificateConfiguration object](#CertificateConfiguration) |
|  virtualNetworkType | enum | No | The type of VPN in which API Managemet service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only. - None, External, Internal |
|  publisherEmail | string | Yes | Publisher email. |
|  publisherName | string | Yes | Publisher name. |


<a id="ApiManagementServiceSkuProperties" />
### ApiManagementServiceSkuProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | Name of the Sku. - Developer, Standard, Premium, Basic |
|  capacity | integer | No | Capacity of the SKU (number of deployed units of the SKU). The default value is 1. |


<a id="ApiManagementServiceIdentity" />
### ApiManagementServiceIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | Yes | The identity type. Currently the only supported type is 'SystemAssigned'. - SystemAssigned |


<a id="HostnameConfiguration" />
### HostnameConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | Yes | Hostname type. - Proxy, Portal, Management, Scm |
|  hostName | string | Yes | Hostname to configure on the Api Management service. |
|  keyVaultId | string | No | Url to the KeyVault Secret containing the Ssl Certificate. If absolute Url containing version is provided, auto-update of ssl certificate will not work. This requires Api Management service to be configured with MSI. The secret should be of type *application/x-pkcs12* |
|  encodedCertificate | string | No | Base64 Encoded certificate. |
|  certificatePassword | string | No | Certificate Password. |
|  defaultSslBinding | boolean | No | Specify true to setup the certificate associated with this Hostname as the Default SSL Certificate. If a client does not send the SNI header, then this will be the certificate that will be challenged. The property is useful if a service has multiple custom hostname enabled and it needs to decide on the default ssl certificate. The setting only applied to Proxy Hostname Type. |
|  negotiateClientCertificate | boolean | No | Specify true to always negotiate client certificate on the hostname. Default Value is false. |


<a id="VirtualNetworkConfiguration" />
### VirtualNetworkConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  subnetResourceId | string | No | The full resource ID of a subnet in a virtual network to deploy the API Management service in. |


<a id="AdditionalLocation" />
### AdditionalLocation object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  location | string | Yes | The location name of the additional region among Azure Data center regions. |
|  sku | object | Yes | SKU properties of the API Management service. - [ApiManagementServiceSkuProperties object](#ApiManagementServiceSkuProperties) |
|  virtualNetworkConfiguration | object | No | Virtual network configuration for the location. - [VirtualNetworkConfiguration object](#VirtualNetworkConfiguration) |


<a id="CertificateConfiguration" />
### CertificateConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  encodedCertificate | string | No | Base64 Encoded certificate. |
|  certificatePassword | string | No | Certificate Password. |
|  storeName | enum | Yes | The local certificate store location. Only Root and CertificateAuthority are valid locations. - CertificateAuthority or Root |

