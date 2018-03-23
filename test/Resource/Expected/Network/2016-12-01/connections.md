# Microsoft.Network/connections template reference
API Version: 2016-12-01
## Template format

To create a Microsoft.Network/connections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/connections",
  "apiVersion": "2016-12-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "authorizationKey": "string",
    "virtualNetworkGateway1": {
      "id": "string",
      "location": "string",
      "tags": {},
      "properties": {
        "ipConfigurations": [
          {
            "id": "string",
            "properties": {
              "privateIPAllocationMethod": "string",
              "subnet": {
                "id": "string"
              },
              "publicIPAddress": {
                "id": "string"
              }
            },
            "name": "string",
            "etag": "string"
          }
        ],
        "gatewayType": "string",
        "vpnType": "string",
        "enableBgp": boolean,
        "activeActive": boolean,
        "gatewayDefaultSite": {
          "id": "string"
        },
        "sku": {
          "name": "string",
          "tier": "string",
          "capacity": "integer"
        },
        "vpnClientConfiguration": {
          "vpnClientAddressPool": {
            "addressPrefixes": [
              "string"
            ]
          },
          "vpnClientRootCertificates": [
            {
              "id": "string",
              "properties": {
                "publicCertData": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "vpnClientRevokedCertificates": [
            {
              "id": "string",
              "properties": {
                "thumbprint": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ]
        },
        "bgpSettings": {
          "asn": "integer",
          "bgpPeeringAddress": "string",
          "peerWeight": "integer"
        },
        "resourceGuid": "string"
      },
      "etag": "string"
    },
    "virtualNetworkGateway2": {
      "id": "string",
      "location": "string",
      "tags": {},
      "properties": {
        "ipConfigurations": [
          {
            "id": "string",
            "properties": {
              "privateIPAllocationMethod": "string",
              "subnet": {
                "id": "string"
              },
              "publicIPAddress": {
                "id": "string"
              }
            },
            "name": "string",
            "etag": "string"
          }
        ],
        "gatewayType": "string",
        "vpnType": "string",
        "enableBgp": boolean,
        "activeActive": boolean,
        "gatewayDefaultSite": {
          "id": "string"
        },
        "sku": {
          "name": "string",
          "tier": "string",
          "capacity": "integer"
        },
        "vpnClientConfiguration": {
          "vpnClientAddressPool": {
            "addressPrefixes": [
              "string"
            ]
          },
          "vpnClientRootCertificates": [
            {
              "id": "string",
              "properties": {
                "publicCertData": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "vpnClientRevokedCertificates": [
            {
              "id": "string",
              "properties": {
                "thumbprint": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ]
        },
        "bgpSettings": {
          "asn": "integer",
          "bgpPeeringAddress": "string",
          "peerWeight": "integer"
        },
        "resourceGuid": "string"
      },
      "etag": "string"
    },
    "localNetworkGateway2": {
      "id": "string",
      "location": "string",
      "tags": {},
      "properties": {
        "localNetworkAddressSpace": {
          "addressPrefixes": [
            "string"
          ]
        },
        "gatewayIpAddress": "string",
        "bgpSettings": {
          "asn": "integer",
          "bgpPeeringAddress": "string",
          "peerWeight": "integer"
        },
        "resourceGuid": "string"
      },
      "etag": "string"
    },
    "connectionType": "string",
    "routingWeight": "integer",
    "sharedKey": "string",
    "peer": {
      "id": "string"
    },
    "enableBgp": boolean,
    "resourceGuid": "string"
  },
  "etag": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/connections" />
### Microsoft.Network/connections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/connections |
|  apiVersion | enum | Yes | 2016-12-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [VirtualNetworkGatewayConnectionPropertiesFormat object](#VirtualNetworkGatewayConnectionPropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated. |


<a id="VirtualNetworkGatewayConnectionPropertiesFormat" />
### VirtualNetworkGatewayConnectionPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationKey | string | No | The authorizationKey. |
|  virtualNetworkGateway1 | object | Yes | [VirtualNetworkGateway object](#VirtualNetworkGateway) |
|  virtualNetworkGateway2 | object | No | [VirtualNetworkGateway object](#VirtualNetworkGateway) |
|  localNetworkGateway2 | object | No | [LocalNetworkGateway object](#LocalNetworkGateway) |
|  connectionType | enum | Yes | Gateway connection type. Possible values are: 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient. - IPsec, Vnet2Vnet, ExpressRoute, VPNClient |
|  routingWeight | integer | No | The routing weight. |
|  sharedKey | string | No | The IPSec shared key. |
|  peer | object | No | The reference to peerings resource. - [SubResource object](#SubResource) |
|  enableBgp | boolean | No | EnableBgp flag |
|  resourceGuid | string | No | The resource GUID property of the VirtualNetworkGatewayConnection resource. |


<a id="VirtualNetworkGateway" />
### VirtualNetworkGateway object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [VirtualNetworkGatewayPropertiesFormat object](#VirtualNetworkGatewayPropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated. |


<a id="LocalNetworkGateway" />
### LocalNetworkGateway object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [LocalNetworkGatewayPropertiesFormat object](#LocalNetworkGatewayPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |


<a id="VirtualNetworkGatewayPropertiesFormat" />
### VirtualNetworkGatewayPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ipConfigurations | array | No | IP configurations for virtual network gateway. - [VirtualNetworkGatewayIPConfiguration object](#VirtualNetworkGatewayIPConfiguration) |
|  gatewayType | enum | No | The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'. - Vpn or ExpressRoute |
|  vpnType | enum | No | The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'. - PolicyBased or RouteBased |
|  enableBgp | boolean | No | Whether BGP is enabled for this virtual network gateway or not. |
|  activeActive | boolean | No | ActiveActive flag |
|  gatewayDefaultSite | object | No | The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting. - [SubResource object](#SubResource) |
|  sku | object | No | The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway. - [VirtualNetworkGatewaySku object](#VirtualNetworkGatewaySku) |
|  vpnClientConfiguration | object | No | The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations. - [VpnClientConfiguration object](#VpnClientConfiguration) |
|  bgpSettings | object | No | Virtual network gateway's BGP speaker settings. - [BgpSettings object](#BgpSettings) |
|  resourceGuid | string | No | The resource GUID property of the VirtualNetworkGateway resource. |


<a id="LocalNetworkGatewayPropertiesFormat" />
### LocalNetworkGatewayPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  localNetworkAddressSpace | object | No | Local network site address space. - [AddressSpace object](#AddressSpace) |
|  gatewayIpAddress | string | No | IP address of local network gateway. |
|  bgpSettings | object | No | Local network gateway's BGP speaker settings. - [BgpSettings object](#BgpSettings) |
|  resourceGuid | string | No | The resource GUID property of the LocalNetworkGateway resource. |


<a id="VirtualNetworkGatewayIPConfiguration" />
### VirtualNetworkGatewayIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [VirtualNetworkGatewayIPConfigurationPropertiesFormat object](#VirtualNetworkGatewayIPConfigurationPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="VirtualNetworkGatewaySku" />
### VirtualNetworkGatewaySku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Gateway SKU name. Possible values are: 'Basic', 'HighPerformance','Standard', and 'UltraPerformance'. - Basic, HighPerformance, Standard, UltraPerformance |
|  tier | enum | No | Gateway SKU tier. Possible values are: 'Basic', 'HighPerformance','Standard', and 'UltraPerformance'. - Basic, HighPerformance, Standard, UltraPerformance |
|  capacity | integer | No | The capacity. |


<a id="VpnClientConfiguration" />
### VpnClientConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vpnClientAddressPool | object | No | The reference of the address space resource which represents Address space for P2S VpnClient. - [AddressSpace object](#AddressSpace) |
|  vpnClientRootCertificates | array | No | VpnClientRootCertificate for virtual network gateway. - [VpnClientRootCertificate object](#VpnClientRootCertificate) |
|  vpnClientRevokedCertificates | array | No | VpnClientRevokedCertificate for Virtual network gateway. - [VpnClientRevokedCertificate object](#VpnClientRevokedCertificate) |


<a id="BgpSettings" />
### BgpSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  asn | integer | No | The BGP speaker's ASN. |
|  bgpPeeringAddress | string | No | The BGP peering address and BGP identifier of this BGP speaker. |
|  peerWeight | integer | No | The weight added to routes learned from this BGP speaker. |


<a id="AddressSpace" />
### AddressSpace object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefixes | array | No | A list of address blocks reserved for this virtual network in CIDR notation. - string |


<a id="VirtualNetworkGatewayIPConfigurationPropertiesFormat" />
### VirtualNetworkGatewayIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  privateIPAllocationMethod | enum | No | The private IP allocation method. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  subnet | object | No | The reference of the subnet resource. - [SubResource object](#SubResource) |
|  publicIPAddress | object | No | The reference of the public IP resource. - [SubResource object](#SubResource) |


<a id="VpnClientRootCertificate" />
### VpnClientRootCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | Yes | [VpnClientRootCertificatePropertiesFormat object](#VpnClientRootCertificatePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="VpnClientRevokedCertificate" />
### VpnClientRevokedCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [VpnClientRevokedCertificatePropertiesFormat object](#VpnClientRevokedCertificatePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="VpnClientRootCertificatePropertiesFormat" />
### VpnClientRootCertificatePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicCertData | string | Yes | The certificate public data. |


<a id="VpnClientRevokedCertificatePropertiesFormat" />
### VpnClientRevokedCertificatePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thumbprint | string | No | The revoked VPN client certificate thumbprint. |
