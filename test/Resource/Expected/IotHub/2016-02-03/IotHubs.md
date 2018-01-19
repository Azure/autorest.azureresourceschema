# Microsoft.Devices/IotHubs template reference
API Version: 2016-02-03
## Template format

To create a Microsoft.Devices/IotHubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Devices/IotHubs",
  "apiVersion": "2016-02-03",
  "location": "string",
  "tags": {},
  "subscriptionid": "string",
  "resourcegroup": "string",
  "etag": "string",
  "properties": {
    "authorizationPolicies": [
      {
        "keyName": "string",
        "primaryKey": "string",
        "secondaryKey": "string",
        "rights": "string"
      }
    ],
    "ipFilterRules": [
      {
        "filterName": "string",
        "action": "string",
        "ipMask": "string"
      }
    ],
    "eventHubEndpoints": {},
    "storageEndpoints": {},
    "messagingEndpoints": {},
    "enableFileUploadNotifications": boolean,
    "cloudToDevice": {
      "maxDeliveryCount": "integer",
      "defaultTtlAsIso8601": "string",
      "feedback": {
        "lockDurationAsIso8601": "string",
        "ttlAsIso8601": "string",
        "maxDeliveryCount": "integer"
      }
    },
    "comments": "string",
    "operationsMonitoringProperties": {
      "events": {}
    },
    "features": "string"
  },
  "sku": {
    "name": "string",
    "capacity": "integer"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Devices/IotHubs" />
### Microsoft.Devices/IotHubs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Devices/IotHubs |
|  apiVersion | enum | Yes | 2016-02-03 |
|  location | string | Yes | The resource location. |
|  tags | object | No | The resource tags. |
|  subscriptionid | string | Yes | The subscription identifier. |
|  resourcegroup | string | Yes | The name of the resource group that contains the IoT hub. A resource group name uniquely identifies the resource group within the subscription. |
|  etag | string | No | The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. |
|  properties | object | Yes | [IotHubProperties object](#IotHubProperties) |
|  sku | object | Yes | [IotHubSkuInfo object](#IotHubSkuInfo) |


<a id="IotHubProperties" />
### IotHubProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationPolicies | array | No | The shared access policies you can use to secure a connection to the IoT hub. - [SharedAccessSignatureAuthorizationRule object](#SharedAccessSignatureAuthorizationRule) |
|  ipFilterRules | array | No | The IP filter rules. - [IpFilterRule object](#IpFilterRule) |
|  eventHubEndpoints | object | No | The Event Hub-compatible endpoint properties. The possible keys to this dictionary are events and operationsMonitoringEvents. Both of these keys have to be present in the dictionary while making create or update calls for the IoT hub. |
|  storageEndpoints | object | No | The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. |
|  messagingEndpoints | object | No | The messaging endpoint properties for the file upload notification queue. |
|  enableFileUploadNotifications | boolean | No | If True, file upload notifications are enabled. |
|  cloudToDevice | object | No | [CloudToDeviceProperties object](#CloudToDeviceProperties) |
|  comments | string | No | Comments. |
|  operationsMonitoringProperties | object | No | [OperationsMonitoringProperties object](#OperationsMonitoringProperties) |
|  features | enum | No | The capabilities and features enabled for the IoT hub. - None or DeviceManagement |


<a id="IotHubSkuInfo" />
### IotHubSkuInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | The name of the SKU. - F1, S1, S2, S3 |
|  capacity | integer | Yes | The number of provisioned IoT Hub units. See: https://docs.microsoft.com/azure/azure-subscription-service-limits#iot-hub-limits. |


<a id="SharedAccessSignatureAuthorizationRule" />
### SharedAccessSignatureAuthorizationRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyName | string | Yes | The name of the shared access policy. |
|  primaryKey | string | No | The primary key. |
|  secondaryKey | string | No | The secondary key. |
|  rights | enum | Yes | The permissions assigned to the shared access policy. - RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect, RegistryRead, RegistryWrite, RegistryRead, ServiceConnect, RegistryRead, DeviceConnect, RegistryWrite, ServiceConnect, RegistryWrite, DeviceConnect, ServiceConnect, DeviceConnect, RegistryRead, RegistryWrite, ServiceConnect, RegistryRead, RegistryWrite, DeviceConnect, RegistryRead, ServiceConnect, DeviceConnect, RegistryWrite, ServiceConnect, DeviceConnect, RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect |


<a id="IpFilterRule" />
### IpFilterRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  filterName | string | Yes | The name of the IP filter rule. |
|  action | enum | Yes | The desired action for requests captured by this rule. - Accept or Reject |
|  ipMask | string | Yes | A string that contains the IP address range in CIDR notation for the rule. |


<a id="CloudToDeviceProperties" />
### CloudToDeviceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxDeliveryCount | integer | No | The max delivery count for cloud-to-device messages in the device queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |
|  defaultTtlAsIso8601 | string | No | The default time to live for cloud-to-device messages in the device queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |
|  feedback | object | No | [FeedbackProperties object](#FeedbackProperties) |


<a id="OperationsMonitoringProperties" />
### OperationsMonitoringProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  events | object | No |  |


<a id="FeedbackProperties" />
### FeedbackProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lockDurationAsIso8601 | string | No | The lock duration for the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |
|  ttlAsIso8601 | string | No | The period of time for which a message is available to consume before it is expired by the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |
|  maxDeliveryCount | integer | No | The number of times the IoT hub attempts to deliver a message on the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |

