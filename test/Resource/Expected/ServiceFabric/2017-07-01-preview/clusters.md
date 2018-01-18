# Microsoft.ServiceFabric/clusters template reference
API Version: 2017-07-01-preview
## Template format

To create a Microsoft.ServiceFabric/clusters resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceFabric/clusters",
  "apiVersion": "2017-07-01-preview",
  "location": "string",
  "tags": {},
  "properties": {
    "availableClusterVersions": [
      {
        "codeVersion": "string",
        "supportExpiryUtc": "string",
        "environment": "string"
      }
    ],
    "clusterState": "string",
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
    },
    "addOnFeatures": [
      "string"
    ]
  },
  "resources": []
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
|  apiVersion | enum | Yes | 2017-07-01-preview |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | The cluster resource properties - [ClusterProperties object](#ClusterProperties) |
|  resources | array | No | [applications](./clusters/applications.md) [applicationTypes](./clusters/applicationTypes.md) |


<a id="ClusterProperties" />
### ClusterProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  availableClusterVersions | array | No | The Service Fabric runtime versions available for this cluster. - [ClusterVersionDetails object](#ClusterVersionDetails) |
|  clusterState | enum | No | WaitingForNodes, Deploying, BaselineUpgrade, UpdatingUserConfiguration, UpdatingUserCertificate, UpdatingInfrastructure, EnforcingClusterVersion, UpgradeServiceUnreachable, AutoScale, Ready |
|  clusterCodeVersion | string | No | The Service Fabric runtime version of the cluster. This property can only by set the user when **upgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**. |
|  certificate | object | No | The certificate to use for securing the cluster. The certificate provided will be used for  node to node security within the cluster, SSL certificate for cluster management endpoint and default  admin client. - [CertificateDescription object](#CertificateDescription) |
|  reliabilityLevel | enum | No | None, Bronze, Silver, Gold, Platinum |
|  upgradeMode | enum | No | Automatic or Manual |
|  clientCertificateThumbprints | array | No | The list of client certificates referenced by thumbprint that are allowed to manage the cluster. - [ClientCertificateThumbprint object](#ClientCertificateThumbprint) |
|  clientCertificateCommonNames | array | No | The list of client certificates referenced by common name that are allowed to manage the cluster. - [ClientCertificateCommonName object](#ClientCertificateCommonName) |
|  fabricSettings | array | No | The list of custom fabric settings to configure the cluster. - [SettingsSectionDescription object](#SettingsSectionDescription) |
|  reverseProxyCertificate | object | No | The server certificate used by reverse proxy. - [CertificateDescription object](#CertificateDescription) |
|  managementEndpoint | string | Yes | The http management endpoint of the cluster. |
|  nodeTypes | array | Yes | The list of node types in the cluster. - [NodeTypeDescription object](#NodeTypeDescription) |
|  azureActiveDirectory | object | No | The AAD authentication settings of the cluster. - [AzureActiveDirectory object](#AzureActiveDirectory) |
|  vmImage | string | No | The VM image VMSS has been configured with. Generic names such as Windows or Linux can be used. |
|  diagnosticsStorageAccountConfig | object | No | The storage account information for storing Service Fabric diagnostic logs. - [DiagnosticsStorageAccountConfig object](#DiagnosticsStorageAccountConfig) |
|  upgradeDescription | object | No | The policy to use when upgrading the cluster. - [ClusterUpgradePolicy object](#ClusterUpgradePolicy) |
|  addOnFeatures | array | No | The list of add-on features to enable in the cluster. - RepairManager, DnsService, BackupRestoreService |


<a id="ClusterVersionDetails" />
### ClusterVersionDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  codeVersion | string | No | The Service Fabric runtime version of the cluster. |
|  supportExpiryUtc | string | No | The date of expiry of support of the version. |
|  environment | enum | No | Indicates if this version is for Windows or Linux operating system. - Windows or Linux |


<a id="CertificateDescription" />
### CertificateDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  thumbprint | string | Yes | Thumbprint of the primary certificate. |
|  thumbprintSecondary | string | No | Thumbprint of the secondary certificate. |
|  x509StoreName | enum | No | The local certificate store location. - AddressBook, AuthRoot, CertificateAuthority, Disallowed, My, Root, TrustedPeople, TrustedPublisher |


<a id="ClientCertificateThumbprint" />
### ClientCertificateThumbprint object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isAdmin | boolean | Yes | Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. |
|  certificateThumbprint | string | Yes | The thumbprint of the client certificate. |


<a id="ClientCertificateCommonName" />
### ClientCertificateCommonName object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isAdmin | boolean | Yes | Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. |
|  certificateCommonName | string | Yes | The common name of the client certificate. |
|  certificateIssuerThumbprint | string | Yes | The issuer thumbprint of the client certificate. |


<a id="SettingsSectionDescription" />
### SettingsSectionDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The section name of the fabric settings. |
|  parameters | array | Yes | The collection of parameters in the section. - [SettingsParameterDescription object](#SettingsParameterDescription) |


<a id="NodeTypeDescription" />
### NodeTypeDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the node type. |
|  placementProperties | object | No | The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. |
|  capacities | object | No | The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. |
|  clientConnectionEndpointPort | integer | Yes | The TCP cluster management endpoint port. |
|  httpGatewayEndpointPort | integer | Yes | The HTTP cluster management endpoint port. |
|  durabilityLevel | enum | No | Bronze, Silver, Gold |
|  applicationPorts | object | No | The range of ports from which cluster assigned port to Service Fabric applications. - [EndpointRangeDescription object](#EndpointRangeDescription) |
|  ephemeralPorts | object | No | The range of empheral ports that nodes in this node type should be configured with. - [EndpointRangeDescription object](#EndpointRangeDescription) |
|  isPrimary | boolean | Yes | The node type on which system services will run. Only one node type should be marked as primary. Primary node type cannot be deleted or changed for existing clusters. |
|  vmInstanceCount | integer | Yes | The number of nodes in the node type. This count should match the capacity property in the corresponding VirtualMachineScaleSet resource. |
|  reverseProxyEndpointPort | integer | No | The endpoint used by reverse proxy. |


<a id="AzureActiveDirectory" />
### AzureActiveDirectory object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  tenantId | string | No | Azure active directory tenant id. |
|  clusterApplication | string | No | Azure active directory cluster application id. |
|  clientApplication | string | No | Azure active directory client application id. |


<a id="DiagnosticsStorageAccountConfig" />
### DiagnosticsStorageAccountConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountName | string | Yes | The Azure storage account name. |
|  protectedAccountKeyName | string | Yes | The protected diagnostics storage key name. |
|  blobEndpoint | string | Yes | The blob endpoint of the azure storage account. |
|  queueEndpoint | string | Yes | The queue endpoint of the azure storage account. |
|  tableEndpoint | string | Yes | The table endpoint of the azure storage account. |


<a id="ClusterUpgradePolicy" />
### ClusterUpgradePolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  forceRestart | boolean | No | If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). |
|  upgradeReplicaSetCheckTimeout | string | Yes | The maximum amount of time to block processing of an upgrade domain and revent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. |
|  healthCheckWaitDuration | string | Yes | The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. |
|  healthCheckStableDuration | string | Yes | The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. |
|  healthCheckRetryTimeout | string | Yes | The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. |
|  upgradeTimeout | string | Yes | The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. |
|  upgradeDomainTimeout | string | Yes | The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. |
|  healthPolicy | object | Yes | The cluster health policy used when upgrading the cluster. - [ClusterHealthPolicy object](#ClusterHealthPolicy) |
|  deltaHealthPolicy | object | No | The delta health policy used when upgrading the cluster. - [ClusterUpgradeDeltaHealthPolicy object](#ClusterUpgradeDeltaHealthPolicy) |


<a id="SettingsParameterDescription" />
### SettingsParameterDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The parameter name of fabric setting. |
|  value | string | Yes | The parameter value of fabric setting. |


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
|  maxPercentDeltaUnhealthyNodes | integer | Yes | The maximum allowed percentage of nodes health degradation allowed during cluster upgrades. The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation. The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. |
|  maxPercentUpgradeDomainDeltaUnhealthyNodes | integer | Yes | The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades. The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation. The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.  |
|  maxPercentDeltaUnhealthyApplications | integer | Yes | The maximum allowed percentage of applications health degradation allowed during cluster upgrades. The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation. The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this. |

