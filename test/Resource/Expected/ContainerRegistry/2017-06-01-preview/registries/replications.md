# Microsoft.ContainerRegistry/registries/replications template reference
API Version: 2017-06-01-preview
## Template format

To create a Microsoft.ContainerRegistry/registries/replications resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ContainerRegistry/registries/replications",
  "apiVersion": "2017-06-01-preview",
  "location": "string",
  "tags": {},
  "properties": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ContainerRegistry/registries/replications" />
### Microsoft.ContainerRegistry/registries/replications object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the replication. |
|  type | enum | Yes | Microsoft.ContainerRegistry/registries/replications |
|  apiVersion | enum | Yes | 2017-06-01-preview |
|  location | string | Yes | The location of the resource. This cannot be changed after the resource is created. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the replication. - [ReplicationProperties object](#ReplicationProperties) |

