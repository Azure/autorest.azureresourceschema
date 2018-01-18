# Microsoft.Web/sites/virtualNetworkConnections/gateways template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/virtualNetworkConnections/gateways resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/virtualNetworkConnections/gateways",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "vnetName": "string",
    "vpnPackageUri": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/virtualNetworkConnections/gateways" />
### Microsoft.Web/sites/virtualNetworkConnections/gateways object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/virtualNetworkConnections/gateways |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | VnetGateway resource specific properties - [VnetGateway_properties object](#VnetGateway_properties) |


<a id="VnetGateway_properties" />
### VnetGateway_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vnetName | string | No | The Virtual Network name. |
|  vpnPackageUri | string | Yes | The URI where the VPN package can be downloaded. |

