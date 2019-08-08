# Microsoft.EventGrid/eventSubscriptions template reference
API Version: 2017-09-15-preview
## Template format

To create a Microsoft.EventGrid/eventSubscriptions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventGrid/eventSubscriptions",
  "apiVersion": "2017-09-15-preview",
  "properties": {
    "destination": {},
    "filter": {
      "subjectBeginsWith": "string",
      "subjectEndsWith": "string",
      "includedEventTypes": [
        "string"
      ],
      "isSubjectCaseSensitive": "boolean"
    },
    "labels": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.EventGrid/eventSubscriptions" />
### Microsoft.EventGrid/eventSubscriptions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.EventGrid/eventSubscriptions |
|  apiVersion | enum | Yes | 2017-09-15-preview |
|  properties | object | Yes | Properties of the event subscription - [EventSubscriptionProperties object](#EventSubscriptionProperties) |


<a id="EventSubscriptionProperties" />
### EventSubscriptionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  destination | object | No | Information about the destination where events have to be delivered for the event subscription. - [EventSubscriptionDestination object](#EventSubscriptionDestination) |
|  filter | object | No | Information about the filter for the event subscription. - [EventSubscriptionFilter object](#EventSubscriptionFilter) |
|  labels | array | No | List of user defined labels. - string |


<a id="EventSubscriptionFilter" />
### EventSubscriptionFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  subjectBeginsWith | string | No | An optional string to filter events for an event subscription based on a resource path prefix.
The format of this depends on the publisher of the events.
Wildcard characters are not supported in this path. |
|  subjectEndsWith | string | No | An optional string to filter events for an event subscription based on a resource path suffix.
Wildcard characters are not supported in this path. |
|  includedEventTypes | array | No | A list of applicable event types that need to be part of the event subscription.
If it is desired to subscribe to all event types, the string "all" needs to be specified as an element in this list. - string |
|  isSubjectCaseSensitive | boolean | No | Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter
should be compared in a case sensitive manner. |

