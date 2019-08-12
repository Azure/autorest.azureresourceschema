# Microsoft.Automation/automationAccounts/nodeConfigurations template reference
API Version: 2015-10-31
## Template format

To create a Microsoft.Automation/automationAccounts/nodeConfigurations resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Automation/automationAccounts/nodeConfigurations",
  "apiVersion": "2015-10-31",
  "source": {
    "hash": {
      "algorithm": "string",
      "value": "string"
    },
    "type": "string",
    "value": "string",
    "version": "string"
  },
  "configuration": {
    "name": "string"
  },
  "newNodeConfigurationBuildVersionRequired": "boolean"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Automation/automationAccounts/nodeConfigurations" />
### Microsoft.Automation/automationAccounts/nodeConfigurations object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Automation/automationAccounts/nodeConfigurations |
|  apiVersion | enum | Yes | 2015-10-31 |
|  source | object | Yes | Gets or sets the source. - [ContentSource object](#ContentSource) |
|  configuration | object | Yes | Gets or sets the configuration of the node. - [DscConfigurationAssociationProperty object](#DscConfigurationAssociationProperty) |
|  newNodeConfigurationBuildVersionRequired | boolean | No | If a new build version of NodeConfiguration is required. |


<a id="ContentSource" />
### ContentSource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  hash | object | No | Gets or sets the hash. - [ContentHash object](#ContentHash) |
|  type | enum | No | Gets or sets the content source type. - embeddedContent or uri |
|  value | string | No | Gets or sets the value of the content. This is based on the content source type. |
|  version | string | No | Gets or sets the version of the content. |


<a id="DscConfigurationAssociationProperty" />
### DscConfigurationAssociationProperty object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets or sets the name of the Dsc configuration. |


<a id="ContentHash" />
### ContentHash object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  algorithm | string | Yes | Gets or sets the content hash algorithm used to hash the content. |
|  value | string | Yes | Gets or sets expected hash value of the content. |

