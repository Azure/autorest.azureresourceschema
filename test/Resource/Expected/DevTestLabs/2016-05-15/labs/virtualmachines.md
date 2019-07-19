# Microsoft.DevTestLab/labs/virtualmachines template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/virtualmachines resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/virtualmachines",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "notes": "string",
    "ownerObjectId": "string",
    "ownerUserPrincipalName": "string",
    "createdByUserId": "string",
    "createdByUser": "string",
    "createdDate": "string",
    "customImageId": "string",
    "osType": "string",
    "size": "string",
    "userName": "string",
    "password": "string",
    "sshKey": "string",
    "isAuthenticationWithSshKey": "boolean",
    "fqdn": "string",
    "labSubnetName": "string",
    "labVirtualNetworkId": "string",
    "disallowPublicIpAddress": "boolean",
    "artifacts": [
      {
        "artifactId": "string",
        "parameters": [
          {
            "name": "string",
            "value": "string"
          }
        ],
        "status": "string",
        "deploymentStatusMessage": "string",
        "vmExtensionStatusMessage": "string",
        "installTime": "string"
      }
    ],
    "artifactDeploymentStatus": {
      "deploymentStatus": "string",
      "artifactsApplied": "integer",
      "totalArtifacts": "integer"
    },
    "galleryImageReference": {
      "offer": "string",
      "publisher": "string",
      "sku": "string",
      "osType": "string",
      "version": "string"
    },
    "computeVm": {
      "statuses": [
        {
          "code": "string",
          "displayStatus": "string",
          "message": "string"
        }
      ],
      "osType": "string",
      "vmSize": "string",
      "networkInterfaceId": "string",
      "osDiskId": "string",
      "dataDiskIds": [
        "string"
      ],
      "dataDisks": [
        {
          "name": "string",
          "diskUri": "string",
          "managedDiskId": "string",
          "diskSizeGiB": "integer"
        }
      ]
    },
    "networkInterface": {
      "virtualNetworkId": "string",
      "subnetId": "string",
      "publicIpAddressId": "string",
      "publicIpAddress": "string",
      "privateIpAddress": "string",
      "dnsName": "string",
      "rdpAuthority": "string",
      "sshAuthority": "string",
      "sharedPublicIpAddressConfiguration": {
        "inboundNatRules": [
          {
            "transportProtocol": "string",
            "frontendPort": "integer",
            "backendPort": "integer"
          }
        ]
      }
    },
    "applicableSchedule": {
      "location": "string",
      "tags": {},
      "properties": {
        "labVmsShutdown": {
          "location": "string",
          "tags": {},
          "properties": {
            "status": "string",
            "taskType": "string",
            "weeklyRecurrence": {
              "weekdays": [
                "string"
              ],
              "time": "string"
            },
            "dailyRecurrence": {
              "time": "string"
            },
            "hourlyRecurrence": {
              "minute": "integer"
            },
            "timeZoneId": "string",
            "notificationSettings": {
              "status": "string",
              "timeInMinutes": "integer",
              "webhookUrl": "string"
            },
            "targetResourceId": "string",
            "provisioningState": "string",
            "uniqueIdentifier": "string"
          }
        },
        "labVmsStartup": {
          "location": "string",
          "tags": {},
          "properties": {
            "status": "string",
            "taskType": "string",
            "weeklyRecurrence": {
              "weekdays": [
                "string"
              ],
              "time": "string"
            },
            "dailyRecurrence": {
              "time": "string"
            },
            "hourlyRecurrence": {
              "minute": "integer"
            },
            "timeZoneId": "string",
            "notificationSettings": {
              "status": "string",
              "timeInMinutes": "integer",
              "webhookUrl": "string"
            },
            "targetResourceId": "string",
            "provisioningState": "string",
            "uniqueIdentifier": "string"
          }
        }
      }
    },
    "expirationDate": "string",
    "allowClaim": "boolean",
    "storageType": "string",
    "virtualMachineCreationSource": "string",
    "environmentId": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/virtualmachines" />
### Microsoft.DevTestLab/labs/virtualmachines object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/virtualmachines |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [LabVirtualMachineProperties object](#LabVirtualMachineProperties) |
|  resources | array | No | [schedules](./virtualmachines/schedules.md) |


