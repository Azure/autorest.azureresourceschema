# Microsoft.DomainRegistration/domains template reference
API Version: 2015-04-01
## Template format

To create a Microsoft.DomainRegistration/domains resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DomainRegistration/domains",
  "apiVersion": "2015-04-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "contactAdmin": {
      "addressMailing": {
        "address1": "string",
        "address2": "string",
        "city": "string",
        "country": "string",
        "postalCode": "string",
        "state": "string"
      },
      "email": "string",
      "fax": "string",
      "jobTitle": "string",
      "nameFirst": "string",
      "nameLast": "string",
      "nameMiddle": "string",
      "organization": "string",
      "phone": "string"
    },
    "contactBilling": {
      "addressMailing": {
        "address1": "string",
        "address2": "string",
        "city": "string",
        "country": "string",
        "postalCode": "string",
        "state": "string"
      },
      "email": "string",
      "fax": "string",
      "jobTitle": "string",
      "nameFirst": "string",
      "nameLast": "string",
      "nameMiddle": "string",
      "organization": "string",
      "phone": "string"
    },
    "contactRegistrant": {
      "addressMailing": {
        "address1": "string",
        "address2": "string",
        "city": "string",
        "country": "string",
        "postalCode": "string",
        "state": "string"
      },
      "email": "string",
      "fax": "string",
      "jobTitle": "string",
      "nameFirst": "string",
      "nameLast": "string",
      "nameMiddle": "string",
      "organization": "string",
      "phone": "string"
    },
    "contactTech": {
      "addressMailing": {
        "address1": "string",
        "address2": "string",
        "city": "string",
        "country": "string",
        "postalCode": "string",
        "state": "string"
      },
      "email": "string",
      "fax": "string",
      "jobTitle": "string",
      "nameFirst": "string",
      "nameLast": "string",
      "nameMiddle": "string",
      "organization": "string",
      "phone": "string"
    },
    "privacy": boolean,
    "autoRenew": boolean,
    "consent": {
      "agreementKeys": [
        "string"
      ],
      "agreedBy": "string",
      "agreedAt": "string"
    },
    "dnsType": "string",
    "dnsZoneId": "string",
    "targetDnsType": "string",
    "authCode": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DomainRegistration/domains" />
### Microsoft.DomainRegistration/domains object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DomainRegistration/domains |
|  apiVersion | enum | Yes | 2015-04-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Domain resource specific properties - [DomainProperties object](#DomainProperties) |
|  resources | array | No | [domainOwnershipIdentifiers](./domains/domainOwnershipIdentifiers.md) |


<a id="DomainProperties" />
### DomainProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  contactAdmin | object | Yes | Administrative contact. - [Contact object](#Contact) |
|  contactBilling | object | Yes | Billing contact. - [Contact object](#Contact) |
|  contactRegistrant | object | Yes | Registrant contact. - [Contact object](#Contact) |
|  contactTech | object | Yes | Technical contact. - [Contact object](#Contact) |
|  privacy | boolean | No | <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>. |
|  autoRenew | boolean | No | <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>. |
|  consent | object | Yes | Legal agreement consent. - [DomainPurchaseConsent object](#DomainPurchaseConsent) |
|  dnsType | enum | No | Current DNS type. - AzureDns or DefaultDomainRegistrarDns |
|  dnsZoneId | string | No | Azure DNS Zone to use |
|  targetDnsType | enum | No | Target DNS type (would be used for migration). - AzureDns or DefaultDomainRegistrarDns |
|  authCode | string | No |  |


<a id="Contact" />
### Contact object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressMailing | object | No | Mailing address. - [Address object](#Address) |
|  email | string | Yes | Email address. |
|  fax | string | No | Fax number. |
|  jobTitle | string | No | Job title. |
|  nameFirst | string | Yes | First name. |
|  nameLast | string | Yes | Last name. |
|  nameMiddle | string | No | Middle name. |
|  organization | string | No | Organization contact belongs to. |
|  phone | string | Yes | Phone number. |


<a id="DomainPurchaseConsent" />
### DomainPurchaseConsent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  agreementKeys | array | No | List of applicable legal agreement keys. This list can be retrieved using ListLegalAgreements API under <code>TopLevelDomain</code> resource. - string |
|  agreedBy | string | No | Client IP address. |
|  agreedAt | string | No | Timestamp when the agreements were accepted. |


<a id="Address" />
### Address object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  address1 | string | Yes | First line of an Address. |
|  address2 | string | No | The second line of the Address. Optional. |
|  city | string | Yes | The city for the address. |
|  country | string | Yes | The country for the address. |
|  postalCode | string | Yes | The postal code for the address. |
|  state | string | Yes | The state or province for the address. |

