# Microsoft.Network/routeTables/routes template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Network/routeTables/routes resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/routeTables/routes",
  "apiVersion": "2017-09-01",
  "id": "string",
  "properties": {
    "addressPrefix": "string",
    "nextHopType": "string",
    "nextHopIpAddress": "string",
    "provisioningState": "string"
  },
  "etag": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/routeTables/routes" />
### Microsoft.Network/routeTables/routes object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/routeTables/routes |
|  apiVersion | enum | Yes | 2017-09-01 |
|  id | string | No | Resource ID. |
|  properties | object | Yes | Properties of the route. - [RoutePropertiesFormat object](#RoutePropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="RoutePropertiesFormat" />
### RoutePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The destination CIDR to which the route applies. |
|  nextHopType | enum | Yes | The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'. - VirtualNetworkGateway, VnetLocal, Internet, VirtualAppliance, None |
|  nextHopIpAddress | string | No | The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. |
|  provisioningState | string | No | The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |

