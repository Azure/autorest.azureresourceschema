# Microsoft.EventHub/namespaces/eventhubs/consumergroups template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.EventHub/namespaces/eventhubs/consumergroups resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.EventHub/namespaces/eventhubs/consumergroups",
  "apiVersion": "2017-04-01",
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
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Single item in List or Get Consumer group operation - [ConsumerGroupProperties object](#ConsumerGroupProperties) |


<a id="ConsumerGroupProperties" />
### ConsumerGroupProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userMetadata | string | No | Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored. |

