# Microsoft.EventHub/namespaces/eventhubs template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.EventHub/namespaces/eventhubs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces/eventhubs",
  "apiVersion": "2015-08-01",
  "location": "string",
  "properties": {
    "messageRetentionInDays": "integer",
    "partitionCount": "integer",
    "status": "string"
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
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Location of the resource. |
|  properties | object | Yes | [EventHubProperties object](#EventHubProperties) |
|  resources | array | No | [consumergroups](./eventhubs/consumergroups.md) [authorizationRules](./eventhubs/authorizationRules.md) |


<a id="EventHubProperties" />
### EventHubProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageRetentionInDays | integer | No | Number of days to retain the events for this Event Hub. |
|  partitionCount | integer | No | Number of partitions created for the Event Hub. |
|  status | enum | No | Enumerates the possible values for the status of the Event Hub. - Active, Disabled, Restoring, SendDisabled, ReceiveDisabled, Creating, Deleting, Renaming, Unknown |

