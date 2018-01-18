# Microsoft.CustomerInsights/hubs/profiles template reference
API Version: 2017-01-01
## Template format

To create a Microsoft.CustomerInsights/hubs/profiles resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.CustomerInsights/hubs/profiles",
  "apiVersion": "2017-01-01",
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
    "strongIds": [
      {
        "keyPropertyNames": [
          "string"
        ],
        "strongIdName": "string",
        "displayName": {},
        "description": {}
      }
    ]
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.CustomerInsights/hubs/profiles" />
### Microsoft.CustomerInsights/hubs/profiles object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.CustomerInsights/hubs/profiles |
|  apiVersion | enum | Yes | 2017-01-01 |
|  properties | object | Yes | [ProfileTypeDefinition object](#ProfileTypeDefinition) |


<a id="ProfileTypeDefinition" />
### ProfileTypeDefinition object
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
|  strongIds | array | No | The strong IDs. - [StrongId object](#StrongId) |


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


<a id="StrongId" />
### StrongId object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  keyPropertyNames | array | Yes | The properties which make up the unique ID. - string |
|  strongIdName | string | Yes | The Name identifying the strong ID. |
|  displayName | object | No | Localized display name. |
|  description | object | No | Localized descriptions. |


<a id="ProfileEnumValidValuesFormat" />
### ProfileEnumValidValuesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  value | integer | No | The integer value of the enum member. |
|  localizedValueNames | object | No | Localized names of the enum member. |

