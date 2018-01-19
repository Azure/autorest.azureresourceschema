# Microsoft.DevTestLab/labs/users/environments template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/users/environments resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/users/environments",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "deploymentProperties": {
      "armTemplateId": "string",
      "parameters": [
        {
          "name": "string",
          "value": "string"
        }
      ]
    },
    "armTemplateDisplayName": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/users/environments" />
### Microsoft.DevTestLab/labs/users/environments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/users/environments |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [EnvironmentProperties object](#EnvironmentProperties) |


<a id="EnvironmentProperties" />
### EnvironmentProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  deploymentProperties | object | No | The deployment properties of the environment. - [EnvironmentDeploymentProperties object](#EnvironmentDeploymentProperties) |
|  armTemplateDisplayName | string | No | The display name of the Azure Resource Manager template that produced the environment. |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |


<a id="EnvironmentDeploymentProperties" />
### EnvironmentDeploymentProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  armTemplateId | string | No | The Azure Resource Manager template's identifier. |
|  parameters | array | No | The parameters of the Azure Resource Manager template. - [ArmTemplateParameterProperties object](#ArmTemplateParameterProperties) |


<a id="ArmTemplateParameterProperties" />
### ArmTemplateParameterProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | The name of the template parameter. |
|  value | string | No | The value of the template parameter. |

