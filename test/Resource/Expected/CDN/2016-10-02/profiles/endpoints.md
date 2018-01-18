# Microsoft.Cdn/profiles/endpoints template reference
API Version: 2016-10-02
## Template format

To create a Microsoft.Cdn/profiles/endpoints resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Cdn/profiles/endpoints",
  "apiVersion": "2016-10-02",
  "location": "string",
  "tags": {},
  "properties": {
    "originHostHeader": "string",
    "originPath": "string",
    "contentTypesToCompress": [
      "string"
    ],
    "isCompressionEnabled": boolean,
    "isHttpAllowed": boolean,
    "isHttpsAllowed": boolean,
    "queryStringCachingBehavior": "string",
    "optimizationType": "string",
    "geoFilters": [
      {
        "relativePath": "string",
        "action": "string",
        "countryCodes": [
          "string"
        ]
      }
    ],
    "origins": [
      {
        "name": "string",
        "properties": {
          "hostName": "string",
          "httpPort": "integer",
          "httpsPort": "integer"
        }
      }
    ]
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Cdn/profiles/endpoints" />
### Microsoft.Cdn/profiles/endpoints object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Cdn/profiles/endpoints |
|  apiVersion | enum | Yes | 2016-10-02 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [EndpointProperties object](#EndpointProperties) |
|  resources | array | No | [customDomains](./endpoints/customDomains.md) |


<a id="EndpointProperties" />
### EndpointProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  originHostHeader | string | No | The host header CDN sends along with content requests to origin. The default value is the host name of the origin. |
|  originPath | string | No | The path used when CDN sends request to origin. |
|  contentTypesToCompress | array | No | List of content types on which compression applies. The value should be a valid MIME type. - string |
|  isCompressionEnabled | boolean | No | Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB. |
|  isHttpAllowed | boolean | No | Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. |
|  isHttpsAllowed | boolean | No | Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. |
|  queryStringCachingBehavior | enum | No | Defines the query string caching behavior. - IgnoreQueryString, BypassCaching, UseQueryString, NotSet |
|  optimizationType | enum | No | Customer can specify what scenario they want this CDN endpoint to optimize, e.g. Download, Media services. With this information we can apply scenario driven optimization. - GeneralWebDelivery, GeneralMediaStreaming, VideoOnDemandMediaStreaming, LargeFileDownload, DynamicSiteAcceleration |
|  geoFilters | array | No | List of rules defining user geo access within a CDN endpoint. Each geo filter defines an acess rule to a specified path or content, e.g. block APAC for path /pictures/ - [GeoFilter object](#GeoFilter) |
|  origins | array | Yes | The source of the content being delivered via CDN. - [DeepCreatedOrigin object](#DeepCreatedOrigin) |


<a id="GeoFilter" />
### GeoFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  relativePath | string | Yes | Relative path applicable to geo filter. (e.g. '/mypictures', '/mypicture/kitty.jpg', and etc.) |
|  action | enum | Yes | Action of the geo filter, i.e. allow or block access. - Block or Allow |
|  countryCodes | array | Yes | Two letter country codes defining user country access in a geo filter, e.g. AU, MX, US. - string |


<a id="DeepCreatedOrigin" />
### DeepCreatedOrigin object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Origin name |
|  properties | object | No | [DeepCreatedOriginProperties object](#DeepCreatedOriginProperties) |


<a id="DeepCreatedOriginProperties" />
### DeepCreatedOriginProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  hostName | string | Yes | The address of the origin. It can be a domain names, IPv4 address, or IPv6 address. |
|  httpPort | integer | No | The value of the HTTP port. Must be between 1 and 65535 |
|  httpsPort | integer | No | The value of the HTTPS port. Must be between 1 and 65535 |

