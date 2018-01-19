# Microsoft.ServiceFabric/clusters/applicationTypes/versions template reference
API Version: 2017-07-01-preview
## Template format

To create a Microsoft.ServiceFabric/clusters/applicationTypes/versions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceFabric/clusters/applicationTypes/versions",
  "apiVersion": "2017-07-01-preview",
  "location": "string",
  "properties": {
    "appPackageUrl": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceFabric/clusters/applicationTypes/versions" />
### Microsoft.ServiceFabric/clusters/applicationTypes/versions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The application type version. |
|  type | enum | Yes | Microsoft.ServiceFabric/clusters/applicationTypes/versions |
|  apiVersion | enum | Yes | 2017-07-01-preview |
|  location | string | Yes | Resource location. |
|  properties | object | Yes | [VersionProperties object](#VersionProperties) |


<a id="VersionProperties" />
### VersionProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  appPackageUrl | string | Yes | The URL to the application package |

