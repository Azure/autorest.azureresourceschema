# Microsoft.Cache/Redis/linkedServers template reference
API Version: 2017-10-01
## Template format

To create a Microsoft.Cache/Redis/linkedServers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Cache/Redis/linkedServers",
  "apiVersion": "2017-10-01",
  "properties": {
    "linkedRedisCacheId": "string",
    "linkedRedisCacheLocation": "string",
    "serverRole": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Cache/Redis/linkedServers" />
### Microsoft.Cache/Redis/linkedServers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Cache/Redis/linkedServers |
|  apiVersion | enum | Yes | 2017-10-01 |
|  properties | object | Yes | Properties required to create a linked server. - [RedisLinkedServerCreateProperties object](#RedisLinkedServerCreateProperties) |


<a id="RedisLinkedServerCreateProperties" />
### RedisLinkedServerCreateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  linkedRedisCacheId | string | Yes | Fully qualified resourceId of the linked redis cache. |
|  linkedRedisCacheLocation | string | Yes | Location of the linked redis cache. |
|  serverRole | enum | Yes | Role of the linked server. - Primary or Secondary |

