# Microsoft.Devices/IotHubs template reference
API Version: 2017-07-01
## Template format

To create a Microsoft.Devices/IotHubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Devices/IotHubs",
  "apiVersion": "2017-07-01",
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
    "routing": {
      "endpoints": {
        "serviceBusQueues": [
          {
            "connectionString": "string",
            "name": "string",
            "subscriptionId": "string",
            "resourceGroup": "string"
          }
        ],
        "serviceBusTopics": [
          {
            "connectionString": "string",
            "name": "string",
            "subscriptionId": "string",
            "resourceGroup": "string"
          }
        ],
        "eventHubs": [
          {
            "connectionString": "string",
            "name": "string",
            "subscriptionId": "string",
            "resourceGroup": "string"
          }
        ],
        "storageContainers": [
          {
            "connectionString": "string",
            "name": "string",
            "subscriptionId": "string",
            "resourceGroup": "string",
            "containerName": "string",
            "fileNameFormat": "string",
            "batchFrequencyInSeconds": "integer",
            "maxChunkSizeInBytes": "integer",
            "encoding": "string"
          }
        ]
      },
      "routes": [
        {
          "name": "string",
          "source": "string",
          "condition": "string",
          "endpointNames": [
            "string"
          ],
          "isEnabled": boolean
        }
      ],
      "fallbackRoute": {
        "source": "DeviceMessages",
        "condition": "string",
        "endpointNames": [
          "string"
        ],
        "isEnabled": boolean
      }
    },
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
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Devices/IotHubs" />
### Microsoft.Devices/IotHubs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the IoT hub. |
|  type | enum | Yes | Microsoft.Devices/IotHubs |
|  apiVersion | enum | Yes | 2017-07-01 |
|  location | string | Yes | The resource location. |
|  tags | object | No | The resource tags. |
|  subscriptionid | string | Yes | The subscription identifier. |
|  resourcegroup | string | Yes | The name of the resource group that contains the IoT hub. A resource group name uniquely identifies the resource group within the subscription. |
|  etag | string | No | The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. |
|  properties | object | Yes | [IotHubProperties object](#IotHubProperties) |
|  sku | object | Yes | [IotHubSkuInfo object](#IotHubSkuInfo) |
|  resources | array | No | [certificates](./IotHubs/certificates.md) |


<a id="IotHubProperties" />
### IotHubProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationPolicies | array | No | The shared access policies you can use to secure a connection to the IoT hub. - [SharedAccessSignatureAuthorizationRule object](#SharedAccessSignatureAuthorizationRule) |
|  ipFilterRules | array | No | The IP filter rules. - [IpFilterRule object](#IpFilterRule) |
|  eventHubEndpoints | object | No | The Event Hub-compatible endpoint properties. The possible keys to this dictionary are events and operationsMonitoringEvents. Both of these keys have to be present in the dictionary while making create or update calls for the IoT hub. |
|  routing | object | No | [RoutingProperties object](#RoutingProperties) |
|  storageEndpoints | object | No | The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. |
|  messagingEndpoints | object | No | The messaging endpoint properties for the file upload notification queue. |
|  enableFileUploadNotifications | boolean | No | If True, file upload notifications are enabled. |
|  cloudToDevice | object | No | [CloudToDeviceProperties object](#CloudToDeviceProperties) |
|  comments | string | No | IoT hub comments. |
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


<a id="RoutingProperties" />
### RoutingProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  endpoints | object | No | [RoutingEndpoints object](#RoutingEndpoints) |
|  routes | array | No | The list of user-provided routing rules that the IoT hub uses to route messages to built-in and custom endpoints. A maximum of 100 routing rules are allowed for paid hubs and a maximum of 5 routing rules are allowed for free hubs. - [RouteProperties object](#RouteProperties) |
|  fallbackRoute | object | No | The properties of the route that is used as a fall-back route when none of the conditions specified in the 'routes' section are met. This is an optional parameter. When this property is not set, the messages which do not meet any of the conditions specified in the 'routes' section get routed to the built-in eventhub endpoint. - [FallbackRouteProperties object](#FallbackRouteProperties) |


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


<a id="RoutingEndpoints" />
### RoutingEndpoints object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceBusQueues | array | No | The list of Service Bus queue endpoints that IoT hub routes the messages to, based on the routing rules. - [RoutingServiceBusQueueEndpointProperties object](#RoutingServiceBusQueueEndpointProperties) |
|  serviceBusTopics | array | No | The list of Service Bus topic endpoints that the IoT hub routes the messages to, based on the routing rules. - [RoutingServiceBusTopicEndpointProperties object](#RoutingServiceBusTopicEndpointProperties) |
|  eventHubs | array | No | The list of Event Hubs endpoints that IoT hub routes messages to, based on the routing rules. This list does not include the built-in Event Hubs endpoint. - [RoutingEventHubProperties object](#RoutingEventHubProperties) |
|  storageContainers | array | No | The list of storage container endpoints that IoT hub routes messages to, based on the routing rules. - [RoutingStorageContainerProperties object](#RoutingStorageContainerProperties) |


<a id="RouteProperties" />
### RouteProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a maximum length of 64 characters, and must be unique. |
|  source | enum | Yes | The source that the routing rule is to be applied to, such as DeviceMessages. - DeviceMessages, TwinChangeEvents, DeviceLifecycleEvents, DeviceJobLifecycleEvents |
|  condition | string | No | The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language |
|  endpointNames | array | Yes | The list of endpoints to which messages that satisfy the condition are routed. Currently only one endpoint is allowed. - string |
|  isEnabled | boolean | Yes | Used to specify whether a route is enabled. |


<a id="FallbackRouteProperties" />
### FallbackRouteProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  source | enum | Yes | The source to which the routing rule is to be applied to. For example, DeviceMessages - DeviceMessages |
|  condition | string | No | The condition which is evaluated in order to apply the fallback route. If the condition is not provided it will evaluate to true by default. For grammar, See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language |
|  endpointNames | array | Yes | The list of endpoints to which the messages that satisfy the condition are routed to. Currently only 1 endpoint is allowed. - string |
|  isEnabled | boolean | Yes | Used to specify whether the fallback route is enabled. |


<a id="FeedbackProperties" />
### FeedbackProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lockDurationAsIso8601 | string | No | The lock duration for the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |
|  ttlAsIso8601 | string | No | The period of time for which a message is available to consume before it is expired by the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |
|  maxDeliveryCount | integer | No | The number of times the IoT hub attempts to deliver a message on the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. |


<a id="RoutingServiceBusQueueEndpointProperties" />
### RoutingServiceBusQueueEndpointProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  connectionString | string | Yes | The connection string of the service bus queue endpoint. |
|  name | string | Yes | The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, operationsMonitoringEvents, fileNotifications, $default. Endpoint names must be unique across endpoint types. The name need not be the same as the actual queue name. |
|  subscriptionId | string | No | The subscription identifier of the service bus queue endpoint. |
|  resourceGroup | string | No | The name of the resource group of the service bus queue endpoint. |


<a id="RoutingServiceBusTopicEndpointProperties" />
### RoutingServiceBusTopicEndpointProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  connectionString | string | Yes | The connection string of the service bus topic endpoint. |
|  name | string | Yes | The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, operationsMonitoringEvents, fileNotifications, $default. Endpoint names must be unique across endpoint types.  The name need not be the same as the actual topic name. |
|  subscriptionId | string | No | The subscription identifier of the service bus topic endpoint. |
|  resourceGroup | string | No | The name of the resource group of the service bus topic endpoint. |


<a id="RoutingEventHubProperties" />
### RoutingEventHubProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  connectionString | string | Yes | The connection string of the event hub endpoint.  |
|  name | string | Yes | The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, operationsMonitoringEvents, fileNotifications, $default. Endpoint names must be unique across endpoint types. |
|  subscriptionId | string | No | The subscription identifier of the event hub endpoint. |
|  resourceGroup | string | No | The name of the resource group of the event hub endpoint. |


<a id="RoutingStorageContainerProperties" />
### RoutingStorageContainerProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  connectionString | string | Yes | The connection string of the storage account. |
|  name | string | Yes | The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, operationsMonitoringEvents, fileNotifications, $default. Endpoint names must be unique across endpoint types. |
|  subscriptionId | string | No | The subscription identifier of the storage account. |
|  resourceGroup | string | No | The name of the resource group of the storage account. |
|  containerName | string | Yes | The name of storage container in the storage account. |
|  fileNameFormat | string | No | File name format for the blob. Default format is {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}. All parameters are mandatory but can be reordered. |
|  batchFrequencyInSeconds | integer | No | Time interval at which blobs are written to storage. Value should be between 60 and 720 seconds. Default value is 300 seconds. |
|  maxChunkSizeInBytes | integer | No | Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB) and 524288000(500MB). Default value is 314572800(300MB). |
|  encoding | string | No | Encoding that is used to serialize messages to blobs. Supported values are 'avro' and 'avrodeflate'. Default value is 'avro'. |

