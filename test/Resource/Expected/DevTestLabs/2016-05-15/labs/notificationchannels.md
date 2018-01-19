# Microsoft.DevTestLab/labs/notificationchannels template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/notificationchannels resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/notificationchannels",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "webHookUrl": "string",
    "description": "string",
    "events": [
      {
        "eventName": "string"
      }
    ],
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/notificationchannels" />
### Microsoft.DevTestLab/labs/notificationchannels object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/notificationchannels |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [NotificationChannelProperties object](#NotificationChannelProperties) |


<a id="NotificationChannelProperties" />
### NotificationChannelProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  webHookUrl | string | No | The webhook URL to send notifications to. |
|  description | string | No | Description of notification. |
|  events | array | No | The list of event for which this notification is enabled. - [Event object](#Event) |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="Event" />
### Event object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  eventName | enum | No | The event type for which this notification is enabled (i.e. AutoShutdown, Cost). - AutoShutdown or Cost |

