# Microsoft.EventHub/namespaces/eventhubs/consumergroups template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.EventHub/namespaces/eventhubs/consumergroups resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces/eventhubs/consumergroups",
  "apiVersion": "2015-08-01",
  "location": "string",
  "properties": {
    "userMetadata": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.EventHub/namespaces/eventhubs/consumergroups" />
### Microsoft.EventHub/namespaces/eventhubs/consumergroups object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The consumer group name |
|  type | enum | Yes | Microsoft.EventHub/namespaces/eventhubs/consumergroups |
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Location of the resource. |
|  properties | object | Yes | [ConsumerGroupProperties object](#ConsumerGroupProperties) |


<a id="ConsumerGroupProperties" />
### ConsumerGroupProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userMetadata | string | No | The user metadata. |

