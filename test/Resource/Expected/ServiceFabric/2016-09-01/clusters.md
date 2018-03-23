# Microsoft.ServiceFabric/clusters template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.ServiceFabric/clusters resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceFabric/clusters",
  "apiVersion": "2016-09-01",
  "location": "string",
  "tags": {},
  "properties": {
    "clusterCodeVersion": "string",
    "certificate": {
      "thumbprint": "string",
      "thumbprintSecondary": "string",
      "x509StoreName": "string"
    },
    "reliabilityLevel": "string",
    "upgradeMode": "string",
    "clientCertificateThumbprints": [
      {
        "isAdmin": boolean,
        "certificateThumbprint": "string"
      }
    ],
    "clientCertificateCommonNames": [
      {
        "isAdmin": boolean,
        "certificateCommonName": "string",
        "certificateIssuerThumbprint": "string"
      }
    ],
    "fabricSettings": [
      {
        "name": "string",
        "parameters": [
          {
            "name": "string",
            "value": "string"
          }
        ]
      }
    ],
    "reverseProxyCertificate": {
      "thumbprint": "string",
      "thumbprintSecondary": "string",
      "x509StoreName": "string"
    },
    "managementEndpoint": "string",
    "nodeTypes": [
      {
        "name": "string",
        "placementProperties": {},
        "capacities": {},
        "clientConnectionEndpointPort": "integer",
        "httpGatewayEndpointPort": "integer",
        "durabilityLevel": "string",
        "applicationPorts": {
          "startPort": "integer",
          "endPort": "integer"
        },
        "ephemeralPorts": {
          "startPort": "integer",
          "endPort": "integer"
        },
        "isPrimary": boolean,
        "vmInstanceCount": "integer",
        "reverseProxyEndpointPort": "integer"
      }
    ],
    "azureActiveDirectory": {
      "tenantId": "string",
      "clusterApplication": "string",
      "clientApplication": "string"
    },
    "vmImage": "string",
    "diagnosticsStorageAccountConfig": {
      "storageAccountName": "string",
      "protectedAccountKeyName": "string",
      "blobEndpoint": "string",
      "queueEndpoint": "string",
      "tableEndpoint": "string"
    },
    "upgradeDescription": {
      "overrideUserUpgradePolicy": boolean,
      "forceRestart": boolean,
      "upgradeReplicaSetCheckTimeout": "string",
      "healthCheckWaitDuration": "string",
      "healthCheckStableDuration": "string",
      "healthCheckRetryTimeout": "string",
      "upgradeTimeout": "string",
      "upgradeDomainTimeout": "string",
      "healthPolicy": {
        "maxPercentUnhealthyNodes": "integer",
        "maxPercentUnhealthyApplications": "integer"
      },
      "deltaHealthPolicy": {
        "maxPercentDeltaUnhealthyNodes": "integer",
        "maxPercentUpgradeDomainDeltaUnhealthyNodes": "integer",
        "maxPercentDeltaUnhealthyApplications": "integer"
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceFabric/clusters" />
### Microsoft.ServiceFabric/clusters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the cluster resource |
|  type | enum | Yes | Microsoft.ServiceFabric/clusters |
|  apiVersion | enum | Yes | 2016-09-01 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [ClusterProperties object](#ClusterProperties) |


<a id="ClusterProperties" />
### ClusterProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  clusterCodeVersion | string | No | The ServiceFabric code version running in your cluster |
|  certificate | object | No | This primay certificate will be used as cluster node to node security, SSL certificate for cluster management endpoint and default admin client - [CertificateDescription object](#CertificateDescription) |
|  reliabilityLevel | enum | No | Cluster reliability level indicates replica set size of system service. - Bronze, Silver, Gold, Platinum |
|  upgradeMode | enum | No | Cluster upgrade mode indicates if fabric upgrade is initiated automatically by the system or not. - Automatic or Manual |
|  clientCertificateThumbprints | array | No | The client thumbprint details ,it is used for client access for cluster operation - [ClientCertificateThumbprint object](#ClientCertificateThumbprint) |
|  clientCertificateCommonNames | array | No |  List of client certificates to whitelist based on common names - [ClientCertificateCommonName object](#ClientCertificateCommonName) |
|  fabricSettings | array | No | List of custom fabric settings to configure the cluster. - [SettingsSectionDescription object](#SettingsSectionDescription) |
|  reverseProxyCertificate | object | No | The server certificate used by reverse proxy - [CertificateDescription object](#CertificateDescription) |
|  managementEndpoint | string | Yes | The http management endpoint of the cluster |
|  nodeTypes | array | Yes | The list of nodetypes that make up the cluster - [NodeTypeDescription object](#NodeTypeDescription) |
|  azureActiveDirectory | object | No | The settings to enable AAD authentication on the cluster - [AzureActiveDirectory object](#AzureActiveDirectory) |
|  vmImage | string | No | The name of VM image VMSS has been configured with. Generic names such as Windows or Linux can be used. |
|  diagnosticsStorageAccountConfig | object | No | The storage diagnostics account configuration details - [DiagnosticsStorageAccountConfig object](#DiagnosticsStorageAccountConfig) |
|  upgradeDescription | object | No | The policy to use when upgrading the cluster. - [ClusterUpgradePolicy object](#ClusterUpgradePolicy) |


<a id="CertificateDescription" />
### CertificateDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thumbprint | string | Yes | Thumbprint of the primary certificate |
|  thumbprintSecondary | string | No | Thumbprint of the secondary certificate |
|  x509StoreName | enum | No | The local certificate store location. - AddressBook, AuthRoot, CertificateAuthority, Disallowed, My, Root, TrustedPeople, TrustedPublisher |


<a id="ClientCertificateThumbprint" />
### ClientCertificateThumbprint object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isAdmin | boolean | Yes | Is this certificate used for admin access from the client, if false, it is used or query only access |
|  certificateThumbprint | string | Yes | Certificate thumbprint |


<a id="ClientCertificateCommonName" />
### ClientCertificateCommonName object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isAdmin | boolean | Yes | Is this certificate used for admin access from the client, if false , it is used or query only access |
|  certificateCommonName | string | Yes | Certificate common name to be granted access; be carefull using wild card common names |
|  certificateIssuerThumbprint | string | Yes | Certificate issuer thumbprint |


<a id="SettingsSectionDescription" />
### SettingsSectionDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of settings section |
|  parameters | array | Yes | Collection of settings in the section, each setting is a tuple consisting of setting name and value - [SettingsParameterDescription object](#SettingsParameterDescription) |


<a id="NodeTypeDescription" />
### NodeTypeDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Name of the node type |
|  placementProperties | object | No | The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run |
|  capacities | object | No | The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much of a resource a node has |
|  clientConnectionEndpointPort | integer | Yes | The TCP cluster management endpoint port |
|  httpGatewayEndpointPort | integer | Yes | The HTTP cluster management endpoint port |
|  durabilityLevel | enum | No | Nodetype durability Level. - Bronze, Silver, Gold |
|  applicationPorts | object | No | Ports used by applications - [EndpointRangeDescription object](#EndpointRangeDescription) |
|  ephemeralPorts | object | No | System assgined application ports - [EndpointRangeDescription object](#EndpointRangeDescription) |
|  isPrimary | boolean | Yes | Mark this as the primary node type |
|  vmInstanceCount | integer | Yes | The number of node instances in the node type |
|  reverseProxyEndpointPort | integer | No | Endpoint used by reverse proxy |


<a id="AzureActiveDirectory" />
### AzureActiveDirectory object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  tenantId | string | No | Azure active directory tenant id |
|  clusterApplication | string | No | Azure active directory cluster application id |
|  clientApplication | string | No | Azure active directory client application id |


<a id="DiagnosticsStorageAccountConfig" />
### DiagnosticsStorageAccountConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountName | string | Yes | Diagnostics storage account name |
|  protectedAccountKeyName | string | Yes | Protected Diagnostics storage key name |
|  blobEndpoint | string | Yes | Diagnostics storage account blob endpoint |
|  queueEndpoint | string | Yes | Diagnostics storage account queue endpoint |
|  tableEndpoint | string | Yes | Diagnostics storage account table endpoint |


<a id="ClusterUpgradePolicy" />
### ClusterUpgradePolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  overrideUserUpgradePolicy | boolean | No | Use the user defined upgrade policy or not |
|  forceRestart | boolean | No | Force node to restart or not |
|  upgradeReplicaSetCheckTimeout | string | Yes | Timeout for replica set upgrade to complete,it represents .Net TimeSpan |
|  healthCheckWaitDuration | string | Yes | The length of time to wait after completing an upgrade domain before performing health checks, it represents .Net TimeSpan |
|  healthCheckStableDuration | string | Yes | The length of time that health checks must pass continuously,it represents .Net TimeSpan |
|  healthCheckRetryTimeout | string | Yes | The length of time that health checks can fail continuously,it represents .Net TimeSpan |
|  upgradeTimeout | string | Yes | The upgrade timeout,it represents .Net TimeSpan |
|  upgradeDomainTimeout | string | Yes | The timeout for any upgrade domain,it represents .Net TimeSpan |
|  healthPolicy | object | Yes | Cluster health Policy - [ClusterHealthPolicy object](#ClusterHealthPolicy) |
|  deltaHealthPolicy | object | No | Delta health policy - [ClusterUpgradeDeltaHealthPolicy object](#ClusterUpgradeDeltaHealthPolicy) |


<a id="SettingsParameterDescription" />
### SettingsParameterDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of settings property |
|  value | string | Yes | The value of the property |


<a id="EndpointRangeDescription" />
### EndpointRangeDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  startPort | integer | Yes | Starting port of a range of ports |
|  endPort | integer | Yes | End port of a range of ports |


<a id="ClusterHealthPolicy" />
### ClusterHealthPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxPercentUnhealthyNodes | integer | No | The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.  |
|  maxPercentUnhealthyApplications | integer | No | The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.  |


<a id="ClusterUpgradeDeltaHealthPolicy" />
### ClusterUpgradeDeltaHealthPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxPercentDeltaUnhealthyNodes | integer | Yes | Additional unhealthy nodes percentage |
|  maxPercentUpgradeDomainDeltaUnhealthyNodes | integer | Yes | Additional unhealthy nodes percentage per upgrade domain  |
|  maxPercentDeltaUnhealthyApplications | integer | Yes | Additional unhealthy applications percentage |

