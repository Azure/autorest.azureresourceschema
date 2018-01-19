# microsoft.insights/autoscalesettings template reference
API Version: 2015-04-01
## Template format

To create a microsoft.insights/autoscalesettings resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/autoscalesettings",
  "apiVersion": "2015-04-01",
  "location": "string",
  "tags": {},
  "properties": {
    "profiles": [
      {
        "name": "string",
        "capacity": {
          "minimum": "string",
          "maximum": "string",
          "default": "string"
        },
        "rules": [
          {
            "metricTrigger": {
              "metricName": "string",
              "metricResourceUri": "string",
              "timeGrain": "string",
              "statistic": "string",
              "timeWindow": "string",
              "timeAggregation": "string",
              "operator": "string",
              "threshold": "number"
            },
            "scaleAction": {
              "direction": "string",
              "type": "string",
              "value": "string",
              "cooldown": "string"
            }
          }
        ],
        "fixedDate": {
          "timeZone": "string",
          "start": "string",
          "end": "string"
        },
        "recurrence": {
          "frequency": "string",
          "schedule": {
            "timeZone": "string",
            "days": [
              "string"
            ],
            "hours": [
              "integer"
            ],
            "minutes": [
              "integer"
            ]
          }
        }
      }
    ],
    "notifications": [
      {
        "operation": "Scale",
        "email": {
          "sendToSubscriptionAdministrator": boolean,
          "sendToSubscriptionCoAdministrators": boolean,
          "customEmails": [
            "string"
          ]
        },
        "webhooks": [
          {
            "serviceUri": "string",
            "properties": {}
          }
        ]
      }
    ],
    "enabled": boolean,
    "name": "string",
    "targetResourceUri": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/autoscalesettings" />
### microsoft.insights/autoscalesettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The autoscale setting name. |
|  type | enum | Yes | microsoft.insights/autoscalesettings |
|  apiVersion | enum | Yes | 2015-04-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  properties | object | Yes | The autoscale setting of the resource. - [AutoscaleSetting object](#AutoscaleSetting) |


<a id="AutoscaleSetting" />
### AutoscaleSetting object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  profiles | array | Yes | the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified. - [AutoscaleProfile object](#AutoscaleProfile) |
|  notifications | array | No | the collection of notifications. - [AutoscaleNotification object](#AutoscaleNotification) |
|  enabled | boolean | No | the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'. |
|  name | string | No | the name of the autoscale setting. |
|  targetResourceUri | string | No | the resource identifier of the resource that the autoscale setting should be added to. |


<a id="AutoscaleProfile" />
### AutoscaleProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | the name of the profile. |
|  capacity | object | Yes | the number of instances that can be used during this profile. - [ScaleCapacity object](#ScaleCapacity) |
|  rules | array | Yes | the collection of rules that provide the triggers and parameters for the scaling action. A maximum of 10 rules can be specified. - [ScaleRule object](#ScaleRule) |
|  fixedDate | object | No | the specific date-time for the profile. This element is not used if the Recurrence element is used. - [TimeWindow object](#TimeWindow) |
|  recurrence | object | No | the repeating times at which this profile begins. This element is not used if the FixedDate element is used. - [Recurrence object](#Recurrence) |


<a id="AutoscaleNotification" />
### AutoscaleNotification object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  operation | enum | Yes | the operation associated with the notification and its value must be "scale" - Scale |
|  email | object | No | the email notification. - [EmailNotification object](#EmailNotification) |
|  webhooks | array | No | the collection of webhook notifications. - [WebhookNotification object](#WebhookNotification) |


<a id="ScaleCapacity" />
### ScaleCapacity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  minimum | string | Yes | the minimum number of instances for the resource. |
|  maximum | string | Yes | the maximum number of instances for the resource. The actual maximum number of instances is limited by the cores that are available in the subscription. |
|  default | string | Yes | the number of instances that will be set if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. |


<a id="ScaleRule" />
### ScaleRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  metricTrigger | object | Yes | the trigger that results in a scaling action. - [MetricTrigger object](#MetricTrigger) |
|  scaleAction | object | Yes | the parameters for the scaling action. - [ScaleAction object](#ScaleAction) |


<a id="TimeWindow" />
### TimeWindow object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  timeZone | string | No | the timezone of the start and end times for the profile. Some examples of valid timezones are: Dateline Standard Time, UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard Time (Mexico), Pacific Standard Time, US Mountain Standard Time, Mountain Standard Time (Mexico), Mountain Standard Time, Central America Standard Time, Central Standard Time, Central Standard Time (Mexico), Canada Central Standard Time, SA Pacific Standard Time, Eastern Standard Time, US Eastern Standard Time, Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard Time, Central Brazilian Standard Time, SA Western Standard Time, Pacific SA Standard Time, Newfoundland Standard Time, E. South America Standard Time, Argentina Standard Time, SA Eastern Standard Time, Greenland Standard Time, Montevideo Standard Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time, Cape Verde Standard Time, Morocco Standard Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe Standard Time, Central Europe Standard Time, Romance Standard Time, Central European Standard Time, W. Central Africa Standard Time, Namibia Standard Time, Jordan Standard Time, GTB Standard Time, Middle East Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe Standard Time, South Africa Standard Time, FLE Standard Time, Turkey Standard Time, Israel Standard Time, Kaliningrad Standard Time, Libya Standard Time, Arabic Standard Time, Arab Standard Time, Belarus Standard Time, Russian Standard Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard Time, Azerbaijan Standard Time, Russia Time Zone 3, Mauritius Standard Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan Standard Time, West Asia Standard Time, Ekaterinburg Standard Time, Pakistan Standard Time, India Standard Time, Sri Lanka Standard Time, Nepal Standard Time, Central Asia Standard Time, Bangladesh Standard Time, N. Central Asia Standard Time, Myanmar Standard Time, SE Asia Standard Time, North Asia Standard Time, China Standard Time, North Asia East Standard Time, Singapore Standard Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS Central Standard Time, E. Australia Standard Time, AUS Eastern Standard Time, West Pacific Standard Time, Tasmania Standard Time, Magadan Standard Time, Vladivostok Standard Time, Russia Time Zone 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand Standard Time, UTC+12, Fiji Standard Time, Kamchatka Standard Time, Tonga Standard Time, Samoa Standard Time, Line Islands Standard Time |
|  start | string | Yes | the start time for the profile in ISO 8601 format. |
|  end | string | Yes | the end time for the profile in ISO 8601 format. |


<a id="Recurrence" />
### Recurrence object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frequency | enum | Yes | the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning each week will have the same set of profiles. - None, Second, Minute, Hour, Day, Week, Month, Year |
|  schedule | object | Yes | the scheduling constraints for when the profile begins. - [RecurrentSchedule object](#RecurrentSchedule) |


<a id="EmailNotification" />
### EmailNotification object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sendToSubscriptionAdministrator | boolean | No | a value indicating whether to send email to subscription administrator. |
|  sendToSubscriptionCoAdministrators | boolean | No | a value indicating whether to send email to subscription co-administrators. |
|  customEmails | array | No | the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored. - string |


<a id="WebhookNotification" />
### WebhookNotification object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceUri | string | No | the service address to receive the notification. |
|  properties | object | No | a property bag of settings. This value can be empty. |


<a id="MetricTrigger" />
### MetricTrigger object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  metricName | string | Yes | the name of the metric that defines what the rule monitors. |
|  metricResourceUri | string | Yes | the resource identifier of the resource the rule monitors. |
|  timeGrain | string | Yes | the granularity of metrics the rule monitors. Must be one of the predefined values returned from metric definitions for the metric. Must be between 12 hours and 1 minute. |
|  statistic | enum | Yes | the metric statistic type. How the metrics from multiple instances are combined. - Average, Min, Max, Sum |
|  timeWindow | string | Yes | the range of time in which instance data is collected. This value must be greater than the delay in metric collection, which can vary from resource-to-resource. Must be between 12 hours and 5 minutes. |
|  timeAggregation | enum | Yes | time aggregation type. How the data that is collected should be combined over time. The default value is Average. - Average, Minimum, Maximum, Total, Count |
|  operator | enum | Yes | the operator that is used to compare the metric data and the threshold. - Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual |
|  threshold | number | Yes | the threshold of the metric that triggers the scale action. |


<a id="ScaleAction" />
### ScaleAction object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  direction | enum | Yes | the scale direction. Whether the scaling action increases or decreases the number of instances. - None, Increase, Decrease |
|  type | enum | Yes | the type of action that should occur when the scale rule fires. - ChangeCount, PercentChangeCount, ExactCount |
|  value | string | No | the number of instances that are involved in the scaling action. This value must be 1 or greater. The default value is 1. |
|  cooldown | string | Yes | the amount of time to wait since the last scaling action before this action occurs. It must be between 1 week and 1 minute in ISO 8601 format. |


<a id="RecurrentSchedule" />
### RecurrentSchedule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  timeZone | string | Yes | the timezone for the hours of the profile. Some examples of valid timezones are: Dateline Standard Time, UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard Time (Mexico), Pacific Standard Time, US Mountain Standard Time, Mountain Standard Time (Mexico), Mountain Standard Time, Central America Standard Time, Central Standard Time, Central Standard Time (Mexico), Canada Central Standard Time, SA Pacific Standard Time, Eastern Standard Time, US Eastern Standard Time, Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard Time, Central Brazilian Standard Time, SA Western Standard Time, Pacific SA Standard Time, Newfoundland Standard Time, E. South America Standard Time, Argentina Standard Time, SA Eastern Standard Time, Greenland Standard Time, Montevideo Standard Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time, Cape Verde Standard Time, Morocco Standard Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe Standard Time, Central Europe Standard Time, Romance Standard Time, Central European Standard Time, W. Central Africa Standard Time, Namibia Standard Time, Jordan Standard Time, GTB Standard Time, Middle East Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe Standard Time, South Africa Standard Time, FLE Standard Time, Turkey Standard Time, Israel Standard Time, Kaliningrad Standard Time, Libya Standard Time, Arabic Standard Time, Arab Standard Time, Belarus Standard Time, Russian Standard Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard Time, Azerbaijan Standard Time, Russia Time Zone 3, Mauritius Standard Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan Standard Time, West Asia Standard Time, Ekaterinburg Standard Time, Pakistan Standard Time, India Standard Time, Sri Lanka Standard Time, Nepal Standard Time, Central Asia Standard Time, Bangladesh Standard Time, N. Central Asia Standard Time, Myanmar Standard Time, SE Asia Standard Time, North Asia Standard Time, China Standard Time, North Asia East Standard Time, Singapore Standard Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS Central Standard Time, E. Australia Standard Time, AUS Eastern Standard Time, West Pacific Standard Time, Tasmania Standard Time, Magadan Standard Time, Vladivostok Standard Time, Russia Time Zone 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand Standard Time, UTC+12, Fiji Standard Time, Kamchatka Standard Time, Tonga Standard Time, Samoa Standard Time, Line Islands Standard Time |
|  days | array | Yes | the collection of days that the profile takes effect on. Possible values are Sunday through Saturday. - string |
|  hours | array | Yes | A collection of hours that the profile takes effect on. Values supported are 0 to 23 on the 24-hour clock (AM/PM times are not supported). - integer |
|  minutes | array | Yes | A collection of minutes at which the profile takes effect at. - integer |

