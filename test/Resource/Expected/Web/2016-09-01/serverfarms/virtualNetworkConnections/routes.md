# Microsoft.Web/serverfarms/virtualNetworkConnections/routes template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Web/serverfarms/virtualNetworkConnections/routes resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/serverfarms/virtualNetworkConnections/routes",
  "apiVersion": "2016-09-01",
  "kind": "string",
  "properties": {
    "name": "string",
    "startAddress": "string",
    "endAddress": "string",
    "routeType": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/serverfarms/virtualNetworkConnections/routes" />
### Microsoft.Web/serverfarms/virtualNetworkConnections/routes object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/serverfarms/virtualNetworkConnections/routes |
|  apiVersion | enum | Yes | 2016-09-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | VnetRoute resource specific properties - [VnetRoute_properties object](#VnetRoute_properties) |


<a id="VnetRoute_properties" />
### VnetRoute_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name of this route. This is only returned by the server and does not need to be set by the client. |
|  startAddress | string | No | The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified. |
|  endAddress | string | No | The ending address for this route. If the start address is specified in CIDR notation, this must be omitted. |
|  routeType | enum | No | The type of route this is:DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918INHERITED - Routes inherited from the real Virtual Network routesSTATIC - Static route set on the app onlyThese values will be used for syncing an app's routes with those from a Virtual Network. - DEFAULT, INHERITED, STATIC |

