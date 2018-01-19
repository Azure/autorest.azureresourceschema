# Microsoft.ContainerService/containerServices template reference
API Version: 2017-07-01
## Template format

To create a Microsoft.ContainerService/containerServices resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ContainerService/containerServices",
  "apiVersion": "2017-07-01",
  "location": "string",
  "tags": {},
  "properties": {
    "orchestratorProfile": {
      "orchestratorType": "string",
      "orchestratorVersion": "string"
    },
    "customProfile": {
      "orchestrator": "string"
    },
    "servicePrincipalProfile": {
      "clientId": "string",
      "secret": "string",
      "keyVaultSecretRef": {
        "vaultID": "string",
        "secretName": "string",
        "version": "string"
      }
    },
    "masterProfile": {
      "count": "integer",
      "dnsPrefix": "string",
      "vmSize": "string",
      "osDiskSizeGB": "integer",
      "vnetSubnetID": "string",
      "firstConsecutiveStaticIP": "string",
      "storageProfile": "string"
    },
    "agentPoolProfiles": [
      {
        "name": "string",
        "count": "integer",
        "vmSize": "string",
        "osDiskSizeGB": "integer",
        "dnsPrefix": "string",
        "ports": [
          "integer"
        ],
        "storageProfile": "string",
        "vnetSubnetID": "string",
        "osType": "string"
      }
    ],
    "windowsProfile": {
      "adminUsername": "string",
      "adminPassword": "string"
    },
    "linuxProfile": {
      "adminUsername": "string",
      "ssh": {
        "publicKeys": [
          {
            "keyData": "string"
          }
        ]
      }
    },
    "diagnosticsProfile": {
      "vmDiagnostics": {
        "enabled": boolean
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ContainerService/containerServices" />
### Microsoft.ContainerService/containerServices object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.ContainerService/containerServices |
|  apiVersion | enum | Yes | 2017-07-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | Properties of the container service. - [ContainerServiceProperties object](#ContainerServiceProperties) |


<a id="ContainerServiceProperties" />
### ContainerServiceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  orchestratorProfile | object | Yes | Profile for the container service orchestrator. - [ContainerServiceOrchestratorProfile object](#ContainerServiceOrchestratorProfile) |
|  customProfile | object | No | Properties to configure a custom container service cluster. - [ContainerServiceCustomProfile object](#ContainerServiceCustomProfile) |
|  servicePrincipalProfile | object | No | Information about a service principal identity for the cluster to use for manipulating Azure APIs. Exact one of secret or keyVaultSecretRef need to be specified. - [ContainerServiceServicePrincipalProfile object](#ContainerServiceServicePrincipalProfile) |
|  masterProfile | object | Yes | Profile for the container service master. - [ContainerServiceMasterProfile object](#ContainerServiceMasterProfile) |
|  agentPoolProfiles | array | No | Properties of the agent pool. - [ContainerServiceAgentPoolProfile object](#ContainerServiceAgentPoolProfile) |
|  windowsProfile | object | No | Profile for Windows VMs in the container service cluster. - [ContainerServiceWindowsProfile object](#ContainerServiceWindowsProfile) |
|  linuxProfile | object | Yes | Profile for Linux VMs in the container service cluster. - [ContainerServiceLinuxProfile object](#ContainerServiceLinuxProfile) |
|  diagnosticsProfile | object | No | Profile for diagnostics in the container service cluster. - [ContainerServiceDiagnosticsProfile object](#ContainerServiceDiagnosticsProfile) |


<a id="ContainerServiceOrchestratorProfile" />
### ContainerServiceOrchestratorProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  orchestratorType | enum | Yes | The orchestrator to use to manage container service cluster resources. Valid values are Kubernetes, Swarm, DCOS, DockerCE and Custom. - Kubernetes, Swarm, DCOS, DockerCE, Custom |
|  orchestratorVersion | string | No | The version of the orchestrator to use. You can specify the major.minor.patch part of the actual version.For example, you can specify version as "1.6.11". |


<a id="ContainerServiceCustomProfile" />
### ContainerServiceCustomProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  orchestrator | string | Yes | The name of the custom orchestrator to use. |


<a id="ContainerServiceServicePrincipalProfile" />
### ContainerServiceServicePrincipalProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  clientId | string | Yes | The ID for the service principal. |
|  secret | string | No | The secret password associated with the service principal in plain text. |
|  keyVaultSecretRef | object | No | Reference to a secret stored in Azure Key Vault. - [KeyVaultSecretRef object](#KeyVaultSecretRef) |


<a id="ContainerServiceMasterProfile" />
### ContainerServiceMasterProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  count | integer | No | Number of masters (VMs) in the container service cluster. Allowed values are 1, 3, and 5. The default value is 1. |
|  dnsPrefix | string | Yes | DNS prefix to be used to create the FQDN for the master pool. |
|  vmSize | enum | Yes | Size of agent VMs. - Standard_A0, Standard_A1, Standard_A10, Standard_A11, Standard_A1_v2, Standard_A2, Standard_A2_v2, Standard_A2m_v2, Standard_A3, Standard_A4, Standard_A4_v2, Standard_A4m_v2, Standard_A5, Standard_A6, Standard_A7, Standard_A8, Standard_A8_v2, Standard_A8m_v2, Standard_A9, Standard_D1, Standard_D11, Standard_D11_v2, Standard_D11_v2_Promo, Standard_D12, Standard_D12_v2, Standard_D12_v2_Promo, Standard_D13, Standard_D13_v2, Standard_D13_v2_Promo, Standard_D14, Standard_D14_v2, Standard_D14_v2_Promo, Standard_D15_v2, Standard_D16_v3, Standard_D16s_v3, Standard_D1_v2, Standard_D2, Standard_D2_v2, Standard_D2_v2_Promo, Standard_D2_v3, Standard_D2s_v3, Standard_D3, Standard_D3_v2, Standard_D3_v2_Promo, Standard_D4, Standard_D4_v2, Standard_D4_v2_Promo, Standard_D4_v3, Standard_D4s_v3, Standard_D5_v2, Standard_D5_v2_Promo, Standard_D8_v3, Standard_D8s_v3, Standard_DS1, Standard_DS11, Standard_DS11_v2, Standard_DS11_v2_Promo, Standard_DS12, Standard_DS12_v2, Standard_DS12_v2_Promo, Standard_DS13, Standard_DS13_v2, Standard_DS13_v2_Promo, Standard_DS14, Standard_DS14_v2, Standard_DS14_v2_Promo, Standard_DS15_v2, Standard_DS1_v2, Standard_DS2, Standard_DS2_v2, Standard_DS2_v2_Promo, Standard_DS3, Standard_DS3_v2, Standard_DS3_v2_Promo, Standard_DS4, Standard_DS4_v2, Standard_DS4_v2_Promo, Standard_DS5_v2, Standard_DS5_v2_Promo, Standard_E16_v3, Standard_E16s_v3, Standard_E2_v3, Standard_E2s_v3, Standard_E32_v3, Standard_E32s_v3, Standard_E4_v3, Standard_E4s_v3, Standard_E64_v3, Standard_E64s_v3, Standard_E8_v3, Standard_E8s_v3, Standard_F1, Standard_F16, Standard_F16s, Standard_F1s, Standard_F2, Standard_F2s, Standard_F4, Standard_F4s, Standard_F8, Standard_F8s, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5, Standard_H16, Standard_H16m, Standard_H16mr, Standard_H16r, Standard_H8, Standard_H8m, Standard_L16s, Standard_L32s, Standard_L4s, Standard_L8s, Standard_M128s, Standard_M64ms, Standard_NC12, Standard_NC24, Standard_NC24r, Standard_NC6, Standard_NV12, Standard_NV24, Standard_NV6 |
|  osDiskSizeGB | integer | No | OS Disk Size in GB to be used to specify the disk size for every machine in this master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified. |
|  vnetSubnetID | string | No | VNet SubnetID specifies the vnet's subnet identifier. If you specify either master VNet Subnet, or agent VNet Subnet, you need to specify both. And they have to be in the same VNet. |
|  firstConsecutiveStaticIP | string | No | FirstConsecutiveStaticIP used to specify the first static ip of masters. |
|  storageProfile | enum | No | Storage profile specifies what kind of storage used. Choose from StorageAccount and ManagedDisks. Leave it empty, we will choose for you based on the orchestrator choice. - StorageAccount or ManagedDisks |


<a id="ContainerServiceAgentPoolProfile" />
### ContainerServiceAgentPoolProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Unique name of the agent pool profile in the context of the subscription and resource group. |
|  count | integer | No | Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.  |
|  vmSize | enum | Yes | Size of agent VMs. - Standard_A0, Standard_A1, Standard_A10, Standard_A11, Standard_A1_v2, Standard_A2, Standard_A2_v2, Standard_A2m_v2, Standard_A3, Standard_A4, Standard_A4_v2, Standard_A4m_v2, Standard_A5, Standard_A6, Standard_A7, Standard_A8, Standard_A8_v2, Standard_A8m_v2, Standard_A9, Standard_D1, Standard_D11, Standard_D11_v2, Standard_D11_v2_Promo, Standard_D12, Standard_D12_v2, Standard_D12_v2_Promo, Standard_D13, Standard_D13_v2, Standard_D13_v2_Promo, Standard_D14, Standard_D14_v2, Standard_D14_v2_Promo, Standard_D15_v2, Standard_D16_v3, Standard_D16s_v3, Standard_D1_v2, Standard_D2, Standard_D2_v2, Standard_D2_v2_Promo, Standard_D2_v3, Standard_D2s_v3, Standard_D3, Standard_D3_v2, Standard_D3_v2_Promo, Standard_D4, Standard_D4_v2, Standard_D4_v2_Promo, Standard_D4_v3, Standard_D4s_v3, Standard_D5_v2, Standard_D5_v2_Promo, Standard_D8_v3, Standard_D8s_v3, Standard_DS1, Standard_DS11, Standard_DS11_v2, Standard_DS11_v2_Promo, Standard_DS12, Standard_DS12_v2, Standard_DS12_v2_Promo, Standard_DS13, Standard_DS13_v2, Standard_DS13_v2_Promo, Standard_DS14, Standard_DS14_v2, Standard_DS14_v2_Promo, Standard_DS15_v2, Standard_DS1_v2, Standard_DS2, Standard_DS2_v2, Standard_DS2_v2_Promo, Standard_DS3, Standard_DS3_v2, Standard_DS3_v2_Promo, Standard_DS4, Standard_DS4_v2, Standard_DS4_v2_Promo, Standard_DS5_v2, Standard_DS5_v2_Promo, Standard_E16_v3, Standard_E16s_v3, Standard_E2_v3, Standard_E2s_v3, Standard_E32_v3, Standard_E32s_v3, Standard_E4_v3, Standard_E4s_v3, Standard_E64_v3, Standard_E64s_v3, Standard_E8_v3, Standard_E8s_v3, Standard_F1, Standard_F16, Standard_F16s, Standard_F1s, Standard_F2, Standard_F2s, Standard_F4, Standard_F4s, Standard_F8, Standard_F8s, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5, Standard_H16, Standard_H16m, Standard_H16mr, Standard_H16r, Standard_H8, Standard_H8m, Standard_L16s, Standard_L32s, Standard_L4s, Standard_L8s, Standard_M128s, Standard_M64ms, Standard_NC12, Standard_NC24, Standard_NC24r, Standard_NC6, Standard_NV12, Standard_NV24, Standard_NV6 |
|  osDiskSizeGB | integer | No | OS Disk Size in GB to be used to specify the disk size for every machine in this master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified. |
|  dnsPrefix | string | No | DNS prefix to be used to create the FQDN for the agent pool. |
|  ports | array | No | Ports number array used to expose on this agent pool. The default opened ports are different based on your choice of orchestrator. - integer |
|  storageProfile | enum | No | Storage profile specifies what kind of storage used. Choose from StorageAccount and ManagedDisks. Leave it empty, we will choose for you based on the orchestrator choice. - StorageAccount or ManagedDisks |
|  vnetSubnetID | string | No | VNet SubnetID specifies the vnet's subnet identifier. If you specify either master VNet Subnet, or agent VNet Subnet, you need to specify both. And they have to be in the same VNet. |
|  osType | enum | No | OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux. - Linux or Windows |


<a id="ContainerServiceWindowsProfile" />
### ContainerServiceWindowsProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  adminUsername | string | Yes | The administrator username to use for Windows VMs. |
|  adminPassword | string | Yes | The administrator password to use for Windows VMs. |


<a id="ContainerServiceLinuxProfile" />
### ContainerServiceLinuxProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  adminUsername | string | Yes | The administrator username to use for Linux VMs. |
|  ssh | object | Yes | SSH configuration for Linux-based VMs running on Azure. - [ContainerServiceSshConfiguration object](#ContainerServiceSshConfiguration) |


<a id="ContainerServiceDiagnosticsProfile" />
### ContainerServiceDiagnosticsProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vmDiagnostics | object | Yes | Profile for diagnostics on the container service VMs. - [ContainerServiceVMDiagnostics object](#ContainerServiceVMDiagnostics) |


<a id="KeyVaultSecretRef" />
### KeyVaultSecretRef object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vaultID | string | Yes | Key vault identifier. |
|  secretName | string | Yes | The secret name. |
|  version | string | No | The secret version. |


<a id="ContainerServiceSshConfiguration" />
### ContainerServiceSshConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicKeys | array | Yes | The list of SSH public keys used to authenticate with Linux-based VMs. Only expect one key specified. - [ContainerServiceSshPublicKey object](#ContainerServiceSshPublicKey) |


<a id="ContainerServiceVMDiagnostics" />
### ContainerServiceVMDiagnostics object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | Yes | Whether the VM diagnostic agent is provisioned on the VM. |


<a id="ContainerServiceSshPublicKey" />
### ContainerServiceSshPublicKey object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyData | string | Yes | Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. |

