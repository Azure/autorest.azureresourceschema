# Microsoft.Network/loadBalancers template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Network/loadBalancers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/loadBalancers",
  "apiVersion": "2016-09-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "frontendIPConfigurations": [
      {
        "id": "string",
        "properties": {
          "privateIPAddress": "string",
          "privateIPAllocationMethod": "string",
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
                        "destinationAddressPrefix": "string",
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
                        "destinationAddressPrefix": "string",
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
          "publicIPAddress": {
            "id": "string",
            "location": "string",
            "tags": {},
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
            "etag": "string"
          },
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "backendAddressPools": [
      {
        "id": "string",
        "properties": {
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "loadBalancingRules": [
      {
        "id": "string",
        "properties": {
          "frontendIPConfiguration": {
            "id": "string"
          },
          "backendAddressPool": {
            "id": "string"
          },
          "probe": {
            "id": "string"
          },
          "protocol": "string",
          "loadDistribution": "string",
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
    "probes": [
      {
        "id": "string",
        "properties": {
          "protocol": "string",
          "port": "integer",
          "intervalInSeconds": "integer",
          "numberOfProbes": "integer",
          "requestPath": "string",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "inboundNatRules": [
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
    "inboundNatPools": [
      {
        "id": "string",
        "properties": {
          "frontendIPConfiguration": {
            "id": "string"
          },
          "protocol": "string",
          "frontendPortRangeStart": "integer",
          "frontendPortRangeEnd": "integer",
          "backendPort": "integer",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "outboundNatRules": [
      {
        "id": "string",
        "properties": {
          "allocatedOutboundPorts": "integer",
          "frontendIPConfigurations": [
            {
              "id": "string"
            }
          ],
          "backendAddressPool": {
            "id": "string"
          },
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
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/loadBalancers" />
### Microsoft.Network/loadBalancers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/loadBalancers |
|  apiVersion | enum | Yes | 2016-09-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [LoadBalancerPropertiesFormat object](#LoadBalancerPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="LoadBalancerPropertiesFormat" />
### LoadBalancerPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfigurations | array | No | Object representing the frontend IPs to be used for the load balancer - [FrontendIPConfiguration object](#FrontendIPConfiguration) |
|  backendAddressPools | array | No | Collection of backend address pools used by a load balancer - [BackendAddressPool object](#BackendAddressPool) |
|  loadBalancingRules | array | No | Object collection representing the load balancing rules Gets the provisioning  - [LoadBalancingRule object](#LoadBalancingRule) |
|  probes | array | No | Collection of probe objects used in the load balancer - [Probe object](#Probe) |
|  inboundNatRules | array | No | Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules. - [InboundNatRule object](#InboundNatRule) |
|  inboundNatPools | array | No | Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules. - [InboundNatPool object](#InboundNatPool) |
|  outboundNatRules | array | No | The outbound NAT rules. - [OutboundNatRule object](#OutboundNatRule) |
|  resourceGuid | string | No | The resource GUID property of the load balancer resource. |
|  provisioningState | string | No | Gets the provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="FrontendIPConfiguration" />
### FrontendIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [FrontendIPConfigurationPropertiesFormat object](#FrontendIPConfigurationPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="BackendAddressPool" />
### BackendAddressPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [BackendAddressPoolPropertiesFormat object](#BackendAddressPoolPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="LoadBalancingRule" />
### LoadBalancingRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [LoadBalancingRulePropertiesFormat object](#LoadBalancingRulePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="Probe" />
### Probe object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ProbePropertiesFormat object](#ProbePropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="InboundNatRule" />
### InboundNatRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [InboundNatRulePropertiesFormat object](#InboundNatRulePropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="InboundNatPool" />
### InboundNatPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [InboundNatPoolPropertiesFormat object](#InboundNatPoolPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="OutboundNatRule" />
### OutboundNatRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [OutboundNatRulePropertiesFormat object](#OutboundNatRulePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="FrontendIPConfigurationPropertiesFormat" />
### FrontendIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  privateIPAddress | string | No | The private IP address of the IP configuration. |
|  privateIPAllocationMethod | enum | No | The Private IP allocation method. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  subnet | object | No | The reference of the subnet resource. - [Subnet object](#Subnet) |
|  publicIPAddress | object | No | The reference of the Public IP resource. - [PublicIPAddress object](#PublicIPAddress) |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="BackendAddressPoolPropertiesFormat" />
### BackendAddressPoolPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  provisioningState | string | No | Get provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="LoadBalancingRulePropertiesFormat" />
### LoadBalancingRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfiguration | object | No | A reference to frontend IP addresses. - [SubResource object](#SubResource) |
|  backendAddressPool | object | No | A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs. - [SubResource object](#SubResource) |
|  probe | object | No | The reference of the load balancer probe used by the load balancing rule. - [SubResource object](#SubResource) |
|  protocol | enum | Yes | The transport protocol for the external endpoint. Possible values are 'Udp' or 'Tcp'. - Udp or Tcp |
|  loadDistribution | enum | No | The load distribution policy for this rule. Possible values are 'Default', 'SourceIP', and 'SourceIPProtocol'. - Default, SourceIP, SourceIPProtocol |
|  frontendPort | integer | Yes | The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 1 and 65534. |
|  backendPort | integer | No | The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.  |
|  idleTimeoutInMinutes | integer | No | The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. |
|  enableFloatingIP | boolean | No | Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint. |
|  provisioningState | string | No | Gets the provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ProbePropertiesFormat" />
### ProbePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  protocol | enum | Yes | The protocol of the end point. Possible values are: 'Http' or 'Tcp'. If 'Tcp' is specified, a received ACK is required for the probe to be successful. If 'Http' is specified, a 200 OK response from the specifies URI is required for the probe to be successful. - Http or Tcp |
|  port | integer | Yes | The port for communicating the probe. Possible values range from 1 to 65535, inclusive. |
|  intervalInSeconds | integer | No | The interval, in seconds, for how frequently to probe the endpoint for health status. Typically, the interval is slightly less than half the allocated timeout period (in seconds) which allows two full probes before taking the instance out of rotation. The default value is 15, the minimum value is 5. |
|  numberOfProbes | integer | No | The number of probes where if no response, will result in stopping further traffic from being delivered to the endpoint. This values allows endpoints to be taken out of rotation faster or slower than the typical times used in Azure. |
|  requestPath | string | No | The URI used for requesting health status from the VM. Path is required if a protocol is set to http. Otherwise, it is not allowed. There is no default value. |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="InboundNatRulePropertiesFormat" />
### InboundNatRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfiguration | object | No | A reference to frontend IP addresses. - [SubResource object](#SubResource) |
|  protocol | enum | No | The transport protocol for the endpoint. Possible values are: 'Udp' or 'Tcp'. - Udp or Tcp |
|  frontendPort | integer | No | The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. |
|  backendPort | integer | No | The port used for the internal endpoint. Acceptable values range from 1 to 65535. |
|  idleTimeoutInMinutes | integer | No | The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. |
|  enableFloatingIP | boolean | No | Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint. |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="InboundNatPoolPropertiesFormat" />
### InboundNatPoolPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfiguration | object | No | A reference to frontend IP addresses. - [SubResource object](#SubResource) |
|  protocol | enum | Yes | The transport protocol for the endpoint. Possible values are: 'Udp' or 'Tcp'. - Udp or Tcp |
|  frontendPortRangeStart | integer | Yes | The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65534. |
|  frontendPortRangeEnd | integer | Yes | The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65535. |
|  backendPort | integer | Yes | The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. |
|  provisioningState | string | No | Gets the provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="OutboundNatRulePropertiesFormat" />
### OutboundNatRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allocatedOutboundPorts | integer | No | The number of outbound ports to be used for NAT. |
|  frontendIPConfigurations | array | No | The Frontend IP addresses of the load balancer. - [SubResource object](#SubResource) |
|  backendAddressPool | object | Yes | A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs. - [SubResource object](#SubResource) |
|  provisioningState | string | No | Gets the provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="Subnet" />
### Subnet object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [SubnetPropertiesFormat object](#SubnetPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="PublicIPAddress" />
### PublicIPAddress object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | [PublicIPAddressPropertiesFormat object](#PublicIPAddressPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |


<a id="SubnetPropertiesFormat" />
### SubnetPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The address prefix for the subnet. |
|  networkSecurityGroup | object | No | The reference of the NetworkSecurityGroup resource. - [NetworkSecurityGroup object](#NetworkSecurityGroup) |
|  routeTable | object | No | The reference of the RouteTable resource. - [RouteTable object](#RouteTable) |
|  resourceNavigationLinks | array | No | Gets an array of references to the external resources using subnet. - [ResourceNavigationLink object](#ResourceNavigationLink) |
|  provisioningState | string | No | The provisioning state of the resource. |


<a id="PublicIPAddressPropertiesFormat" />
### PublicIPAddressPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicIPAllocationMethod | enum | No | The public IP allocation method. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  publicIPAddressVersion | enum | No | The public IP address version. Possible values are: 'IPv4' and 'IPv6'. - IPv4 or IPv6 |
|  dnsSettings | object | No | The FQDN of the DNS record associated with the public IP address. - [PublicIPAddressDnsSettings object](#PublicIPAddressDnsSettings) |
|  ipAddress | string | No |  |
|  idleTimeoutInMinutes | integer | No | The idle timeout of the public IP address. |
|  resourceGuid | string | No | The resource GUID property of the public IP resource. |
|  provisioningState | string | No | The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="NetworkSecurityGroup" />
### NetworkSecurityGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | [NetworkSecurityGroupPropertiesFormat object](#NetworkSecurityGroupPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="RouteTable" />
### RouteTable object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | [RouteTablePropertiesFormat object](#RouteTablePropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated. |


<a id="ResourceNavigationLink" />
### ResourceNavigationLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ResourceNavigationLinkFormat object](#ResourceNavigationLinkFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |


<a id="PublicIPAddressDnsSettings" />
### PublicIPAddressDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  domainNameLabel | string | No | Gets or sets the Domain name label.The concatenation of the domain name label and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system. |
|  fqdn | string | No | Gets the FQDN, Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone. |
|  reverseFqdn | string | No | Gets or Sets the Reverse FQDN. A user-visible, fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.  |


<a id="NetworkSecurityGroupPropertiesFormat" />
### NetworkSecurityGroupPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  securityRules | array | No | A collection of security rules of the network security group. - [SecurityRule object](#SecurityRule) |
|  defaultSecurityRules | array | No | The default security rules of network security group. - [SecurityRule object](#SecurityRule) |
|  resourceGuid | string | No | The resource GUID property of the network security group resource. |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


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


<a id="SecurityRule" />
### SecurityRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [SecurityRulePropertiesFormat object](#SecurityRulePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="Route" />
### Route object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [RoutePropertiesFormat object](#RoutePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="SecurityRulePropertiesFormat" />
### SecurityRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | A description for this rule. Restricted to 140 chars. |
|  protocol | enum | Yes | Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'. - Tcp, Udp, * |
|  sourcePortRange | string | No | The source port or range. Integer or range between 0 and 65535. Asterix '*' can also be used to match all ports. |
|  destinationPortRange | string | No | The destination port or range. Integer or range between 0 and 65535. Asterix '*' can also be used to match all ports. |
|  sourceAddressPrefix | string | Yes | The CIDR or source IP range. Asterix '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.  |
|  destinationAddressPrefix | string | Yes | The destination address prefix. CIDR or source IP range. Asterix '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. |
|  access | enum | Yes | The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'. - Allow or Deny |
|  priority | integer | No | The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. |
|  direction | enum | Yes | The direction of the rule. The direction specifies if rule will be evaluated on incoming or outcoming traffic. Possible values are: 'Inbound' and 'Outbound'. - Inbound or Outbound |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="RoutePropertiesFormat" />
### RoutePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The destination CIDR to which the route applies. |
|  nextHopType | enum | Yes | The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'. - VirtualNetworkGateway, VnetLocal, Internet, VirtualAppliance, None |
|  nextHopIpAddress | string | No | The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. |
|  provisioningState | string | No | The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |

