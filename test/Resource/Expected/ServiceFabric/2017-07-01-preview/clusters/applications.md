# Microsoft.ServiceFabric/clusters/applications template reference
API Version: 2017-07-01-preview
## Template format

To create a Microsoft.ServiceFabric/clusters/applications resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceFabric/clusters/applications",
  "apiVersion": "2017-07-01-preview",
  "location": "string",
  "properties": {
    "typeVersion": "string",
    "parameters": [
      {
        "Key": "string",
        "Value": "string"
      }
    ],
    "upgradePolicy": {
      "upgradeReplicaSetCheckTimeout": "integer",
      "forceRestart": "boolean",
      "rollingUpgradeMonitoringPolicy": {
        "healthCheckWaitDuration": "string",
        "healthCheckStableDuration": "string",
        "healthCheckRetryTimeout": "string",
        "upgradeTimeout": "string",
        "upgradeDomainTimeout": "string"
      },
      "applicationHealthPolicy": {
        "ConsiderWarningAsError": "boolean",
        "MaxPercentUnhealthyDeployedApplications": "integer",
        "DefaultServiceTypeHealthPolicy": {
          "MaxPercentUnhealthyPartitionsPerService": "integer",
          "MaxPercentUnhealthyReplicasPerPartition": "integer",
          "MaxPercentUnhealthyServices": "integer"
        },
        "ServiceTypeHealthPolicyMap": [
          {
            "Key": "string",
            "Value": {
              "MaxPercentUnhealthyPartitionsPerService": "integer",
              "MaxPercentUnhealthyReplicasPerPartition": "integer",
              "MaxPercentUnhealthyServices": "integer"
            }
          }
        ]
      }
    },
    "minimumNodes": "integer",
    "maximumNodes": "integer",
    "removeApplicationCapacity": "boolean",
    "metrics": [
      {
        "Name": "string",
        "MaximumCapacity": "integer",
        "ReservationCapacity": "integer",
        "TotalApplicationCapacity": "integer"
      }
    ],
    "typeName": "string"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceFabric/clusters/applications" />
### Microsoft.ServiceFabric/clusters/applications object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The name of the application resource. |
|  type | enum | Yes | Microsoft.ServiceFabric/clusters/applications |
|  apiVersion | enum | Yes | 2017-07-01-preview |
|  location | string | Yes | Resource location. |
|  properties | object | Yes | [ApplicationProperties object](#ApplicationProperties) |
|  resources | array | No | [services](./applications/services.md) |


<a id="ApplicationProperties" />
### ApplicationProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  typeVersion | string | No |  |
|  parameters | array | No | [ApplicationParameter object](#ApplicationParameter) |
|  upgradePolicy | object | No | [ApplicationUpgradePolicy object](#ApplicationUpgradePolicy) |
|  minimumNodes | integer | No | The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. |
|  maximumNodes | integer | No | The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. |
|  removeApplicationCapacity | boolean | No | The version of the application type |
|  metrics | array | No | [ApplicationMetricDescription object](#ApplicationMetricDescription) |
|  typeName | string | No |  |


<a id="ApplicationParameter" />
### ApplicationParameter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Key | string | Yes | The name of the parameter. |
|  Value | string | Yes | The value of the parameter. |


<a id="ApplicationUpgradePolicy" />
### ApplicationUpgradePolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  upgradeReplicaSetCheckTimeout | integer | No |  |
|  forceRestart | boolean | No |  |
|  rollingUpgradeMonitoringPolicy | object | No | [RollingUpgradeMonitoringPolicy object](#RollingUpgradeMonitoringPolicy) |
|  applicationHealthPolicy | object | No | [ApplicationHealthPolicy object](#ApplicationHealthPolicy) |


<a id="ApplicationMetricDescription" />
### ApplicationMetricDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Name | string | No | The name of the metric. |
|  MaximumCapacity | integer | No | The maximum node capacity for Service Fabric application.This is the maximum Load for an instance of this application on a single node. Even if the capacity of node is greater than this value, Service Fabric will limit the total load of services within the application on each node to this value.If set to zero, capacity for this metric is unlimited on each node.When creating a new application with application capacity defined, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.When updating existing application with application capacity, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity. |
|  ReservationCapacity | integer | No | The node reservation capacity for Service Fabric application.This is the amount of load which is reserved on nodes which have instances of this application.If MinimumNodes is specified, then the product of these values will be the capacity reserved in the cluster for the application.If set to zero, no capacity is reserved for this metric.When setting application capacity or when updating application capacity; this value must be smaller than or equal to MaximumCapacity for each metric. |
|  TotalApplicationCapacity | integer | No | The total metric capacity for Service Fabric application.This is the total metric capacity for this application in the cluster. Service Fabric will try to limit the sum of loads of services within the application to this value.When creating a new application with application capacity defined, the product of MaximumNodes and MaximumCapacity must always be smaller than or equal to this value. |


<a id="RollingUpgradeMonitoringPolicy" />
### RollingUpgradeMonitoringPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  healthCheckWaitDuration | string | No |  |
|  healthCheckStableDuration | string | No |  |
|  healthCheckRetryTimeout | string | No |  |
|  upgradeTimeout | string | No |  |
|  upgradeDomainTimeout | string | No |  |


<a id="ApplicationHealthPolicy" />
### ApplicationHealthPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ConsiderWarningAsError | boolean | No | Indicates whether warnings are treated with the same severity as errors. |
|  MaxPercentUnhealthyDeployedApplications | integer | No | The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero. |
|  DefaultServiceTypeHealthPolicy | object | No | [ServiceTypeHealthPolicy object](#ServiceTypeHealthPolicy) |
|  ServiceTypeHealthPolicyMap | array | No | [ServiceTypeHealthPolicyMapItem object](#ServiceTypeHealthPolicyMapItem) |


<a id="ServiceTypeHealthPolicy" />
### ServiceTypeHealthPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  MaxPercentUnhealthyPartitionsPerService | integer | No | The maximum allowed percentage of unhealthy partitions per service. Allowed values are Byte values from zero to 100The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered in error.If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the service.The computation rounds up to tolerate one failure on small numbers of partitions. Default percentage is zero. |
|  MaxPercentUnhealthyReplicasPerPartition | integer | No | The maximum allowed percentage of unhealthy replicas per partition. Allowed values are Byte values from zero to 100.The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered in error.If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.The computation rounds up to tolerate one failure on small numbers of replicas. Default percentage is zero. |
|  MaxPercentUnhealthyServices | integer | No | The maximum maximum allowed percentage of unhealthy services. Allowed values are Byte values from zero to 100.The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is considered in error.If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy services of the specific service type over the total number of services of the specific service type.The computation rounds up to tolerate one failure on small numbers of services. Default percentage is zero. |


<a id="ServiceTypeHealthPolicyMapItem" />
### ServiceTypeHealthPolicyMapItem object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Key | string | Yes | The key of the service type health policy map item. This is the name of the service type. |
|  Value | object | Yes | [ServiceTypeHealthPolicy object](#ServiceTypeHealthPolicy) |

