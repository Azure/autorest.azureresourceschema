# Microsoft.Logic/integrationAccounts/partners template reference
API Version: 2016-06-01
## Template format

To create a Microsoft.Logic/integrationAccounts/partners resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/partners",
  "apiVersion": "2016-06-01",
  "location": "string",
  "tags": {},
  "properties": {
    "partnerType": "string",
    "metadata": {},
    "content": {
      "b2b": {
        "businessIdentities": [
          {
            "qualifier": "string",
            "value": "string"
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
|  apiVersion | enum | Yes | 2016-06-01 |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account partner properties. - [IntegrationAccountPartnerProperties object](#IntegrationAccountPartnerProperties) |


<a id="IntegrationAccountPartnerProperties" />
### IntegrationAccountPartnerProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  partnerType | enum | Yes | The partner type. - NotSpecified or B2B |
|  metadata | object | No | The metadata. |
|  content | object | Yes | The partner content. - [PartnerContent object](#PartnerContent) |


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
|  qualifier | string | Yes | The business identity qualifier e.g. as2identity, ZZ, ZZZ, 31, 32 |
|  value | string | Yes | The user defined business identity value. |

