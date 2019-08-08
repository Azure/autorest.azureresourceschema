# Microsoft.CustomerInsights/hubs/links template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/links resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/links",
  "apiVersion": "2017-04-26",
  "properties": {
    "sourceEntityType": "string",
    "targetEntityType": "string",
    "sourceEntityTypeName": "string",
    "targetEntityTypeName": "string",
    "displayName": {},
    "description": {},
    "mappings": [
      {
        "sourcePropertyName": "string",
        "targetPropertyName": "string",
        "linkType": "string"
      }
    ],
    "participantPropertyReferences": [
      {
        "sourcePropertyName": "string",
        "targetPropertyName": "string"
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
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [LinkDefinition object](#LinkDefinition) |


<a id="LinkDefinition" />
### LinkDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourceEntityType | enum | Yes | Type of source entity. - None, Profile, Interaction, Relationship |
|  targetEntityType | enum | Yes | Type of target entity. - None, Profile, Interaction, Relationship |
|  sourceEntityTypeName | string | Yes | Name of the source Entity Type. |
|  targetEntityTypeName | string | Yes | Name of the target Entity Type. |
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
|  sourcePropertyName | string | Yes |  Property name on the source Entity Type. |
|  targetPropertyName | string | Yes | Property name on the target Entity Type. |
|  linkType | enum | No | Link type. - UpdateAlways or CopyIfNull |


<a id="ParticipantPropertyReference" />
### ParticipantPropertyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourcePropertyName | string | Yes | The source property that maps to the target property. |
|  targetPropertyName | string | Yes | The target property that maps to the source property. |

