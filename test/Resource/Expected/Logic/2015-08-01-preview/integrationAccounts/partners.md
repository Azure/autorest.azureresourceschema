# Microsoft.Logic/integrationAccounts/partners template reference
API Version: 2015-08-01-preview
## Template format

To create a Microsoft.Logic/integrationAccounts/partners resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/partners",
  "apiVersion": "2015-08-01-preview",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "partnerType": "string",
    "metadata": {},
    "content": {
      "b2b": {
        "businessIdentities": [
          {
            "Qualifier": "string",
            "Value": "string"
          }
        ]
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts/partners" />
### Microsoft.Logic/integrationAccounts/partners object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts/partners |
|  apiVersion | enum | Yes | 2015-08-01-preview |
|  id | string | No | The resource id. |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account partner properties. - [IntegrationAccountPartnerProperties object](#IntegrationAccountPartnerProperties) |


<a id="IntegrationAccountPartnerProperties" />
### IntegrationAccountPartnerProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  partnerType | enum | No | The partner type. - NotSpecified or B2B |
|  metadata | object | No | The metadata. |
|  content | object | No | The partner content. - [PartnerContent object](#PartnerContent) |


<a id="PartnerContent" />
### PartnerContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  b2b | object | No | The B2B partner content. - [B2BPartnerContent object](#B2BPartnerContent) |


<a id="B2BPartnerContent" />
### B2BPartnerContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  businessIdentities | array | No | The list of partner business identities. - [BusinessIdentity object](#BusinessIdentity) |


<a id="BusinessIdentity" />
### BusinessIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Qualifier | string | No | The business identity qualifier. |
|  Value | string | No | The business identity value. |

