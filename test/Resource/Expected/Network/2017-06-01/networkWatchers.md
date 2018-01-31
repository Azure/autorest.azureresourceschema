# Microsoft.Network/networkWatchers template reference
API Version: 2017-06-01
## Template format

To create a Microsoft.Network/networkWatchers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/networkWatchers",
  "apiVersion": "2017-06-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "etag": "string",
  "properties": {},
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/networkWatchers" />
### Microsoft.Network/networkWatchers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/networkWatchers |
|  apiVersion | enum | Yes | 2017-06-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  properties | object | Yes | [NetworkWatcherPropertiesFormat object](#NetworkWatcherPropertiesFormat) |
|  resources | array | No | [packetCaptures](./networkWatchers/packetCaptures.md) |

