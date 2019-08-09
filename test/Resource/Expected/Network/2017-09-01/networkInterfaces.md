# Microsoft.Network/networkInterfaces template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Network/networkInterfaces resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/networkInterfaces",
  "apiVersion": "2017-09-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "virtualMachine": {
      "id": "string"
    },
    "networkSecurityGroup": {
      "id": "string",
      "location": "string",
      "tags": {},
      "properties": {
        "securityRules": [
          {
            "id": "string",
            "properties": {
              "description": "string",
              "protocol": "string",
              "sourcePortRange": "string",
              "destinationPortRange": "string",
              "sourceAddressPrefix": "string",
              "sourceAddressPrefixes": [
                "string"
              ],
              "sourceApplicationSecurityGroups": [
                {
                  "id": "string",
                  "location": "string",
                  "tags": {},
                  "properties": {}
                }
              ],
              "destinationAddressPrefix": "string",
              "destinationAddressPrefixes": [
                "string"
              ],
              "destinationApplicationSecurityGroups": [
                {
                  "id": "string",
                  "location": "string",
                  "tags": {},
                  "properties": {}
                }
              ],
              "sourcePortRanges": [
                "string"
              ],
              "destinationPortRanges": [
                "string"
              ],
              "access": "string",
              "priority": "integer",
              "direction": "string",
              "provisioningState": "string"
            },
            "name": "string",
            "etag": "string"
          }
        ],
        "defaultSecurityRules": [
          {
            "id": "string",
            "properties": {
              "description": "string",
              "protocol": "string",
              "sourcePortRange": "string",
              "destinationPortRange": "string",
              "sourceAddressPrefix": "string",
              "sourceAddressPrefixes": [
                "string"
              ],
              "sourceApplicationSecurityGroups": [
                {
                  "id": "string",
                  "location": "string",
                  "tags": {},
                  "properties": {}
                }
              ],
              "destinationAddressPrefix": "string",
              "destinationAddressPrefixes": [
                "string"
              ],
              "destinationApplicationSecurityGroups": [
                {
                  "id": "string",
                  "location": "string",
                  "tags": {},
                  "properties": {}
                }
              ],
              "sourcePortRanges": [
                "string"
              ],
              "destinationPortRanges": [
                "string"
              ],
              "access": "string",
              "priority": "integer",
              "direction": "string",
              "provisioningState": "string"
            },
            "name": "string",
            "etag": "string"
          }
        ],
        "resourceGuid": "string",
        "provisioningState": "string"
      },
      "etag": "string"
    },
    "ipConfigurations": [
      {
        "id": "string",
        "properties": {
          "applicationGatewayBackendAddressPools": [
            {
              "id": "string",
              "properties": {
                "backendIPConfigurations": [
                  "NetworkInterfaceIPConfiguration"
                ],
                "backendAddresses": [
                  {
                    "fqdn": "string",
                    "ipAddress": "string"
                  }
                ],
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string",
              "type": "string"
            }
          ],
          "loadBalancerBackendAddressPools": [
            {
              "id": "string",
              "properties": {
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "loadBalancerInboundNatRules": [
            {
              "id": "string",
              "properties": {
                "frontendIPConfiguration": {
                  "id": "string"
                },
                "protocol": "string",
                "frontendPort": "integer",
                "backendPort": "integer",
                "idleTimeoutInMinutes": "integer",
                "enableFloatingIP": "boolean",
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "privateIPAddress": "string",
          "privateIPAllocationMethod": "string",
          "privateIPAddressVersion": "string",
          "subnet": {
            "id": "string",
            "properties": {
              "addressPrefix": "string",
              "networkSecurityGroup": {
                "id": "string",
                "location": "string",
                "tags": {},
                "properties": {
                  "securityRules": [
                    {
                      "id": "string",
                      "properties": {
                        "description": "string",
                        "protocol": "string",
                        "sourcePortRange": "string",
                        "destinationPortRange": "string",
                        "sourceAddressPrefix": "string",
                        "sourceAddressPrefixes": [
                          "string"
                        ],
                        "sourceApplicationSecurityGroups": [
                          {
                            "id": "string",
                            "location": "string",
                            "tags": {},
                            "properties": {}
                          }
                        ],
                        "destinationAddressPrefix": "string",
                        "destinationAddressPrefixes": [
                          "string"
                        ],
                        "destinationApplicationSecurityGroups": [
                          {
                            "id": "string",
                            "location": "string",
                            "tags": {},
                            "properties": {}
                          }
                        ],
                        "sourcePortRanges": [
                          "string"
                        ],
                        "destinationPortRanges": [
                          "string"
                        ],
                        "access": "string",
                        "priority": "integer",
                        "direction": "string",
                        "provisioningState": "string"
                      },
                      "name": "string",
                      "etag": "string"
                    }
                  ],
                  "defaultSecurityRules": [
                    {
                      "id": "string",
                      "properties": {
                        "description": "string",
                        "protocol": "string",
                        "sourcePortRange": "string",
                        "destinationPortRange": "string",
                        "sourceAddressPrefix": "string",
                        "sourceAddressPrefixes": [
                          "string"
                        ],
                        "sourceApplicationSecurityGroups": [
                          {
                            "id": "string",
                            "location": "string",
                            "tags": {},
                            "properties": {}
                          }
                        ],
                        "destinationAddressPrefix": "string",
                        "destinationAddressPrefixes": [
                          "string"
                        ],
                        "destinationApplicationSecurityGroups": [
                          {
                            "id": "string",
                            "location": "string",
                            "tags": {},
                            "properties": {}
                          }
                        ],
                        "sourcePortRanges": [
                          "string"
                        ],
                        "destinationPortRanges": [
                          "string"
                        ],
                        "access": "string",
                        "priority": "integer",
                        "direction": "string",
                        "provisioningState": "string"
                      },
                      "name": "string",
                      "etag": "string"
                    }
                  ],
                  "resourceGuid": "string",
                  "provisioningState": "string"
                },
                "etag": "string"
              },
              "routeTable": {
                "id": "string",
                "location": "string",
                "tags": {},
                "properties": {
                  "routes": [
                    {
                      "id": "string",
                      "properties": {
                        "addressPrefix": "string",
                        "nextHopType": "string",
                        "nextHopIpAddress": "string",
                        "provisioningState": "string"
                      },
                      "name": "string",
                      "etag": "string"
                    }
                  ],
                  "provisioningState": "string"
                },
                "etag": "string"
              },
              "serviceEndpoints": [
                {
                  "service": "string",
                  "locations": [
                    "string"
                  ],
                  "provisioningState": "string"
                }
              ],
              "resourceNavigationLinks": [
                {
                  "id": "string",
                  "properties": {
                    "linkedResourceType": "string",
                    "link": "string"
                  },
                  "name": "string"
                }
              ],
              "provisioningState": "string"
            },
            "name": "string",
            "etag": "string"
          },
          "primary": "boolean",
          "publicIPAddress": {
            "id": "string",
            "location": "string",
            "tags": {},
            "sku": {
              "name": "string"
            },
            "properties": {
              "publicIPAllocationMethod": "string",
              "publicIPAddressVersion": "string",
              "dnsSettings": {
                "domainNameLabel": "string",
                "fqdn": "string",
                "reverseFqdn": "string"
              },
              "ipAddress": "string",
              "idleTimeoutInMinutes": "integer",
              "resourceGuid": "string",
              "provisioningState": "string"
            },
            "etag": "string",
            "zones": [
              "string"
            ]
          },
          "applicationSecurityGroups": [
            {
              "id": "string",
              "location": "string",
              "tags": {},
              "properties": {}
            }
          ],
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "dnsSettings": {
      "dnsServers": [
        "string"
      ],
      "appliedDnsServers": [
        "string"
      ],
      "internalDnsNameLabel": "string",
      "internalFqdn": "string",
      "internalDomainNameSuffix": "string"
    },
    "macAddress": "string",
    "primary": "boolean",
    "enableAcceleratedNetworking": "boolean",
    "enableIPForwarding": "boolean",
    "resourceGuid": "string",
    "provisioningState": "string"
  },
  "etag": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/networkInterfaces" />
### Microsoft.Network/networkInterfaces object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/networkInterfaces |
|  apiVersion | enum | Yes | 2017-09-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Properties of the network interface. - [NetworkInterfacePropertiesFormat object](#NetworkInterfacePropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="NetworkInterfacePropertiesFormat" />
### NetworkInterfacePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  virtualMachine | object | No | The reference of a virtual machine. - [SubResource object](#SubResource) |
|  networkSecurityGroup | object | No | The reference of the NetworkSecurityGroup resource. - [NetworkSecurityGroup object](#NetworkSecurityGroup) |
|  ipConfigurations | array | No | A list of IPConfigurations of the network interface. - [NetworkInterfaceIPConfiguration object](#NetworkInterfaceIPConfiguration) |
|  dnsSettings | object | No | The DNS settings in network interface. - [NetworkInterfaceDnsSettings object](#NetworkInterfaceDnsSettings) |
|  macAddress | string | No | The MAC address of the network interface. |
|  primary | boolean | No | Gets whether this is a primary network interface on a virtual machine. |
|  enableAcceleratedNetworking | boolean | No | If the network interface is accelerated networking enabled. |
|  enableIPForwarding | boolean | No | Indicates whether IP forwarding is enabled on this network interface. |
|  resourceGuid | string | No | The resource GUID property of the network interface resource. |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |


<a id="NetworkSecurityGroup" />
### NetworkSecurityGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | Properties of the network security group - [NetworkSecurityGroupPropertiesFormat object](#NetworkSecurityGroupPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="NetworkInterfaceIPConfiguration" />
### NetworkInterfaceIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Network interface IP configuration properties. - [NetworkInterfaceIPConfigurationPropertiesFormat object](#NetworkInterfaceIPConfigurationPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="NetworkInterfaceDnsSettings" />
### NetworkInterfaceDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  dnsServers | array | No | List of DNS servers IP addresses. Use 'AzureProvidedDNS' to switch to azure provided DNS resolution. 'AzureProvidedDNS' value cannot be combined with other IPs, it must be the only value in dnsServers collection. - string |
|  appliedDnsServers | array | No | If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set. This property is what is configured on each of those VMs. - string |
|  internalDnsNameLabel | string | No | Relative DNS name for this NIC used for internal communications between VMs in the same virtual network. |
|  internalFqdn | string | No | Fully qualified DNS name supporting internal communications between VMs in the same virtual network. |
|  internalDomainNameSuffix | string | No | Even if internalDnsNameLabel is not specified, a DNS entry is created for the primary NIC of the VM. This DNS name can be constructed by concatenating the VM name with the value of internalDomainNameSuffix. |


<a id="NetworkSecurityGroupPropertiesFormat" />
### NetworkSecurityGroupPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  securityRules | array | No | A collection of security rules of the network security group. - [SecurityRule object](#SecurityRule) |
|  defaultSecurityRules | array | No | The default security rules of network security group. - [SecurityRule object](#SecurityRule) |
|  resourceGuid | string | No | The resource GUID property of the network security group resource. |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="NetworkInterfaceIPConfigurationPropertiesFormat" />
### NetworkInterfaceIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  applicationGatewayBackendAddressPools | array | No | The reference of ApplicationGatewayBackendAddressPool resource. - [ApplicationGatewayBackendAddressPool object](#ApplicationGatewayBackendAddressPool) |
|  loadBalancerBackendAddressPools | array | No | The reference of LoadBalancerBackendAddressPool resource. - [BackendAddressPool object](#BackendAddressPool) |
|  loadBalancerInboundNatRules | array | No | A list of references of LoadBalancerInboundNatRules. - [InboundNatRule object](#InboundNatRule) |
|  privateIPAddress | string | No | Private IP address of the IP configuration. |
|  privateIPAllocationMethod | enum | No | Defines how a private IP address is assigned. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  privateIPAddressVersion | enum | No | Available from Api-Version 2016-03-30 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: 'IPv4' and 'IPv6'. - IPv4 or IPv6 |
|  subnet | object | No | Subnet bound to the IP configuration. - [Subnet object](#Subnet) |
|  primary | boolean | No | Gets whether this is a primary customer address on the network interface. |
|  publicIPAddress | object | No | Public IP address bound to the IP configuration. - [PublicIPAddress object](#PublicIPAddress) |
|  applicationSecurityGroups | array | No | Application security groups in which the IP configuration is included. - [ApplicationSecurityGroup object](#ApplicationSecurityGroup) |
|  provisioningState | string | No | The provisioning state of the network interface IP configuration. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="SecurityRule" />
### SecurityRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of the security rule - [SecurityRulePropertiesFormat object](#SecurityRulePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="ApplicationGatewayBackendAddressPool" />
### ApplicationGatewayBackendAddressPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayBackendAddressPoolPropertiesFormat object](#ApplicationGatewayBackendAddressPoolPropertiesFormat) |
|  name | string | No | Resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="BackendAddressPool" />
### BackendAddressPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of load balancer backend address pool. - [BackendAddressPoolPropertiesFormat object](#BackendAddressPoolPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="InboundNatRule" />
### InboundNatRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of load balancer inbound nat rule. - [InboundNatRulePropertiesFormat object](#InboundNatRulePropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="Subnet" />
### Subnet object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of the subnet. - [SubnetPropertiesFormat object](#SubnetPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="PublicIPAddress" />
### PublicIPAddress object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  sku | object | No | The public IP address SKU. - [PublicIPAddressSku object](#PublicIPAddressSku) |
|  properties | object | No | Public IP address properties. - [PublicIPAddressPropertiesFormat object](#PublicIPAddressPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  zones | array | No | A list of availability zones denoting the IP allocated for the resource needs to come from. - string |


<a id="ApplicationSecurityGroup" />
### ApplicationSecurityGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | Properties of the application security group. - [ApplicationSecurityGroupPropertiesFormat object](#ApplicationSecurityGroupPropertiesFormat) |


<a id="SecurityRulePropertiesFormat" />
### SecurityRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | A description for this rule. Restricted to 140 chars. |
|  protocol | enum | Yes | Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'. - Tcp, Udp, * |
|  sourcePortRange | string | No | The source port or range. Integer or range between 0 and 65535. Asterix '*' can also be used to match all ports. |
|  destinationPortRange | string | No | The destination port or range. Integer or range between 0 and 65535. Asterix '*' can also be used to match all ports. |
|  sourceAddressPrefix | string | No | The CIDR or source IP range. Asterix '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.  |
|  sourceAddressPrefixes | array | No | The CIDR or source IP ranges. - string |
|  sourceApplicationSecurityGroups | array | No | The application security group specified as source. - [ApplicationSecurityGroup object](#ApplicationSecurityGroup) |
|  destinationAddressPrefix | string | No | The destination address prefix. CIDR or destination IP range. Asterix '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. |
|  destinationAddressPrefixes | array | No | The destination address prefixes. CIDR or destination IP ranges. - string |
|  destinationApplicationSecurityGroups | array | No | The application security group specified as destination. - [ApplicationSecurityGroup object](#ApplicationSecurityGroup) |
|  sourcePortRanges | array | No | The source port ranges. - string |
|  destinationPortRanges | array | No | The destination port ranges. - string |
|  access | enum | Yes | The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'. - Allow or Deny |
|  priority | integer | No | The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. |
|  direction | enum | Yes | The direction of the rule. The direction specifies if rule will be evaluated on incoming or outcoming traffic. Possible values are: 'Inbound' and 'Outbound'. - Inbound or Outbound |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayBackendAddressPoolPropertiesFormat" />
### ApplicationGatewayBackendAddressPoolPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  backendIPConfigurations | array | No | Collection of references to IPs defined in network interfaces. - [NetworkInterfaceIPConfiguration object](#NetworkInterfaceIPConfiguration) |
|  backendAddresses | array | No | Backend addresses - [ApplicationGatewayBackendAddress object](#ApplicationGatewayBackendAddress) |
|  provisioningState | string | No | Provisioning state of the backend address pool resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="BackendAddressPoolPropertiesFormat" />
### BackendAddressPoolPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  provisioningState | string | No | Get provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="InboundNatRulePropertiesFormat" />
### InboundNatRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfiguration | object | No | A reference to frontend IP addresses. - [SubResource object](#SubResource) |
|  protocol | enum | No | Udp, Tcp, All |
|  frontendPort | integer | No | The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. |
|  backendPort | integer | No | The port used for the internal endpoint. Acceptable values range from 1 to 65535. |
|  idleTimeoutInMinutes | integer | No | The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. |
|  enableFloatingIP | boolean | No | Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint. |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="SubnetPropertiesFormat" />
### SubnetPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The address prefix for the subnet. |
|  networkSecurityGroup | object | No | The reference of the NetworkSecurityGroup resource. - [NetworkSecurityGroup object](#NetworkSecurityGroup) |
|  routeTable | object | No | The reference of the RouteTable resource. - [RouteTable object](#RouteTable) |
|  serviceEndpoints | array | No | An array of service endpoints. - [ServiceEndpointPropertiesFormat object](#ServiceEndpointPropertiesFormat) |
|  resourceNavigationLinks | array | No | Gets an array of references to the external resources using subnet. - [ResourceNavigationLink object](#ResourceNavigationLink) |
|  provisioningState | string | No | The provisioning state of the resource. |


<a id="PublicIPAddressSku" />
### PublicIPAddressSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Name of a public IP address SKU. - Basic or Standard |


<a id="PublicIPAddressPropertiesFormat" />
### PublicIPAddressPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicIPAllocationMethod | enum | No | The public IP allocation method. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  publicIPAddressVersion | enum | No | The public IP address version. Possible values are: 'IPv4' and 'IPv6'. - IPv4 or IPv6 |
|  dnsSettings | object | No | The FQDN of the DNS record associated with the public IP address. - [PublicIPAddressDnsSettings object](#PublicIPAddressDnsSettings) |
|  ipAddress | string | No | The IP address associated with the public IP address resource. |
|  idleTimeoutInMinutes | integer | No | The idle timeout of the public IP address. |
|  resourceGuid | string | No | The resource GUID property of the public IP resource. |
|  provisioningState | string | No | The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayBackendAddress" />
### ApplicationGatewayBackendAddress object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  fqdn | string | No | Fully qualified domain name (FQDN). |
|  ipAddress | string | No | IP address |


<a id="RouteTable" />
### RouteTable object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | Properties of the route table. - [RouteTablePropertiesFormat object](#RouteTablePropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated. |


<a id="ServiceEndpointPropertiesFormat" />
### ServiceEndpointPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  service | string | No | The type of the endpoint service. |
|  locations | array | No | A list of locations. - string |
|  provisioningState | string | No | The provisioning state of the resource. |


<a id="ResourceNavigationLink" />
### ResourceNavigationLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Resource navigation link properties format. - [ResourceNavigationLinkFormat object](#ResourceNavigationLinkFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |


<a id="PublicIPAddressDnsSettings" />
### PublicIPAddressDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  domainNameLabel | string | No | Gets or sets the Domain name label.The concatenation of the domain name label and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system. |
|  fqdn | string | No | Gets the FQDN, Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone. |
|  reverseFqdn | string | No | Gets or Sets the Reverse FQDN. A user-visible, fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.  |


<a id="RouteTablePropertiesFormat" />
### RouteTablePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  routes | array | No | Collection of routes contained within a route table. - [Route object](#Route) |
|  provisioningState | string | No | The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ResourceNavigationLinkFormat" />
### ResourceNavigationLinkFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  linkedResourceType | string | No | Resource type of the linked resource. |
|  link | string | No | Link to the external resource |


<a id="Route" />
### Route object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of the route. - [RoutePropertiesFormat object](#RoutePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="RoutePropertiesFormat" />
### RoutePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The destination CIDR to which the route applies. |
|  nextHopType | enum | Yes | The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'. - VirtualNetworkGateway, VnetLocal, Internet, VirtualAppliance, None |
|  nextHopIpAddress | string | No | The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. |
|  provisioningState | string | No | The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |

