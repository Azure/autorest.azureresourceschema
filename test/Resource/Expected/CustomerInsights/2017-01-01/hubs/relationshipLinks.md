# Microsoft.CustomerInsights/hubs/relationshipLinks template reference
API Version: 2017-01-01
## Template format

To create a Microsoft.CustomerInsights/hubs/relationshipLinks resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/relationshipLinks",
  "apiVersion": "2017-01-01",
  "properties": {
    "displayName": {},
    "description": {},
    "interactionType": "string",
    "mappings": [
      {
        "interactionFieldName": "string",
        "linkType": "string",
        "relationshipFieldName": "string"
      }
    ],
    "profilePropertyReferences": [
      {
        "interactionPropertyName": "string",
        "profilePropertyName": "string"
      }
    ],
    "relatedProfilePropertyReferences": [
      {
        "interactionPropertyName": "string",
        "profilePropertyName": "string"
      }
    ],
    "relationshipName": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/relationshipLinks" />
### Microsoft.CustomerInsights/hubs/relationshipLinks object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/relationshipLinks |
|  apiVersion | enum | Yes | 2017-01-01 |
|  properties | object | Yes | [RelationshipLinkDefinition object](#RelationshipLinkDefinition) |


<a id="RelationshipLinkDefinition" />
### RelationshipLinkDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  displayName | object | No | Localized display name for the Relationship Link. |
|  description | object | No | Localized descriptions for the Relationship Link. |
|  interactionType | string | Yes | The InteractionType associated with the Relationship Link. |
|  mappings | array | No | The mappings between Interaction and Relationship fields. - [RelationshipLinkFieldMapping object](#RelationshipLinkFieldMapping) |
|  profilePropertyReferences | array | Yes | The property references for the Profile of the Relationship. - [ParticipantPropertyReference object](#ParticipantPropertyReference) |
|  relatedProfilePropertyReferences | array | Yes | The property references for the Related Profile of the Relationship. - [ParticipantPropertyReference object](#ParticipantPropertyReference) |
|  relationshipName | string | Yes | The Relationship associated with the Link. |


<a id="RelationshipLinkFieldMapping" />
### RelationshipLinkFieldMapping object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  interactionFieldName | string | Yes | The field name on the Interaction Type. |
|  linkType | enum | No | Link type. - UpdateAlways or CopyIfNull |
|  relationshipFieldName | string | Yes | The field name on the Relationship metadata. |


<a id="ParticipantPropertyReference" />
### ParticipantPropertyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  interactionPropertyName | string | Yes | The interaction property that maps to the profile property. |
|  profilePropertyName | string | Yes | The profile property that maps to the interaction property. |

