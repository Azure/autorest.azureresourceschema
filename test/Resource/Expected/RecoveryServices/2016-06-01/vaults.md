# Microsoft.RecoveryServices/vaults template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.RecoveryServices/vaults resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.RecoveryServices/vaults",
  "apiVersion": "2016-06-01",
  "eTag": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "upgradeDetails": {}
  },
  "sku": {
    "name": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.RecoveryServices/vaults" />
### Microsoft.RecoveryServices/vaults object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the recovery services vault. |
|  type | enum | Yes | Microsoft.RecoveryServices/vaults |
|  apiVersion | enum | Yes | 2016-06-01 |
|  eTag | string | No | Optional ETag. |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [VaultProperties object](#VaultProperties) |
|  sku | object | No | [Sku object](#Sku) |
|  resources | array | No | [certificates](./vaults/certificates.md) |


<a id="VaultProperties" />
### VaultProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  upgradeDetails | object | No | [UpgradeDetails object](#UpgradeDetails) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | The Sku name. - Standard or RS0 |

