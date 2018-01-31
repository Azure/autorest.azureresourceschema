# Microsoft.Network/loadBalancers/inboundNatRules template reference
API Version: 2017-08-01
## Template format

To create a Microsoft.Network/loadBalancers/inboundNatRules resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/loadBalancers/inboundNatRules",
  "apiVersion": "2017-08-01",
  "id": "string",
  "properties": {
    "frontendIPConfiguration": {
      "id": "string"
    },
    "protocol": "string",
    "frontendPort": "integer",
    "backendPort": "integer",
    "idleTimeoutInMinutes": "integer",
    "enableFloatingIP": boolean,
    "provisioningState": "string"
  },
  "etag": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/loadBalancers/inboundNatRules" />
### Microsoft.Network/loadBalancers/inboundNatRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/loadBalancers/inboundNatRules |
|  apiVersion | enum | Yes | 2017-08-01 |
|  id | string | No | Resource ID. |
|  properties | object | Yes | Properties of load balancer inbound nat rule. - [InboundNatRulePropertiesFormat object](#InboundNatRulePropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


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


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |

