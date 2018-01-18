# Microsoft.Devices/provisioningServices template reference
API Version: 2017-08-21-preview
## Template format

To create a Microsoft.Devices/provisioningServices resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Devices/provisioningServices",
  "apiVersion": "2017-08-21-preview",
  "location": "string",
  "tags": {},
  "etag": "string",
  "properties": {
    "state": "string",
    "provisioningState": "string",
    "iotHubs": [
      {
        "applyAllocationPolicy": boolean,
        "allocationWeight": "integer",
        "connectionString": "string",
        "location": "string"
      }
    ],
    "allocationPolicy": "string",
    "authorizationPolicies": [
      {
        "keyName": "string",
        "primaryKey": "string",
        "secondaryKey": "string",
        "rights": "string"
      }
    ]
  },
  "sku": {
    "name": "S1",
    "capacity": "integer"
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Devices/provisioningServices" />
### Microsoft.Devices/provisioningServices object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Devices/provisioningServices |
|  apiVersion | enum | Yes | 2017-08-21-preview |
|  location | string | Yes | The resource location. |
|  tags | object | No | The resource tags. |
|  etag | string | No | The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. |
|  properties | object | Yes | [IotDpsPropertiesDescription object](#IotDpsPropertiesDescription) |
|  sku | object | Yes | [IotDpsSkuInfo object](#IotDpsSkuInfo) |
|  resources | array | No | [certificates](./provisioningServices/certificates.md) |


<a id="IotDpsPropertiesDescription" />
### IotDpsPropertiesDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  state | enum | No | Current state of the provisioning service. - Activating, Active, Deleting, Deleted, ActivationFailed, DeletionFailed, Transitioning, Suspending, Suspended, Resuming, FailingOver, FailoverFailed |
|  provisioningState | string | No | The ARM provisioning state of the provisioning service. |
|  iotHubs | array | No | List of IoT hubs assosciated with this provisioning service. - [IotHubDefinitionDescription object](#IotHubDefinitionDescription) |
|  allocationPolicy | enum | No | Allocation policy to be used by this provisioning service. - Hashed, GeoLatency, Static |
|  authorizationPolicies | array | No | [SharedAccessSignatureAuthorizationRule_AccessRightsDescription_ object](#SharedAccessSignatureAuthorizationRule_AccessRightsDescription_) |


<a id="IotDpsSkuInfo" />
### IotDpsSkuInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | S1 |
|  capacity | integer | No | The number of services of the selected tier allowed in the subscription. |


<a id="IotHubDefinitionDescription" />
### IotHubDefinitionDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  applyAllocationPolicy | boolean | No |  |
|  allocationWeight | integer | No |  |
|  connectionString | string | Yes | Connection string og the IoT hub. |
|  location | string | Yes | ARM region of the IoT hub. |


<a id="SharedAccessSignatureAuthorizationRule_AccessRightsDescription_" />
### SharedAccessSignatureAuthorizationRule_AccessRightsDescription_ object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyName | string | Yes | Name of the key. |
|  primaryKey | string | No | Primary SAS key value. |
|  secondaryKey | string | No | Secondary SAS key value. |
|  rights | enum | Yes | Rights that this key has. - ServiceConfig, EnrollmentRead, EnrollmentWrite, DeviceConnect, RegistrationStatusRead, RegistrationStatusWrite |

