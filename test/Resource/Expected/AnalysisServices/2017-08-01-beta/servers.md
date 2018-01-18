# Microsoft.AnalysisServices/servers template reference
API Version: 2017-08-01-beta
## Template format

To create a Microsoft.AnalysisServices/servers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.AnalysisServices/servers",
  "apiVersion": "2017-08-01-beta",
  "location": "string",
  "sku": {
    "name": "string",
    "tier": "string",
    "capacity": "integer"
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
    },
    "ipV4FirewallSettings": {
      "firewallRules": [
        {
          "firewallRuleName": "string",
          "rangeStart": "string",
          "rangeEnd": "string"
        }
      ],
      "enablePowerBIService": "string"
    },
    "querypoolConnectionMode": "string"
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
|  apiVersion | enum | Yes | 2017-08-01-beta |
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
|  capacity | integer | No | The number of instances in the read only query pool. |


<a id="AnalysisServicesServerProperties" />
### AnalysisServicesServerProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  asAdministrators | object | No | A collection of AS server administrators - [ServerAdministrators object](#ServerAdministrators) |
|  backupBlobContainerUri | string | No | The SAS container URI to the backup container. |
|  gatewayDetails | object | No | The gateway details configured for the AS server. - [GatewayDetails object](#GatewayDetails) |
|  ipV4FirewallSettings | object | No | The firewall settings for the AS server. - [IPv4FirewallSettings object](#IPv4FirewallSettings) |
|  querypoolConnectionMode | enum | No | How the read-write server's participation in the query pool is controlled.<br/>It can have the following values: <ul><li>readOnly - indicates that the read-write server is intended not to participate in query operations</li><li>all - indicates that the read-write server can participate in query operations</li></ul>Specifying readOnly when capacity is 1 results in error. - All or ReadOnly |


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


<a id="IPv4FirewallSettings" />
### IPv4FirewallSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  firewallRules | array | No | An array of firewall rules. - [IPv4FirewallRule object](#IPv4FirewallRule) |
|  enablePowerBIService | string | No | The indicator of enableing PBI service. |


<a id="IPv4FirewallRule" />
### IPv4FirewallRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  firewallRuleName | string | No | The rule name. |
|  rangeStart | string | No | The start range of IPv4. |
|  rangeEnd | string | No | The end range of IPv4. |

