# Microsoft.Network/connections template reference
API Version: 2016-03-30
## Template format

To create a Microsoft.Network/connections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/connections",
  "apiVersion": "2016-03-30",
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
              "privateIPAddress": "string",
              "privateIPAllocationMethod": "string",
              "subnet": {
                "id": "string"
              },
              "publicIPAddress": {
                "id": "string"
              },
              "provisioningState": "string"
            },
            "name": "string",
            "etag": "string"
          }
        ],
        "gatewayType": "string",
        "vpnType": "string",
        "enableBgp": boolean,
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
                "publicCertData": "string",
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "vpnClientRevokedCertificates": [
            {
              "id": "string",
              "properties": {
                "thumbprint": "string",
                "provisioningState": "string"
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
        "resourceGuid": "string",
        "provisioningState": "string"
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
              "privateIPAddress": "string",
              "privateIPAllocationMethod": "string",
              "subnet": {
                "id": "string"
              },
              "publicIPAddress": {
                "id": "string"
              },
              "provisioningState": "string"
            },
            "name": "string",
            "etag": "string"
          }
        ],
        "gatewayType": "string",
        "vpnType": "string",
        "enableBgp": boolean,
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
                "publicCertData": "string",
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "vpnClientRevokedCertificates": [
            {
              "id": "string",
              "properties": {
                "thumbprint": "string",
                "provisioningState": "string"
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
        "resourceGuid": "string",
        "provisioningState": "string"
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
        "resourceGuid": "string",
        "provisioningState": "string"
      },
      "etag": "string"
    },
    "connectionType": "string",
    "routingWeight": "integer",
    "sharedKey": "string",
    "connectionStatus": "string",
    "egressBytesTransferred": "integer",
    "ingressBytesTransferred": "integer",
    "peer": {
      "id": "string"
    },
    "enableBgp": boolean,
    "resourceGuid": "string",
    "provisioningState": "string"
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
|  apiVersion | enum | Yes | 2016-03-30 |
|  id | string | No | Resource Id |
|  location | string | No | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | [VirtualNetworkGatewayConnectionPropertiesFormat object](#VirtualNetworkGatewayConnectionPropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated |


<a id="VirtualNetworkGatewayConnectionPropertiesFormat" />
### VirtualNetworkGatewayConnectionPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationKey | string | No | The authorizationKey. |
|  virtualNetworkGateway1 | object | No | [VirtualNetworkGateway object](#VirtualNetworkGateway) |
|  virtualNetworkGateway2 | object | No | [VirtualNetworkGateway object](#VirtualNetworkGateway) |
|  localNetworkGateway2 | object | No | [LocalNetworkGateway object](#LocalNetworkGateway) |
|  connectionType | enum | No | Gateway connection type -Ipsec/Dedicated/VpnClient/Vnet2Vnet. - IPsec, Vnet2Vnet, ExpressRoute, VPNClient |
|  routingWeight | integer | No | The Routing weight. |
|  sharedKey | string | No | The Ipsec share key. |
|  connectionStatus | enum | No | Virtual network Gateway connection status. - Unknown, Connecting, Connected, NotConnected |
|  egressBytesTransferred | integer | No | The Egress Bytes Transferred in this connection |
|  ingressBytesTransferred | integer | No | The Ingress Bytes Transferred in this connection |
|  peer | object | No | The reference to peerings resource. - [SubResource object](#SubResource) |
|  enableBgp | boolean | No | EnableBgp Flag |
|  resourceGuid | string | No | Gets or sets resource guid property of the VirtualNetworkGatewayConnection resource |
|  provisioningState | string | No | Gets or sets Provisioning state of the VirtualNetworkGatewayConnection resource Updating/Deleting/Failed |


<a id="VirtualNetworkGateway" />
### VirtualNetworkGateway object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  location | string | No | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | No | [VirtualNetworkGatewayPropertiesFormat object](#VirtualNetworkGatewayPropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated |


<a id="LocalNetworkGateway" />
### LocalNetworkGateway object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  location | string | No | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | No | [LocalNetworkGatewayPropertiesFormat object](#LocalNetworkGatewayPropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |


<a id="VirtualNetworkGatewayPropertiesFormat" />
### VirtualNetworkGatewayPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ipConfigurations | array | No | IpConfigurations for Virtual network gateway. - [VirtualNetworkGatewayIPConfiguration object](#VirtualNetworkGatewayIPConfiguration) |
|  gatewayType | enum | No | The type of this virtual network gateway. - Vpn or ExpressRoute |
|  vpnType | enum | No | The type of this virtual network gateway. - PolicyBased or RouteBased |
|  enableBgp | boolean | No | EnableBgp Flag |
|  gatewayDefaultSite | object | No | Gets or sets the reference of the LocalNetworkGateway resource which represents Local network site having default routes. Assign Null value in case of removing existing default site setting. - [SubResource object](#SubResource) |
|  sku | object | No | Gets or sets the reference of the VirtualNetworkGatewaySku resource which represents the sku selected for Virtual network gateway. - [VirtualNetworkGatewaySku object](#VirtualNetworkGatewaySku) |
|  vpnClientConfiguration | object | No | Gets or sets the reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations. - [VpnClientConfiguration object](#VpnClientConfiguration) |
|  bgpSettings | object | No | Virtual network gateway's BGP speaker settings - [BgpSettings object](#BgpSettings) |
|  resourceGuid | string | No | Gets or sets resource guid property of the VirtualNetworkGateway resource |
|  provisioningState | string | No | Gets or sets Provisioning state of the VirtualNetworkGateway resource Updating/Deleting/Failed |


<a id="LocalNetworkGatewayPropertiesFormat" />
### LocalNetworkGatewayPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  localNetworkAddressSpace | object | No | Local network site Address space - [AddressSpace object](#AddressSpace) |
|  gatewayIpAddress | string | No | IP address of local network gateway. |
|  bgpSettings | object | No | Local network gateway's BGP speaker settings - [BgpSettings object](#BgpSettings) |
|  resourceGuid | string | No | Gets or sets resource guid property of the LocalNetworkGateway resource |
|  provisioningState | string | No | Gets or sets Provisioning state of the LocalNetworkGateway resource Updating/Deleting/Failed |


<a id="VirtualNetworkGatewayIPConfiguration" />
### VirtualNetworkGatewayIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  properties | object | No | [VirtualNetworkGatewayIPConfigurationPropertiesFormat object](#VirtualNetworkGatewayIPConfigurationPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated |


<a id="VirtualNetworkGatewaySku" />
### VirtualNetworkGatewaySku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Gateway sku name -Basic/HighPerformance/Standard. - Basic, HighPerformance, Standard |
|  tier | enum | No | Gateway sku tier -Basic/HighPerformance/Standard. - Basic, HighPerformance, Standard |
|  capacity | integer | No | The capacity |


<a id="VpnClientConfiguration" />
### VpnClientConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vpnClientAddressPool | object | No | Gets or sets the reference of the Address space resource which represents Address space for P2S VpnClient. - [AddressSpace object](#AddressSpace) |
|  vpnClientRootCertificates | array | No | VpnClientRootCertificate for Virtual network gateway. - [VpnClientRootCertificate object](#VpnClientRootCertificate) |
|  vpnClientRevokedCertificates | array | No | VpnClientRevokedCertificate for Virtual network gateway. - [VpnClientRevokedCertificate object](#VpnClientRevokedCertificate) |


<a id="BgpSettings" />
### BgpSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  asn | integer | No | Gets or sets this BGP speaker's ASN |
|  bgpPeeringAddress | string | No | Gets or sets the BGP peering address and BGP identifier of this BGP speaker |
|  peerWeight | integer | No | Gets or sets the weight added to routes learned from this BGP speaker |


<a id="AddressSpace" />
### AddressSpace object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefixes | array | No | Gets or sets List of address blocks reserved for this virtual network in CIDR notation - string |


<a id="VirtualNetworkGatewayIPConfigurationPropertiesFormat" />
### VirtualNetworkGatewayIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  privateIPAddress | string | No | Gets or sets the privateIPAddress of the IP Configuration |
|  privateIPAllocationMethod | enum | No | Gets or sets PrivateIP allocation method (Static/Dynamic). - Static or Dynamic |
|  subnet | object | No | Gets or sets the reference of the subnet resource - [SubResource object](#SubResource) |
|  publicIPAddress | object | No | Gets or sets the reference of the PublicIP resource - [SubResource object](#SubResource) |
|  provisioningState | string | No | Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed |


<a id="VpnClientRootCertificate" />
### VpnClientRootCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  properties | object | No | [VpnClientRootCertificatePropertiesFormat object](#VpnClientRootCertificatePropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated |


<a id="VpnClientRevokedCertificate" />
### VpnClientRevokedCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  properties | object | No | [VpnClientRevokedCertificatePropertiesFormat object](#VpnClientRevokedCertificatePropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated |


<a id="VpnClientRootCertificatePropertiesFormat" />
### VpnClientRootCertificatePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicCertData | string | No | Gets or sets the certificate public data |
|  provisioningState | string | No | Gets or sets Provisioning state of the VPN client root certificate resource Updating/Deleting/Failed |


<a id="VpnClientRevokedCertificatePropertiesFormat" />
### VpnClientRevokedCertificatePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thumbprint | string | No | Gets or sets the revoked Vpn client certificate thumbprint |
|  provisioningState | string | No | Gets or sets Provisioning state of the VPN client revoked certificate resource Updating/Deleting/Failed |

