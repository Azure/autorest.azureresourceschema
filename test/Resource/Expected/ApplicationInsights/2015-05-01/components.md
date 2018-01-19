# microsoft.insights/components template reference
API Version: 2015-05-01
## Template format

To create a microsoft.insights/components resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/components",
  "apiVersion": "2015-05-01",
  "location": "string",
  "tags": {},
  "kind": "string",
  "properties": {
    "Application_Type": "string",
    "Flow_Type": "Bluefield",
    "Request_Source": "rest",
    "HockeyAppId": "string",
    "SamplingPercentage": "number"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/components" />
### microsoft.insights/components object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the Application Insights component resource. |
|  type | enum | Yes | microsoft.insights/components |
|  apiVersion | enum | Yes | 2015-05-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  kind | string | Yes | The kind of application that this component refers to, used to customize UI. This value is a freeform string, values should typically be one of the following: web, ios, other, store, java, phone. |
|  properties | object | Yes | Properties that define an Application Insights component resource. - [ApplicationInsightsComponentProperties object](#ApplicationInsightsComponentProperties) |
|  resources | array | No | [exportconfiguration](./components/exportconfiguration.md) |


<a id="ApplicationInsightsComponentProperties" />
### ApplicationInsightsComponentProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Application_Type | enum | Yes | Type of application being monitored. - web or other |
|  Flow_Type | enum | No | Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set to 'Bluefield' when creating/updating a component via the REST API. - Bluefield |
|  Request_Source | enum | No | Describes what tool created this Application Insights component. Customers using this API should set this to the default 'rest'. - rest |
|  HockeyAppId | string | No | The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp. |
|  SamplingPercentage | number | No | Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry. |

