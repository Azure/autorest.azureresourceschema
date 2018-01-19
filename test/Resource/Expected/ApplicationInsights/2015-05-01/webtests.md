# microsoft.insights/webtests template reference
API Version: 2015-05-01
## Template format

To create a microsoft.insights/webtests resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "microsoft.insights/webtests",
  "apiVersion": "2015-05-01",
  "location": "string",
  "tags": {},
  "kind": "string",
  "properties": {
    "SyntheticMonitorId": "string",
    "Name": "string",
    "Description": "string",
    "Enabled": boolean,
    "Frequency": "integer",
    "Timeout": "integer",
    "Kind": "string",
    "RetryEnabled": boolean,
    "Locations": [
      {
        "Id": "string"
      }
    ],
    "Configuration": {
      "WebTest": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="microsoft.insights/webtests" />
### microsoft.insights/webtests object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the Application Insights webtest resource. |
|  type | enum | Yes | microsoft.insights/webtests |
|  apiVersion | enum | Yes | 2015-05-01 |
|  location | string | Yes | Resource location |
|  tags | object | No | Resource tags |
|  kind | enum | No | The kind of web test that this web test watches. Choices are ping and multistep. - ping or multistep |
|  properties | object | Yes | Metadata describing a web test for an Azure resource. - [WebTestProperties object](#WebTestProperties) |


<a id="WebTestProperties" />
### WebTestProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  SyntheticMonitorId | string | Yes | Unique ID of this WebTest. This is typically the same value as the Name field. |
|  Name | string | Yes | User defined name if this WebTest. |
|  Description | string | No | Purpose/user defined descriptive test for this WebTest. |
|  Enabled | boolean | No | Is the test actively being monitored. |
|  Frequency | integer | No | Interval in seconds between test runs for this WebTest. Default value is 300. |
|  Timeout | integer | No | Seconds until this WebTest will timeout and fail. Default value is 30. |
|  Kind | enum | Yes | The kind of web test this is, valid choices are ping and multistep. - ping or multistep |
|  RetryEnabled | boolean | No | Allow for retries should this WebTest fail. |
|  Locations | array | Yes | A list of where to physically run the tests from to give global coverage for accessibility of your application. - [WebTestGeolocation object](#WebTestGeolocation) |
|  Configuration | object | No | An XML configuration specification for a WebTest. - [WebTestPropertiesConfiguration object](#WebTestPropertiesConfiguration) |


<a id="WebTestGeolocation" />
### WebTestGeolocation object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Id | string | No | Location ID for the webtest to run from. |


<a id="WebTestPropertiesConfiguration" />
### WebTestPropertiesConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  WebTest | string | No | The XML specification of a WebTest to run against an application. |

