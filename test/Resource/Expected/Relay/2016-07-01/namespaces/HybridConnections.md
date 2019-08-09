# Microsoft.Relay/namespaces/HybridConnections template reference
API Version: 2016-07-01
## Template format

To create a Microsoft.Relay/namespaces/HybridConnections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/HybridConnections",
  "apiVersion": "2016-07-01",
  "properties": {
    "requiresClientAuthorization": "boolean",
    "userMetadata": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Relay/namespaces/HybridConnections" />
### Microsoft.Relay/namespaces/HybridConnections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The hybrid connection name. |
|  type | enum | Yes | Microsoft.Relay/namespaces/HybridConnections |
|  apiVersion | enum | Yes | 2016-07-01 |
|  properties | object | Yes | Properties of HybridConnection - [HybridConnectionProperties object](#HybridConnectionProperties) |
|  resources | array | No | [authorizationRules](./HybridConnections/authorizationRules.md) |


<a id="HybridConnectionProperties" />
### HybridConnectionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  requiresClientAuthorization | boolean | No | true if client authorization is needed for this HybridConnection; otherwise, false. |
|  userMetadata | string | No | usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored. |

