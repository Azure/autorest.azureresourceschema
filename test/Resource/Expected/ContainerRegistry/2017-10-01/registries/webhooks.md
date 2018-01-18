# Microsoft.ContainerRegistry/registries/webhooks template reference
API Version: 2017-10-01
## Template format

To create a Microsoft.ContainerRegistry/registries/webhooks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ContainerRegistry/registries/webhooks",
  "apiVersion": "2017-10-01",
  "tags": {},
  "location": "string",
  "properties": {
    "serviceUri": "string",
    "customHeaders": {},
    "status": "string",
    "scope": "string",
    "actions": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ContainerRegistry/registries/webhooks" />
### Microsoft.ContainerRegistry/registries/webhooks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the webhook. |
|  type | enum | Yes | Microsoft.ContainerRegistry/registries/webhooks |
|  apiVersion | enum | Yes | 2017-10-01 |
|  tags | object | No | The tags for the webhook. |
|  location | string | Yes | The location of the webhook. This cannot be changed after the resource is created. |
|  properties | object | Yes | The properties that the webhook will be created with. - [WebhookPropertiesCreateParameters object](#WebhookPropertiesCreateParameters) |


<a id="WebhookPropertiesCreateParameters" />
### WebhookPropertiesCreateParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceUri | string | Yes | The service URI for the webhook to post notifications. |
|  customHeaders | object | No | Custom headers that will be added to the webhook notifications. |
|  status | enum | No | The status of the webhook at the time the operation was called. - enabled or disabled |
|  scope | string | No | The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events. |
|  actions | array | Yes | The list of actions that trigger the webhook to post notifications. - push or delete |

