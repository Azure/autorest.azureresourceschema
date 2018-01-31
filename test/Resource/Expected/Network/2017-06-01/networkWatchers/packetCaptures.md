# Microsoft.Network/networkWatchers/packetCaptures template reference
API Version: 2017-06-01
## Template format

To create a Microsoft.Network/networkWatchers/packetCaptures resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/networkWatchers/packetCaptures",
  "apiVersion": "2017-06-01",
  "properties": {
    "target": "string",
    "bytesToCapturePerPacket": "integer",
    "totalBytesPerSession": "integer",
    "timeLimitInSeconds": "integer",
    "storageLocation": {
      "storageId": "string",
      "storagePath": "string",
      "filePath": "string"
    },
    "filters": [
      {
        "protocol": "string",
        "localIPAddress": "string",
        "remoteIPAddress": "string",
        "localPort": "string",
        "remotePort": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/networkWatchers/packetCaptures" />
### Microsoft.Network/networkWatchers/packetCaptures object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/networkWatchers/packetCaptures |
|  apiVersion | enum | Yes | 2017-06-01 |
|  properties | object | Yes | [PacketCaptureParameters object](#PacketCaptureParameters) |


<a id="PacketCaptureParameters" />
### PacketCaptureParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  target | string | Yes | The ID of the targeted resource, only VM is currently supported. |
|  bytesToCapturePerPacket | integer | No | Number of bytes captured per packet, the remaining bytes are truncated. |
|  totalBytesPerSession | integer | No | Maximum size of the capture output. |
|  timeLimitInSeconds | integer | No | Maximum duration of the capture session in seconds. |
|  storageLocation | object | Yes | [PacketCaptureStorageLocation object](#PacketCaptureStorageLocation) |
|  filters | array | No | [PacketCaptureFilter object](#PacketCaptureFilter) |


<a id="PacketCaptureStorageLocation" />
### PacketCaptureStorageLocation object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageId | string | No | The ID of the storage account to save the packet capture session. Required if no local file path is provided. |
|  storagePath | string | No | The URI of the storage path to save the packet capture. Must be a well-formed URI describing the location to save the packet capture. |
|  filePath | string | No | A valid local path on the targeting VM. Must include the name of the capture file (*.cap). For linux virtual machine it must start with /var/captures. Required if no storage ID is provided, otherwise optional. |


<a id="PacketCaptureFilter" />
### PacketCaptureFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  protocol | enum | No | Protocol to be filtered on. - TCP, UDP, Any |
|  localIPAddress | string | No | Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5"? for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. |
|  remoteIPAddress | string | No | Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. |
|  localPort | string | No | Local port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. |
|  remotePort | string | No | Remote port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null. |

