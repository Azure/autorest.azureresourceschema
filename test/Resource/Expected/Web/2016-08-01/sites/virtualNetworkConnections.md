# Microsoft.Web/sites/virtualNetworkConnections template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/virtualNetworkConnections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/virtualNetworkConnections",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "vnetResourceId": "string",
    "certBlob": [
      "integer"
    ],
    "dnsServers": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/virtualNetworkConnections" />
### Microsoft.Web/sites/virtualNetworkConnections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/virtualNetworkConnections |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | VnetInfo resource specific properties - [VnetInfo_properties object](#VnetInfo_properties) |
|  resources | array | No | [gateways](./virtualNetworkConnections/gateways.md) |


<a id="VnetInfo_properties" />
### VnetInfo_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vnetResourceId | string | No | The Virtual Network's resource ID. |
|  certBlob | array | No | A certificate file (.cer) blob containing the public key of the private key used to authenticate a Point-To-Site VPN connection. - integer |
|  dnsServers | string | No | DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. |

