# Microsoft.CustomerInsights/hubs/links template reference
API Version: 2017-01-01
## Template format

To create a Microsoft.CustomerInsights/hubs/links resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/links",
  "apiVersion": "2017-01-01",
  "properties": {
    "sourceInteractionType": "string",
    "targetProfileType": "string",
    "displayName": {},
    "description": {},
    "mappings": [
      {
        "interactionTypePropertyName": "string",
        "profileTypePropertyName": "string",
        "isProfileTypeId": "boolean",
        "linkType": "string"
      }
    ],
    "participantPropertyReferences": [
      {
        "interactionPropertyName": "string",
        "profilePropertyName": "string"
      }
    ],
    "referenceOnly": "boolean",
    "operationType": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/links" />
### Microsoft.CustomerInsights/hubs/links object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/links |
|  apiVersion | enum | Yes | 2017-01-01 |
|  properties | object | Yes | [LinkDefinition object](#LinkDefinition) |


<a id="LinkDefinition" />
### LinkDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceInteractionType | string | Yes | Name of the source Interaction Type. |
|  targetProfileType | string | Yes | Name of the target Profile Type. |
|  displayName | object | No | Localized display name for the Link. |
|  description | object | No | Localized descriptions for the Link. |
|  mappings | array | No | The set of properties mappings between the source and target Types. - [TypePropertiesMapping object](#TypePropertiesMapping) |
|  participantPropertyReferences | array | Yes | The properties that represent the participating profile. - [ParticipantPropertyReference object](#ParticipantPropertyReference) |
|  referenceOnly | boolean | No | Indicating whether the link is reference only link. This flag is ingored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles. |
|  operationType | enum | No | Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only. - Upsert or Delete |


<a id="TypePropertiesMapping" />
### TypePropertiesMapping object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  interactionTypePropertyName | string | Yes |  Property name on the source Interaction Type. |
|  profileTypePropertyName | string | Yes | Property name on the target Profile Type. |
|  isProfileTypeId | boolean | No | Flag to indicate whether the Profile Type property is an id on the Profile Type. |
|  linkType | enum | No | Link type. - UpdateAlways or CopyIfNull |


<a id="ParticipantPropertyReference" />
### ParticipantPropertyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  interactionPropertyName | string | Yes | The interaction property that maps to the profile property. |
|  profilePropertyName | string | Yes | The profile property that maps to the interaction property. |

