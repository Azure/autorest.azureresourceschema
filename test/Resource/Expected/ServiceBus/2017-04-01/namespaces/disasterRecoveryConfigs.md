# Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs template reference
API Version: 2017-04-01
## Template format

To create a Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs",
  "apiVersion": "2017-04-01",
  "properties": {
    "partnerNamespace": "string",
    "alternateName": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs" />
### Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes | The Disaster Recovery configuration name |
|  type | enum | Yes | Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs |
|  apiVersion | enum | Yes | 2017-04-01 |
|  properties | object | Yes | Properties required to the Create Or Update Alias(Disaster Recovery configurations) - [ArmDisasterRecoveryProperties object](#ArmDisasterRecoveryProperties) |


<a id="ArmDisasterRecoveryProperties" />
### ArmDisasterRecoveryProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  partnerNamespace | string | No | ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairning |
|  alternateName | string | No | Primary/Secondary eventhub namespace name, which is part of GEO DR pairning |

