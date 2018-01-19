# Microsoft.Network/virtualNetworks/virtualNetworkPeerings template reference
API Version: 2017-08-01
## Template format

To create a Microsoft.Network/virtualNetworks/virtualNetworkPeerings resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/virtualNetworks/virtualNetworkPeerings",
  "apiVersion": "2017-08-01",
  "id": "string",
  "properties": {
    "allowVirtualNetworkAccess": boolean,
    "allowForwardedTraffic": boolean,
    "allowGatewayTransit": boolean,
    "useRemoteGateways": boolean,
    "remoteVirtualNetwork": {
      "id": "string"
    },
    "peeringState": "string",
    "provisioningState": "string"
  },
  "etag": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/virtualNetworks/virtualNetworkPeerings" />
### Microsoft.Network/virtualNetworks/virtualNetworkPeerings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/virtualNetworks/virtualNetworkPeerings |
|  apiVersion | enum | Yes | 2017-08-01 |
|  id | string | No | Resource ID. |
|  properties | object | Yes | Properties of the virtual network peering. - [VirtualNetworkPeeringPropertiesFormat object](#VirtualNetworkPeeringPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="VirtualNetworkPeeringPropertiesFormat" />
### VirtualNetworkPeeringPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allowVirtualNetworkAccess | boolean | No | Whether the VMs in the linked virtual network space would be able to access all the VMs in local Virtual network space. |
|  allowForwardedTraffic | boolean | No | Whether the forwarded traffic from the VMs in the remote virtual network will be allowed/disallowed. |
|  allowGatewayTransit | boolean | No | If gateway links can be used in remote virtual networking to link to this virtual network. |
|  useRemoteGateways | boolean | No | If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway. |
|  remoteVirtualNetwork | object | No | The reference of the remote virtual network. - [SubResource object](#SubResource) |
|  peeringState | enum | No | The status of the virtual network peering. Possible values are 'Initiated', 'Connected', and 'Disconnected'. - Initiated, Connected, Disconnected |
|  provisioningState | string | No | The provisioning state of the resource. |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |

