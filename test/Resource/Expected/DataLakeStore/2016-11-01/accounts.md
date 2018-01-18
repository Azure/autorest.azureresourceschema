# Microsoft.DataLakeStore/accounts template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeStore/accounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeStore/accounts",
  "apiVersion": "2016-11-01",
  "location": "string",
  "tags": {},
  "identity": {
    "type": "SystemAssigned"
  },
  "properties": {
    "encryptionState": "string",
    "encryptionConfig": {
      "type": "string",
      "keyVaultMetaInfo": {
        "keyVaultResourceId": "string",
        "encryptionKeyName": "string",
        "encryptionKeyVersion": "string"
      }
    },
    "firewallState": "string",
    "firewallRules": [
      {
        "name": "string",
        "properties": {
          "startIpAddress": "string",
          "endIpAddress": "string"
        }
      }
    ],
    "trustedIdProviderState": "string",
    "trustedIdProviders": [
      {
        "name": "string",
        "properties": {
          "idProvider": "string"
        }
      }
    ],
    "defaultGroup": "string",
    "newTier": "string",
    "firewallAllowAzureIps": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeStore/accounts" />
### Microsoft.DataLakeStore/accounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeStore/accounts |
|  apiVersion | enum | Yes | 2016-11-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  identity | object | No | The Key Vault encryption identity, if any. - [EncryptionIdentity object](#EncryptionIdentity) |
|  properties | object | Yes | the Data Lake Store account properties. - [DataLakeStoreAccountProperties object](#DataLakeStoreAccountProperties) |
|  resources | array | No | [trustedIdProviders](./accounts/trustedIdProviders.md) [firewallRules](./accounts/firewallRules.md) |


<a id="EncryptionIdentity" />
### EncryptionIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | Yes | The type of encryption being used. Currently the only supported type is 'SystemAssigned'. - SystemAssigned |


<a id="DataLakeStoreAccountProperties" />
### DataLakeStoreAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  encryptionState | enum | No | The current state of encryption for this Data Lake store account. - Enabled or Disabled |
|  encryptionConfig | object | No | The Key Vault encryption configuration. - [EncryptionConfig object](#EncryptionConfig) |
|  firewallState | enum | No | The current state of the IP address firewall for this Data Lake store account. - Enabled or Disabled |
|  firewallRules | array | No | The list of firewall rules associated with this Data Lake store account. - [FirewallRule object](#FirewallRule) |
|  trustedIdProviderState | enum | No | The current state of the trusted identity provider feature for this Data Lake store account. - Enabled or Disabled |
|  trustedIdProviders | array | No | The list of trusted identity providers associated with this Data Lake store account. - [TrustedIdProvider object](#TrustedIdProvider) |
|  defaultGroup | string | No | the default owner group for all new folders and files created in the Data Lake Store account. |
|  newTier | enum | No | the commitment tier to use for next month. - Consumption, Commitment_1TB, Commitment_10TB, Commitment_100TB, Commitment_500TB, Commitment_1PB, Commitment_5PB |
|  firewallAllowAzureIps | enum | No | The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. - Enabled or Disabled |


<a id="EncryptionConfig" />
### EncryptionConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | Yes | The type of encryption configuration being used. Currently the only supported types are 'UserManaged' and 'ServiceManaged'. - UserManaged or ServiceManaged |
|  keyVaultMetaInfo | object | No | The Key Vault information for connecting to user managed encryption keys. - [KeyVaultMetaInfo object](#KeyVaultMetaInfo) |


<a id="FirewallRule" />
### FirewallRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Resource name |
|  properties | object | Yes | the properties of the firewall rule. - [FirewallRuleProperties object](#FirewallRuleProperties) |


<a id="TrustedIdProvider" />
### TrustedIdProvider object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Resource name |
|  properties | object | Yes | the properties of the trusted identity provider. - [TrustedIdProviderProperties object](#TrustedIdProviderProperties) |


<a id="KeyVaultMetaInfo" />
### KeyVaultMetaInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyVaultResourceId | string | Yes | The resource identifier for the user managed Key Vault being used to encrypt. |
|  encryptionKeyName | string | Yes | The name of the user managed encryption key. |
|  encryptionKeyVersion | string | Yes | The version of the user managed encryption key. |


<a id="FirewallRuleProperties" />
### FirewallRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  startIpAddress | string | Yes | the start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. |
|  endIpAddress | string | Yes | the end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. |


<a id="TrustedIdProviderProperties" />
### TrustedIdProviderProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  idProvider | string | Yes | The URL of this trusted identity provider |

