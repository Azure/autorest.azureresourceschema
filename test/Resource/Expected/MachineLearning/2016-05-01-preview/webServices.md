# Microsoft.MachineLearning/webServices template reference
API Version: 2016-05-01-preview
## Template format

To create a Microsoft.MachineLearning/webServices resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.MachineLearning/webServices",
  "apiVersion": "2016-05-01-preview",
  "location": "string",
  "tags": {},
  "properties": {
    "packageType": "string",
    "title": "string",
    "description": "string",
    "keys": {
      "primary": "string",
      "secondary": "string"
    },
    "readOnly": boolean,
    "exposeSampleData": boolean,
    "realtimeConfiguration": {
      "maxConcurrentCalls": "integer"
    },
    "diagnostics": {
      "level": "string",
      "expiry": "string"
    },
    "storageAccount": {
      "name": "string",
      "key": "string"
    },
    "machineLearningWorkspace": {
      "id": "string"
    },
    "commitmentPlan": {
      "id": "string"
    },
    "input": {
      "title": "string",
      "description": "string",
      "type": "string",
      "properties": {}
    },
    "output": {
      "title": "string",
      "description": "string",
      "type": "string",
      "properties": {}
    },
    "exampleRequest": {
      "inputs": {},
      "globalParameters": {}
    },
    "assets": {},
    "parameters": {}
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.MachineLearning/webServices" />
### Microsoft.MachineLearning/webServices object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the web service. |
|  type | enum | Yes | Microsoft.MachineLearning/webServices |
|  apiVersion | enum | Yes | 2016-05-01-preview |
|  location | string | Yes | Specifies the location of the resource. |
|  tags | object | No | Contains resource tags defined as key/value pairs. |
|  properties | object | Yes | Contains the property payload that describes the web service. - [WebServiceProperties object](#WebServiceProperties) |


<a id="WebServiceProperties" />
### WebServiceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  packageType | enum | No | WebServiceProperties or Graph |
|  title | string | No | The title of the web service. |
|  description | string | No | The description of the web service. |
|  keys | object | No | Contains the web service provisioning keys. If you do not specify provisioning keys, the Azure Machine Learning system generates them for you. Note: The keys are not returned from calls to GET operations. - [WebServiceKeys object](#WebServiceKeys) |
|  readOnly | boolean | No | When set to true, indicates that the web service is read-only and can no longer be updated or patched, only removed. Default, is false. Note: Once set to true, you cannot change its value. |
|  exposeSampleData | boolean | No | When set to true, sample data is included in the web service's swagger definition. The default value is true. |
|  realtimeConfiguration | object | No | Contains the configuration settings for the web service endpoint. - [RealtimeConfiguration object](#RealtimeConfiguration) |
|  diagnostics | object | No | Settings controlling the diagnostics traces collection for the web service. - [DiagnosticsConfiguration object](#DiagnosticsConfiguration) |
|  storageAccount | object | No | Specifies the storage account that Azure Machine Learning uses to store information about the web service. Only the name of the storage account is returned from calls to GET operations. When updating the storage account information, you must ensure that all necessary assets are available in the new storage account or calls to your web service will fail. - [StorageAccount object](#StorageAccount) |
|  machineLearningWorkspace | object | No | Specifies the Machine Learning workspace containing the experiment that is source for the web service. - [MachineLearningWorkspace object](#MachineLearningWorkspace) |
|  commitmentPlan | object | No | Contains the commitment plan associated with this web service. Set at creation time. Once set, this value cannot be changed. Note: The commitment plan is not returned from calls to GET operations. - [CommitmentPlan object](#CommitmentPlan) |
|  input | object | No | Contains the Swagger 2.0 schema describing one or more of the web service's inputs. For more information, see the Swagger specification. - [ServiceInputOutputSpecification object](#ServiceInputOutputSpecification) |
|  output | object | No | Contains the Swagger 2.0 schema describing one or more of the web service's outputs. For more information, see the Swagger specification. - [ServiceInputOutputSpecification object](#ServiceInputOutputSpecification) |
|  exampleRequest | object | No | Defines sample input data for one or more of the service's inputs. - [ExampleRequest object](#ExampleRequest) |
|  assets | object | No | Contains user defined properties describing web service assets. Properties are expressed as Key/Value pairs. |
|  parameters | object | No | The set of global parameters values defined for the web service, given as a global parameter name to default value map. If no default value is specified, the parameter is considered to be required. |


<a id="WebServiceKeys" />
### WebServiceKeys object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  primary | string | No | The primary access key. |
|  secondary | string | No | The secondary access key. |


<a id="RealtimeConfiguration" />
### RealtimeConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxConcurrentCalls | integer | No | Specifies the maximum concurrent calls that can be made to the web service. Minimum value: 4, Maximum value: 200. |


<a id="DiagnosticsConfiguration" />
### DiagnosticsConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  level | enum | Yes | Specifies the verbosity of the diagnostic output. Valid values are: None - disables tracing; Error - collects only error (stderr) traces; All - collects all traces (stdout and stderr). - None, Error, All |
|  expiry | string | No | Specifies the date and time when the logging will cease. If null, diagnostic collection is not time limited. |


<a id="StorageAccount" />
### StorageAccount object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Specifies the name of the storage account. |
|  key | string | No | Specifies the key used to access the storage account. |


<a id="MachineLearningWorkspace" />
### MachineLearningWorkspace object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes | Specifies the workspace ID of the machine learning workspace associated with the web service |


<a id="CommitmentPlan" />
### CommitmentPlan object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | Yes | Specifies the Azure Resource Manager ID of the commitment plan associated with the web service. |


<a id="ServiceInputOutputSpecification" />
### ServiceInputOutputSpecification object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  title | string | No | The title of your Swagger schema. |
|  description | string | No | The description of the Swagger schema. |
|  type | string | Yes | The type of the entity described in swagger. Always 'object'. |
|  properties | object | Yes | Specifies a collection that contains the column schema for each input or output of the web service. For more information, see the Swagger specification. |


<a id="ExampleRequest" />
### ExampleRequest object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  inputs | object | No | Sample input data for the web service's input(s) given as an input name to sample input values matrix map. |
|  globalParameters | object | No | Sample input data for the web service's global parameters |

