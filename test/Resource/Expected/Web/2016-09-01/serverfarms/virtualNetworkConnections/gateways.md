# Microsoft.Web/serverfarms/virtualNetworkConnections/gateways template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Web/serverfarms/virtualNetworkConnections/gateways resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/serverfarms/virtualNetworkConnections/gateways",
  "apiVersion": "2016-09-01",
  "kind": "string",
  "properties": {
    "vnetName": "string",
    "vpnPackageUri": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/serverfarms/virtualNetworkConnections/gateways" />
### Microsoft.Web/serverfarms/virtualNetworkConnections/gateways object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/serverfarms/virtualNetworkConnections/gateways |
|  apiVersion | enum | Yes | 2016-09-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | VnetGateway resource specific properties - [VnetGateway_properties object](#VnetGateway_properties) |


<a id="VnetGateway_properties" />
### VnetGateway_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vnetName | string | No | The Virtual Network name. |
|  vpnPackageUri | string | Yes | The URI where the VPN package can be downloaded. |

