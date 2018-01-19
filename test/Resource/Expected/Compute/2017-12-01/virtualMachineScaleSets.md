# Microsoft.Compute/virtualMachineScaleSets template reference
API Version: 2017-12-01
## Template format

To create a Microsoft.Compute/virtualMachineScaleSets resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/virtualMachineScaleSets",
  "apiVersion": "2017-12-01",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string",
    "tier": "string",
    "capacity": "integer"
  },
  "plan": {
    "name": "string",
    "publisher": "string",
    "product": "string",
    "promotionCode": "string"
  },
  "properties": {
    "upgradePolicy": {
      "mode": "string",
      "rollingUpgradePolicy": {
        "maxBatchInstancePercent": "integer",
        "maxUnhealthyInstancePercent": "integer",
        "maxUnhealthyUpgradedInstancePercent": "integer",
        "pauseTimeBetweenBatches": "string"
      },
      "automaticOSUpgrade": boolean
    },
    "virtualMachineProfile": {
      "osProfile": {
        "computerNamePrefix": "string",
        "adminUsername": "string",
        "adminPassword": "string",
        "customData": "string",
        "windowsConfiguration": {
          "provisionVMAgent": boolean,
          "enableAutomaticUpdates": boolean,
          "timeZone": "string",
          "additionalUnattendContent": [
            {
              "passName": "OobeSystem",
              "componentName": "Microsoft-Windows-Shell-Setup",
              "settingName": "string",
              "content": "string"
            }
          ],
          "winRM": {
            "listeners": [
              {
                "protocol": "string",
                "certificateUrl": "string"
              }
            ]
          }
        },
        "linuxConfiguration": {
          "disablePasswordAuthentication": boolean,
          "ssh": {
            "publicKeys": [
              {
                "path": "string",
                "keyData": "string"
              }
            ]
          }
        },
        "secrets": [
          {
            "sourceVault": {
              "id": "string"
            },
            "vaultCertificates": [
              {
                "certificateUrl": "string",
                "certificateStore": "string"
              }
            ]
          }
        ]
      },
      "storageProfile": {
        "imageReference": {
          "id": "string",
          "publisher": "string",
          "offer": "string",
          "sku": "string",
          "version": "string"
        },
        "osDisk": {
          "name": "string",
          "caching": "string",
          "createOption": "string",
          "osType": "string",
          "image": {
            "uri": "string"
          },
          "vhdContainers": [
            "string"
          ],
          "managedDisk": {
            "storageAccountType": "string"
          }
        },
        "dataDisks": [
          {
            "name": "string",
            "lun": "integer",
            "caching": "string",
            "createOption": "string",
            "diskSizeGB": "integer",
            "managedDisk": {
              "storageAccountType": "string"
            }
          }
        ]
      },
      "networkProfile": {
        "healthProbe": {
          "id": "string"
        },
        "networkInterfaceConfigurations": [
          {
            "id": "string",
            "name": "string",
            "properties": {
              "primary": boolean,
              "enableAcceleratedNetworking": boolean,
              "networkSecurityGroup": {
                "id": "string"
              },
              "dnsSettings": {
                "dnsServers": [
                  "string"
                ]
              },
              "ipConfigurations": [
                {
                  "id": "string",
                  "name": "string",
                  "properties": {
                    "subnet": {
                      "id": "string"
                    },
                    "primary": boolean,
                    "publicIPAddressConfiguration": {
                      "name": "string",
                      "properties": {
                        "idleTimeoutInMinutes": "integer",
                        "dnsSettings": {
                          "domainNameLabel": "string"
                        }
                      }
                    },
                    "privateIPAddressVersion": "string",
                    "applicationGatewayBackendAddressPools": [
                      {
                        "id": "string"
                      }
                    ],
                    "loadBalancerBackendAddressPools": [
                      {
                        "id": "string"
                      }
                    ],
                    "loadBalancerInboundNatPools": [
                      {
                        "id": "string"
                      }
                    ]
                  }
                }
              ],
              "enableIPForwarding": boolean
            }
          }
        ]
      },
      "diagnosticsProfile": {
        "bootDiagnostics": {
          "enabled": boolean,
          "storageUri": "string"
        }
      },
      "extensionProfile": {
        "extensions": [
          {
            "name": "string",
            "properties": {
              "forceUpdateTag": "string",
              "publisher": "string",
              "type": "string",
              "typeHandlerVersion": "string",
              "autoUpgradeMinorVersion": boolean,
              "settings": {},
              "protectedSettings": {}
            }
          }
        ]
      },
      "licenseType": "string",
      "priority": "string"
    },
    "overprovision": boolean,
    "singlePlacementGroup": boolean
  },
  "identity": {
    "type": "string",
    "identityIds": [
      "string"
    ]
  },
  "zones": [
    "string"
  ],
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/virtualMachineScaleSets" />
### Microsoft.Compute/virtualMachineScaleSets object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Compute/virtualMachineScaleSets |
|  apiVersion | enum | Yes | 2017-12-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  sku | object | No | The virtual machine scale set sku. - [Sku object](#Sku) |
|  plan | object | No | Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**. - [Plan object](#Plan) |
|  properties | object | Yes | [VirtualMachineScaleSetProperties object](#VirtualMachineScaleSetProperties) |
|  identity | object | No | The identity of the virtual machine scale set, if configured. - [VirtualMachineScaleSetIdentity object](#VirtualMachineScaleSetIdentity) |
|  zones | array | No | The virtual machine scale set zones. - string |
|  resources | array | No | [virtualmachines](./virtualMachineScaleSets/virtualmachines.md) [extensions](./virtualMachineScaleSets/extensions.md) |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The sku name. |
|  tier | string | No | Specifies the tier of virtual machines in a scale set.<br /><br /> Possible Values:<br /><br /> **Standard**<br /><br /> **Basic** |
|  capacity | integer | No | Specifies the number of virtual machines in the scale set. |


<a id="Plan" />
### Plan object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The plan ID. |
|  publisher | string | No | The publisher ID. |
|  product | string | No | Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. |
|  promotionCode | string | No | The promotion code. |


<a id="VirtualMachineScaleSetProperties" />
### VirtualMachineScaleSetProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  upgradePolicy | object | No | The upgrade policy. - [UpgradePolicy object](#UpgradePolicy) |
|  virtualMachineProfile | object | No | The virtual machine profile. - [VirtualMachineScaleSetVMProfile object](#VirtualMachineScaleSetVMProfile) |
|  overprovision | boolean | No | Specifies whether the Virtual Machine Scale Set should be overprovisioned. |
|  singlePlacementGroup | boolean | No | When true this limits the scale set to a single placement group, of max size 100 virtual machines. |


<a id="VirtualMachineScaleSetIdentity" />
### VirtualMachineScaleSetIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | No | The type of identity used for the virtual machine scale set. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities. The type 'None' will remove any identities from the virtual machine scale set. - SystemAssigned, UserAssigned, SystemAssigned, UserAssigned, None |
|  identityIds | array | No | The list of user identities associated with the virtual machine scale set. The user identity references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/identities/{identityName}'. - string |


<a id="UpgradePolicy" />
### UpgradePolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  mode | enum | No | Specifies the mode of an upgrade to virtual machines in the scale set.<br /><br /> Possible values are:<br /><br /> **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.<br /><br /> **Automatic** - All virtual machines in the scale set are  automatically updated at the same time. - Automatic, Manual, Rolling |
|  rollingUpgradePolicy | object | No | The configuration parameters used while performing a rolling upgrade. - [RollingUpgradePolicy object](#RollingUpgradePolicy) |
|  automaticOSUpgrade | boolean | No | Whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the image becomes available. |


<a id="VirtualMachineScaleSetVMProfile" />
### VirtualMachineScaleSetVMProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osProfile | object | No | Specifies the operating system settings for the virtual machines in the scale set. - [VirtualMachineScaleSetOSProfile object](#VirtualMachineScaleSetOSProfile) |
|  storageProfile | object | No | Specifies the storage settings for the virtual machine disks. - [VirtualMachineScaleSetStorageProfile object](#VirtualMachineScaleSetStorageProfile) |
|  networkProfile | object | No | Specifies properties of the network interfaces of the virtual machines in the scale set. - [VirtualMachineScaleSetNetworkProfile object](#VirtualMachineScaleSetNetworkProfile) |
|  diagnosticsProfile | object | No | Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15. - [DiagnosticsProfile object](#DiagnosticsProfile) |
|  extensionProfile | object | No | Specifies a collection of settings for extensions installed on virtual machines in the scale set. - [VirtualMachineScaleSetExtensionProfile object](#VirtualMachineScaleSetExtensionProfile) |
|  licenseType | string | No | Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15 |
|  priority | enum | No | Specifies the priority for the virtual machines in the scale set. <br><br>Minimum api-version: 2017-10-30-preview. - Regular or Low |


<a id="RollingUpgradePolicy" />
### RollingUpgradePolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxBatchInstancePercent | integer | No | The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability. The default value for this parameter is 20%. |
|  maxUnhealthyInstancePercent | integer | No | The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch. The default value for this parameter is 20%. |
|  maxUnhealthyUpgradedInstancePercent | integer | No | The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts. The default value for this parameter is 20%. |
|  pauseTimeBetweenBatches | string | No | The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format. The default value is 0 seconds (PT0S). |


<a id="VirtualMachineScaleSetOSProfile" />
### VirtualMachineScaleSetOSProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  computerNamePrefix | string | No | Specifies the computer name prefix for all of the virtual machines in the scale set. Computer name prefixes must be 1 to 15 characters long. |
|  adminUsername | string | No | Specifies the name of the administrator account. <br><br> **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters  <br><br><li> For root access to the Linux VM, see [Using root privileges on Linux virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)<br><li> For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for Linux on Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) |
|  adminPassword | string | No | Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password) |
|  customData | string | No | Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes. <br><br> For using cloud-init for your VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) |
|  windowsConfiguration | object | No | Specifies Windows operating system settings on the virtual machine. - [WindowsConfiguration object](#WindowsConfiguration) |
|  linuxConfiguration | object | No | Specifies the Linux operating system settings on the virtual machine. <br><br>For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) <br><br> For running non-endorsed distributions, see [Information for Non-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json). - [LinuxConfiguration object](#LinuxConfiguration) |
|  secrets | array | No | Specifies set of certificates that should be installed onto the virtual machines in the scale set. - [VaultSecretGroup object](#VaultSecretGroup) |


<a id="VirtualMachineScaleSetStorageProfile" />
### VirtualMachineScaleSetStorageProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  imageReference | object | No | Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. - [ImageReference object](#ImageReference) |
|  osDisk | object | No | Specifies information about the operating system disk used by the virtual machines in the scale set. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). - [VirtualMachineScaleSetOSDisk object](#VirtualMachineScaleSetOSDisk) |
|  dataDisks | array | No | Specifies the parameters that are used to add data disks to the virtual machines in the scale set. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). - [VirtualMachineScaleSetDataDisk object](#VirtualMachineScaleSetDataDisk) |


<a id="VirtualMachineScaleSetNetworkProfile" />
### VirtualMachineScaleSetNetworkProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  healthProbe | object | No | A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'. - [ApiEntityReference object](#ApiEntityReference) |
|  networkInterfaceConfigurations | array | No | The list of network configurations. - [VirtualMachineScaleSetNetworkConfiguration object](#VirtualMachineScaleSetNetworkConfiguration) |


<a id="DiagnosticsProfile" />
### DiagnosticsProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  bootDiagnostics | object | No | Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. <br><br> For Linux Virtual Machines, you can easily view the output of your console log. <br><br> For both Windows and Linux virtual machines, Azure also enables you to see a screenshot of the VM from the hypervisor. - [BootDiagnostics object](#BootDiagnostics) |


<a id="VirtualMachineScaleSetExtensionProfile" />
### VirtualMachineScaleSetExtensionProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  extensions | array | No | The virtual machine scale set child extension resources. - [VirtualMachineScaleSetExtension object](#VirtualMachineScaleSetExtension) |


<a id="WindowsConfiguration" />
### WindowsConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  provisionVMAgent | boolean | No | Indicates whether virtual machine agent should be provisioned on the virtual machine. <br><br> When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. |
|  enableAutomaticUpdates | boolean | No | Indicates whether virtual machine is enabled for automatic updates. |
|  timeZone | string | No | Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time" |
|  additionalUnattendContent | array | No | Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. - [AdditionalUnattendContent object](#AdditionalUnattendContent) |
|  winRM | object | No | Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell. - [WinRMConfiguration object](#WinRMConfiguration) |


<a id="LinuxConfiguration" />
### LinuxConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  disablePasswordAuthentication | boolean | No | Specifies whether password authentication should be disabled. |
|  ssh | object | No | Specifies the ssh key configuration for a Linux OS. - [SshConfiguration object](#SshConfiguration) |


<a id="VaultSecretGroup" />
### VaultSecretGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceVault | object | No | The relative URL of the Key Vault containing all of the certificates in VaultCertificates. - [SubResource object](#SubResource) |
|  vaultCertificates | array | No | The list of key vault references in SourceVault which contain certificates. - [VaultCertificate object](#VaultCertificate) |


<a id="ImageReference" />
### ImageReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  publisher | string | No | The image publisher. |
|  offer | string | No | Specifies the offer of the platform image or marketplace image used to create the virtual machine. |
|  sku | string | No | The image SKU. |
|  version | string | No | Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available. |


<a id="VirtualMachineScaleSetOSDisk" />
### VirtualMachineScaleSetOSDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The disk name. |
|  caching | enum | No | Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**. - None, ReadOnly, ReadWrite |
|  createOption | enum | Yes | Specifies how the virtual machines in the scale set should be created.<br><br> The only allowed value is: **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described. - FromImage, Empty, Attach |
|  osType | enum | No | This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**. - Windows or Linux |
|  image | object | No | Specifies information about the unmanaged user image to base the scale set on. - [VirtualHardDisk object](#VirtualHardDisk) |
|  vhdContainers | array | No | Specifies the container urls that are used to store operating system disks for the scale set. - string |
|  managedDisk | object | No | The managed disk parameters. - [VirtualMachineScaleSetManagedDiskParameters object](#VirtualMachineScaleSetManagedDiskParameters) |


<a id="VirtualMachineScaleSetDataDisk" />
### VirtualMachineScaleSetDataDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The disk name. |
|  lun | integer | Yes | Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. |
|  caching | enum | No | Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**. - None, ReadOnly, ReadWrite |
|  createOption | enum | Yes | The create option. - FromImage, Empty, Attach |
|  diskSizeGB | integer | No | Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB |
|  managedDisk | object | No | The managed disk parameters. - [VirtualMachineScaleSetManagedDiskParameters object](#VirtualMachineScaleSetManagedDiskParameters) |


<a id="ApiEntityReference" />
### ApiEntityReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | The ARM resource id in the form of /subscriptions/{SubcriptionId}/resourceGroups/{ResourceGroupName}/... |


<a id="VirtualMachineScaleSetNetworkConfiguration" />
### VirtualMachineScaleSetNetworkConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | Yes | The network configuration name. |
|  properties | object | No | [VirtualMachineScaleSetNetworkConfigurationProperties object](#VirtualMachineScaleSetNetworkConfigurationProperties) |


<a id="BootDiagnostics" />
### BootDiagnostics object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | No | Whether boot diagnostics should be enabled on the Virtual Machine. |
|  storageUri | string | No | Uri of the storage account to use for placing the console output and screenshot. |


<a id="VirtualMachineScaleSetExtension" />
### VirtualMachineScaleSetExtension object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name of the extension. |
|  properties | object | No | [VirtualMachineScaleSetExtensionProperties object](#VirtualMachineScaleSetExtensionProperties) |


<a id="AdditionalUnattendContent" />
### AdditionalUnattendContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  passName | enum | No | The pass name. Currently, the only allowable value is OobeSystem. - OobeSystem |
|  componentName | enum | No | The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup. - Microsoft-Windows-Shell-Setup |
|  settingName | enum | No | Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon. - AutoLogon or FirstLogonCommands |
|  content | string | No | Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted. |


<a id="WinRMConfiguration" />
### WinRMConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  listeners | array | No | The list of Windows Remote Management listeners - [WinRMListener object](#WinRMListener) |


<a id="SshConfiguration" />
### SshConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicKeys | array | No | The list of SSH public keys used to authenticate with linux based VMs. - [SshPublicKey object](#SshPublicKey) |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |


<a id="VaultCertificate" />
### VaultCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  certificateUrl | string | No | This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: <br><br> {<br>  "data":"<Base64-encoded-certificate>",<br>  "dataType":"pfx",<br>  "password":"<pfx-file-password>"<br>} |
|  certificateStore | string | No | For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The specified certificate store is implicitly in the LocalMachine account. <br><br>For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name <UppercaseThumbprint>.crt for the X509 certificate file and <UppercaseThumbpring>.prv for private key. Both of these files are .pem formatted. |


<a id="VirtualHardDisk" />
### VirtualHardDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uri | string | No | Specifies the virtual hard disk's uri. |


<a id="VirtualMachineScaleSetManagedDiskParameters" />
### VirtualMachineScaleSetManagedDiskParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  storageAccountType | enum | No | Specifies the storage account type for the managed disk. Possible values are: Standard_LRS or Premium_LRS. - Standard_LRS or Premium_LRS |


<a id="VirtualMachineScaleSetNetworkConfigurationProperties" />
### VirtualMachineScaleSetNetworkConfigurationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  primary | boolean | No | Specifies the primary network interface in case the virtual machine has more than 1 network interface. |
|  enableAcceleratedNetworking | boolean | No | Specifies whether the network interface is accelerated networking-enabled. |
|  networkSecurityGroup | object | No | The network security group. - [SubResource object](#SubResource) |
|  dnsSettings | object | No | The dns settings to be applied on the network interfaces. - [VirtualMachineScaleSetNetworkConfigurationDnsSettings object](#VirtualMachineScaleSetNetworkConfigurationDnsSettings) |
|  ipConfigurations | array | Yes | Specifies the IP configurations of the network interface. - [VirtualMachineScaleSetIPConfiguration object](#VirtualMachineScaleSetIPConfiguration) |
|  enableIPForwarding | boolean | No | Whether IP forwarding enabled on this NIC. |


<a id="VirtualMachineScaleSetExtensionProperties" />
### VirtualMachineScaleSetExtensionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  forceUpdateTag | string | No | If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed. |
|  publisher | string | No | The name of the extension handler publisher. |
|  type | string | No | Specifies the type of the extension; an example is "CustomScriptExtension". |
|  typeHandlerVersion | string | No | Specifies the version of the script handler. |
|  autoUpgradeMinorVersion | boolean | No | Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. |
|  settings | object | No | Json formatted public settings for the extension. |
|  protectedSettings | object | No | The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. |


<a id="WinRMListener" />
### WinRMListener object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  protocol | enum | No | Specifies the protocol of listener. <br><br> Possible values are: <br>**http** <br><br> **https**. - Http or Https |
|  certificateUrl | string | No | This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: <br><br> {<br>  "data":"<Base64-encoded-certificate>",<br>  "dataType":"pfx",<br>  "password":"<pfx-file-password>"<br>} |


<a id="SshPublicKey" />
### SshPublicKey object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  path | string | No | Specifies the full path on the created VM where ssh public key is stored. If the file already exists, the specified key is appended to the file. Example: /home/user/.ssh/authorized_keys |
|  keyData | string | No | SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in ssh-rsa format. <br><br> For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-mac-create-ssh-keys?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json). |


<a id="VirtualMachineScaleSetNetworkConfigurationDnsSettings" />
### VirtualMachineScaleSetNetworkConfigurationDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  dnsServers | array | No | List of DNS servers IP addresses - string |


<a id="VirtualMachineScaleSetIPConfiguration" />
### VirtualMachineScaleSetIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | Yes | The IP configuration name. |
|  properties | object | No | [VirtualMachineScaleSetIPConfigurationProperties object](#VirtualMachineScaleSetIPConfigurationProperties) |


<a id="VirtualMachineScaleSetIPConfigurationProperties" />
### VirtualMachineScaleSetIPConfigurationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  subnet | object | No | Specifies the identifier of the subnet. - [ApiEntityReference object](#ApiEntityReference) |
|  primary | boolean | No | Specifies the primary network interface in case the virtual machine has more than 1 network interface. |
|  publicIPAddressConfiguration | object | No | The publicIPAddressConfiguration. - [VirtualMachineScaleSetPublicIPAddressConfiguration object](#VirtualMachineScaleSetPublicIPAddressConfiguration) |
|  privateIPAddressVersion | enum | No | Available from Api-Version 2017-03-30 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: 'IPv4' and 'IPv6'. - IPv4 or IPv6 |
|  applicationGatewayBackendAddressPools | array | No | Specifies an array of references to backend address pools of application gateways. A scale set can reference backend address pools of multiple application gateways. Multiple scale sets cannot use the same application gateway. - [SubResource object](#SubResource) |
|  loadBalancerBackendAddressPools | array | No | Specifies an array of references to backend address pools of load balancers. A scale set can reference backend address pools of one public and one internal load balancer. Multiple scale sets cannot use the same load balancer. - [SubResource object](#SubResource) |
|  loadBalancerInboundNatPools | array | No | Specifies an array of references to inbound Nat pools of the load balancers. A scale set can reference inbound nat pools of one public and one internal load balancer. Multiple scale sets cannot use the same load balancer - [SubResource object](#SubResource) |


<a id="VirtualMachineScaleSetPublicIPAddressConfiguration" />
### VirtualMachineScaleSetPublicIPAddressConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The publicIP address configuration name. |
|  properties | object | No | [VirtualMachineScaleSetPublicIPAddressConfigurationProperties object](#VirtualMachineScaleSetPublicIPAddressConfigurationProperties) |


<a id="VirtualMachineScaleSetPublicIPAddressConfigurationProperties" />
### VirtualMachineScaleSetPublicIPAddressConfigurationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  idleTimeoutInMinutes | integer | No | The idle timeout of the public IP address. |
|  dnsSettings | object | No | The dns settings to be applied on the publicIP addresses . - [VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings object](#VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings) |


<a id="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings" />
### VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  domainNameLabel | string | Yes | The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created |

