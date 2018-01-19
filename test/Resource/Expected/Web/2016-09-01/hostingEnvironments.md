# Microsoft.Web/hostingEnvironments template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Web/hostingEnvironments resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/hostingEnvironments",
  "apiVersion": "2016-09-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "name": "string",
    "location": "string",
    "vnetName": "string",
    "vnetResourceGroupName": "string",
    "vnetSubnetName": "string",
    "virtualNetwork": {
      "id": "string",
      "subnet": "string"
    },
    "internalLoadBalancingMode": "string",
    "multiSize": "string",
    "multiRoleCount": "integer",
    "workerPools": [
      {
        "workerSizeId": "integer",
        "computeMode": "string",
        "workerSize": "string",
        "workerCount": "integer"
      }
    ],
    "ipsslAddressCount": "integer",
    "dnsSuffix": "string",
    "networkAccessControlList": [
      {
        "action": "string",
        "description": "string",
        "order": "integer",
        "remoteSubnet": "string"
      }
    ],
    "frontEndScaleFactor": "integer",
    "apiManagementAccountId": "string",
    "suspended": boolean,
    "dynamicCacheEnabled": boolean,
    "clusterSettings": [
      {
        "name": "string",
        "value": "string"
      }
    ],
    "userWhitelistedIpRanges": [
      "string"
    ]
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/hostingEnvironments" />
### Microsoft.Web/hostingEnvironments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/hostingEnvironments |
|  apiVersion | enum | Yes | 2016-09-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Core resource properties - [AppServiceEnvironment object](#AppServiceEnvironment) |
|  resources | array | No | [workerPools](./hostingEnvironments/workerPools.md) |


<a id="AppServiceEnvironment" />
### AppServiceEnvironment object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Name of the App Service Environment. |
|  location | string | Yes | Location of the App Service Environment, e.g. "West US". |
|  vnetName | string | No | Name of the Virtual Network for the App Service Environment. |
|  vnetResourceGroupName | string | No | Resource group of the Virtual Network. |
|  vnetSubnetName | string | No | Subnet of the Virtual Network. |
|  virtualNetwork | object | Yes | Description of the Virtual Network. - [VirtualNetworkProfile object](#VirtualNetworkProfile) |
|  internalLoadBalancingMode | enum | No | Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. - None, Web, Publishing |
|  multiSize | string | No | Front-end VM size, e.g. "Medium", "Large". |
|  multiRoleCount | integer | No | Number of front-end instances. |
|  workerPools | array | Yes | Description of worker pools with worker size IDs, VM sizes, and number of workers in each pool. - [WorkerPool object](#WorkerPool) |
|  ipsslAddressCount | integer | No | Number of IP SSL addresses reserved for the App Service Environment. |
|  dnsSuffix | string | No | DNS suffix of the App Service Environment. |
|  networkAccessControlList | array | No | Access control list for controlling traffic to the App Service Environment. - [NetworkAccessControlEntry object](#NetworkAccessControlEntry) |
|  frontEndScaleFactor | integer | No | Scale factor for front-ends. |
|  apiManagementAccountId | string | No | API Management Account associated with the App Service Environment. |
|  suspended | boolean | No | <code>true</code> if the App Service Environment is suspended; otherwise, <code>false</code>. The environment can be suspended, e.g. when the management endpoint is no longer available (most likely because NSG blocked the incoming traffic). |
|  dynamicCacheEnabled | boolean | No | True/false indicating whether the App Service Environment is suspended. The environment can be suspended e.g. when the management endpoint is no longer available(most likely because NSG blocked the incoming traffic). |
|  clusterSettings | array | No | Custom settings for changing the behavior of the App Service Environment. - [NameValuePair object](#NameValuePair) |
|  userWhitelistedIpRanges | array | No | User added ip ranges to whitelist on ASE db - string |


<a id="VirtualNetworkProfile" />
### VirtualNetworkProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource id of the Virtual Network. |
|  subnet | string | No | Subnet within the Virtual Network. |


<a id="WorkerPool" />
### WorkerPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  workerSizeId | integer | No | Worker size ID for referencing this worker pool. |
|  computeMode | enum | No | Shared or dedicated app hosting. - Shared, Dedicated, Dynamic |
|  workerSize | string | No | VM size of the worker pool instances. |
|  workerCount | integer | No | Number of instances in the worker pool. |


<a id="NetworkAccessControlEntry" />
### NetworkAccessControlEntry object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  action | enum | No | Action object. - Permit or Deny |
|  description | string | No | Description of network access control entry. |
|  order | integer | No | Order of precedence. |
|  remoteSubnet | string | No | Remote subnet. |


<a id="NameValuePair" />
### NameValuePair object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Pair name. |
|  value | string | No | Pair value. |

