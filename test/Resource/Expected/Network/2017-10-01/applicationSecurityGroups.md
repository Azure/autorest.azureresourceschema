# Microsoft.Network/applicationSecurityGroups template reference
API Version: 2017-10-01
## Template format

To create a Microsoft.Network/applicationSecurityGroups resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/applicationSecurityGroups",
  "apiVersion": "2017-10-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {}
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/applicationSecurityGroups" />
### Microsoft.Network/applicationSecurityGroups object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/applicationSecurityGroups |
|  apiVersion | enum | Yes | 2017-10-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Properties of the application security group. - [ApplicationSecurityGroupPropertiesFormat object](#ApplicationSecurityGroupPropertiesFormat) |

