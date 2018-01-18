# Microsoft.Network/publicIPAddresses template reference
API Version: 2017-08-01
## Template format

To create a Microsoft.Network/publicIPAddresses resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/publicIPAddresses",
  "apiVersion": "2017-08-01",
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
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/publicIPAddresses" />
### Microsoft.Network/publicIPAddresses object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/publicIPAddresses |
|  apiVersion | enum | Yes | 2017-08-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  sku | object | No | The public IP address SKU. - [PublicIPAddressSku object](#PublicIPAddressSku) |
|  properties | object | Yes | Public IP address properties. - [PublicIPAddressPropertiesFormat object](#PublicIPAddressPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  zones | array | No | A list of availability zones denoting the IP allocated for the resource needs to come from. - string |


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


<a id="PublicIPAddressDnsSettings" />
### PublicIPAddressDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  domainNameLabel | string | No | Gets or sets the Domain name label.The concatenation of the domain name label and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system. |
|  fqdn | string | No | Gets the FQDN, Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone. |
|  reverseFqdn | string | No | Gets or Sets the Reverse FQDN. A user-visible, fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.  |

