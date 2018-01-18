# Microsoft.ApiManagement/service/subscriptions template reference
API Version: 2017-03-01
## Template format

To create a Microsoft.ApiManagement/service/subscriptions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ApiManagement/service/subscriptions",
  "apiVersion": "2017-03-01",
  "properties": {
    "userId": "string",
    "productId": "string",
    "displayName": "string",
    "primaryKey": "string",
    "secondaryKey": "string",
    "state": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ApiManagement/service/subscriptions" />
### Microsoft.ApiManagement/service/subscriptions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | Subscription entity Identifier. The entity represents the association between a user and a product in API Management. |
|  type | enum | Yes | Microsoft.ApiManagement/service/subscriptions |
|  apiVersion | enum | Yes | 2017-03-01 |
|  properties | object | Yes | Subscription contract properties. - [SubscriptionCreateParameterProperties object](#SubscriptionCreateParameterProperties) |


<a id="SubscriptionCreateParameterProperties" />
### SubscriptionCreateParameterProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  userId | string | Yes | User (user id path) for whom subscription is being created in form /users/{uid} |
|  productId | string | Yes | Product (product id path) for which subscription is being created in form /products/{productid} |
|  displayName | string | Yes | Subscription name. |
|  primaryKey | string | No | Primary subscription key. If not specified during request key will be generated automatically. |
|  secondaryKey | string | No | Secondary subscription key. If not specified during request key will be generated automatically. |
|  state | enum | No | Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. - suspended, active, expired, submitted, rejected, cancelled |

