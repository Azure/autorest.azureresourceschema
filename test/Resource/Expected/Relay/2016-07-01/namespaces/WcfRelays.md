# Microsoft.Relay/namespaces/WcfRelays template reference
API Version: 2016-07-01
## Template format

To create a Microsoft.Relay/namespaces/WcfRelays resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/WcfRelays",
  "apiVersion": "2016-07-01",
  "properties": {
    "relayType": "string",
    "requiresClientAuthorization": boolean,
    "requiresTransportSecurity": boolean,
    "userMetadata": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Relay/namespaces/WcfRelays" />
### Microsoft.Relay/namespaces/WcfRelays object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The relay name |
|  type | enum | Yes | Microsoft.Relay/namespaces/WcfRelays |
|  apiVersion | enum | Yes | 2016-07-01 |
|  properties | object | Yes | Properties of WcfRelay - [WcfRelayProperties object](#WcfRelayProperties) |
|  resources | array | No | [authorizationRules](./WcfRelays/authorizationRules.md) |


<a id="WcfRelayProperties" />
### WcfRelayProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  relayType | enum | No | WCFRelay Type. - NetTcp or Http |
|  requiresClientAuthorization | boolean | No | true if client authorization is needed for this relay; otherwise, false. |
|  requiresTransportSecurity | boolean | No | true if transport security is needed for this relay; otherwise, false. |
|  userMetadata | string | No | usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored. |

