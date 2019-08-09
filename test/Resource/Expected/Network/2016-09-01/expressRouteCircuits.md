# Microsoft.Network/expressRouteCircuits template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Network/expressRouteCircuits resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/expressRouteCircuits",
  "apiVersion": "2016-09-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "sku": {
    "name": "string",
    "tier": "string",
    "family": "string"
  },
  "properties": {
    "allowClassicOperations": "boolean",
    "circuitProvisioningState": "string",
    "serviceProviderProvisioningState": "string",
    "authorizations": [
      {
        "id": "string",
        "properties": {
          "authorizationKey": "string",
          "authorizationUseStatus": "string",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "peerings": [
      {
        "id": "string",
        "properties": {
          "peeringType": "string",
          "state": "string",
          "azureASN": "integer",
          "peerASN": "integer",
          "primaryPeerAddressPrefix": "string",
          "secondaryPeerAddressPrefix": "string",
          "primaryAzurePort": "string",
          "secondaryAzurePort": "string",
          "sharedKey": "string",
          "vlanId": "integer",
          "microsoftPeeringConfig": {
            "advertisedPublicPrefixes": [
              "string"
            ],
            "advertisedPublicPrefixesState": "string",
            "customerASN": "integer",
            "routingRegistryName": "string"
          },
          "stats": {
            "primarybytesIn": "integer",
            "primarybytesOut": "integer",
            "secondarybytesIn": "integer",
            "secondarybytesOut": "integer"
          },
          "provisioningState": "string",
          "gatewayManagerEtag": "string",
          "lastModifiedBy": "string"
        },
        "name": "string",
        "etag": "string"
      }
    ],
    "serviceKey": "string",
    "serviceProviderNotes": "string",
    "serviceProviderProperties": {
      "serviceProviderName": "string",
      "peeringLocation": "string",
      "bandwidthInMbps": "integer"
    },
    "provisioningState": "string",
    "gatewayManagerEtag": "string"
  },
  "etag": "string",
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/expressRouteCircuits" />
### Microsoft.Network/expressRouteCircuits object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/expressRouteCircuits |
|  apiVersion | enum | Yes | 2016-09-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  sku | object | No | The SKU. - [ExpressRouteCircuitSku object](#ExpressRouteCircuitSku) |
|  properties | object | Yes | [ExpressRouteCircuitPropertiesFormat object](#ExpressRouteCircuitPropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated. |
|  resources | array | No | [peerings](./expressRouteCircuits/peerings.md) [authorizations](./expressRouteCircuits/authorizations.md) |


<a id="ExpressRouteCircuitSku" />
### ExpressRouteCircuitSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name of the SKU. |
|  tier | enum | No | The tier of the SKU. Possible values are 'Standard' and 'Premium'. - Standard or Premium |
|  family | enum | No | The family of the SKU. Possible values are: 'UnlimitedData' and 'MeteredData'. - UnlimitedData or MeteredData |


<a id="ExpressRouteCircuitPropertiesFormat" />
### ExpressRouteCircuitPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allowClassicOperations | boolean | No | Allow classic operations |
|  circuitProvisioningState | string | No | The CircuitProvisioningState state of the resource. |
|  serviceProviderProvisioningState | enum | No | The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'. - NotProvisioned, Provisioning, Provisioned, Deprovisioning |
|  authorizations | array | No | The list of authorizations. - [ExpressRouteCircuitAuthorization object](#ExpressRouteCircuitAuthorization) |
|  peerings | array | No | The list of peerings. - [ExpressRouteCircuitPeering object](#ExpressRouteCircuitPeering) |
|  serviceKey | string | No | The ServiceKey. |
|  serviceProviderNotes | string | No | The ServiceProviderNotes. |
|  serviceProviderProperties | object | No | The ServiceProviderProperties. - [ExpressRouteCircuitServiceProviderProperties object](#ExpressRouteCircuitServiceProviderProperties) |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |
|  gatewayManagerEtag | string | No | The GatewayManager Etag. |


<a id="ExpressRouteCircuitAuthorization" />
### ExpressRouteCircuitAuthorization object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [AuthorizationPropertiesFormat object](#AuthorizationPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="ExpressRouteCircuitPeering" />
### ExpressRouteCircuitPeering object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ExpressRouteCircuitPeeringPropertiesFormat object](#ExpressRouteCircuitPeeringPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="ExpressRouteCircuitServiceProviderProperties" />
### ExpressRouteCircuitServiceProviderProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceProviderName | string | No | The serviceProviderName. |
|  peeringLocation | string | No | The peering location. |
|  bandwidthInMbps | integer | No | The BandwidthInMbps. |


<a id="AuthorizationPropertiesFormat" />
### AuthorizationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationKey | string | No | The authorization key. |
|  authorizationUseStatus | enum | No | AuthorizationUseStatus. Possible values are: 'Available' and 'InUse'. - Available or InUse |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ExpressRouteCircuitPeeringPropertiesFormat" />
### ExpressRouteCircuitPeeringPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  peeringType | enum | No | The PeeringType. Possible values are: 'AzurePublicPeering', 'AzurePrivatePeering', and 'MicrosoftPeering'. - AzurePublicPeering, AzurePrivatePeering, MicrosoftPeering |
|  state | enum | No | The state of peering. Possible values are: 'Disabled' and 'Enabled'. - Disabled or Enabled |
|  azureASN | integer | No | The Azure ASN. |
|  peerASN | integer | No | The peer ASN. |
|  primaryPeerAddressPrefix | string | No | The primary address prefix. |
|  secondaryPeerAddressPrefix | string | No | The secondary address prefix. |
|  primaryAzurePort | string | No | The primary port. |
|  secondaryAzurePort | string | No | The secondary port. |
|  sharedKey | string | No | The shared key. |
|  vlanId | integer | No | The VLAN ID. |
|  microsoftPeeringConfig | object | No | The Microsoft peering configuration. - [ExpressRouteCircuitPeeringConfig object](#ExpressRouteCircuitPeeringConfig) |
|  stats | object | No | Gets peering stats. - [ExpressRouteCircuitStats object](#ExpressRouteCircuitStats) |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |
|  gatewayManagerEtag | string | No | The GatewayManager Etag. |
|  lastModifiedBy | string | No | Gets whether the provider or the customer last modified the peering. |


<a id="ExpressRouteCircuitPeeringConfig" />
### ExpressRouteCircuitPeeringConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  advertisedPublicPrefixes | array | No | The reference of AdvertisedPublicPrefixes. - string |
|  advertisedPublicPrefixesState | enum | No | AdvertisedPublicPrefixState of the Peering resource. Possible values are 'NotConfigured', 'Configuring', 'Configured', and 'ValidationNeeded'. - NotConfigured, Configuring, Configured, ValidationNeeded |
|  customerASN | integer | No | The CustomerASN of the peering. |
|  routingRegistryName | string | No | The RoutingRegistryName of the configuration. |


<a id="ExpressRouteCircuitStats" />
### ExpressRouteCircuitStats object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  primarybytesIn | integer | No | Gets BytesIn of the peering. |
|  primarybytesOut | integer | No | Gets BytesOut of the peering. |
|  secondarybytesIn | integer | No | Gets BytesIn of the peering. |
|  secondarybytesOut | integer | No | Gets BytesOut of the peering. |

