# Microsoft.Automation/automationAccounts/configurations template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/configurations resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/configurations",
  "apiVersion": "2015-10-31",
  "properties": {
    "logVerbose": boolean,
    "logProgress": boolean,
    "source": {
      "hash": {
        "algorithm": "string",
        "value": "string"
      },
      "type": "string",
      "value": "string",
      "version": "string"
    },
    "parameters": {},
    "description": "string"
  },
  "location": "string",
  "tags": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/configurations" />
### Microsoft.Automation/automationAccounts/configurations object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/configurations |
|  apiVersion | enum | Yes | 2015-10-31 |
|  properties | object | Yes | Gets or sets configuration create or update properties. - [DscConfigurationCreateOrUpdateProperties object](#DscConfigurationCreateOrUpdateProperties) |
|  location | string | No | Gets or sets the location of the resource. |
|  tags | object | No | Gets or sets the tags attached to the resource. |


<a id="DscConfigurationCreateOrUpdateProperties" />
### DscConfigurationCreateOrUpdateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  logVerbose | boolean | No | Gets or sets verbose log option. |
|  logProgress | boolean | No | Gets or sets progress log option. |
|  source | object | Yes | Gets or sets the source. - [ContentSource object](#ContentSource) |
|  parameters | object | No | Gets or sets the configuration parameters. |
|  description | string | No | Gets or sets the description of the configuration. |


<a id="ContentSource" />
### ContentSource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  hash | object | No | Gets or sets the hash. - [ContentHash object](#ContentHash) |
|  type | enum | No | Gets or sets the content source type. - embeddedContent or uri |
|  value | string | No | Gets or sets the value of the content. This is based on the content source type. |
|  version | string | No | Gets or sets the version of the content. |


<a id="ContentHash" />
### ContentHash object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  algorithm | string | Yes | Gets or sets the content hash algorithm used to hash the content. |
|  value | string | Yes | Gets or sets expected hash value of the content. |

