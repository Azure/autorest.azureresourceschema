# Microsoft.DataLakeAnalytics/accounts template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeAnalytics/accounts resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeAnalytics/accounts",
  "apiVersion": "2016-11-01",
  "location": "string",
  "tags": {},
  "properties": {
    "defaultDataLakeStoreAccount": "string",
    "maxDegreeOfParallelism": "integer",
    "queryStoreRetention": "integer",
    "maxJobCount": "integer",
    "dataLakeStoreAccounts": [
      {
        "name": "string",
        "properties": {
          "suffix": "string"
        }
      }
    ],
    "storageAccounts": [
      {
        "name": "string",
        "properties": {
          "accessKey": "string",
          "suffix": "string"
        }
      }
    ],
    "newTier": "string",
    "firewallState": "string",
    "firewallAllowAzureIps": "string",
    "firewallRules": [
      {
        "name": "string",
        "properties": {
          "startIpAddress": "string",
          "endIpAddress": "string"
        }
      }
    ],
    "maxDegreeOfParallelismPerJob": "integer",
    "minPriorityPerJob": "integer",
    "computePolicies": [
      {
        "name": "string",
        "properties": {
          "objectId": "string",
          "objectType": "string",
          "maxDegreeOfParallelismPerJob": "integer",
          "minPriorityPerJob": "integer"
        }
      }
    ]
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeAnalytics/accounts" />
### Microsoft.DataLakeAnalytics/accounts object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeAnalytics/accounts |
|  apiVersion | enum | Yes | 2016-11-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | The properties defined by Data Lake Analytics all properties are specific to each resource provider. - [DataLakeAnalyticsAccountProperties object](#DataLakeAnalyticsAccountProperties) |
|  resources | array | No | [DataLakeStoreAccounts](./accounts/DataLakeStoreAccounts.md) [StorageAccounts](./accounts/StorageAccounts.md) [firewallRules](./accounts/firewallRules.md) [computePolicies](./accounts/computePolicies.md) |


<a id="DataLakeAnalyticsAccountProperties" />
### DataLakeAnalyticsAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  defaultDataLakeStoreAccount | string | Yes | the default data lake storage account associated with this Data Lake Analytics account. |
|  maxDegreeOfParallelism | integer | No | the maximum supported degree of parallelism for this account. |
|  queryStoreRetention | integer | No | the number of days that job metadata is retained. |
|  maxJobCount | integer | No | the maximum supported jobs running under the account at the same time. |
|  dataLakeStoreAccounts | array | Yes | the list of Data Lake storage accounts associated with this account. - [DataLakeStoreAccountInfo object](#DataLakeStoreAccountInfo) |
|  storageAccounts | array | No | the list of Azure Blob storage accounts associated with this account. - [StorageAccountInfo object](#StorageAccountInfo) |
|  newTier | enum | No | the commitment tier for the next month. - Consumption, Commitment_100AUHours, Commitment_500AUHours, Commitment_1000AUHours, Commitment_5000AUHours, Commitment_10000AUHours, Commitment_50000AUHours, Commitment_100000AUHours, Commitment_500000AUHours |
|  firewallState | enum | No | The current state of the IP address firewall for this Data Lake Analytics account. - Enabled or Disabled |
|  firewallAllowAzureIps | enum | No | The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. - Enabled or Disabled |
|  firewallRules | array | No | The list of firewall rules associated with this Data Lake Analytics account. - [FirewallRule object](#FirewallRule) |
|  maxDegreeOfParallelismPerJob | integer | No | the maximum supported degree of parallelism per job for this account. |
|  minPriorityPerJob | integer | No | the minimum supported priority per job for this account. |
|  computePolicies | array | No | the list of compute policies to create in this account. - [ComputePolicyAccountCreateParameters object](#ComputePolicyAccountCreateParameters) |


<a id="DataLakeStoreAccountInfo" />
### DataLakeStoreAccountInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Resource name |
|  properties | object | No | the properties associated with this Data Lake Store account. - [DataLakeStoreAccountInfoProperties object](#DataLakeStoreAccountInfoProperties) |


<a id="StorageAccountInfo" />
### StorageAccountInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Resource name |
|  properties | object | Yes | the properties associated with this storage account. - [StorageAccountProperties object](#StorageAccountProperties) |


<a id="FirewallRule" />
### FirewallRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Resource name |
|  properties | object | Yes | the properties of the firewall rule. - [FirewallRuleProperties object](#FirewallRuleProperties) |


<a id="ComputePolicyAccountCreateParameters" />
### ComputePolicyAccountCreateParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The unique name of the policy to create |
|  properties | object | Yes | The policy properties to use when creating a new compute policy - [ComputePolicyPropertiesCreateParameters object](#ComputePolicyPropertiesCreateParameters) |


<a id="DataLakeStoreAccountInfoProperties" />
### DataLakeStoreAccountInfoProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  suffix | string | No | the optional suffix for the Data Lake Store account. |


<a id="StorageAccountProperties" />
### StorageAccountProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  accessKey | string | Yes | the access key associated with this Azure Storage account that will be used to connect to it. |
|  suffix | string | No | the optional suffix for the storage account. |


<a id="FirewallRuleProperties" />
### FirewallRuleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  startIpAddress | string | Yes | the start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. |
|  endIpAddress | string | Yes | the end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. |


<a id="ComputePolicyPropertiesCreateParameters" />
### ComputePolicyPropertiesCreateParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  objectId | string | Yes | The AAD object identifier for the entity to create a policy for. - globally unique identifier |
|  objectType | enum | Yes | The type of AAD object the object identifier refers to. - User, Group, ServicePrincipal |
|  maxDegreeOfParallelismPerJob | integer | No | The maximum degree of parallelism per job this user can use to submit jobs. This property, the min priority per job property, or both must be passed. |
|  minPriorityPerJob | integer | No | The minimum priority per job this user can use to submit jobs. This property, the max degree of parallelism per job property, or both must be passed. |

