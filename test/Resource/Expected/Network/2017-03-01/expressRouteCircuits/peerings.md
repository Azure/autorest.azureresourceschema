# Microsoft.Network/expressRouteCircuits/peerings template reference
API Version: 2017-03-01
## Template format

To create a Microsoft.Network/expressRouteCircuits/peerings resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/expressRouteCircuits/peerings",
  "apiVersion": "2017-03-01",
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
    "lastModifiedBy": "string",
    "routeFilter": {
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
            "location": "string",
            "tags": {}
          }
        ]
      }
    },
    "ipv6PeeringConfig": {
      "primaryPeerAddressPrefix": "string",
      "secondaryPeerAddressPrefix": "string",
      "microsoftPeeringConfig": {
        "advertisedPublicPrefixes": [
          "string"
        ],
        "advertisedPublicPrefixesState": "string",
        "customerASN": "integer",
        "routingRegistryName": "string"
      },
      "routeFilter": {
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
              "location": "string",
              "tags": {}
            }
          ]
        }
      },
      "state": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/expressRouteCircuits/peerings" />
### Microsoft.Network/expressRouteCircuits/peerings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/expressRouteCircuits/peerings |
|  apiVersion | enum | Yes | 2017-03-01 |
|  id | string | No | Resource ID. |
|  properties | object | Yes | [ExpressRouteCircuitPeeringPropertiesFormat object](#ExpressRouteCircuitPeeringPropertiesFormat) |


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


<a id="RouteFilterPropertiesFormat" />
### RouteFilterPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rules | array | No | Collection of RouteFilterRules contained within a route filter. - [RouteFilterRule object](#RouteFilterRule) |


<a id="RouteFilterRule" />
### RouteFilterRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [RouteFilterRulePropertiesFormat object](#RouteFilterRulePropertiesFormat) |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |


<a id="RouteFilterRulePropertiesFormat" />
### RouteFilterRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  access | enum | Yes | The access type of the rule. Valid values are: 'Allow', 'Deny'. - Allow or Deny |
|  routeFilterRuleType | enum | Yes | The rule type of the rule. Valid value is: 'Community' - Community |
|  communities | array | Yes | The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020'] - string |

