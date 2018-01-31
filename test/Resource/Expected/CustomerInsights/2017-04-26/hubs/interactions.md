# Microsoft.CustomerInsights/hubs/interactions template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/interactions resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/interactions",
  "apiVersion": "2017-04-26",
  "properties": {
    "attributes": {},
    "description": {},
    "displayName": {},
    "localizedAttributes": {},
    "smallImage": "string",
    "mediumImage": "string",
    "largeImage": "string",
    "apiEntitySetName": "string",
    "entityType": "string",
    "fields": [
      {
        "arrayValueSeparator": "string",
        "enumValidValues": [
          {
            "value": "integer",
            "localizedValueNames": {}
          }
        ],
        "fieldName": "string",
        "fieldType": "string",
        "isArray": boolean,
        "isEnum": boolean,
        "isFlagEnum": boolean,
        "isImage": boolean,
        "isLocalizedString": boolean,
        "isName": boolean,
        "isRequired": boolean,
        "propertyId": "string",
        "schemaItemPropLink": "string",
        "maxLength": "integer",
        "isAvailableInGraph": boolean
      }
    ],
    "instancesCount": "integer",
    "schemaItemTypeLink": "string",
    "timestampFieldName": "string",
    "typeName": "string",
    "idPropertyNames": [
      "string"
    ],
    "participantProfiles": [
      {
        "profileTypeName": "string",
        "participantPropertyReferences": [
          {
            "sourcePropertyName": "string",
            "targetPropertyName": "string"
          }
        ],
        "participantName": "string",
        "displayName": {},
        "description": {},
        "role": "string"
      }
    ],
    "primaryParticipantProfilePropertyName": "string",
    "defaultDataSource": {},
    "isActivity": boolean
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/interactions" />
### Microsoft.CustomerInsights/hubs/interactions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/interactions |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [InteractionTypeDefinition object](#InteractionTypeDefinition) |


<a id="InteractionTypeDefinition" />
### InteractionTypeDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  attributes | object | No | The attributes for the Type. |
|  description | object | No | Localized descriptions for the property. |
|  displayName | object | No | Localized display names for the property. |
|  localizedAttributes | object | No | Any custom localized attributes for the Type. |
|  smallImage | string | No | Small Image associated with the Property or EntityType. |
|  mediumImage | string | No | Medium Image associated with the Property or EntityType. |
|  largeImage | string | No | Large Image associated with the Property or EntityType. |
|  apiEntitySetName | string | No | The api entity set name. This becomes the odata entity set name for the entity Type being refered in this object. |
|  entityType | enum | No | Type of entity. - None, Profile, Interaction, Relationship |
|  fields | array | No | The properties of the Profile. - [PropertyDefinition object](#PropertyDefinition) |
|  instancesCount | integer | No | The instance count. |
|  schemaItemTypeLink | string | No | The schema org link. This helps ACI identify and suggest semantic models. |
|  timestampFieldName | string | No | The timestamp property name. Represents the time when the interaction or profile update happened. |
|  typeName | string | No | The name of the entity. |
|  idPropertyNames | array | No | The id property names. Properties which uniquely identify an interaction instance. - string |
|  participantProfiles | array | No | Profiles that participated in the interaction. - [Participant object](#Participant) |
|  primaryParticipantProfilePropertyName | string | No | The primary participant property name for an interaction ,This is used to logically represent the agent of the interaction, Specify the participant name here from ParticipantName. |
|  defaultDataSource | object | No | Default data source is specifically used in cases where data source is not specified in an instance. - [DataSource object](#DataSource) |
|  isActivity | boolean | No | An interaction can be tagged as an activity only during create. This enables the interaction to be editable and can enable merging of properties from multiple data sources based on precedence, which is defined at a link level. |


<a id="PropertyDefinition" />
### PropertyDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  arrayValueSeparator | string | No | Array value separator for properties with isArray set. |
|  enumValidValues | array | No | Describes valid values for an enum property. - [ProfileEnumValidValuesFormat object](#ProfileEnumValidValuesFormat) |
|  fieldName | string | Yes | Name of the property. |
|  fieldType | string | Yes | Type of the property. |
|  isArray | boolean | No | Indicates if the property is actually an array of the fieldType above on the data api. |
|  isEnum | boolean | No | Indicates if the property is an enum. |
|  isFlagEnum | boolean | No | Indicates if the property is an flag enum. |
|  isImage | boolean | No | Whether the property is an Image. |
|  isLocalizedString | boolean | No | Whether the property is a localized string. |
|  isName | boolean | No | Whether the property is a name or a part of name. |
|  isRequired | boolean | No | Whether property value is required on instances, IsRequired field only for Intercation. Profile Instance will not check for required field. |
|  propertyId | string | No | The ID associated with the property. |
|  schemaItemPropLink | string | No | URL encoded schema.org item prop link for the property. |
|  maxLength | integer | No | Max length of string. Used only if type is string. |
|  isAvailableInGraph | boolean | No | Whether property is available in graph or not. |


<a id="Participant" />
### Participant object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  profileTypeName | string | Yes | Profile type name. |
|  participantPropertyReferences | array | Yes | The property references. - [ParticipantPropertyReference object](#ParticipantPropertyReference) |
|  participantName | string | Yes | Participant name. |
|  displayName | object | No | Localized display name. |
|  description | object | No | Localized descriptions. |
|  role | string | No | The role that the participant is playing in the interaction. |


<a id="ProfileEnumValidValuesFormat" />
### ProfileEnumValidValuesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  value | integer | No | The integer value of the enum member. |
|  localizedValueNames | object | No | Localized names of the enum member. |


<a id="ParticipantPropertyReference" />
### ParticipantPropertyReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sourcePropertyName | string | Yes | The source property that maps to the target property. |
|  targetPropertyName | string | Yes | The target property that maps to the source property. |

