# Microsoft.Logic/integrationAccounts/certificates template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.Logic/integrationAccounts/certificates resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/certificates",
  "apiVersion": "2016-06-01",
  "location": "string",
  "tags": {},
  "properties": {
    "metadata": {},
    "key": {
      "keyVault": {
        "id": "string"
      },
      "keyName": "string",
      "keyVersion": "string"
    },
    "publicCertificate": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts/certificates" />
### Microsoft.Logic/integrationAccounts/certificates object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts/certificates |
|  apiVersion | enum | Yes | 2016-06-01 |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account certificate properties. - [IntegrationAccountCertificateProperties object](#IntegrationAccountCertificateProperties) |


<a id="IntegrationAccountCertificateProperties" />
### IntegrationAccountCertificateProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  metadata | object | No | The metadata. |
|  key | object | No | The key details in the key vault. - [KeyVaultKeyReference object](#KeyVaultKeyReference) |
|  publicCertificate | string | No | The public certificate. |


<a id="KeyVaultKeyReference" />
### KeyVaultKeyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyVault | object | Yes | The key vault reference. - [KeyVaultKeyReferenceKeyVault object](#KeyVaultKeyReferenceKeyVault) |
|  keyName | string | Yes | The private key name in key vault. |
|  keyVersion | string | No | The private key version in key vault. |


<a id="KeyVaultKeyReferenceKeyVault" />
### KeyVaultKeyReferenceKeyVault object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | The resource id. |

