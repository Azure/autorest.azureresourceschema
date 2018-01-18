# Microsoft.Web/certificates template reference
API Version: 2016-03-01
## Template format

To create a Microsoft.Web/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/certificates",
  "apiVersion": "2016-03-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "hostNames": [
      "string"
    ],
    "pfxBlob": [
      "integer"
    ],
    "password": "string",
    "keyVaultId": "string",
    "keyVaultSecretName": "string",
    "serverFarmId": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/certificates" />
### Microsoft.Web/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/certificates |
|  apiVersion | enum | Yes | 2016-03-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Certificate resource specific properties - [Certificate_properties object](#Certificate_properties) |


<a id="Certificate_properties" />
### Certificate_properties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  hostNames | array | No | Host names the certificate applies to. - string |
|  pfxBlob | array | No | Pfx blob. - integer |
|  password | string | Yes | Certificate password. |
|  keyVaultId | string | No | Key Vault Csm resource Id. |
|  keyVaultSecretName | string | No | Key Vault secret name. |
|  serverFarmId | string | No | Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}". |

