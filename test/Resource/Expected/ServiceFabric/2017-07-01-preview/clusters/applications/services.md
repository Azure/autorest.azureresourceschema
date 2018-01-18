# Microsoft.ServiceFabric/clusters/applications/services template reference
API Version: 2017-07-01-preview
## Template format

To create a Microsoft.ServiceFabric/clusters/applications/services resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceFabric/clusters/applications/services",
  "apiVersion": "2017-07-01-preview",
  "location": "string",
  "properties": {
    "serviceKind": "string",
    "placementConstraints": "string",
    "correlationScheme": [
      {
        "Scheme": "string",
        "ServiceName": "string"
      }
    ],
    "serviceLoadMetrics": [
      {
        "Name": "string",
        "Weight": "string",
        "PrimaryDefaultLoad": "integer",
        "SecondaryDefaultLoad": "integer",
        "DefaultLoad": "integer"
      }
    ],
    "servicePlacementPolicies": [
      {}
    ],
    "defaultMoveCost": "string",
    "serviceTypeName": "string",
    "partitionDescription": {
      "PartitionScheme": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceFabric/clusters/applications/services" />
### Microsoft.ServiceFabric/clusters/applications/services object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the service resource in the format of {applicationName}~{serviceName}. |
|  type | enum | Yes | Microsoft.ServiceFabric/clusters/applications/services |
|  apiVersion | enum | Yes | 2017-07-01-preview |
|  location | string | Yes | Resource location. |
|  properties | object | Yes | [ServiceProperties object](#ServiceProperties) |


<a id="ServiceProperties" />
### ServiceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceKind | enum | No | ServiceProperties, Stateless, Stateful |
|  placementConstraints | string | No | The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: "NodeColor == blue)". |
|  correlationScheme | array | No | [ServiceCorrelationDescription object](#ServiceCorrelationDescription) |
|  serviceLoadMetrics | array | No | [ServiceLoadMetricDescription object](#ServiceLoadMetricDescription) |
|  servicePlacementPolicies | array | No | [ServicePlacementPolicyDescription object](#ServicePlacementPolicyDescription) |
|  defaultMoveCost | enum | No | Zero, Low, Medium, High |
|  serviceTypeName | string | No | The name of the service type |
|  partitionDescription | object | No | [PartitionSchemeDescription object](#PartitionSchemeDescription) |


<a id="ServiceCorrelationDescription" />
### ServiceCorrelationDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Scheme | enum | Yes | Invalid, Affinity, AlignedAffinity, NonAlignedAffinity |
|  ServiceName | string | Yes |  |


<a id="ServiceLoadMetricDescription" />
### ServiceLoadMetricDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Name | string | Yes | The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name that is specified in Name exactly. Note that metric names are case sensitive. |
|  Weight | enum | No | Zero, Low, Medium, High |
|  PrimaryDefaultLoad | integer | No | Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Primary replica. |
|  SecondaryDefaultLoad | integer | No | Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Secondary replica. |
|  DefaultLoad | integer | No | Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric. |


<a id="ServicePlacementPolicyDescription" />
### ServicePlacementPolicyDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |


<a id="PartitionSchemeDescription" />
### PartitionSchemeDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  PartitionScheme | enum | No | PartitionSchemeDescription, Named, Singleton, UniformInt64Range |

