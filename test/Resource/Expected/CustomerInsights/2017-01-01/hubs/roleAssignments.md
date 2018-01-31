# Microsoft.CustomerInsights/hubs/roleAssignments template reference
API Version: 2017-01-01
## Template format

To create a Microsoft.CustomerInsights/hubs/roleAssignments resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/roleAssignments",
  "apiVersion": "2017-01-01",
  "properties": {
    "displayName": {},
    "description": {},
    "role": "string",
    "principals": [
      {
        "principalId": "string",
        "principalType": "string",
        "principalMetadata": {}
      }
    ],
    "profiles": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "interactions": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "links": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "kpis": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "sasPolicies": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "connectors": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "views": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "relationshipLinks": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "relationships": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "widgetTypes": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "roleAssignments": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "conflationPolicies": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    },
    "segments": {
      "elements": [
        "string"
      ],
      "exceptions": [
        "string"
      ]
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/roleAssignments" />
### Microsoft.CustomerInsights/hubs/roleAssignments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/roleAssignments |
|  apiVersion | enum | Yes | 2017-01-01 |
|  properties | object | Yes | [RoleAssignment object](#RoleAssignment) |


<a id="RoleAssignment" />
### RoleAssignment object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  displayName | object | No | Localized display names for the metadata. |
|  description | object | No | Localized description for the metadata. |
|  role | enum | Yes | Type of roles. - Admin, Reader, ManageAdmin, ManageReader, DataAdmin, DataReader |
|  principals | array | Yes | The principals being assigned to. - [AssignmentPrincipal object](#AssignmentPrincipal) |
|  profiles | object | No | Profiles set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  interactions | object | No | Interactions set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  links | object | No | Links set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  kpis | object | No | Kpis set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  sasPolicies | object | No | Sas Policies set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  connectors | object | No | Connectors set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  views | object | No | Views set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  relationshipLinks | object | No | The Role assignments set for the relationship links. - [ResourceSetDescription object](#ResourceSetDescription) |
|  relationships | object | No | The Role assignments set for the relationships. - [ResourceSetDescription object](#ResourceSetDescription) |
|  widgetTypes | object | No | Widget types set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  roleAssignments | object | No | The Role assignments set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  conflationPolicies | object | No | Widget types set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |
|  segments | object | No | The Role assignments set for the assignment. - [ResourceSetDescription object](#ResourceSetDescription) |


<a id="AssignmentPrincipal" />
### AssignmentPrincipal object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  principalId | string | Yes | The principal id being assigned to. |
|  principalType | string | Yes | The Type of the principal ID. |
|  principalMetadata | object | No | Other metadata for the principal. |


<a id="ResourceSetDescription" />
### ResourceSetDescription object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  elements | array | No | The elements included in the set. - string |
|  exceptions | array | No | The elements that are not included in the set, in case elements contains '*' indicating 'all'. - string |

