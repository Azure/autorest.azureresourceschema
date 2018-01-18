# Microsoft.CustomerInsights/hubs/relationships template reference
API Version: 2017-04-26
## Template format

To create a Microsoft.CustomerInsights/hubs/relationships resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/relationships",
  "apiVersion": "2017-04-26",
  "properties": {
    "cardinality": "string",
    "displayName": {},
    "description": {},
    "expiryDateTimeUtc": "string",
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
    "lookupMappings": [
      {
        "fieldMappings": [
          {
            "profileFieldName": "string",
            "relatedProfileKeyProperty": "string"
          }
        ]
      }
    ],
    "profileType": "string",
    "relatedProfileType": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/relationships" />
### Microsoft.CustomerInsights/hubs/relationships object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/relationships |
|  apiVersion | enum | Yes | 2017-04-26 |
|  properties | object | Yes | [RelationshipDefinition object](#RelationshipDefinition) |


<a id="RelationshipDefinition" />
### RelationshipDefinition object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  cardinality | enum | No | The Relationship Cardinality. - OneToOne, OneToMany, ManyToMany |
|  displayName | object | No | Localized display name for the Relationship. |
|  description | object | No | Localized descriptions for the Relationship. |
|  expiryDateTimeUtc | string | No | The expiry date time in UTC. |
|  fields | array | No | The properties of the Relationship. - [PropertyDefinition object](#PropertyDefinition) |
|  lookupMappings | array | No | Optional property to be used to map fields in profile to their strong ids in related profile. - [RelationshipTypeMapping object](#RelationshipTypeMapping) |
|  profileType | string | Yes | Profile type. |
|  relatedProfileType | string | Yes | Related profile being referenced. |


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


<a id="RelationshipTypeMapping" />
### RelationshipTypeMapping object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  fieldMappings | array | Yes | Maps a profile property with the StrongId of related profile. This is an array to support StrongIds that are composite key as well. - [RelationshipTypeFieldMapping object](#RelationshipTypeFieldMapping) |


<a id="ProfileEnumValidValuesFormat" />
### ProfileEnumValidValuesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  value | integer | No | The integer value of the enum member. |
|  localizedValueNames | object | No | Localized names of the enum member. |


<a id="RelationshipTypeFieldMapping" />
### RelationshipTypeFieldMapping object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  profileFieldName | string | Yes | Specifies the fieldName in profile. |
|  relatedProfileKeyProperty | string | Yes | Specifies the KeyProperty (from StrongId) of the related profile. |

