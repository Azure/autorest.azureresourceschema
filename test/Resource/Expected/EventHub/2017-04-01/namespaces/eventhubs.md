# Microsoft.EventHub/namespaces/eventhubs template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.EventHub/namespaces/eventhubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces/eventhubs",
  "apiVersion": "2017-04-01",
  "properties": {
    "messageRetentionInDays": "integer",
    "partitionCount": "integer",
    "status": "string",
    "captureDescription": {
      "enabled": boolean,
      "encoding": "string",
      "intervalInSeconds": "integer",
      "sizeLimitInBytes": "integer",
      "destination": {
        "name": "string",
        "properties": {
          "storageAccountResourceId": "string",
          "blobContainer": "string",
          "archiveNameFormat": "string"
        }
      }
    }
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.EventHub/namespaces/eventhubs" />
### Microsoft.EventHub/namespaces/eventhubs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The Event Hub name |
|  type | enum | Yes | Microsoft.EventHub/namespaces/eventhubs |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties supplied to the Create Or Update Event Hub operation. - [EventhubProperties object](#EventhubProperties) |
|  resources | array | No | [consumergroups](./eventhubs/consumergroups.md) [authorizationRules](./eventhubs/authorizationRules.md) |


<a id="EventhubProperties" />
### EventhubProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageRetentionInDays | integer | No | Number of days to retain the events for this Event Hub, value should be 1 to 7 days |
|  partitionCount | integer | No | Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions. |
|  status | enum | No | Enumerates the possible values for the status of the Event Hub. - Active, Disabled, Restoring, SendDisabled, ReceiveDisabled, Creating, Deleting, Renaming, Unknown |
|  captureDescription | object | No | Properties of capture description - [CaptureDescription object](#CaptureDescription) |


<a id="CaptureDescription" />
### CaptureDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | No | A value that indicates whether capture description is enabled.  |
|  encoding | enum | No | Enumerates the possible values for the encoding format of capture description. - Avro or AvroDeflate |
|  intervalInSeconds | integer | No | The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds |
|  sizeLimitInBytes | integer | No | The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes |
|  destination | object | No | Properties of Destination where capture will be stored. (Storage Account, Blob Names) - [Destination object](#Destination) |


<a id="Destination" />
### Destination object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name for capture destination |
|  properties | object | No | Properties describing the storage account, blob container and acrchive anme format for capture destination - [DestinationProperties object](#DestinationProperties) |


<a id="DestinationProperties" />
### DestinationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountResourceId | string | No | Resource id of the storage account to be used to create the blobs |
|  blobContainer | string | No | Blob container Name |
|  archiveNameFormat | string | No | Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order |