<a id="LabVirtualMachineProperties" />
### LabVirtualMachineProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  notes | string | No | The notes of the virtual machine. |
|  ownerObjectId | string | No | The object identifier of the owner of the virtual machine. |
|  ownerUserPrincipalName | string | No | The user principal name of the virtual machine owner. |
|  createdByUserId | string | No | The object identifier of the creator of the virtual machine. |
|  createdByUser | string | No | The email address of creator of the virtual machine. |
|  createdDate | string | No | The creation date of the virtual machine. |
|  customImageId | string | No | The custom image identifier of the virtual machine. |
|  osType | string | No | The OS type of the virtual machine. |
|  size | string | No | The size of the virtual machine. |
|  userName | string | No | The user name of the virtual machine. |
|  password | string | No | The password of the virtual machine administrator. |
|  sshKey | string | No | The SSH key of the virtual machine administrator. |
|  isAuthenticationWithSshKey | boolean | No | Indicates whether this virtual machine uses an SSH key for authentication. |
|  fqdn | string | No | The fully-qualified domain name of the virtual machine. |
|  labSubnetName | string | No | The lab subnet name of the virtual machine. |
|  labVirtualNetworkId | string | No | The lab virtual network identifier of the virtual machine. |
|  disallowPublicIpAddress | boolean | No | Indicates whether the virtual machine is to be created without a public IP address. |
|  artifacts | array | No | The artifacts to be installed on the virtual machine. - [ArtifactInstallProperties object](#ArtifactInstallProperties) |
|  artifactDeploymentStatus | object | No | The artifact deployment status for the virtual machine. - [ArtifactDeploymentStatusProperties object](#ArtifactDeploymentStatusProperties) |
|  galleryImageReference | object | No | The Microsoft Azure Marketplace image reference of the virtual machine. - [GalleryImageReference object](#GalleryImageReference) |
|  computeVm | object | No | The compute virtual machine properties. - [ComputeVmProperties object](#ComputeVmProperties) |
|  networkInterface | object | No | The network interface properties. - [NetworkInterfaceProperties object](#NetworkInterfaceProperties) |
|  applicableSchedule | object | No | The applicable schedule for the virtual machine. - [ApplicableSchedule object](#ApplicableSchedule) |
|  expirationDate | string | No | The expiration date for VM. |
|  allowClaim | boolean | No | Indicates whether another user can take ownership of the virtual machine |
|  storageType | string | No | Storage type to use for virtual machine (i.e. Standard, Premium). |
|  virtualMachineCreationSource | enum | No | Tells source of creation of lab virtual machine. Output property only. - FromCustomImage or FromGalleryImage |
|  environmentId | string | No | The resource ID of the environment that contains this virtual machine, if any. |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="ArtifactInstallProperties" />
### ArtifactInstallProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  artifactId | string | No | The artifact's identifier. |
|  parameters | array | No | The parameters of the artifact. - [ArtifactParameterProperties object](#ArtifactParameterProperties) |
|  status | string | No | The status of the artifact. |
|  deploymentStatusMessage | string | No | The status message from the deployment. |
|  vmExtensionStatusMessage | string | No | The status message from the virtual machine extension. |
|  installTime | string | No | The time that the artifact starts to install on the virtual machine. |


<a id="ArtifactDeploymentStatusProperties" />
### ArtifactDeploymentStatusProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  deploymentStatus | string | No | The deployment status of the artifact. |
|  artifactsApplied | integer | No | The total count of the artifacts that were successfully applied. |
|  totalArtifacts | integer | No | The total count of the artifacts that were tentatively applied. |


<a id="GalleryImageReference" />
### GalleryImageReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  offer | string | No | The offer of the gallery image. |
|  publisher | string | No | The publisher of the gallery image. |
|  sku | string | No | The SKU of the gallery image. |
|  osType | string | No | The OS type of the gallery image. |
|  version | string | No | The version of the gallery image. |


<a id="ComputeVmProperties" />
### ComputeVmProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  statuses | array | No | Gets the statuses of the virtual machine. - [ComputeVmInstanceViewStatus object](#ComputeVmInstanceViewStatus) |
|  osType | string | No | Gets the OS type of the virtual machine. |
|  vmSize | string | No | Gets the size of the virtual machine. |
|  networkInterfaceId | string | No | Gets the network interface ID of the virtual machine. |
|  osDiskId | string | No | Gets OS disk blob uri for the virtual machine. |
|  dataDiskIds | array | No | Gets data disks blob uri for the virtual machine. - string |
|  dataDisks | array | No | Gets all data disks attached to the virtual machine. - [ComputeDataDisk object](#ComputeDataDisk) |


<a id="NetworkInterfaceProperties" />
### NetworkInterfaceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  virtualNetworkId | string | No | The resource ID of the virtual network. |
|  subnetId | string | No | The resource ID of the sub net. |
|  publicIpAddressId | string | No | The resource ID of the public IP address. |
|  publicIpAddress | string | No | The public IP address. |
|  privateIpAddress | string | No | The private IP address. |
|  dnsName | string | No | The DNS name. |
|  rdpAuthority | string | No | The RdpAuthority property is a server DNS host name or IP address followed by the service port number for RDP (Remote Desktop Protocol). |
|  sshAuthority | string | No | The SshAuthority property is a server DNS host name or IP address followed by the service port number for SSH. |
|  sharedPublicIpAddressConfiguration | object | No | The configuration for sharing a public IP address across multiple virtual machines. - [SharedPublicIpAddressConfiguration object](#SharedPublicIpAddressConfiguration) |


<a id="ApplicableSchedule" />
### ApplicableSchedule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [ApplicableScheduleProperties object](#ApplicableScheduleProperties) |


<a id="ArtifactParameterProperties" />
### ArtifactParameterProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name of the artifact parameter. |
|  value | string | No | The value of the artifact parameter. |


<a id="ComputeVmInstanceViewStatus" />
### ComputeVmInstanceViewStatus object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  code | string | No | Gets the status Code. |
|  displayStatus | string | No | Gets the short localizable label for the status. |
|  message | string | No | Gets the message associated with the status. |


<a id="ComputeDataDisk" />
### ComputeDataDisk object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Gets data disk name. |
|  diskUri | string | No | When backed by a blob, the URI of underlying blob. |
|  managedDiskId | string | No | When backed by managed disk, this is the ID of the compute disk resource. |
|  diskSizeGiB | integer | No | Gets data disk size in GiB. |


<a id="SharedPublicIpAddressConfiguration" />
### SharedPublicIpAddressConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  inboundNatRules | array | No | The incoming NAT rules - [InboundNatRule object](#InboundNatRule) |


<a id="ApplicableScheduleProperties" />
### ApplicableScheduleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  labVmsShutdown | object | No | The auto-shutdown schedule, if one has been set at the lab or lab resource level. - [Schedule object](#Schedule) |
|  labVmsStartup | object | No | The auto-startup schedule, if one has been set at the lab or lab resource level. - [Schedule object](#Schedule) |


<a id="InboundNatRule" />
### InboundNatRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  transportProtocol | enum | No | The transport protocol for the endpoint. - Tcp or Udp |
|  frontendPort | integer | No | The external endpoint port of the inbound connection. Possible values range between 1 and 65535, inclusive. If unspecified, a value will be allocated automatically. |
|  backendPort | integer | No | The port to which the external traffic will be redirected. |


<a id="Schedule" />
### Schedule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [ScheduleProperties object](#ScheduleProperties) |


<a id="ScheduleProperties" />
### ScheduleProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | The status of the schedule (i.e. Enabled, Disabled). - Enabled or Disabled |
|  taskType | string | No | The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart). |
|  weeklyRecurrence | object | No | If the schedule will occur only some days of the week, specify the weekly recurrence. - [WeekDetails object](#WeekDetails) |
|  dailyRecurrence | object | No | If the schedule will occur once each day of the week, specify the daily recurrence. - [DayDetails object](#DayDetails) |
|  hourlyRecurrence | object | No | If the schedule will occur multiple times a day, specify the hourly recurrence. - [HourDetails object](#HourDetails) |
|  timeZoneId | string | No | The time zone ID (e.g. Pacific Standard time). |
|  notificationSettings | object | No | Notification settings. - [NotificationSettings object](#NotificationSettings) |
|  targetResourceId | string | No | The resource ID to which the schedule belongs |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="WeekDetails" />
### WeekDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  weekdays | array | No | The days of the week for which the schedule is set (e.g. Sunday, Monday, Tuesday, etc.). - string |
|  time | string | No | The time of the day the schedule will occur. |


<a id="DayDetails" />
### DayDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  time | string | No | The time of day the schedule will occur. |


<a id="HourDetails" />
### HourDetails object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  minute | integer | No | Minutes of the hour the schedule will run. |


<a id="NotificationSettings" />
### NotificationSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | enum | No | If notifications are enabled for this schedule (i.e. Enabled, Disabled). - Disabled or Enabled |
|  timeInMinutes | integer | No | Time in minutes before event at which notification will be sent. |
|  webhookUrl | string | No | The webhook URL to which the notification will be sent. |

