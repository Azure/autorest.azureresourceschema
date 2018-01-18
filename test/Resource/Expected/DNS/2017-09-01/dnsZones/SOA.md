# Microsoft.Network/dnsZones/SOA template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Network/dnsZones/SOA resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/dnsZones/SOA",
  "apiVersion": "2017-09-01",
  "etag": "string",
  "properties": {
    "metadata": {},
    "TTL": "integer",
    "ARecords": [
      {
        "ipv4Address": "string"
      }
    ],
    "AAAARecords": [
      {
        "ipv6Address": "string"
      }
    ],
    "MXRecords": [
      {
        "preference": "integer",
        "exchange": "string"
      }
    ],
    "NSRecords": [
      {
        "nsdname": "string"
      }
    ],
    "PTRRecords": [
      {
        "ptrdname": "string"
      }
    ],
    "SRVRecords": [
      {
        "priority": "integer",
        "weight": "integer",
        "port": "integer",
        "target": "string"
      }
    ],
    "TXTRecords": [
      {
        "value": [
          "string"
        ]
      }
    ],
    "CNAMERecord": {
      "cname": "string"
    },
    "SOARecord": {
      "host": "string",
      "email": "string",
      "serialNumber": "integer",
      "refreshTime": "integer",
      "retryTime": "integer",
      "expireTime": "integer",
      "minimumTTL": "integer"
    },
    "caaRecords": [
      {
        "flags": "integer",
        "tag": "string",
        "value": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/dnsZones/SOA" />
### Microsoft.Network/dnsZones/SOA object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/dnsZones/SOA |
|  apiVersion | enum | Yes | 2017-09-01 |
|  etag | string | No | The etag of the record set. |
|  properties | object | Yes | The properties of the record set. - [RecordSetProperties object](#RecordSetProperties) |


<a id="RecordSetProperties" />
### RecordSetProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  metadata | object | No | The metadata attached to the record set. |
|  TTL | integer | No | The TTL (time-to-live) of the records in the record set. |
|  ARecords | array | No | The list of A records in the record set. - [ARecord object](#ARecord) |
|  AAAARecords | array | No | The list of AAAA records in the record set. - [AaaaRecord object](#AaaaRecord) |
|  MXRecords | array | No | The list of MX records in the record set. - [MxRecord object](#MxRecord) |
|  NSRecords | array | No | The list of NS records in the record set. - [NsRecord object](#NsRecord) |
|  PTRRecords | array | No | The list of PTR records in the record set. - [PtrRecord object](#PtrRecord) |
|  SRVRecords | array | No | The list of SRV records in the record set. - [SrvRecord object](#SrvRecord) |
|  TXTRecords | array | No | The list of TXT records in the record set. - [TxtRecord object](#TxtRecord) |
|  CNAMERecord | object | No | The CNAME record in the  record set. - [CnameRecord object](#CnameRecord) |
|  SOARecord | object | No | The SOA record in the record set. - [SoaRecord object](#SoaRecord) |
|  caaRecords | array | No | The list of CAA records in the record set. - [CaaRecord object](#CaaRecord) |


<a id="ARecord" />
### ARecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ipv4Address | string | No | The IPv4 address of this A record. |


<a id="AaaaRecord" />
### AaaaRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ipv6Address | string | No | The IPv6 address of this AAAA record. |


<a id="MxRecord" />
### MxRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  preference | integer | No | The preference value for this MX record. |
|  exchange | string | No | The domain name of the mail host for this MX record. |


<a id="NsRecord" />
### NsRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  nsdname | string | No | The name server name for this NS record. |


<a id="PtrRecord" />
### PtrRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ptrdname | string | No | The PTR target domain name for this PTR record. |


<a id="SrvRecord" />
### SrvRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  priority | integer | No | The priority value for this SRV record. |
|  weight | integer | No | The weight value for this SRV record. |
|  port | integer | No | The port value for this SRV record. |
|  target | string | No | The target domain name for this SRV record. |


<a id="TxtRecord" />
### TxtRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  value | array | No | The text value of this TXT record. - string |


<a id="CnameRecord" />
### CnameRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  cname | string | No | The canonical name for this CNAME record. |


<a id="SoaRecord" />
### SoaRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  host | string | No | The domain name of the authoritative name server for this SOA record. |
|  email | string | No | The email contact for this SOA record. |
|  serialNumber | integer | No | The serial number for this SOA record. |
|  refreshTime | integer | No | The refresh value for this SOA record. |
|  retryTime | integer | No | The retry time for this SOA record. |
|  expireTime | integer | No | The expire time for this SOA record. |
|  minimumTTL | integer | No | The minimum value for this SOA record. By convention this is used to determine the negative caching duration. |


<a id="CaaRecord" />
### CaaRecord object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  flags | integer | No | The flags for this CAA record as an integer between 0 and 255. |
|  tag | string | No | The tag for this CAA record. |
|  value | string | No | The value for this CAA record. |

