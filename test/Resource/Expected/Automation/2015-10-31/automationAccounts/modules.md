# Microsoft.Automation/automationAccounts/modules template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/modules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/modules",
  "apiVersion": "2015-10-31",
  "properties": {
    "contentLink": {
      "uri": "string",
      "contentHash": {
        "algorithm": "string",
        "value": "string"
      },
      "version": "string"
    }
  },
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/modules" />
### Microsoft.Automation/automationAccounts/modules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/modules |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets the module create properties. - [ModuleCreateOrUpdateProperties object](#ModuleCreateOrUpdateProperties) |
|  location | string | No | Gets or sets the location of the resource. |
|  tags | object | No | Gets or sets the tags attached to the resource. |


<a id="ModuleCreateOrUpdateProperties" />
### ModuleCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  contentLink | object | Yes | Gets or sets the module content link. - [ContentLink object](#ContentLink) |


<a id="ContentLink" />
### ContentLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uri | string | No | Gets or sets the uri of the runbook content. |
|  contentHash | object | No | Gets or sets the hash. - [ContentHash object](#ContentHash) |
|  version | string | No | Gets or sets the version of the content. |


<a id="ContentHash" />
### ContentHash object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  algorithm | string | Yes | Gets or sets the content hash algorithm used to hash the content. |
|  value | string | Yes | Gets or sets expected hash value of the content. |

