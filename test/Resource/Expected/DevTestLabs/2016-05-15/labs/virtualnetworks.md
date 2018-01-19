# Microsoft.DevTestLab/labs/virtualnetworks template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/virtualnetworks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/virtualnetworks",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "allowedSubnets": [
      {
        "resourceId": "string",
        "labSubnetName": "string",
        "allowPublicIp": "string"
      }
    ],
    "description": "string",
    "externalProviderResourceId": "string",
    "externalSubnets": [
      {
        "id": "string",
        "name": "string"
      }
    ],
    "subnetOverrides": [
      {
        "resourceId": "string",
        "labSubnetName": "string",
        "useInVmCreationPermission": "string",
        "usePublicIpAddressPermission": "string",
        "sharedPublicIpAddressConfiguration": {
          "allowedPorts": [
            {
              "transportProtocol": "string",
              "backendPort": "integer"
            }
          ]
        },
        "virtualNetworkPoolName": "string"
      }
    ],
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/virtualnetworks" />
### Microsoft.DevTestLab/labs/virtualnetworks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/virtualnetworks |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [VirtualNetworkProperties object](#VirtualNetworkProperties) |


<a id="VirtualNetworkProperties" />
### VirtualNetworkProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allowedSubnets | array | No | The allowed subnets of the virtual network. - [Subnet object](#Subnet) |
|  description | string | No | The description of the virtual network. |
|  externalProviderResourceId | string | No | The Microsoft.Network resource identifier of the virtual network. |
|  externalSubnets | array | No | The external subnet properties. - [ExternalSubnet object](#ExternalSubnet) |
|  subnetOverrides | array | No | The subnet overrides of the virtual network. - [SubnetOverride object](#SubnetOverride) |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="Subnet" />
### Subnet object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  resourceId | string | No | The resource ID of the subnet. |
|  labSubnetName | string | No | The name of the subnet as seen in the lab. |
|  allowPublicIp | enum | No | The permission policy of the subnet for allowing public IP addresses (i.e. Allow, Deny)). - Default, Deny, Allow |


<a id="ExternalSubnet" />
### ExternalSubnet object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Gets or sets the identifier. |
|  name | string | No | Gets or sets the name. |


<a id="SubnetOverride" />
### SubnetOverride object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  resourceId | string | No | The resource ID of the subnet. |
|  labSubnetName | string | No | The name given to the subnet within the lab. |
|  useInVmCreationPermission | enum | No | Indicates whether this subnet can be used during virtual machine creation (i.e. Allow, Deny). - Default, Deny, Allow |
|  usePublicIpAddressPermission | enum | No | Indicates whether public IP addresses can be assigned to virtual machines on this subnet (i.e. Allow, Deny). - Default, Deny, Allow |
|  sharedPublicIpAddressConfiguration | object | No | Properties that virtual machines on this subnet will share. - [SubnetSharedPublicIpAddressConfiguration object](#SubnetSharedPublicIpAddressConfiguration) |
|  virtualNetworkPoolName | string | No | The virtual network pool associated with this subnet. |


<a id="SubnetSharedPublicIpAddressConfiguration" />
### SubnetSharedPublicIpAddressConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allowedPorts | array | No | Backend ports that virtual machines on this subnet are allowed to expose - [Port object](#Port) |


<a id="Port" />
### Port object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  transportProtocol | enum | No | Protocol type of the port. - Tcp or Udp |
|  backendPort | integer | No | Backend port of the target virtual machine. |

