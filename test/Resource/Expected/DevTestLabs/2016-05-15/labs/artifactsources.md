# Microsoft.DevTestLab/labs/artifactsources template reference
API Version: 2016-05-15
## Template format

To create a Microsoft.DevTestLab/labs/artifactsources resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.DevTestLab/labs/artifactsources",
  "apiVersion": "2016-05-15",
  "location": "string",
  "tags": {},
  "properties": {
    "displayName": "string",
    "uri": "string",
    "sourceType": "string",
    "folderPath": "string",
    "armTemplateFolderPath": "string",
    "branchRef": "string",
    "securityToken": "string",
    "status": "string",
    "provisioningState": "string",
    "uniqueIdentifier": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.DevTestLab/labs/artifactsources" />
### Microsoft.DevTestLab/labs/artifactsources object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.DevTestLab/labs/artifactsources |
|  apiVersion | enum | Yes | 2016-05-15 |
|  location | string | No | The location of the resource. |
|  tags | object | No | The tags of the resource. |
|  properties | object | Yes | The properties of the resource. - [ArtifactSourceProperties object](#ArtifactSourceProperties) |


<a id="ArtifactSourceProperties" />
### ArtifactSourceProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  displayName | string | No | The artifact source's display name. |
|  uri | string | No | The artifact source's URI. |
|  sourceType | enum | No | The artifact source's type. - VsoGit or GitHub |
|  folderPath | string | No | The folder containing artifacts. |
|  armTemplateFolderPath | string | No | The folder containing Azure Resource Manager templates. |
|  branchRef | string | No | The artifact source's branch reference. |
|  securityToken | string | No | The security token to authenticate to the artifact source. |
|  status | enum | No | Indicates if the artifact source is enabled (values: Enabled, Disabled). - Enabled or Disabled |
|  provisioningState | string | No | The provisioning status of the resource. |
|  uniqueIdentifier | string | No | The unique immutable identifier of a resource (Guid). |

