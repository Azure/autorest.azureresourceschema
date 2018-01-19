# Microsoft.Web/sites/slots/virtualNetworkConnections template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/slots/virtualNetworkConnections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/slots/virtualNetworkConnections",
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

<a id="Microsoft.Web/sites/slots/virtualNetworkConnections" />
### Microsoft.Web/sites/slots/virtualNetworkConnections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/slots/virtualNetworkConnections |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | VnetInfo resource specific properties - [VnetInfoProperties object](#VnetInfoProperties) |
|  resources | array | No | [gateways](./virtualNetworkConnections/gateways.md) |


<a id="VnetInfoProperties" />
### VnetInfoProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vnetResourceId | string | No | The Virtual Network's resource ID. |
|  certBlob | array | No | A certificate file (.cer) blob containing the public key of the private key used to authenticate a Point-To-Site VPN connection. - integer |
|  dnsServers | string | No | DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. |

