# Microsoft.AnalysisServices/servers template reference
API Version: 2017-07-14
## Template format

To create a Microsoft.AnalysisServices/servers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.AnalysisServices/servers",
  "apiVersion": "2017-07-14",
  "location": "string",
  "sku": {
    "name": "string",
    "tier": "string"
  },
  "tags": {},
  "properties": {
    "asAdministrators": {
      "members": [
        "string"
      ]
    },
    "backupBlobContainerUri": "string",
    "gatewayDetails": {
      "gatewayResourceId": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.AnalysisServices/servers" />
### Microsoft.AnalysisServices/servers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.AnalysisServices/servers |
|  apiVersion | enum | Yes | 2017-07-14 |
|  location | string | Yes | Location of the Analysis Services resource. |
|  sku | object | Yes | The SKU of the Analysis Services resource. - [ResourceSku object](#ResourceSku) |
|  tags | object | No | Key-value pairs of additional resource provisioning properties. |
|  properties | object | Yes | Properties of the provision operation request. - [AnalysisServicesServerProperties object](#AnalysisServicesServerProperties) |


<a id="ResourceSku" />
### ResourceSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Name of the SKU level. |
|  tier | enum | No | The name of the Azure pricing tier to which the SKU applies. - Development, Basic, Standard |


<a id="AnalysisServicesServerProperties" />
### AnalysisServicesServerProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  asAdministrators | object | No | A collection of AS server administrators - [ServerAdministrators object](#ServerAdministrators) |
|  backupBlobContainerUri | string | No | The SAS container URI to the backup container. |
|  gatewayDetails | object | No | The gateway details configured for the AS server. - [GatewayDetails object](#GatewayDetails) |


<a id="ServerAdministrators" />
### ServerAdministrators object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  members | array | No | An array of administrator user identities. - string |


<a id="GatewayDetails" />
### GatewayDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  gatewayResourceId | string | No | Gateway resource to be associated with the server. |

