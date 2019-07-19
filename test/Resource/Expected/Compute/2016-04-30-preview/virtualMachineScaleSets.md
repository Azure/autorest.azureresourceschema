# Microsoft.Compute/virtualMachineScaleSets template reference
API Version: 2016-04-30-preview
## Template format

To create a Microsoft.Compute/virtualMachineScaleSets resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/virtualMachineScaleSets",
  "apiVersion": "2016-04-30-preview",
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
      "mode": "string"
    },
    "virtualMachineProfile": {
      "osProfile": {
        "computerNamePrefix": "string",
        "adminUsername": "string",
        "adminPassword": "string",
        "customData": "string",
        "windowsConfiguration": {
          "provisionVMAgent": "boolean",
          "enableAutomaticUpdates": "boolean",
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
          "disablePasswordAuthentication": "boolean",
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
        "networkInterfaceConfigurations": [
          {
            "id": "string",
            "name": "string",
            "properties": {
              "primary": "boolean",
              "ipConfigurations": [
                {
                  "id": "string",
                  "name": "string",
                  "properties": {
                    "subnet": {
                      "id": "string"
                    },
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
              ]
            }
          }
        ]
      },
      "extensionProfile": {
        "extensions": [
          {
            "name": "string",
            "properties": {
              "publisher": "string",
              "type": "string",
              "typeHandlerVersion": "string",
              "autoUpgradeMinorVersion": "boolean",
              "settings": {},
              "protectedSettings": {}
            }
          }
        ]
      }
    },
    "overProvision": "boolean",
    "singlePlacementGroup": "boolean"
  },
  "identity": {
    "type": "SystemAssigned"
  }
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
|  apiVersion | enum | Yes | 2016-04-30-preview |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  sku | object | No | The virtual machine scale set sku. - [Sku object](#Sku) |
|  plan | object | No | Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**. - [Plan object](#Plan) |
|  properties | object | Yes | [VirtualMachineScaleSetProperties object](#VirtualMachineScaleSetProperties) |
|  identity | object | No | The identity of the virtual machine scale set, if configured. - [VirtualMachineScaleSetIdentity object](#VirtualMachineScaleSetIdentity) |


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
|  overProvision | boolean | No | Specifies whether the Virtual Machine Scale Set should be overprovisioned. |
|  singlePlacementGroup | boolean | No | When true this limits the scale set to a single placement group, of max size 100 virtual machines. |


<a id="VirtualMachineScaleSetIdentity" />
### VirtualMachineScaleSetIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | No | The type of identity used for the virtual machine scale set. Currently, the only supported type is 'SystemAssigned', which implicitly creates an identity. - SystemAssigned |


<a id="UpgradePolicy" />
### UpgradePolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  mode | enum | No | Specifies the mode of an upgrade to virtual machines in the scale set.<br /><br /> Possible values are:<br /><br /> **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.<br /><br /> **Automatic** - All virtual machines in the scale set are  automatically updated at the same time. - Automatic or Manual |


<a id="VirtualMachineScaleSetVMProfile" />
### VirtualMachineScaleSetVMProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osProfile | object | No | The virtual machine scale set OS profile. - [VirtualMachineScaleSetOSProfile object](#VirtualMachineScaleSetOSProfile) |
|  storageProfile | object | No | The virtual machine scale set storage profile. - [VirtualMachineScaleSetStorageProfile object](#VirtualMachineScaleSetStorageProfile) |
|  networkProfile | object | No | The virtual machine scale set network profile. - [VirtualMachineScaleSetNetworkProfile object](#VirtualMachineScaleSetNetworkProfile) |
|  extensionProfile | object | No | The virtual machine scale set extension profile. - [VirtualMachineScaleSetExtensionProfile object](#VirtualMachineScaleSetExtensionProfile) |


<a id="VirtualMachineScaleSetOSProfile" />
### VirtualMachineScaleSetOSProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  computerNamePrefix | string | No | Specifies the computer name prefix for all of the virtual machines in the scale set. Computer name prefixes must be 1 to 15 characters long. |
|  adminUsername | string | No | Specifies the name of the administrator account. <br><br> **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters  <br><br><li> For root access to the Linux VM, see [Using root privileges on Linux virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)<br><li> For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for Linux on Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) |
|  adminPassword | string | No | Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password) |
|  customData | string | No | A base-64 encoded string of custom data. |
|  windowsConfiguration | object | No | The Windows Configuration of the OS profile. - [WindowsConfiguration object](#WindowsConfiguration) |
|  linuxConfiguration | object | No | The Linux Configuration of the OS profile. - [LinuxConfiguration object](#LinuxConfiguration) |
|  secrets | array | No | The List of certificates for addition to the VM. - [VaultSecretGroup object](#VaultSecretGroup) |


<a id="VirtualMachineScaleSetStorageProfile" />
### VirtualMachineScaleSetStorageProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  imageReference | object | No | The image reference. - [ImageReference object](#ImageReference) |
|  osDisk | object | No | The OS disk. - [VirtualMachineScaleSetOSDisk object](#VirtualMachineScaleSetOSDisk) |
|  dataDisks | array | No | The data disks. - [VirtualMachineScaleSetDataDisk object](#VirtualMachineScaleSetDataDisk) |


<a id="VirtualMachineScaleSetNetworkProfile" />
### VirtualMachineScaleSetNetworkProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  networkInterfaceConfigurations | array | No | The list of network configurations. - [VirtualMachineScaleSetNetworkConfiguration object](#VirtualMachineScaleSetNetworkConfiguration) |


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
|  image | object | No | The Source User Image VirtualHardDisk. This VirtualHardDisk will be copied before using it to attach to the Virtual Machine. If SourceImage is provided, the destination VirtualHardDisk should not exist. - [VirtualHardDisk object](#VirtualHardDisk) |
|  vhdContainers | array | No | The list of virtual hard disk container uris. - string |
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


<a id="VirtualMachineScaleSetNetworkConfiguration" />
### VirtualMachineScaleSetNetworkConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  name | string | Yes | The network configuration name. |
|  properties | object | No | [VirtualMachineScaleSetNetworkConfigurationProperties object](#VirtualMachineScaleSetNetworkConfigurationProperties) |


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
|  primary | boolean | No | Whether this is a primary NIC on a virtual machine. |
|  ipConfigurations | array | Yes | The virtual machine scale set IP Configuration. - [VirtualMachineScaleSetIPConfiguration object](#VirtualMachineScaleSetIPConfiguration) |


<a id="VirtualMachineScaleSetExtensionProperties" />
### VirtualMachineScaleSetExtensionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
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
|  subnet | object | Yes | The subnet. - [ApiEntityReference object](#ApiEntityReference) |
|  applicationGatewayBackendAddressPools | array | No | The application gateway backend address pools. - [SubResource object](#SubResource) |
|  loadBalancerBackendAddressPools | array | No | The load balancer backend address pools. - [SubResource object](#SubResource) |
|  loadBalancerInboundNatPools | array | No | The load balancer inbound nat pools. - [SubResource object](#SubResource) |


<a id="ApiEntityReference" />
### ApiEntityReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | The ARM resource id in the form of /subscriptions/{SubcriptionId}/resourceGroups/{ResourceGroupName}/... |

