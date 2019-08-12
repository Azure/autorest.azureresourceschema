# Microsoft.Batch/batchAccounts/pools template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Batch/batchAccounts/pools resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Batch/batchAccounts/pools",
  "apiVersion": "2017-09-01",
  "properties": {
    "displayName": "string",
    "vmSize": "string",
    "deploymentConfiguration": {
      "cloudServiceConfiguration": {
        "osFamily": "string",
        "targetOSVersion": "string",
        "currentOSVersion": "string"
      },
      "virtualMachineConfiguration": {
        "imageReference": {
          "publisher": "string",
          "offer": "string",
          "sku": "string",
          "version": "string",
          "id": "string"
        },
        "osDisk": {
          "caching": "string"
        },
        "nodeAgentSkuId": "string",
        "windowsConfiguration": {
          "enableAutomaticUpdates": "boolean"
        },
        "dataDisks": [
          {
            "lun": "integer",
            "caching": "string",
            "diskSizeGB": "integer",
            "storageAccountType": "string"
          }
        ],
        "licenseType": "string"
      }
    },
    "scaleSettings": {
      "fixedScale": {
        "resizeTimeout": "string",
        "targetDedicatedNodes": "integer",
        "targetLowPriorityNodes": "integer",
        "nodeDeallocationOption": "string"
      },
      "autoScale": {
        "formula": "string",
        "evaluationInterval": "string"
      }
    },
    "interNodeCommunication": "string",
    "networkConfiguration": {
      "subnetId": "string",
      "endpointConfiguration": {
        "inboundNatPools": [
          {
            "name": "string",
            "protocol": "string",
            "backendPort": "integer",
            "frontendPortRangeStart": "integer",
            "frontendPortRangeEnd": "integer",
            "networkSecurityGroupRules": [
              {
                "priority": "integer",
                "access": "string",
                "sourceAddressPrefix": "string"
              }
            ]
          }
        ]
      }
    },
    "maxTasksPerNode": "integer",
    "taskSchedulingPolicy": {
      "nodeFillType": "string"
    },
    "userAccounts": [
      {
        "name": "string",
        "password": "string",
        "elevationLevel": "string",
        "linuxUserConfiguration": {
          "uid": "integer",
          "gid": "integer",
          "sshPrivateKey": "string"
        }
      }
    ],
    "metadata": [
      {
        "name": "string",
        "value": "string"
      }
    ],
    "startTask": {
      "commandLine": "string",
      "resourceFiles": [
        {
          "blobSource": "string",
          "filePath": "string",
          "fileMode": "string"
        }
      ],
      "environmentSettings": [
        {
          "name": "string",
          "value": "string"
        }
      ],
      "userIdentity": {
        "userName": "string",
        "autoUser": {
          "scope": "string",
          "elevationLevel": "string"
        }
      },
      "maxTaskRetryCount": "integer",
      "waitForSuccess": "boolean"
    },
    "certificates": [
      {
        "id": "string",
        "storeLocation": "string",
        "storeName": "string",
        "visibility": [
          "string"
        ]
      }
    ],
    "applicationPackages": [
      {
        "id": "string",
        "version": "string"
      }
    ],
    "applicationLicenses": [
      "string"
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Batch/batchAccounts/pools" />
### Microsoft.Batch/batchAccounts/pools object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The pool name. This must be unique within the account. |
|  type | enum | Yes | Microsoft.Batch/batchAccounts/pools |
|  apiVersion | enum | Yes | 2017-09-01 |
|  properties | object | Yes | The properties associated with the pool. - [PoolProperties object](#PoolProperties) |


<a id="PoolProperties" />
### PoolProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  displayName | string | No | The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. |
|  vmSize | string | No | For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (http://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). |
|  deploymentConfiguration | object | No | Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS). - [DeploymentConfiguration object](#DeploymentConfiguration) |
|  scaleSettings | object | No | [ScaleSettings object](#ScaleSettings) |
|  interNodeCommunication | enum | No | This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'. - Enabled or Disabled |
|  networkConfiguration | object | No | [NetworkConfiguration object](#NetworkConfiguration) |
|  maxTasksPerNode | integer | No |  |
|  taskSchedulingPolicy | object | No | [TaskSchedulingPolicy object](#TaskSchedulingPolicy) |
|  userAccounts | array | No | [UserAccount object](#UserAccount) |
|  metadata | array | No | The Batch service does not assign any meaning to metadata; it is solely for the use of user code. - [MetadataItem object](#MetadataItem) |
|  startTask | object | No | In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool. - [StartTask object](#StartTask) |
|  certificates | array | No | For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory. - [CertificateReference object](#CertificateReference) |
|  applicationPackages | array | No | Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged. - [ApplicationPackageReference object](#ApplicationPackageReference) |
|  applicationLicenses | array | No | The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail. - string |


<a id="DeploymentConfiguration" />
### DeploymentConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  cloudServiceConfiguration | object | No | This property and virtualMachineConfiguration are mutually exclusive and one of the properties must be specified. This property cannot be specified if the Batch account was created with its poolAllocationMode property set to 'UserSubscription'. - [CloudServiceConfiguration object](#CloudServiceConfiguration) |
|  virtualMachineConfiguration | object | No | This property and cloudServiceConfiguration are mutually exclusive and one of the properties must be specified. - [VirtualMachineConfiguration object](#VirtualMachineConfiguration) |


<a id="ScaleSettings" />
### ScaleSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  fixedScale | object | No | This property and autoScale are mutually exclusive and one of the properties must be specified. - [FixedScaleSettings object](#FixedScaleSettings) |
|  autoScale | object | No | This property and fixedScale are mutually exclusive and one of the properties must be specified. - [AutoScaleSettings object](#AutoScaleSettings) |


<a id="NetworkConfiguration" />
### NetworkConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  subnetId | string | No | The virtual network must be in the same region and subscription as the Azure Batch account. The specified subnet should have enough free IP addresses to accommodate the number of nodes in the pool. If the subnet doesn't have enough free IP addresses, the pool will partially allocate compute nodes, and a resize error will occur. The 'MicrosoftAzureBatch' service principal must have the 'Classic Virtual Machine Contributor' Role-Based Access Control (RBAC) role for the specified VNet. The specified subnet must allow communication from the Azure Batch service to be able to schedule tasks on the compute nodes. This can be verified by checking if the specified VNet has any associated Network Security Groups (NSG). If communication to the compute nodes in the specified subnet is denied by an NSG, then the Batch service will set the state of the compute nodes to unusable. For pools created via virtualMachineConfiguration the Batch account must have poolAllocationMode userSubscription in order to use a VNet. If the specified VNet has any associated Network Security Groups (NSG), then a few reserved system ports must be enabled for inbound communication. For pools created with a virtual machine configuration, enable ports 29876 and 29877, as well as port 22 for Linux and port 3389 for Windows. For pools created with a cloud service configuration, enable ports 10100, 20100, and 30100. Also enable outbound connections to Azure Storage on port 443. For more details see: https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration |
|  endpointConfiguration | object | No | Pool endpoint configuration is only supported on pools with the virtualMachineConfiguration property. - [PoolEndpointConfiguration object](#PoolEndpointConfiguration) |


<a id="TaskSchedulingPolicy" />
### TaskSchedulingPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  nodeFillType | enum | Yes | Spread or Pack |


<a id="UserAccount" />
### UserAccount object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  password | string | Yes |  |
|  elevationLevel | enum | No | nonAdmin - The auto user is a standard user without elevated access. admin - The auto user is a user with elevated access and operates with full Administrator permissions. The default value is nonAdmin. - NonAdmin or Admin |
|  linuxUserConfiguration | object | No | This property is ignored if specified on a Windows pool. If not specified, the user is created with the default options. - [LinuxUserConfiguration object](#LinuxUserConfiguration) |


<a id="MetadataItem" />
### MetadataItem object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  value | string | Yes |  |


<a id="StartTask" />
### StartTask object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  commandLine | string | No | The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. Required if any other properties of the startTask are specified. |
|  resourceFiles | array | No | [ResourceFile object](#ResourceFile) |
|  environmentSettings | array | No | [EnvironmentSetting object](#EnvironmentSetting) |
|  userIdentity | object | No | If omitted, the task runs as a non-administrative user unique to the task. - [UserIdentity object](#UserIdentity) |
|  maxTaskRetryCount | integer | No | The Batch service retries a task if its exit code is nonzero. Note that this value specifically controls the number of retries. The Batch service will try the task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries the task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry the task. If the maximum retry count is -1, the Batch service retries the task without limit. |
|  waitForSuccess | boolean | No | If true and the start task fails on a compute node, the Batch service retries the start task up to its maximum retry count (maxTaskRetryCount). If the task has still not completed successfully after all retries, then the Batch service marks the compute node unusable, and will not schedule tasks to it. This condition can be detected via the node state and scheduling error detail. If false, the Batch service will not wait for the start task to complete. In this case, other tasks can start executing on the compute node while the start task is still running; and even if the start task fails, new tasks will continue to be scheduled on the node. The default is false. |


<a id="CertificateReference" />
### CertificateReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes |  |
|  storeLocation | enum | No | The default value is currentUser. This property is applicable only for pools configured with Windows nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows image reference). For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory. - CurrentUser or LocalMachine |
|  storeName | string | No | This property is applicable only for pools configured with Windows nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows image reference). Common store names include: My, Root, CA, Trust, Disallowed, TrustedPeople, TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also be used. The default value is My. |
|  visibility | array | No | Values are: starttask - The user account under which the start task is run. task - The accounts under which job tasks are run. remoteuser - The accounts under which users remotely access the node. You can specify more than one visibility in this collection. The default is all accounts. - StartTask, Task, RemoteUser |


<a id="ApplicationPackageReference" />
### ApplicationPackageReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes |  |
|  version | string | No | If this is omitted, and no default version is specified for this application, the request fails with the error code InvalidApplicationPackageReferences. If you are calling the REST API directly, the HTTP status code is 409. |


<a id="CloudServiceConfiguration" />
### CloudServiceConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osFamily | string | Yes | Possible values are: 2 - OS Family 2, equivalent to Windows Server 2008 R2 SP1. 3 - OS Family 3, equivalent to Windows Server 2012. 4 - OS Family 4, equivalent to Windows Server 2012 R2. 5 - OS Family 5, equivalent to Windows Server 2016. For more information, see Azure Guest OS Releases (https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/#releases). |
|  targetOSVersion | string | No | The default value is * which specifies the latest operating system version for the specified OS family. |
|  currentOSVersion | string | No | This may differ from targetOSVersion if the pool state is Upgrading. In this case some virtual machines may be on the targetOSVersion and some may be on the currentOSVersion during the upgrade process. Once all virtual machines have upgraded, currentOSVersion is updated to be the same as targetOSVersion. |


<a id="VirtualMachineConfiguration" />
### VirtualMachineConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  imageReference | object | Yes | [ImageReference object](#ImageReference) |
|  osDisk | object | No | [OSDisk object](#OSDisk) |
|  nodeAgentSkuId | string | Yes | The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. |
|  windowsConfiguration | object | No | This property must not be specified if the imageReference specifies a Linux OS image. - [WindowsConfiguration object](#WindowsConfiguration) |
|  dataDisks | array | No | This property must be specified if the compute nodes in the pool need to have empty data disks attached to them. - [DataDisk object](#DataDisk) |
|  licenseType | string | No | This only applies to images that contain the Windows operating system, and should only be used when you hold valid on-premises licenses for the nodes which will be deployed. If omitted, no on-premises licensing discount is applied. Values are: Windows_Server - The on-premises license is for Windows Server. Windows_Client - The on-premises license is for Windows Client. |


<a id="FixedScaleSettings" />
### FixedScaleSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  resizeTimeout | string | No | The default value is 15 minutes. Timeout values use ISO 8601 format. For example, use PT10M for 10 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service rejects the request with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). |
|  targetDedicatedNodes | integer | No | At least one of targetDedicatedNodes, targetLowPriority nodes must be set. |
|  targetLowPriorityNodes | integer | No | At least one of targetDedicatedNodes, targetLowPriority nodes must be set. |
|  nodeDeallocationOption | enum | No | If omitted, the default value is Requeue. - Requeue, Terminate, TaskCompletion, RetainedData |


<a id="AutoScaleSettings" />
### AutoScaleSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  formula | string | Yes |  |
|  evaluationInterval | string | No | If omitted, the default value is 15 minutes (PT15M). |


<a id="PoolEndpointConfiguration" />
### PoolEndpointConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  inboundNatPools | array | Yes | The maximum number of inbound NAT pools per Batch pool is 5. If the maximum number of inbound NAT pools is exceeded the request fails with HTTP status code 400. - [InboundNatPool object](#InboundNatPool) |


<a id="LinuxUserConfiguration" />
### LinuxUserConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uid | integer | No | The uid and gid properties must be specified together or not at all. If not specified the underlying operating system picks the uid. |
|  gid | integer | No | The uid and gid properties must be specified together or not at all. If not specified the underlying operating system picks the gid. |
|  sshPrivateKey | string | No | The private key must not be password protected. The private key is used to automatically configure asymmetric-key based authentication for SSH between nodes in a Linux pool when the pool's enableInterNodeCommunication property is true (it is ignored if enableInterNodeCommunication is false). It does this by placing the key pair into the user's .ssh directory. If not specified, password-less SSH is not configured between nodes (no modification of the user's .ssh directory is done). |


<a id="ResourceFile" />
### ResourceFile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  blobSource | string | Yes | This URL must be readable using anonymous access; that is, the Batch service does not present any credentials when downloading the blob. There are two ways to get such a URL for a blob in Azure storage: include a Shared Access Signature (SAS) granting read permissions on the blob, or set the ACL for the blob or its container to allow public access. |
|  filePath | string | Yes |  |
|  fileMode | string | No | This property applies only to files being downloaded to Linux compute nodes. It will be ignored if it is specified for a resourceFile which will be downloaded to a Windows node. If this property is not specified for a Linux node, then a default value of 0770 is applied to the file. |


<a id="EnvironmentSetting" />
### EnvironmentSetting object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  value | string | No |  |


<a id="UserIdentity" />
### UserIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userName | string | No | The userName and autoUser properties are mutually exclusive; you must specify one but not both. |
|  autoUser | object | No | The userName and autoUser properties are mutually exclusive; you must specify one but not both. - [AutoUserSpecification object](#AutoUserSpecification) |


<a id="ImageReference" />
### ImageReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publisher | string | No | For example, Canonical or MicrosoftWindowsServer. |
|  offer | string | No | For example, UbuntuServer or WindowsServer. |
|  sku | string | No | For example, 14.04.0-LTS or 2012-R2-Datacenter. |
|  version | string | No | A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'. |
|  id | string | No | This property is mutually exclusive with other properties. The virtual machine image must be in the same region and subscription as the Azure Batch account. For information about the firewall settings for Batch node agent to communicate with Batch service see https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration . |


<a id="OSDisk" />
### OSDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  caching | enum | No | Default value is none. - None, ReadOnly, ReadWrite |


<a id="WindowsConfiguration" />
### WindowsConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enableAutomaticUpdates | boolean | No | If omitted, the default value is true. |


<a id="DataDisk" />
### DataDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lun | integer | Yes | The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun. |
|  caching | enum | No | Values are: none - The caching mode for the disk is not enabled. readOnly - The caching mode for the disk is read only. readWrite - The caching mode for the disk is read and write. The default value for caching is none. For information about the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/. - None, ReadOnly, ReadWrite |
|  diskSizeGB | integer | Yes |  |
|  storageAccountType | enum | No | If omitted, the default is "Standard_LRS". Values are: Standard_LRS - The data disk should use standard locally redundant storage. Premium_LRS - The data disk should use premium locally redundant storage. - Standard_LRS or Premium_LRS |


<a id="InboundNatPool" />
### InboundNatPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name must be unique within a Batch pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. |
|  protocol | enum | Yes | TCP or UDP |
|  backendPort | integer | Yes | This must be unique within a Batch pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. |
|  frontendPortRangeStart | integer | Yes | Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. |
|  frontendPortRangeEnd | integer | Yes | Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. |
|  networkSecurityGroupRules | array | No | The maximum number of rules that can be specified across all the endpoints on a Batch pool is 25. If no network security group rules are specified, a default rule will be created to allow inbound access to the specified backendPort. If the maximum number of network security group rules is exceeded the request fails with HTTP status code 400. - [NetworkSecurityGroupRule object](#NetworkSecurityGroupRule) |


<a id="AutoUserSpecification" />
### AutoUserSpecification object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  scope | enum | No | pool - specifies that the task runs as the common auto user account which is created on every node in a pool. task - specifies that the service should create a new user for the task. The default value is task. - Task or Pool |
|  elevationLevel | enum | No | nonAdmin - The auto user is a standard user without elevated access. admin - The auto user is a user with elevated access and operates with full Administrator permissions. The default value is nonAdmin. - NonAdmin or Admin |


<a id="NetworkSecurityGroupRule" />
### NetworkSecurityGroupRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  priority | integer | Yes | Priorities within a pool must be unique and are evaluated in order of priority. The lower the number the higher the priority. For example, rules could be specified with order numbers of 150, 250, and 350. The rule with the order number of 150 takes precedence over the rule that has an order of 250. Allowed priorities are 150 to 3500. If any reserved or duplicate values are provided the request fails with HTTP status code 400. |
|  access | enum | Yes | Allow or Deny |
|  sourceAddressPrefix | string | Yes | Valid values are a single IP address (i.e. 10.10.10.10), IP subnet (i.e. 192.168.1.0/24), default tag, or * (for all addresses).  If any other values are provided the request fails with HTTP status code 400. |

