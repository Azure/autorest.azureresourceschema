# Microsoft.Web/sites/domainOwnershipIdentifiers template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/domainOwnershipIdentifiers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/domainOwnershipIdentifiers",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "id": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/domainOwnershipIdentifiers" />
### Microsoft.Web/sites/domainOwnershipIdentifiers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/domainOwnershipIdentifiers |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | Identifier resource specific properties - [IdentifierProperties object](#IdentifierProperties) |


<a id="IdentifierProperties" />
### IdentifierProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | String representation of the identity. |

