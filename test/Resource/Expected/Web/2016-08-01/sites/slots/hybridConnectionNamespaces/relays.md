# Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "serviceBusNamespace": "string",
    "relayName": "string",
    "relayArmUri": "string",
    "hostname": "string",
    "port": "integer",
    "sendKeyName": "string",
    "sendKeyValue": "string",
    "serviceBusSuffix": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays" />
### Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | HybridConnection resource specific properties - [HybridConnectionProperties object](#HybridConnectionProperties) |


<a id="HybridConnectionProperties" />
### HybridConnectionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceBusNamespace | string | No | The name of the Service Bus namespace. |
|  relayName | string | No | The name of the Service Bus relay. |
|  relayArmUri | string | No | The ARM URI to the Service Bus relay. |
|  hostname | string | No | The hostname of the endpoint. |
|  port | integer | No | The port of the endpoint. |
|  sendKeyName | string | No | The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus. |
|  sendKeyValue | string | No | The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returnednormally, use the POST /listKeys API instead. |
|  serviceBusSuffix | string | No | The suffix for the service bus endpoint. By default this is .servicebus.windows.net |

