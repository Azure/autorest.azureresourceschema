# Microsoft.EventGrid/topics template reference
API Version: 2017-06-15-preview
## Template format

To create a Microsoft.EventGrid/topics resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventGrid/topics",
  "apiVersion": "2017-06-15-preview",
  "location": "string",
  "tags": {},
  "properties": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.EventGrid/topics" />
### Microsoft.EventGrid/topics object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.EventGrid/topics |
|  apiVersion | enum | Yes | 2017-06-15-preview |
|  location | string | Yes | Location of the resource |
|  tags | object | No | Tags of the resource |
|  properties | object | Yes | Properties of the topic - [TopicProperties object](#TopicProperties) |

