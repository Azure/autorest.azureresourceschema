# Microsoft.ApiManagement/service/groups template reference
API Version: 2016-10-10
## Template format

To create a Microsoft.ApiManagement/service/groups resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/groups",
  "apiVersion": "2016-10-10",
  "description": "string",
  "externalId": "string",
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/groups" />
### Microsoft.ApiManagement/service/groups object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Group identifier. Must be unique in the current API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/groups |
|  apiVersion | enum | Yes | 2016-10-10 |
|  description | string | No | Group description. |
|  externalId | string | No | Identifier of the external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory aad://<tenant>.onmicrosoft.com/groups/<group object id>; otherwise the value is null. |
|  resources | array | No | [users](./groups/users.md) |

