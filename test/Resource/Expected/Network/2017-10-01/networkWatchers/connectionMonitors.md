# Microsoft.Network/networkWatchers/connectionMonitors template reference
API Version: 2017-10-01
## Template format

To create a Microsoft.Network/networkWatchers/connectionMonitors resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/networkWatchers/connectionMonitors",
  "apiVersion": "2017-10-01",
  "location": "string",
  "tags": {},
  "properties": {
    "source": {
      "resourceId": "string",
      "port": "integer"
    },
    "destination": {
      "resourceId": "string",
      "address": "string",
      "port": "integer"
    },
    "autoStart": "boolean",
    "monitoringIntervalInSeconds": "integer"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/networkWatchers/connectionMonitors" />
### Microsoft.Network/networkWatchers/connectionMonitors object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/networkWatchers/connectionMonitors |
|  apiVersion | enum | Yes | 2017-10-01 |
|  location | string | No | Connection monitor location. |
|  tags | object | No | Connection monitor tags. |
|  properties | object | Yes | [ConnectionMonitorParameters object](#ConnectionMonitorParameters) |


<a id="ConnectionMonitorParameters" />
### ConnectionMonitorParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  source | object | Yes | [ConnectionMonitorSource object](#ConnectionMonitorSource) |
|  destination | object | Yes | [ConnectionMonitorDestination object](#ConnectionMonitorDestination) |
|  autoStart | boolean | No | Determines if the connection monitor will start automatically once created. |
|  monitoringIntervalInSeconds | integer | No | Monitoring interval in seconds. |


<a id="ConnectionMonitorSource" />
### ConnectionMonitorSource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  resourceId | string | Yes | The ID of the resource used as the source by connection monitor. |
|  port | integer | No | The source port used by connection monitor. |


<a id="ConnectionMonitorDestination" />
### ConnectionMonitorDestination object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  resourceId | string | No | The ID of the resource used as the destination by connection monitor. |
|  address | string | No | Address of the connection monitor destination (IP or domain name). |
|  port | integer | No | The destination port used by connection monitor. |

