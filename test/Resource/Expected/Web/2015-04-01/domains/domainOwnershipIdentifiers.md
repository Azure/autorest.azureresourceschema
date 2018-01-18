# Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers template reference
API Version: 2015-04-01
## Template format

To create a Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers",
  "apiVersion": "2015-04-01",
  "kind": "string",
  "properties": {
    "ownershipId": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers" />
### Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers |
|  apiVersion | enum | Yes | 2015-04-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | DomainOwnershipIdentifier resource specific properties - [DomainOwnershipIdentifier_properties object](#DomainOwnershipIdentifier_properties) |


<a id="DomainOwnershipIdentifier_properties" />
### DomainOwnershipIdentifier_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ownershipId | string | No | Ownership Id. |

