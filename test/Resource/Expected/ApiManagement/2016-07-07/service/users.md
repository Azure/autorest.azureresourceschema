# Microsoft.ApiManagement/service/users template reference
API Version: 2016-07-07
## Template format

To create a Microsoft.ApiManagement/service/users resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/users",
  "apiVersion": "2016-07-07",
  "email": "string",
  "password": "string",
  "firstName": "string",
  "lastName": "string",
  "state": "string",
  "note": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/users" />
### Microsoft.ApiManagement/service/users object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | User identifier. Must be unique in the current API Management service instance. |
|  type | enum | Yes | Microsoft.ApiManagement/service/users |
|  apiVersion | enum | Yes | 2016-07-07 |
|  email | string | Yes | Email address. Must not be empty and must be unique within the service instance. |
|  password | string | Yes | User Password. |
|  firstName | string | Yes | First name. |
|  lastName | string | Yes | Last name. |
|  state | enum | No | Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. - Active or Blocked |
|  note | string | No | Optional note about a user set by the administrator. |

