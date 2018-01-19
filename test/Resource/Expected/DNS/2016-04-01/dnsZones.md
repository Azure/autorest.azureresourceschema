# Microsoft.Network/dnsZones template reference
API Version: 2016-04-01
## Template format

To create a Microsoft.Network/dnsZones resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/dnsZones",
  "apiVersion": "2016-04-01",
  "location": "string",
  "tags": {},
  "etag": "string",
  "properties": {
    "maxNumberOfRecordSets": "integer",
    "numberOfRecordSets": "integer"
  },
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
|  apiVersion | enum | Yes | 2016-04-01 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  etag | string | No | The etag of the zone. |
|  properties | object | Yes | The properties of the zone. - [ZoneProperties object](#ZoneProperties) |
|  resources | array | No | [TXT](./dnsZones/TXT.md) [SRV](./dnsZones/SRV.md) [SOA](./dnsZones/SOA.md) [PTR](./dnsZones/PTR.md) [NS](./dnsZones/NS.md) [MX](./dnsZones/MX.md) [CNAME](./dnsZones/CNAME.md) [AAAA](./dnsZones/AAAA.md) [A](./dnsZones/A.md) |


<a id="ZoneProperties" />
### ZoneProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxNumberOfRecordSets | integer | No | The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. |
|  numberOfRecordSets | integer | No | The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. |

