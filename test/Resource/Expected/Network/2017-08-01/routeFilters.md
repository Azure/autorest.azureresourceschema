# Microsoft.Network/routeFilters template reference
API Version: 2017-08-01
## Template format

To create a Microsoft.Network/routeFilters resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/routeFilters",
  "apiVersion": "2017-08-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "rules": [
      {
        "id": "string",
        "properties": {
          "access": "string",
          "routeFilterRuleType": "Community",
          "communities": [
            "string"
          ]
        },
        "name": "string",
        "location": "string",
        "tags": {}
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
            "advertisedCommunities": [
              "string"
            ],
            "advertisedPublicPrefixesState": "string",
            "legacyMode": "integer",
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
          "lastModifiedBy": "string",
          "routeFilter": {
            "id": "string",
            "location": "string",
            "tags": {},
            "properties": "RouteFilterPropertiesFormat"
          },
          "ipv6PeeringConfig": {
            "primaryPeerAddressPrefix": "string",
            "secondaryPeerAddressPrefix": "string",
            "microsoftPeeringConfig": {
              "advertisedPublicPrefixes": [
                "string"
              ],
              "advertisedCommunities": [
                "string"
              ],
              "advertisedPublicPrefixesState": "string",
              "legacyMode": "integer",
              "customerASN": "integer",
              "routingRegistryName": "string"
            },
            "routeFilter": {
              "id": "string",
              "location": "string",
              "tags": {},
              "properties": "RouteFilterPropertiesFormat"
            },
            "state": "string"
          }
        },
        "name": "string"
      }
    ]
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/routeFilters" />
### Microsoft.Network/routeFilters object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/routeFilters |
|  apiVersion | enum | Yes | 2017-08-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [RouteFilterPropertiesFormat object](#RouteFilterPropertiesFormat) |
|  resources | array | No | [routeFilterRules](./routeFilters/routeFilterRules.md) |


<a id="RouteFilterPropertiesFormat" />
### RouteFilterPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rules | array | No | Collection of RouteFilterRules contained within a route filter. - [RouteFilterRule object](#RouteFilterRule) |
|  peerings | array | No | A collection of references to express route circuit peerings. - [ExpressRouteCircuitPeering object](#ExpressRouteCircuitPeering) |


<a id="RouteFilterRule" />
### RouteFilterRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [RouteFilterRulePropertiesFormat object](#RouteFilterRulePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |


<a id="ExpressRouteCircuitPeering" />
### ExpressRouteCircuitPeering object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ExpressRouteCircuitPeeringPropertiesFormat object](#ExpressRouteCircuitPeeringPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |


<a id="RouteFilterRulePropertiesFormat" />
### RouteFilterRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  access | enum | Yes | The access type of the rule. Valid values are: 'Allow', 'Deny'. - Allow or Deny |
|  routeFilterRuleType | enum | Yes | The rule type of the rule. Valid value is: 'Community' - Community |
|  communities | array | Yes | The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020'] - string |


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
|  routeFilter | object | No | The reference of the RouteFilter resource. - [RouteFilter object](#RouteFilter) |
|  ipv6PeeringConfig | object | No | The IPv6 peering configuration. - [Ipv6ExpressRouteCircuitPeeringConfig object](#Ipv6ExpressRouteCircuitPeeringConfig) |


<a id="ExpressRouteCircuitPeeringConfig" />
### ExpressRouteCircuitPeeringConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  advertisedPublicPrefixes | array | No | The reference of AdvertisedPublicPrefixes. - string |
|  advertisedCommunities | array | No | The communities of bgp peering. Spepcified for microsoft peering - string |
|  advertisedPublicPrefixesState | enum | No | AdvertisedPublicPrefixState of the Peering resource. Possible values are 'NotConfigured', 'Configuring', 'Configured', and 'ValidationNeeded'. - NotConfigured, Configuring, Configured, ValidationNeeded |
|  legacyMode | integer | No | The legacy mode of the peering. |
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


<a id="RouteFilter" />
### RouteFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | [RouteFilterPropertiesFormat object](#RouteFilterPropertiesFormat) |


<a id="Ipv6ExpressRouteCircuitPeeringConfig" />
### Ipv6ExpressRouteCircuitPeeringConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  primaryPeerAddressPrefix | string | No | The primary address prefix. |
|  secondaryPeerAddressPrefix | string | No | The secondary address prefix. |
|  microsoftPeeringConfig | object | No | The Microsoft peering configuration. - [ExpressRouteCircuitPeeringConfig object](#ExpressRouteCircuitPeeringConfig) |
|  routeFilter | object | No | The reference of the RouteFilter resource. - [RouteFilter object](#RouteFilter) |
|  state | enum | No | The state of peering. Possible values are: 'Disabled' and 'Enabled'. - Disabled or Enabled |

