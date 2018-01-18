# Microsoft.DataLakeStore/accounts/trustedIdProviders template reference
API Version: 2016-11-01
## Template format

To create a Microsoft.DataLakeStore/accounts/trustedIdProviders resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DataLakeStore/accounts/trustedIdProviders",
  "apiVersion": "2016-11-01",
  "properties": {
    "idProvider": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DataLakeStore/accounts/trustedIdProviders" />
### Microsoft.DataLakeStore/accounts/trustedIdProviders object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DataLakeStore/accounts/trustedIdProviders |
|  apiVersion | enum | Yes | 2016-11-01 |
|  properties | object | Yes | the properties of the trusted identity provider. - [TrustedIdProviderProperties object](#TrustedIdProviderProperties) |


<a id="TrustedIdProviderProperties" />
### TrustedIdProviderProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  idProvider | string | Yes | The URL of this trusted identity provider |

