# Microsoft.ApiManagement/service/properties template reference
API Version: 2016-10-10
## Template format

To create a Microsoft.ApiManagement/service/properties resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/properties",
  "apiVersion": "2016-10-10",
  "value": "string",
  "tags": [
    "string"
  ],
  "secret": "boolean"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/properties" />
### Microsoft.ApiManagement/service/properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Identifier of the property. |
|  type | enum | Yes | Microsoft.ApiManagement/service/properties |
|  apiVersion | enum | Yes | 2016-10-10 |
|  value | string | Yes | Value of the property. Can contain policy expressions. It may not be empty or consist only of whitespace. |
|  tags | array | No | Optional tags that when provided can be used to filter the property list. - string |
|  secret | boolean | No | Determines whether the value is a secret and should be encrypted or not. Default value is false. |

