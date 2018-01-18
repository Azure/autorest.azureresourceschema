# Microsoft.Network/trafficmanagerprofiles template reference
API Version: 2017-05-01
## Template format

To create a Microsoft.Network/trafficmanagerprofiles resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/trafficmanagerprofiles",
  "apiVersion": "2017-05-01",
  "tags": {},
  "location": "string",
  "properties": {
    "profileStatus": "string",
    "trafficRoutingMethod": "string",
    "dnsConfig": {
      "relativeName": "string",
      "ttl": "integer"
    },
    "monitorConfig": {
      "profileMonitorStatus": "string",
      "protocol": "string",
      "port": "integer",
      "path": "string",
      "intervalInSeconds": "integer",
      "timeoutInSeconds": "integer",
      "toleratedNumberOfFailures": "integer"
    },
    "endpoints": [
      {
        "properties": {
          "targetResourceId": "string",
          "target": "string",
          "endpointStatus": "string",
          "weight": "integer",
          "priority": "integer",
          "endpointLocation": "string",
          "endpointMonitorStatus": "string",
          "minChildEndpoints": "integer",
          "geoMapping": [
            "string"
          ]
        }
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/trafficmanagerprofiles" />
### Microsoft.Network/trafficmanagerprofiles object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/trafficmanagerprofiles |
|  apiVersion | enum | Yes | 2017-05-01 |
|  tags | object | No | Resource tags. |
|  location | string | No | The Azure Region where the resource lives |
|  properties | object | Yes | The properties of the Traffic Manager profile. - [ProfileProperties object](#ProfileProperties) |


<a id="ProfileProperties" />
### ProfileProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  profileStatus | enum | No | The status of the Traffic Manager profile. - Enabled or Disabled |
|  trafficRoutingMethod | enum | No | The traffic routing method of the Traffic Manager profile. - Performance, Priority, Weighted, Geographic |
|  dnsConfig | object | No | The DNS settings of the Traffic Manager profile. - [DnsConfig object](#DnsConfig) |
|  monitorConfig | object | No | The endpoint monitoring settings of the Traffic Manager profile. - [MonitorConfig object](#MonitorConfig) |
|  endpoints | array | No | The list of endpoints in the Traffic Manager profile. - [Endpoint object](#Endpoint) |


<a id="DnsConfig" />
### DnsConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  relativeName | string | No | The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile. |
|  ttl | integer | No | The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile. |


<a id="MonitorConfig" />
### MonitorConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  profileMonitorStatus | enum | No | The profile-level monitoring status of the Traffic Manager profile. - CheckingEndpoints, Online, Degraded, Disabled, Inactive |
|  protocol | enum | No | The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health. - HTTP, HTTPS, TCP |
|  port | integer | No | The TCP port used to probe for endpoint health. |
|  path | string | No | The path relative to the endpoint domain name used to probe for endpoint health. |
|  intervalInSeconds | integer | No | The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager will check the health of each endpoint in this profile. |
|  timeoutInSeconds | integer | No | The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows endpoints in this profile to response to the health check. |
|  toleratedNumberOfFailures | integer | No | The number of consecutive failed health check that Traffic Manager tolerates before declaring an endpoint in this profile Degraded after the next failed health check. |


<a id="Endpoint" />
### Endpoint object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  properties | object | No | The properties of the Traffic Manager endpoint. - [EndpointProperties object](#EndpointProperties) |


<a id="EndpointProperties" />
### EndpointProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  targetResourceId | string | No | The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'. |
|  target | string | No | The fully-qualified DNS name of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint. |
|  endpointStatus | enum | No | The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method. - Enabled or Disabled |
|  weight | integer | No | The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000. |
|  priority | integer | No | The priority of this endpoint when using the ‘Priority’ traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value. |
|  endpointLocation | string | No | Specifies the location of the external or nested endpoints when using the ‘Performance’ traffic routing method. |
|  endpointMonitorStatus | enum | No | The monitoring status of the endpoint. - CheckingEndpoint, Online, Degraded, Disabled, Inactive, Stopped |
|  minChildEndpoints | integer | No | The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. |
|  geoMapping | array | No | The list of countries/regions mapped to this endpoint when using the ‘Geographic’ traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values. - string |

