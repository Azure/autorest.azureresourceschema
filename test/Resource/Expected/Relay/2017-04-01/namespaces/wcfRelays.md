# Microsoft.Relay/namespaces/wcfRelays template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.Relay/namespaces/wcfRelays resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/wcfRelays",
  "apiVersion": "2017-04-01",
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

<a id="Microsoft.Relay/namespaces/wcfRelays" />
### Microsoft.Relay/namespaces/wcfRelays object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The relay name. |
|  type | enum | Yes | Microsoft.Relay/namespaces/wcfRelays |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties of the WCF relay. - [WcfRelay_properties object](#WcfRelay_properties) |
|  resources | array | No | [authorizationRules](./wcfRelays/authorizationRules.md) |


<a id="WcfRelay_properties" />
### WcfRelay_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  relayType | enum | No | WCF relay type. - NetTcp or Http |
|  requiresClientAuthorization | boolean | No | Returns true if client authorization is needed for this relay; otherwise, false. |
|  requiresTransportSecurity | boolean | No | Returns true if transport security is needed for this relay; otherwise, false. |
|  userMetadata | string | No | The usermetadata is a placeholder to store user-defined string data for the WCF Relay endpoint. For example, it can be used to store descriptive data, such as list of teams and their contact information. Also, user-defined configuration settings can be stored. |

