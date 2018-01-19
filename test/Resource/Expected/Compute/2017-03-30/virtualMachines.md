# Microsoft.Compute/virtualMachines template reference
API Version: 2017-03-30
## Template format

To create a Microsoft.Compute/virtualMachines resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Compute/virtualMachines",
  "apiVersion": "2017-03-30",
  "location": "string",
  "tags": {},
  "plan": {
    "name": "string",
    "publisher": "string",
    "product": "string",
    "promotionCode": "string"
  },
  "properties": {
    "hardwareProfile": {
      "vmSize": "string"
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
        "osType": "string",
        "encryptionSettings": {
          "diskEncryptionKey": {
            "secretUrl": "string",
            "sourceVault": {
              "id": "string"
            }
          },
          "keyEncryptionKey": {
            "keyUrl": "string",
            "sourceVault": {
              "id": "string"
            }
          },
          "enabled": boolean
        },
        "name": "string",
        "vhd": {
          "uri": "string"
        },
        "image": {
          "uri": "string"
        },
        "caching": "string",
        "createOption": "string",
        "diskSizeGB": "integer",
        "managedDisk": {
          "id": "string",
          "storageAccountType": "string"
        }
      },
      "dataDisks": [
        {
          "lun": "integer",
          "name": "string",
          "vhd": {
            "uri": "string"
          },
          "image": {
            "uri": "string"
          },
          "caching": "string",
          "createOption": "string",
          "diskSizeGB": "integer",
          "managedDisk": {
            "id": "string",
            "storageAccountType": "string"
          }
        }
      ]
    },
    "osProfile": {
      "computerName": "string",
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
    "networkProfile": {
      "networkInterfaces": [
        {
          "id": "string",
          "properties": {
            "primary": boolean
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
    "availabilitySet": {
      "id": "string"
    },
    "licenseType": "string"
  },
  "identity": {
    "type": "SystemAssigned"
  },
  "zones": [
    "string"
  ],
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Compute/virtualMachines" />
### Microsoft.Compute/virtualMachines object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Compute/virtualMachines |
|  apiVersion | enum | Yes | 2017-03-30 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  plan | object | No | Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**. - [Plan object](#Plan) |
|  properties | object | Yes | [VirtualMachineProperties object](#VirtualMachineProperties) |
|  identity | object | No | The identity of the virtual machine, if configured. - [VirtualMachineIdentity object](#VirtualMachineIdentity) |
|  zones | array | No | The virtual machine zones. - string |
|  resources | array | No | [extensions](./virtualMachines/extensions.md) |


<a id="Plan" />
### Plan object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The plan ID. |
|  publisher | string | No | The publisher ID. |
|  product | string | No | Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. |
|  promotionCode | string | No | The promotion code. |


<a id="VirtualMachineProperties" />
### VirtualMachineProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  hardwareProfile | object | No | Specifies the hardware settings for the virtual machine. - [HardwareProfile object](#HardwareProfile) |
|  storageProfile | object | No | Specifies the storage settings for the virtual machine disks. - [StorageProfile object](#StorageProfile) |
|  osProfile | object | No | Specifies the operating system settings for the virtual machine. - [OSProfile object](#OSProfile) |
|  networkProfile | object | No | Specifies the network interfaces of the virtual machine. - [NetworkProfile object](#NetworkProfile) |
|  diagnosticsProfile | object | No | Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15. - [DiagnosticsProfile object](#DiagnosticsProfile) |
|  availabilitySet | object | No | Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintainance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. - [SubResource object](#SubResource) |
|  licenseType | string | No | Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15 |


<a id="VirtualMachineIdentity" />
### VirtualMachineIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | enum | No | The type of identity used for the virtual machine. Currently, the only supported type is 'SystemAssigned', which implicitly creates an identity. - SystemAssigned |


<a id="HardwareProfile" />
### HardwareProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  vmSize | enum | No | Specifies the size of the virtual machine. For more information about virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-sizes?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> The available VM sizes depend on region and availability set. For a list of available sizes use these APIs:  <br><br> [List all available virtual machine sizes in an availability set](virtualmachines-list-sizes-availability-set.md) <br><br> [List all available virtual machine sizes in a region](virtualmachines-list-sizes-region.md) <br><br> [List all available virtual machine sizes for resizing](virtualmachines-list-sizes-for-resizing.md). - Basic_A0, Basic_A1, Basic_A2, Basic_A3, Basic_A4, Standard_A0, Standard_A1, Standard_A2, Standard_A3, Standard_A4, Standard_A5, Standard_A6, Standard_A7, Standard_A8, Standard_A9, Standard_A10, Standard_A11, Standard_A1_v2, Standard_A2_v2, Standard_A4_v2, Standard_A8_v2, Standard_A2m_v2, Standard_A4m_v2, Standard_A8m_v2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_D5_v2, Standard_D11_v2, Standard_D12_v2, Standard_D13_v2, Standard_D14_v2, Standard_D15_v2, Standard_DS1, Standard_DS2, Standard_DS3, Standard_DS4, Standard_DS11, Standard_DS12, Standard_DS13, Standard_DS14, Standard_DS1_v2, Standard_DS2_v2, Standard_DS3_v2, Standard_DS4_v2, Standard_DS5_v2, Standard_DS11_v2, Standard_DS12_v2, Standard_DS13_v2, Standard_DS14_v2, Standard_DS15_v2, Standard_F1, Standard_F2, Standard_F4, Standard_F8, Standard_F16, Standard_F1s, Standard_F2s, Standard_F4s, Standard_F8s, Standard_F16s, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5, Standard_H8, Standard_H16, Standard_H8m, Standard_H16m, Standard_H16r, Standard_H16mr, Standard_L4s, Standard_L8s, Standard_L16s, Standard_L32s, Standard_NC6, Standard_NC12, Standard_NC24, Standard_NC24r, Standard_NV6, Standard_NV12, Standard_NV24 |


<a id="StorageProfile" />
### StorageProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  imageReference | object | No | Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. - [ImageReference object](#ImageReference) |
|  osDisk | object | No | Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). - [OSDisk object](#OSDisk) |
|  dataDisks | array | No | Specifies the parameters that are used to add a data disk to a virtual machine. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). - [DataDisk object](#DataDisk) |


<a id="OSProfile" />
### OSProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  computerName | string | No | Specifies the host OS name of the virtual machine. <br><br> **Max-length (Windows):** 15 characters <br><br> **Max-length (Linux):** 64 characters. <br><br> For naming conventions and restrictions see [Azure infrastructure services implementation guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions). |
|  adminUsername | string | No | Specifies the name of the administrator account. <br><br> **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters  <br><br><li> For root access to the Linux VM, see [Using root privileges on Linux virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)<br><li> For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for Linux on Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) |
|  adminPassword | string | No | Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password) |
|  customData | string | No | Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes. <br><br> For using cloud-init for your VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) |
|  windowsConfiguration | object | No | Specifies Windows operating system settings on the virtual machine. - [WindowsConfiguration object](#WindowsConfiguration) |
|  linuxConfiguration | object | No | Specifies the Linux operating system settings on the virtual machine. <br><br>For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) <br><br> For running non-endorsed distributions, see [Information for Non-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json). - [LinuxConfiguration object](#LinuxConfiguration) |
|  secrets | array | No | Specifies set of certificates that should be installed onto the virtual machine. - [VaultSecretGroup object](#VaultSecretGroup) |


<a id="NetworkProfile" />
### NetworkProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  networkInterfaces | array | No | Specifies the list of resource Ids for the network interfaces associated with the virtual machine. - [NetworkInterfaceReference object](#NetworkInterfaceReference) |


<a id="DiagnosticsProfile" />
### DiagnosticsProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  bootDiagnostics | object | No | Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. <br><br> For Linux Virtual Machines, you can easily view the output of your console log. <br><br> For both Windows and Linux virtual machines, Azure also enables you to see a screenshot of the VM from the hypervisor. - [BootDiagnostics object](#BootDiagnostics) |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |


<a id="ImageReference" />
### ImageReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  publisher | string | No | The image publisher. |
|  offer | string | No | Specifies the offer of the platform image or marketplace image used to create the virtual machine. |
|  sku | string | No | The image SKU. |
|  version | string | No | Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available. |


<a id="OSDisk" />
### OSDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  osType | enum | No | This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**. - Windows or Linux |
|  encryptionSettings | object | No | Specifies the encryption settings for the OS Disk. <br><br> Minimum api-version: 2015-06-15 - [DiskEncryptionSettings object](#DiskEncryptionSettings) |
|  name | string | No | The disk name. |
|  vhd | object | No | The virtual hard disk. - [VirtualHardDisk object](#VirtualHardDisk) |
|  image | object | No | The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist. - [VirtualHardDisk object](#VirtualHardDisk) |
|  caching | enum | No | Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**. - None, ReadOnly, ReadWrite |
|  createOption | enum | Yes | Specifies how the virtual machine should be created.<br><br> Possible values are:<br><br> **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.<br><br> **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described. - FromImage, Empty, Attach |
|  diskSizeGB | integer | No | Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB |
|  managedDisk | object | No | The managed disk parameters. - [ManagedDiskParameters object](#ManagedDiskParameters) |


<a id="DataDisk" />
### DataDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  lun | integer | Yes | Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. |
|  name | string | No | The disk name. |
|  vhd | object | No | The virtual hard disk. - [VirtualHardDisk object](#VirtualHardDisk) |
|  image | object | No | The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist. - [VirtualHardDisk object](#VirtualHardDisk) |
|  caching | enum | No | Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**. - None, ReadOnly, ReadWrite |
|  createOption | enum | Yes | Specifies how the virtual machine should be created.<br><br> Possible values are:<br><br> **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.<br><br> **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described. - FromImage, Empty, Attach |
|  diskSizeGB | integer | No | Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB |
|  managedDisk | object | No | The managed disk parameters. - [ManagedDiskParameters object](#ManagedDiskParameters) |


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


<a id="NetworkInterfaceReference" />
### NetworkInterfaceReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  properties | object | No | [NetworkInterfaceReferenceProperties object](#NetworkInterfaceReferenceProperties) |


<a id="BootDiagnostics" />
### BootDiagnostics object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | No | Whether boot diagnostics should be enabled on the Virtual Machine. |
|  storageUri | string | No | Uri of the storage account to use for placing the console output and screenshot. |


<a id="DiskEncryptionSettings" />
### DiskEncryptionSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  diskEncryptionKey | object | No | Specifies the location of the disk encryption key, which is a Key Vault Secret. - [KeyVaultSecretReference object](#KeyVaultSecretReference) |
|  keyEncryptionKey | object | No | Specifies the location of the key encryption key in Key Vault. - [KeyVaultKeyReference object](#KeyVaultKeyReference) |
|  enabled | boolean | No | Specifies whether disk encryption should be enabled on the virtual machine. |


<a id="VirtualHardDisk" />
### VirtualHardDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uri | string | No | Specifies the virtual hard disk's uri. |


<a id="ManagedDiskParameters" />
### ManagedDiskParameters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource Id |
|  storageAccountType | enum | No | Specifies the storage account type for the managed disk. Possible values are: Standard_LRS or Premium_LRS. - Standard_LRS or Premium_LRS |


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


<a id="VaultCertificate" />
### VaultCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  certificateUrl | string | No | This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: <br><br> {<br>  "data":"<Base64-encoded-certificate>",<br>  "dataType":"pfx",<br>  "password":"<pfx-file-password>"<br>} |
|  certificateStore | string | No | For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The specified certificate store is implicitly in the LocalMachine account. <br><br>For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name <UppercaseThumbprint>.crt for the X509 certificate file and <UppercaseThumbpring>.prv for private key. Both of these files are .pem formatted. |


<a id="NetworkInterfaceReferenceProperties" />
### NetworkInterfaceReferenceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  primary | boolean | No | Specifies the primary network interface in case the virtual machine has more than 1 network interface. |


<a id="KeyVaultSecretReference" />
### KeyVaultSecretReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  secretUrl | string | Yes | The URL referencing a secret in a Key Vault. |
|  sourceVault | object | Yes | The relative URL of the Key Vault containing the secret. - [SubResource object](#SubResource) |


<a id="KeyVaultKeyReference" />
### KeyVaultKeyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyUrl | string | Yes | The URL referencing a key encryption key in Key Vault. |
|  sourceVault | object | Yes | The relative URL of the Key Vault containing the key. - [SubResource object](#SubResource) |


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

