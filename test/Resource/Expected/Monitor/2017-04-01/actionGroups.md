# microsoft.insights/actionGroups template reference
API Version: 2017-04-01
## Template format

To create a microsoft.insights/actionGroups resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/actionGroups",
  "apiVersion": "2017-04-01",
  "location": "string",
  "tags": {},
  "properties": {
    "groupShortName": "string",
    "enabled": boolean,
    "emailReceivers": [
      {
        "name": "string",
        "emailAddress": "string"
      }
    ],
    "smsReceivers": [
      {
        "name": "string",
        "countryCode": "string",
        "phoneNumber": "string"
      }
    ],
    "webhookReceivers": [
      {
        "name": "string",
        "serviceUri": "string"
      }
    ],
    "itsmReceivers": [
      {
        "name": "string",
        "workspaceId": "string",
        "connectionId": "string",
        "ticketConfiguration": "string",
        "region": "string"
      }
    ],
    "azureAppPushReceivers": [
      {
        "name": "string",
        "emailAddress": "string"
      }
    ],
    "automationRunbookReceivers": [
      {
        "automationAccountId": "string",
        "runbookName": "string",
        "webhookResourceId": "string",
        "isGlobalRunbook": boolean,
        "name": "string",
        "serviceUri": "string"
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/actionGroups" />
### microsoft.insights/actionGroups object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the action group. |
|  type | enum | Yes | microsoft.insights/actionGroups |
|  apiVersion | enum | Yes | 2017-04-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | The action groups properties of the resource. - [ActionGroup object](#ActionGroup) |


<a id="ActionGroup" />
### ActionGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  groupShortName | string | Yes | The short name of the action group. This will be used in SMS messages. |
|  enabled | boolean | Yes | Indicates whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. |
|  emailReceivers | array | No | The list of email receivers that are part of this action group. - [EmailReceiver object](#EmailReceiver) |
|  smsReceivers | array | No | The list of SMS receivers that are part of this action group. - [SmsReceiver object](#SmsReceiver) |
|  webhookReceivers | array | No | The list of webhook receivers that are part of this action group. - [WebhookReceiver object](#WebhookReceiver) |
|  itsmReceivers | array | No | The list of ITSM receivers that are part of this action group. - [ItsmReceiver object](#ItsmReceiver) |
|  azureAppPushReceivers | array | No | The list of AzureAppPush receivers that are part of this action group. - [AzureAppPushReceiver object](#AzureAppPushReceiver) |
|  automationRunbookReceivers | array | No | The list of AutomationRunbook receivers that are part of this action group. - [AutomationRunbookReceiver object](#AutomationRunbookReceiver) |


<a id="EmailReceiver" />
### EmailReceiver object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the email receiver. Names must be unique across all receivers within an action group. |
|  emailAddress | string | Yes | The email address of this receiver. |


<a id="SmsReceiver" />
### SmsReceiver object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the SMS receiver. Names must be unique across all receivers within an action group. |
|  countryCode | string | Yes | The country code of the SMS receiver. |
|  phoneNumber | string | Yes | The phone number of the SMS receiver. |


<a id="WebhookReceiver" />
### WebhookReceiver object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the webhook receiver. Names must be unique across all receivers within an action group. |
|  serviceUri | string | Yes | The URI where webhooks should be sent. |


<a id="ItsmReceiver" />
### ItsmReceiver object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the Itsm receiver. Names must be unique across all receivers within an action group. |
|  workspaceId | string | Yes | OMS LA instance identifier. |
|  connectionId | string | Yes | Unique identification of ITSM connection among multiple defined in above workspace. |
|  ticketConfiguration | string | Yes | JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well. |
|  region | string | Yes | Region in which workspace resides. Supported values:'centralindia','japaneast','southeastasia','australiasoutheast','uksouth','westcentralus','canadacentral','eastus','westeurope' |


<a id="AzureAppPushReceiver" />
### AzureAppPushReceiver object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group. |
|  emailAddress | string | Yes | The email address registered for the Azure mobile app. |


<a id="AutomationRunbookReceiver" />
### AutomationRunbookReceiver object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  automationAccountId | string | Yes | The Azure automation account Id which holds this runbook and authenticate to Azure resource. |
|  runbookName | string | Yes | The name for this runbook. |
|  webhookResourceId | string | Yes | The resource id for webhook linked to this runbook. |
|  isGlobalRunbook | boolean | Yes | Indicates whether this instance is global runbook. |
|  name | string | No | Indicates name of the webhook. |
|  serviceUri | string | No | The URI where webhooks should be sent. |

