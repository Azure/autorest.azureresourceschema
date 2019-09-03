# Microsoft.Web/sites/slots/deployments template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/slots/deployments resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/slots/deployments",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "properties": {
    "id": "string",
    "status": "integer",
    "message": "string",
    "author": "string",
    "deployer": "string",
    "authorEmail": "string",
    "startTime": "string",
    "endTime": "string",
    "active": "boolean",
    "details": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/slots/deployments" />
### Microsoft.Web/sites/slots/deployments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/slots/deployments |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  properties | object | Yes | Deployment resource specific properties - [DeploymentProperties object](#DeploymentProperties) |


<a id="DeploymentProperties" />
### DeploymentProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Identifier for deployment. |
|  status | integer | No | Deployment status. |
|  message | string | No | Details about deployment status. |
|  author | string | No | Who authored the deployment. |
|  deployer | string | No | Who performed the deployment. |
|  authorEmail | string | No | Author email. |
|  startTime | string | No | Start time. |
|  endTime | string | No | End time. |
|  active | boolean | No | True if deployment is currently active, false if completed and null if not started. |
|  details | string | No | Details on deployment. |

