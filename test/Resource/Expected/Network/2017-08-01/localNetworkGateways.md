# Microsoft.Network/localNetworkGateways template reference
API Version: 2017-08-01
## Template format

To create a Microsoft.Network/localNetworkGateways resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/localNetworkGateways",
  "apiVersion": "2017-08-01",
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
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/localNetworkGateways" />
### Microsoft.Network/localNetworkGateways object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/localNetworkGateways |
|  apiVersion | enum | Yes | 2017-08-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Properties of the local network gateway. - [LocalNetworkGatewayPropertiesFormat object](#LocalNetworkGatewayPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="LocalNetworkGatewayPropertiesFormat" />
### LocalNetworkGatewayPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  localNetworkAddressSpace | object | No | Local network site address space. - [AddressSpace object](#AddressSpace) |
|  gatewayIpAddress | string | No | IP address of local network gateway. |
|  bgpSettings | object | No | Local network gateway's BGP speaker settings. - [BgpSettings object](#BgpSettings) |
|  resourceGuid | string | No | The resource GUID property of the LocalNetworkGateway resource. |


<a id="AddressSpace" />
### AddressSpace object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefixes | array | No | A list of address blocks reserved for this virtual network in CIDR notation. - string |


<a id="BgpSettings" />
### BgpSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  asn | integer | No | The BGP speaker's ASN. |
|  bgpPeeringAddress | string | No | The BGP peering address and BGP identifier of this BGP speaker. |
|  peerWeight | integer | No | The weight added to routes learned from this BGP speaker. |

