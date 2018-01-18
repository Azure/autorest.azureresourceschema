# Microsoft.Resources/deployments template reference
API Version: 2016-09-01
## Template format

To create a Microsoft.Resources/deployments resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Resources/deployments",
  "apiVersion": "2016-09-01",
  "properties": {
    "template": {},
    "templateLink": {
      "uri": "string",
      "contentVersion": "string"
    },
    "parameters": {},
    "parametersLink": {
      "uri": "string",
      "contentVersion": "string"
    },
    "mode": "string",
    "debugSetting": {
      "detailLevel": "string"
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Resources/deployments" />
### Microsoft.Resources/deployments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Resources/deployments |
|  apiVersion | enum | Yes | 2016-09-01 |
|  properties | object | Yes | The deployment properties. - [DeploymentProperties object](#DeploymentProperties) |


<a id="DeploymentProperties" />
### DeploymentProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  template | object | No | The template content. You use this element when you want to pass the template syntax directly in the request rather than link to an existing template. It can be a JObject or well-formed JSON string. Use either the templateLink property or the template property, but not both. |
|  templateLink | object | No | The URI of the template. Use either the templateLink property or the template property, but not both. - [TemplateLink object](#TemplateLink) |
|  parameters | object | No | Name and value pairs that define the deployment parameters for the template. You use this element when you want to provide the parameter values directly in the request rather than link to an existing parameter file. Use either the parametersLink property or the parameters property, but not both. It can be a JObject or a well formed JSON string. |
|  parametersLink | object | No | The URI of parameters file. You use this element to link to an existing parameters file. Use either the parametersLink property or the parameters property, but not both. - [ParametersLink object](#ParametersLink) |
|  mode | enum | Yes | The mode that is used to deploy resources. This value can be either Incremental or Complete. In Incremental mode, resources are deployed without deleting existing resources that are not included in the template. In Complete mode, resources are deployed and existing resources in the resource group that are not included in the template are deleted. Be careful when using Complete mode as you may unintentionally delete resources. - Incremental or Complete |
|  debugSetting | object | No | The debug setting of the deployment. - [DebugSetting object](#DebugSetting) |


<a id="TemplateLink" />
### TemplateLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uri | string | Yes | The URI of the template to deploy. |
|  contentVersion | string | No | If included, must match the ContentVersion in the template. |


<a id="ParametersLink" />
### ParametersLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  uri | string | Yes | The URI of the parameters file. |
|  contentVersion | string | No | If included, must match the ContentVersion in the template. |


<a id="DebugSetting" />
### DebugSetting object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  detailLevel | string | No | Specifies the type of information to log for debugging. The permitted values are none, requestContent, responseContent, or both requestContent and responseContent separated by a comma. The default is none. When setting this value, carefully consider the type of information you are passing in during deployment. By logging information about the request or response, you could potentially expose sensitive data that is retrieved through the deployment operations. |

