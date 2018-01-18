# Microsoft.Relay/namespaces/hybridConnections template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.Relay/namespaces/hybridConnections resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Relay/namespaces/hybridConnections",
  "apiVersion": "2017-04-01",
  "properties": {
    "requiresClientAuthorization": boolean,
    "userMetadata": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Relay/namespaces/hybridConnections" />
### Microsoft.Relay/namespaces/hybridConnections object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The hybrid connection name. |
|  type | enum | Yes | Microsoft.Relay/namespaces/hybridConnections |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties of the HybridConnection. - [HybridConnection_properties object](#HybridConnection_properties) |
|  resources | array | No | [authorizationRules](./hybridConnections/authorizationRules.md) |


<a id="HybridConnection_properties" />
### HybridConnection_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  requiresClientAuthorization | boolean | No | Returns true if client authorization is needed for this hybrid connection; otherwise, false. |
|  userMetadata | string | No | The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored. |

