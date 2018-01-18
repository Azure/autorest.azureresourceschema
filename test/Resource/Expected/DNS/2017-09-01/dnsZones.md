# Microsoft.Network/dnsZones template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Network/dnsZones resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/dnsZones",
  "apiVersion": "2017-09-01",
  "location": "string",
  "tags": {},
  "etag": "string",
  "properties": {},
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/dnsZones" />
### Microsoft.Network/dnsZones object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/dnsZones |
|  apiVersion | enum | Yes | 2017-09-01 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  etag | string | No | The etag of the zone. |
|  properties | object | Yes | The properties of the zone. - [ZoneProperties object](#ZoneProperties) |
|  resources | array | No | [TXT](./dnsZones/TXT.md) [SRV](./dnsZones/SRV.md) [SOA](./dnsZones/SOA.md) [PTR](./dnsZones/PTR.md) [NS](./dnsZones/NS.md) [MX](./dnsZones/MX.md) [CNAME](./dnsZones/CNAME.md) [CAA](./dnsZones/CAA.md) [AAAA](./dnsZones/AAAA.md) [A](./dnsZones/A.md) |

