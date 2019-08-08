# Microsoft.Logic/integrationAccounts/agreements template reference
API Version: 2015-08-01-preview
## Template format

To create a Microsoft.Logic/integrationAccounts/agreements resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Logic/integrationAccounts/agreements",
  "apiVersion": "2015-08-01-preview",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "metadata": {},
    "agreementType": "string",
    "hostPartner": "string",
    "guestPartner": "string",
    "hostIdentity": {
      "Qualifier": "string",
      "Value": "string"
    },
    "guestIdentity": {
      "Qualifier": "string",
      "Value": "string"
    },
    "content": {
      "AS2": {
        "receiveAgreement": {
          "senderBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "receiverBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "protocolSettings": {
            "messageConnectionSettings": {
              "ignoreCertificateNameMismatch": "boolean",
              "supportHttpStatusCodeContinue": "boolean",
              "keepHttpConnectionAlive": "boolean",
              "unfoldHttpHeaders": "boolean"
            },
            "acknowledgementConnectionSettings": {
              "ignoreCertificateNameMismatch": "boolean",
              "supportHttpStatusCodeContinue": "boolean",
              "keepHttpConnectionAlive": "boolean",
              "unfoldHttpHeaders": "boolean"
            },
            "mdnSettings": {
              "needMdn": "boolean",
              "signMdn": "boolean",
              "sendMdnAsynchronously": "boolean",
              "receiptDeliveryUrl": "string",
              "dispositionNotificationTo": "string",
              "signOutboundMdnIfOptional": "boolean",
              "mdnText": "string",
              "sendInboundMdnToMessageBox": "boolean",
              "micHashingAlgorithm": "string"
            },
            "securitySettings": {
              "overrideGroupSigningCertificate": "boolean",
              "signingCertificateName": "string",
              "encryptionCertificateName": "string",
              "enableNrrForInboundEncodedMessages": "boolean",
              "enableNrrForInboundDecodedMessages": "boolean",
              "enableNrrForOutboundMdn": "boolean",
              "enableNrrForOutboundEncodedMessages": "boolean",
              "enableNrrForOutboundDecodedMessages": "boolean",
              "enableNrrForInboundMdn": "boolean"
            },
            "validationSettings": {
              "overrideMessageProperties": "boolean",
              "encryptMessage": "boolean",
              "signMessage": "boolean",
              "compressMessage": "boolean",
              "checkDuplicateMessage": "boolean",
              "interchangeDuplicatesValidityDays": "integer",
              "checkCertificateRevocationListOnSend": "boolean",
              "checkCertificateRevocationListOnReceive": "boolean",
              "encryptionAlgorithm": "string"
            },
            "envelopeSettings": {
              "messageContentType": "string",
              "transmitFileNameInMimeHeader": "boolean",
              "fileNameTemplate": "string",
              "SuspendMessageOnFileNameGenerationError": "boolean",
              "AutogenerateFileName": "boolean"
            },
            "errorSettings": {
              "SuspendDuplicateMessage": "boolean",
              "ResendIfMdnNotReceived": "boolean"
            }
          }
        },
        "sendAgreement": {
          "senderBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "receiverBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "protocolSettings": {
            "messageConnectionSettings": {
              "ignoreCertificateNameMismatch": "boolean",
              "supportHttpStatusCodeContinue": "boolean",
              "keepHttpConnectionAlive": "boolean",
              "unfoldHttpHeaders": "boolean"
            },
            "acknowledgementConnectionSettings": {
              "ignoreCertificateNameMismatch": "boolean",
              "supportHttpStatusCodeContinue": "boolean",
              "keepHttpConnectionAlive": "boolean",
              "unfoldHttpHeaders": "boolean"
            },
            "mdnSettings": {
              "needMdn": "boolean",
              "signMdn": "boolean",
              "sendMdnAsynchronously": "boolean",
              "receiptDeliveryUrl": "string",
              "dispositionNotificationTo": "string",
              "signOutboundMdnIfOptional": "boolean",
              "mdnText": "string",
              "sendInboundMdnToMessageBox": "boolean",
              "micHashingAlgorithm": "string"
            },
            "securitySettings": {
              "overrideGroupSigningCertificate": "boolean",
              "signingCertificateName": "string",
              "encryptionCertificateName": "string",
              "enableNrrForInboundEncodedMessages": "boolean",
              "enableNrrForInboundDecodedMessages": "boolean",
              "enableNrrForOutboundMdn": "boolean",
              "enableNrrForOutboundEncodedMessages": "boolean",
              "enableNrrForOutboundDecodedMessages": "boolean",
              "enableNrrForInboundMdn": "boolean"
            },
            "validationSettings": {
              "overrideMessageProperties": "boolean",
              "encryptMessage": "boolean",
              "signMessage": "boolean",
              "compressMessage": "boolean",
              "checkDuplicateMessage": "boolean",
              "interchangeDuplicatesValidityDays": "integer",
              "checkCertificateRevocationListOnSend": "boolean",
              "checkCertificateRevocationListOnReceive": "boolean",
              "encryptionAlgorithm": "string"
            },
            "envelopeSettings": {
              "messageContentType": "string",
              "transmitFileNameInMimeHeader": "boolean",
              "fileNameTemplate": "string",
              "SuspendMessageOnFileNameGenerationError": "boolean",
              "AutogenerateFileName": "boolean"
            },
            "errorSettings": {
              "SuspendDuplicateMessage": "boolean",
              "ResendIfMdnNotReceived": "boolean"
            }
          }
        }
      },
      "X12": {
        "receiveAgreement": {
          "senderBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "receiverBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "protocolSettings": {
            "validationSettings": {
              "validateCharacterSet": "boolean",
              "checkDuplicateInterchangeControlNumber": "boolean",
              "interchangeControlNumberValidityDays": "integer",
              "checkDuplicateGroupControlNumber": "boolean",
              "checkDuplicateTransactionSetControlNumber": "boolean",
              "validateEDITypes": "boolean",
              "validateXSDTypes": "boolean",
              "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trimLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trailingSeparatorPolicy": "string"
            },
            "framingSettings": {
              "dataElementSeparator": "integer",
              "componentSeparator": "integer",
              "replaceSeparatorsInPayload": "boolean",
              "replaceCharacter": "integer",
              "segmentTerminator": "integer",
              "characterSet": "string",
              "segmentTerminatorSuffix": "string"
            },
            "envelopeSettings": {
              "controlStandardsId": "integer",
              "useControlStandardsIdAsRepetitionCharacter": "boolean",
              "senderApplicationId": "string",
              "receiverApplicationId": "string",
              "controlVersionNumber": "string",
              "interchangeControlNumberLowerBound": "integer",
              "interchangeControlNumberUpperBound": "integer",
              "rolloverInterchangeControlNumber": "boolean",
              "enableDefaultGroupHeaders": "boolean",
              "functionalGroupId": "string",
              "groupControlNumberLowerBound": "integer",
              "groupControlNumberUpperBound": "integer",
              "rolloverGroupControlNumber": "boolean",
              "groupHeaderAgencyCode": "string",
              "groupHeaderVersion": "string",
              "transactionSetControlNumberLowerBound": "integer",
              "transactionSetControlNumberUpperBound": "integer",
              "rolloverTransactionSetControlNumber": "boolean",
              "transactionSetControlNumberPrefix": "string",
              "transactionSetControlNumberSuffix": "string",
              "overwriteExistingTransactionSetControlNumber": "boolean",
              "groupHeaderDateFormat": "string",
              "groupHeaderTimeFormat": "string",
              "usageIndicator": "string"
            },
            "acknowledgementSettings": {
              "needTechnicalAcknowledgement": "boolean",
              "batchTechnicalAcknowledgements": "boolean",
              "needFunctionalAcknowledgement": "boolean",
              "functionalAcknowledgementVersion": "string",
              "batchFunctionalAcknowledgements": "boolean",
              "needImplementationAcknowledgement": "boolean",
              "implementationAcknowledgementVersion": "string",
              "batchImplementationAcknowledgements": "boolean",
              "needLoopForValidMessages": "boolean",
              "sendSynchronousAcknowledgement": "boolean",
              "acknowledgementControlNumberPrefix": "string",
              "acknowledgementControlNumberSuffix": "string",
              "acknowledgementControlNumberLowerBound": "integer",
              "acknowledgementControlNumberUpperBound": "integer",
              "rolloverAcknowledgementControlNumber": "boolean"
            },
            "messageFilter": {
              "messageFilterType": "string"
            },
            "securitySettings": {
              "authorizationQualifier": "string",
              "authorizationValue": "string",
              "securityQualifier": "string",
              "passwordValue": "string"
            },
            "processingSettings": {
              "maskSecurityInfo": "boolean",
              "convertImpliedDecimal": "boolean",
              "preserveInterchange": "boolean",
              "suspendInterchangeOnError": "boolean",
              "createEmptyXmlTagsForTrailingSeparators": "boolean",
              "useDotAsDecimalSeparator": "boolean"
            },
            "envelopeOverrides": [
              {
                "targetNamespace": "string",
                "protocolVersion": "string",
                "messageId": "string",
                "responsibleAgencyCode": "integer",
                "headerVersion": "string",
                "senderApplicationId": "string",
                "receiverApplicationId": "string",
                "functionalIdentifierCode": "string",
                "dateFormat": "string",
                "timeFormat": "string"
              }
            ],
            "validationOverrides": [
              {
                "messageId": "string",
                "validateEDITypes": "boolean",
                "validateXSDTypes": "boolean",
                "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
                "validateCharacterSet": "boolean",
                "trimLeadingAndTrailingSpacesAndZeroes": "boolean",
                "trailingSeparatorPolicy": "string"
              }
            ],
            "messageFilterList": [
              {
                "messageId": "string"
              }
            ],
            "schemaReferences": [
              {
                "messageId": "string",
                "senderApplicationId": "string",
                "schemaVersion": "string",
                "schemaName": "string"
              }
            ],
            "x12DelimiterOverrides": [
              {
                "protocolVersion": "string",
                "messageId": "string",
                "dataElementSeparator": "integer",
                "componentSeparator": "integer",
                "segmentTerminator": "integer",
                "segmentTerminatorSuffix": "string",
                "replaceCharacter": "integer",
                "replaceSeparatorsInPayload": "boolean",
                "targetNamespace": "string"
              }
            ]
          }
        },
        "sendAgreement": {
          "senderBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "receiverBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "protocolSettings": {
            "validationSettings": {
              "validateCharacterSet": "boolean",
              "checkDuplicateInterchangeControlNumber": "boolean",
              "interchangeControlNumberValidityDays": "integer",
              "checkDuplicateGroupControlNumber": "boolean",
              "checkDuplicateTransactionSetControlNumber": "boolean",
              "validateEDITypes": "boolean",
              "validateXSDTypes": "boolean",
              "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trimLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trailingSeparatorPolicy": "string"
            },
            "framingSettings": {
              "dataElementSeparator": "integer",
              "componentSeparator": "integer",
              "replaceSeparatorsInPayload": "boolean",
              "replaceCharacter": "integer",
              "segmentTerminator": "integer",
              "characterSet": "string",
              "segmentTerminatorSuffix": "string"
            },
            "envelopeSettings": {
              "controlStandardsId": "integer",
              "useControlStandardsIdAsRepetitionCharacter": "boolean",
              "senderApplicationId": "string",
              "receiverApplicationId": "string",
              "controlVersionNumber": "string",
              "interchangeControlNumberLowerBound": "integer",
              "interchangeControlNumberUpperBound": "integer",
              "rolloverInterchangeControlNumber": "boolean",
              "enableDefaultGroupHeaders": "boolean",
              "functionalGroupId": "string",
              "groupControlNumberLowerBound": "integer",
              "groupControlNumberUpperBound": "integer",
              "rolloverGroupControlNumber": "boolean",
              "groupHeaderAgencyCode": "string",
              "groupHeaderVersion": "string",
              "transactionSetControlNumberLowerBound": "integer",
              "transactionSetControlNumberUpperBound": "integer",
              "rolloverTransactionSetControlNumber": "boolean",
              "transactionSetControlNumberPrefix": "string",
              "transactionSetControlNumberSuffix": "string",
              "overwriteExistingTransactionSetControlNumber": "boolean",
              "groupHeaderDateFormat": "string",
              "groupHeaderTimeFormat": "string",
              "usageIndicator": "string"
            },
            "acknowledgementSettings": {
              "needTechnicalAcknowledgement": "boolean",
              "batchTechnicalAcknowledgements": "boolean",
              "needFunctionalAcknowledgement": "boolean",
              "functionalAcknowledgementVersion": "string",
              "batchFunctionalAcknowledgements": "boolean",
              "needImplementationAcknowledgement": "boolean",
              "implementationAcknowledgementVersion": "string",
              "batchImplementationAcknowledgements": "boolean",
              "needLoopForValidMessages": "boolean",
              "sendSynchronousAcknowledgement": "boolean",
              "acknowledgementControlNumberPrefix": "string",
              "acknowledgementControlNumberSuffix": "string",
              "acknowledgementControlNumberLowerBound": "integer",
              "acknowledgementControlNumberUpperBound": "integer",
              "rolloverAcknowledgementControlNumber": "boolean"
            },
            "messageFilter": {
              "messageFilterType": "string"
            },
            "securitySettings": {
              "authorizationQualifier": "string",
              "authorizationValue": "string",
              "securityQualifier": "string",
              "passwordValue": "string"
            },
            "processingSettings": {
              "maskSecurityInfo": "boolean",
              "convertImpliedDecimal": "boolean",
              "preserveInterchange": "boolean",
              "suspendInterchangeOnError": "boolean",
              "createEmptyXmlTagsForTrailingSeparators": "boolean",
              "useDotAsDecimalSeparator": "boolean"
            },
            "envelopeOverrides": [
              {
                "targetNamespace": "string",
                "protocolVersion": "string",
                "messageId": "string",
                "responsibleAgencyCode": "integer",
                "headerVersion": "string",
                "senderApplicationId": "string",
                "receiverApplicationId": "string",
                "functionalIdentifierCode": "string",
                "dateFormat": "string",
                "timeFormat": "string"
              }
            ],
            "validationOverrides": [
              {
                "messageId": "string",
                "validateEDITypes": "boolean",
                "validateXSDTypes": "boolean",
                "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
                "validateCharacterSet": "boolean",
                "trimLeadingAndTrailingSpacesAndZeroes": "boolean",
                "trailingSeparatorPolicy": "string"
              }
            ],
            "messageFilterList": [
              {
                "messageId": "string"
              }
            ],
            "schemaReferences": [
              {
                "messageId": "string",
                "senderApplicationId": "string",
                "schemaVersion": "string",
                "schemaName": "string"
              }
            ],
            "x12DelimiterOverrides": [
              {
                "protocolVersion": "string",
                "messageId": "string",
                "dataElementSeparator": "integer",
                "componentSeparator": "integer",
                "segmentTerminator": "integer",
                "segmentTerminatorSuffix": "string",
                "replaceCharacter": "integer",
                "replaceSeparatorsInPayload": "boolean",
                "targetNamespace": "string"
              }
            ]
          }
        }
      },
      "Edifact": {
        "receiveAgreement": {
          "senderBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "receiverBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "protocolSettings": {
            "validationSettings": {
              "validateCharacterSet": "boolean",
              "checkDuplicateInterchangeControlNumber": "boolean",
              "interchangeControlNumberValidityDays": "integer",
              "checkDuplicateGroupControlNumber": "boolean",
              "checkDuplicateTransactionSetControlNumber": "boolean",
              "validateEDITypes": "boolean",
              "validateXSDTypes": "boolean",
              "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trimLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trailingSeparatorPolicy": "string"
            },
            "framingSettings": {
              "serviceCodeListDirectoryVersion": "string",
              "characterEncoding": "string",
              "protocolVersion": "integer",
              "dataElementSeparator": "integer",
              "componentSeparator": "integer",
              "segmentTerminator": "integer",
              "releaseIndicator": "integer",
              "repetitionSeparator": "integer",
              "characterSet": "string",
              "decimalPointIndicator": "string",
              "segmentTerminatorSuffix": "string"
            },
            "envelopeSettings": {
              "groupAssociationAssignedCode": "string",
              "communicationAgreementId": "string",
              "applyDelimiterStringAdvice": "boolean",
              "createGroupingSegments": "boolean",
              "enableDefaultGroupHeaders": "boolean",
              "recipientReferencePasswordValue": "string",
              "recipientReferencePasswordQualifier": "string",
              "applicationReferenceId": "string",
              "processingPriorityCode": "string",
              "interchangeControlNumberLowerBound": "integer",
              "interchangeControlNumberUpperBound": "integer",
              "rolloverInterchangeControlNumber": "boolean",
              "interchangeControlNumberPrefix": "string",
              "interchangeControlNumberSuffix": "string",
              "senderReverseRoutingAddress": "string",
              "receiverReverseRoutingAddress": "string",
              "functionalGroupId": "string",
              "groupControllingAgencyCode": "string",
              "groupMessageVersion": "string",
              "groupMessageRelease": "string",
              "groupControlNumberLowerBound": "integer",
              "groupControlNumberUpperBound": "integer",
              "rolloverGroupControlNumber": "boolean",
              "groupControlNumberPrefix": "string",
              "groupControlNumberSuffix": "string",
              "groupApplicationReceiverQualifier": "string",
              "groupApplicationReceiverId": "string",
              "groupApplicationSenderQualifier": "string",
              "groupApplicationSenderId": "string",
              "groupApplicationPassword": "string",
              "overwriteExistingTransactionSetControlNumber": "boolean",
              "transactionSetControlNumberPrefix": "string",
              "transactionSetControlNumberSuffix": "string",
              "transactionSetControlNumberLowerBound": "integer",
              "transactionSetControlNumberUpperBound": "integer",
              "rolloverTransactionSetControlNumber": "boolean",
              "isTestInterchange": "boolean",
              "senderInternalIdentification": "string",
              "senderInternalSubIdentification": "string",
              "receiverInternalIdentification": "string",
              "receiverInternalSubIdentification": "string"
            },
            "acknowledgementSettings": {
              "needTechnicalAcknowledgement": "boolean",
              "batchTechnicalAcknowledgements": "boolean",
              "needFunctionalAcknowledgement": "boolean",
              "batchFunctionalAcknowledgements": "boolean",
              "needLoopForValidMessages": "boolean",
              "sendSynchronousAcknowledgement": "boolean",
              "acknowledgementControlNumberPrefix": "string",
              "acknowledgementControlNumberSuffix": "string",
              "acknowledgementControlNumberLowerBound": "integer",
              "acknowledgementControlNumberUpperBound": "integer",
              "rolloverAcknowledgementControlNumber": "boolean"
            },
            "messageFilter": {
              "messageFilterType": "string"
            },
            "processingSettings": {
              "maskSecurityInfo": "boolean",
              "preserveInterchange": "boolean",
              "suspendInterchangeOnError": "boolean",
              "createEmptyXmlTagsForTrailingSeparators": "boolean",
              "useDotAsDecimalSeparator": "boolean"
            },
            "envelopeOverrides": [
              {
                "messageId": "string",
                "messageVersion": "string",
                "messageRelease": "string",
                "messageAssociationAssignedCode": "string",
                "targetNamespace": "string",
                "functionalGroupId": "string",
                "senderApplicationQualifier": "string",
                "senderApplicationId": "string",
                "receiverApplicationQualifier": "string",
                "receiverApplicationId": "string",
                "controllingAgencyCode": "string",
                "groupHeaderMessageVersion": "string",
                "groupHeaderMessageRelease": "string",
                "associationAssignedCode": "string",
                "applicationPassword": "string"
              }
            ],
            "messageFilterList": [
              {
                "messageId": "string"
              }
            ],
            "schemaReferences": [
              {
                "messageId": "string",
                "messageVersion": "string",
                "messageRelease": "string",
                "senderApplicationId": "string",
                "senderApplicationQualifier": "string",
                "associationAssignedCode": "string",
                "schemaName": "string"
              }
            ],
            "validationOverrides": [
              {
                "messageId": "string",
                "enforceCharacterSet": "boolean",
                "validateEDITypes": "boolean",
                "validateXSDTypes": "boolean",
                "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
                "trailingSeparatorPolicy": "string",
                "trimLeadingAndTrailingSpacesAndZeroes": "boolean"
              }
            ],
            "edifactDelimiterOverrides": [
              {
                "messageId": "string",
                "messageVersion": "string",
                "messageRelease": "string",
                "dataElementSeparator": "integer",
                "componentSeparator": "integer",
                "segmentTerminator": "integer",
                "repetitionSeparator": "integer",
                "segmentTerminatorSuffix": "string",
                "decimalPointIndicator": "string",
                "releaseIndicator": "integer",
                "messageAssociationAssignedCode": "string",
                "targetNamespace": "string"
              }
            ]
          }
        },
        "sendAgreement": {
          "senderBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "receiverBusinessIdentity": {
            "Qualifier": "string",
            "Value": "string"
          },
          "protocolSettings": {
            "validationSettings": {
              "validateCharacterSet": "boolean",
              "checkDuplicateInterchangeControlNumber": "boolean",
              "interchangeControlNumberValidityDays": "integer",
              "checkDuplicateGroupControlNumber": "boolean",
              "checkDuplicateTransactionSetControlNumber": "boolean",
              "validateEDITypes": "boolean",
              "validateXSDTypes": "boolean",
              "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trimLeadingAndTrailingSpacesAndZeroes": "boolean",
              "trailingSeparatorPolicy": "string"
            },
            "framingSettings": {
              "serviceCodeListDirectoryVersion": "string",
              "characterEncoding": "string",
              "protocolVersion": "integer",
              "dataElementSeparator": "integer",
              "componentSeparator": "integer",
              "segmentTerminator": "integer",
              "releaseIndicator": "integer",
              "repetitionSeparator": "integer",
              "characterSet": "string",
              "decimalPointIndicator": "string",
              "segmentTerminatorSuffix": "string"
            },
            "envelopeSettings": {
              "groupAssociationAssignedCode": "string",
              "communicationAgreementId": "string",
              "applyDelimiterStringAdvice": "boolean",
              "createGroupingSegments": "boolean",
              "enableDefaultGroupHeaders": "boolean",
              "recipientReferencePasswordValue": "string",
              "recipientReferencePasswordQualifier": "string",
              "applicationReferenceId": "string",
              "processingPriorityCode": "string",
              "interchangeControlNumberLowerBound": "integer",
              "interchangeControlNumberUpperBound": "integer",
              "rolloverInterchangeControlNumber": "boolean",
              "interchangeControlNumberPrefix": "string",
              "interchangeControlNumberSuffix": "string",
              "senderReverseRoutingAddress": "string",
              "receiverReverseRoutingAddress": "string",
              "functionalGroupId": "string",
              "groupControllingAgencyCode": "string",
              "groupMessageVersion": "string",
              "groupMessageRelease": "string",
              "groupControlNumberLowerBound": "integer",
              "groupControlNumberUpperBound": "integer",
              "rolloverGroupControlNumber": "boolean",
              "groupControlNumberPrefix": "string",
              "groupControlNumberSuffix": "string",
              "groupApplicationReceiverQualifier": "string",
              "groupApplicationReceiverId": "string",
              "groupApplicationSenderQualifier": "string",
              "groupApplicationSenderId": "string",
              "groupApplicationPassword": "string",
              "overwriteExistingTransactionSetControlNumber": "boolean",
              "transactionSetControlNumberPrefix": "string",
              "transactionSetControlNumberSuffix": "string",
              "transactionSetControlNumberLowerBound": "integer",
              "transactionSetControlNumberUpperBound": "integer",
              "rolloverTransactionSetControlNumber": "boolean",
              "isTestInterchange": "boolean",
              "senderInternalIdentification": "string",
              "senderInternalSubIdentification": "string",
              "receiverInternalIdentification": "string",
              "receiverInternalSubIdentification": "string"
            },
            "acknowledgementSettings": {
              "needTechnicalAcknowledgement": "boolean",
              "batchTechnicalAcknowledgements": "boolean",
              "needFunctionalAcknowledgement": "boolean",
              "batchFunctionalAcknowledgements": "boolean",
              "needLoopForValidMessages": "boolean",
              "sendSynchronousAcknowledgement": "boolean",
              "acknowledgementControlNumberPrefix": "string",
              "acknowledgementControlNumberSuffix": "string",
              "acknowledgementControlNumberLowerBound": "integer",
              "acknowledgementControlNumberUpperBound": "integer",
              "rolloverAcknowledgementControlNumber": "boolean"
            },
            "messageFilter": {
              "messageFilterType": "string"
            },
            "processingSettings": {
              "maskSecurityInfo": "boolean",
              "preserveInterchange": "boolean",
              "suspendInterchangeOnError": "boolean",
              "createEmptyXmlTagsForTrailingSeparators": "boolean",
              "useDotAsDecimalSeparator": "boolean"
            },
            "envelopeOverrides": [
              {
                "messageId": "string",
                "messageVersion": "string",
                "messageRelease": "string",
                "messageAssociationAssignedCode": "string",
                "targetNamespace": "string",
                "functionalGroupId": "string",
                "senderApplicationQualifier": "string",
                "senderApplicationId": "string",
                "receiverApplicationQualifier": "string",
                "receiverApplicationId": "string",
                "controllingAgencyCode": "string",
                "groupHeaderMessageVersion": "string",
                "groupHeaderMessageRelease": "string",
                "associationAssignedCode": "string",
                "applicationPassword": "string"
              }
            ],
            "messageFilterList": [
              {
                "messageId": "string"
              }
            ],
            "schemaReferences": [
              {
                "messageId": "string",
                "messageVersion": "string",
                "messageRelease": "string",
                "senderApplicationId": "string",
                "senderApplicationQualifier": "string",
                "associationAssignedCode": "string",
                "schemaName": "string"
              }
            ],
            "validationOverrides": [
              {
                "messageId": "string",
                "enforceCharacterSet": "boolean",
                "validateEDITypes": "boolean",
                "validateXSDTypes": "boolean",
                "allowLeadingAndTrailingSpacesAndZeroes": "boolean",
                "trailingSeparatorPolicy": "string",
                "trimLeadingAndTrailingSpacesAndZeroes": "boolean"
              }
            ],
            "edifactDelimiterOverrides": [
              {
                "messageId": "string",
                "messageVersion": "string",
                "messageRelease": "string",
                "dataElementSeparator": "integer",
                "componentSeparator": "integer",
                "segmentTerminator": "integer",
                "repetitionSeparator": "integer",
                "segmentTerminatorSuffix": "string",
                "decimalPointIndicator": "string",
                "releaseIndicator": "integer",
                "messageAssociationAssignedCode": "string",
                "targetNamespace": "string"
              }
            ]
          }
        }
      }
    }
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Logic/integrationAccounts/agreements" />
### Microsoft.Logic/integrationAccounts/agreements object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Logic/integrationAccounts/agreements |
|  apiVersion | enum | Yes | 2015-08-01-preview |
|  id | string | No | The resource id. |
|  location | string | No | The resource location. |
|  tags | object | No | The resource tags. |
|  properties | object | Yes | The integration account agreement properties. - [IntegrationAccountAgreementProperties object](#IntegrationAccountAgreementProperties) |


<a id="IntegrationAccountAgreementProperties" />
### IntegrationAccountAgreementProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  metadata | object | No | The metadata. |
|  agreementType | enum | No | The agreement type. - NotSpecified, AS2, X12, Edifact |
|  hostPartner | string | No | The host partner. |
|  guestPartner | string | No | The guest partner. |
|  hostIdentity | object | No | The host identity. - [BusinessIdentity object](#BusinessIdentity) |
|  guestIdentity | object | No | The guest identity. - [BusinessIdentity object](#BusinessIdentity) |
|  content | object | No | The agreement content. - [AgreementContent object](#AgreementContent) |


<a id="BusinessIdentity" />
### BusinessIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  Qualifier | string | No | The business identity qualifier. |
|  Value | string | No | The business identity value. |


<a id="AgreementContent" />
### AgreementContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  AS2 | object | No | The AS2 agreement content. - [AS2AgreementContent object](#AS2AgreementContent) |
|  X12 | object | No | The X12 agreement content. - [X12AgreementContent object](#X12AgreementContent) |
|  Edifact | object | No | The EDIFACT agreement content. - [EdifactAgreementContent object](#EdifactAgreementContent) |


<a id="AS2AgreementContent" />
### AS2AgreementContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  receiveAgreement | object | No | The AS2 one-way receive agreement. - [AS2OneWayAgreement object](#AS2OneWayAgreement) |
|  sendAgreement | object | No | The AS2 one-way send agreement. - [AS2OneWayAgreement object](#AS2OneWayAgreement) |


<a id="X12AgreementContent" />
### X12AgreementContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  receiveAgreement | object | No | The X12 one-way receive agreement. - [X12OneWayAgreement object](#X12OneWayAgreement) |
|  sendAgreement | object | No | The X12 one-way send agreement. - [X12OneWayAgreement object](#X12OneWayAgreement) |


<a id="EdifactAgreementContent" />
### EdifactAgreementContent object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  receiveAgreement | object | No | The EDIFACT one-way receive agreement. - [EdifactOneWayAgreement object](#EdifactOneWayAgreement) |
|  sendAgreement | object | No | The EDIFACT one-way send agreement. - [EdifactOneWayAgreement object](#EdifactOneWayAgreement) |


<a id="AS2OneWayAgreement" />
### AS2OneWayAgreement object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  senderBusinessIdentity | object | No | The sender business identity - [BusinessIdentity object](#BusinessIdentity) |
|  receiverBusinessIdentity | object | No | The receiver business identity - [BusinessIdentity object](#BusinessIdentity) |
|  protocolSettings | object | No | The AS2 protocol settings. - [AS2ProtocolSettings object](#AS2ProtocolSettings) |


<a id="X12OneWayAgreement" />
### X12OneWayAgreement object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  senderBusinessIdentity | object | No | The sender business identity - [BusinessIdentity object](#BusinessIdentity) |
|  receiverBusinessIdentity | object | No | The receiver business identity - [BusinessIdentity object](#BusinessIdentity) |
|  protocolSettings | object | No | The X12 protocol settings. - [X12ProtocolSettings object](#X12ProtocolSettings) |


<a id="EdifactOneWayAgreement" />
### EdifactOneWayAgreement object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  senderBusinessIdentity | object | No | The sender business identity - [BusinessIdentity object](#BusinessIdentity) |
|  receiverBusinessIdentity | object | No | The receiver business identity - [BusinessIdentity object](#BusinessIdentity) |
|  protocolSettings | object | No | The EDIFACT protocol settings. - [EdifactProtocolSettings object](#EdifactProtocolSettings) |


<a id="AS2ProtocolSettings" />
### AS2ProtocolSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageConnectionSettings | object | No | The message connection settings. - [AS2MessageConnectionSettings object](#AS2MessageConnectionSettings) |
|  acknowledgementConnectionSettings | object | No | The acknowledgement connection settings. - [AS2AcknowledgementConnectionSettings object](#AS2AcknowledgementConnectionSettings) |
|  mdnSettings | object | No | The MDN settings. - [AS2MdnSettings object](#AS2MdnSettings) |
|  securitySettings | object | No | The security settings. - [AS2SecuritySettings object](#AS2SecuritySettings) |
|  validationSettings | object | No | The validation settings. - [AS2ValidationSettings object](#AS2ValidationSettings) |
|  envelopeSettings | object | No | The envelope settings. - [AS2EnvelopeSettings object](#AS2EnvelopeSettings) |
|  errorSettings | object | No | The error settings. - [AS2ErrorSettings object](#AS2ErrorSettings) |


<a id="X12ProtocolSettings" />
### X12ProtocolSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  validationSettings | object | No | The X12 validation settings. - [X12ValidationSettings object](#X12ValidationSettings) |
|  framingSettings | object | No | The X12 framing settings. - [X12FramingSettings object](#X12FramingSettings) |
|  envelopeSettings | object | No | The X12 envelope settings. - [X12EnvelopeSettings object](#X12EnvelopeSettings) |
|  acknowledgementSettings | object | No | The X12 acknowledgment settings. - [X12AcknowledgementSettings object](#X12AcknowledgementSettings) |
|  messageFilter | object | No | The X12 message filter. - [X12MessageFilter object](#X12MessageFilter) |
|  securitySettings | object | No | The X12 security settings. - [X12SecuritySettings object](#X12SecuritySettings) |
|  processingSettings | object | No | The X12 processing settings. - [X12ProcessingSettings object](#X12ProcessingSettings) |
|  envelopeOverrides | array | No | The X12 envelope override settings. - [X12EnvelopeOverride object](#X12EnvelopeOverride) |
|  validationOverrides | array | No | The X12 validation override settings. - [X12ValidationOverride object](#X12ValidationOverride) |
|  messageFilterList | array | No | The X12 message filter list. - [X12MessageIdentifier object](#X12MessageIdentifier) |
|  schemaReferences | array | No | The X12 schema references. - [X12SchemaReference object](#X12SchemaReference) |
|  x12DelimiterOverrides | array | No | The X12 delimiter override settings. - [X12DelimiterOverrides object](#X12DelimiterOverrides) |


<a id="EdifactProtocolSettings" />
### EdifactProtocolSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  validationSettings | object | No | The EDIFACT validation settings. - [EdifactValidationSettings object](#EdifactValidationSettings) |
|  framingSettings | object | No | The EDIFACT framing settings. - [EdifactFramingSettings object](#EdifactFramingSettings) |
|  envelopeSettings | object | No | The EDIFACT envelope settings. - [EdifactEnvelopeSettings object](#EdifactEnvelopeSettings) |
|  acknowledgementSettings | object | No | The EDIFACT acknowledgement settings. - [EdifactAcknowledgementSettings object](#EdifactAcknowledgementSettings) |
|  messageFilter | object | No | The EDIFACT message filter. - [EdifactMessageFilter object](#EdifactMessageFilter) |
|  processingSettings | object | No | The EDIFACT processing Settings. - [EdifactProcessingSettings object](#EdifactProcessingSettings) |
|  envelopeOverrides | array | No | The EDIFACT envelope override settings. - [EdifactEnvelopeOverride object](#EdifactEnvelopeOverride) |
|  messageFilterList | array | No | The EDIFACT message filter list. - [EdifactMessageIdentifier object](#EdifactMessageIdentifier) |
|  schemaReferences | array | No | The EDIFACT schema references. - [EdifactSchemaReference object](#EdifactSchemaReference) |
|  validationOverrides | array | No | The EDIFACT validation override settings. - [EdifactValidationOverride object](#EdifactValidationOverride) |
|  edifactDelimiterOverrides | array | No | The EDIFACT delimiter override settings. - [EdifactDelimiterOverride object](#EdifactDelimiterOverride) |


<a id="AS2MessageConnectionSettings" />
### AS2MessageConnectionSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ignoreCertificateNameMismatch | boolean | No | The value indicating whether to ignore mismatch in certificate name. |
|  supportHttpStatusCodeContinue | boolean | No | The value indicating whether to support HTTP status code 'CONTINUE'. |
|  keepHttpConnectionAlive | boolean | No | The value indicating whether to keep the connection alive. |
|  unfoldHttpHeaders | boolean | No | The value indicating whether to unfold the HTTP headers. |


<a id="AS2AcknowledgementConnectionSettings" />
### AS2AcknowledgementConnectionSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ignoreCertificateNameMismatch | boolean | No | The value indicating whether to ignore mismatch in certificate name. |
|  supportHttpStatusCodeContinue | boolean | No | The value indicating whether to support HTTP status code 'CONTINUE'. |
|  keepHttpConnectionAlive | boolean | No | The value indicating whether to keep the connection alive. |
|  unfoldHttpHeaders | boolean | No | The value indicating whether to unfold the HTTP headers. |


<a id="AS2MdnSettings" />
### AS2MdnSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  needMdn | boolean | No | The value indicating whether to send or request a MDN. |
|  signMdn | boolean | No | The value indicating whether the MDN needs to be signed or not. |
|  sendMdnAsynchronously | boolean | No | The value indicating whether to send the asynchronous MDN. |
|  receiptDeliveryUrl | string | No | The receipt delivery URL. |
|  dispositionNotificationTo | string | No | The disposition notification to header value. |
|  signOutboundMdnIfOptional | boolean | No | The value indicating whether to sign the outbound MDN if optional. |
|  mdnText | string | No | The MDN text. |
|  sendInboundMdnToMessageBox | boolean | No | The value indicating whether to send inbound MDN to message box. |
|  micHashingAlgorithm | enum | No | The signing or hashing algorithm. - NotSpecified, None, SHA2256, SHA2384, SHA2512 |


<a id="AS2SecuritySettings" />
### AS2SecuritySettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  overrideGroupSigningCertificate | boolean | No | The value indicating whether to send or request a MDN. |
|  signingCertificateName | string | No | The name of the signing certificate. |
|  encryptionCertificateName | string | No | The name of the encryption certificate. |
|  enableNrrForInboundEncodedMessages | boolean | No | The value indicating whether to enable NRR for inbound encoded messages. |
|  enableNrrForInboundDecodedMessages | boolean | No | The value indicating whether to enable NRR for inbound decoded messages. |
|  enableNrrForOutboundMdn | boolean | No | The value indicating whether to enable NRR for outbound MDN. |
|  enableNrrForOutboundEncodedMessages | boolean | No | The value indicating whether to enable NRR for outbound encoded messages. |
|  enableNrrForOutboundDecodedMessages | boolean | No | The value indicating whether to enable NRR for outbound decoded messages. |
|  enableNrrForInboundMdn | boolean | No | The value indicating whether to enable NRR for inbound MDN. |


<a id="AS2ValidationSettings" />
### AS2ValidationSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  overrideMessageProperties | boolean | No | The value indicating whether to override incoming message properties with those in agreement. |
|  encryptMessage | boolean | No | The value indicating whether the message has to be encrypted. |
|  signMessage | boolean | No | The value indicating whether the message has to be signed. |
|  compressMessage | boolean | No | The value indicating whether the message has to be compressed. |
|  checkDuplicateMessage | boolean | No | The value indicating whether to check for duplicate message. |
|  interchangeDuplicatesValidityDays | integer | No | The number of days to look back for duplicate interchange. |
|  checkCertificateRevocationListOnSend | boolean | No | The value indicating whether to check for certificate revocation list on send. |
|  checkCertificateRevocationListOnReceive | boolean | No | The value indicating whether to check for certificate revocation list on receive. |
|  encryptionAlgorithm | enum | No | The encryption algorithm. - NotSpecified, None, DES3, RC2, AES128, AES192, AES256 |


<a id="AS2EnvelopeSettings" />
### AS2EnvelopeSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageContentType | string | No | The message content type. |
|  transmitFileNameInMimeHeader | boolean | No | The value indicating whether to transmit file name in mime header. |
|  fileNameTemplate | string | No | The template for file name. |
|  SuspendMessageOnFileNameGenerationError | boolean | No | The value indicating whether to suspend message on file name generation error. |
|  AutogenerateFileName | boolean | No | The value indicating whether to auto generate file name. |


<a id="AS2ErrorSettings" />
### AS2ErrorSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  SuspendDuplicateMessage | boolean | No | The value indicating whether to suspend duplicate message. |
|  ResendIfMdnNotReceived | boolean | No | The value indicating whether to resend message If MDN is not received. |


<a id="X12ValidationSettings" />
### X12ValidationSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  validateCharacterSet | boolean | No | The value indicating whether to validate character set in the message. |
|  checkDuplicateInterchangeControlNumber | boolean | No | The value indicating whether to check for duplicate interchange control number. |
|  interchangeControlNumberValidityDays | integer | No | The validity period of interchange control number. |
|  checkDuplicateGroupControlNumber | boolean | No | The value indicating whether to check for duplicate group control number. |
|  checkDuplicateTransactionSetControlNumber | boolean | No | The value indicating whether to check for duplicate transaction set control number. |
|  validateEDITypes | boolean | No | The value indicating whether to Whether to validate EDI types. |
|  validateXSDTypes | boolean | No | The value indicating whether to Whether to validate XSD types. |
|  allowLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to allow leading and trailing spaces and zeroes. |
|  trimLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to trim leading and trailing spaces and zeroes. |
|  trailingSeparatorPolicy | enum | No | The trailing separator policy. - NotSpecified, NotAllowed, Optional, Mandatory |


<a id="X12FramingSettings" />
### X12FramingSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  dataElementSeparator | integer | No | The data element separator. |
|  componentSeparator | integer | No | The component separator. |
|  replaceSeparatorsInPayload | boolean | No | The value indicating whether to replace separators in payload. |
|  replaceCharacter | integer | No | The replacement character. |
|  segmentTerminator | integer | No | The segment terminator. |
|  characterSet | enum | No | The X12 character set. - NotSpecified, Basic, Extended, UTF8 |
|  segmentTerminatorSuffix | enum | No | The segment terminator suffix. - NotSpecified, None, CR, LF, CRLF |


<a id="X12EnvelopeSettings" />
### X12EnvelopeSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  controlStandardsId | integer | No | The controls standards id. |
|  useControlStandardsIdAsRepetitionCharacter | boolean | No | The value indicating whether to use control standards id as repetition character. |
|  senderApplicationId | string | No | The sender application id. |
|  receiverApplicationId | string | No | The receiver application id. |
|  controlVersionNumber | string | No | The control version number. |
|  interchangeControlNumberLowerBound | integer | No | The interchange  control number lower bound. |
|  interchangeControlNumberUpperBound | integer | No | The interchange  control number upper bound. |
|  rolloverInterchangeControlNumber | boolean | No | The value indicating whether to rollover interchange control number. |
|  enableDefaultGroupHeaders | boolean | No | The value indicating whether to enable default group headers. |
|  functionalGroupId | string | No | The functional group id. |
|  groupControlNumberLowerBound | integer | No | The group control number lower bound. |
|  groupControlNumberUpperBound | integer | No | The group control number upper bound. |
|  rolloverGroupControlNumber | boolean | No | The value indicating whether to rollover group control number. |
|  groupHeaderAgencyCode | string | No | The group header agency code. |
|  groupHeaderVersion | string | No | The group header version. |
|  transactionSetControlNumberLowerBound | integer | No | The transaction set control number lower bound. |
|  transactionSetControlNumberUpperBound | integer | No | The transaction set control number upper bound. |
|  rolloverTransactionSetControlNumber | boolean | No | The value indicating whether to rollover transaction set control number. |
|  transactionSetControlNumberPrefix | string | No | The transaction set control number prefix. |
|  transactionSetControlNumberSuffix | string | No | The transaction set control number suffix. |
|  overwriteExistingTransactionSetControlNumber | boolean | No | The value indicating whether to overwrite existing transaction set control number. |
|  groupHeaderDateFormat | enum | No | The group header date format. - NotSpecified, CCYYMMDD, YYMMDD |
|  groupHeaderTimeFormat | enum | No | The group header time format. - NotSpecified, HHMM, HHMMSS, HHMMSSdd, HHMMSSd |
|  usageIndicator | enum | No | The usage indicator. - NotSpecified, Test, Information, Production |


<a id="X12AcknowledgementSettings" />
### X12AcknowledgementSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  needTechnicalAcknowledgement | boolean | No | The value indicating whether technical acknowledgement is needed. |
|  batchTechnicalAcknowledgements | boolean | No | The value indicating whether to batch the technical acknowledgements. |
|  needFunctionalAcknowledgement | boolean | No | The value indicating whether functional acknowledgement is needed. |
|  functionalAcknowledgementVersion | string | No | The functional acknowledgement version. |
|  batchFunctionalAcknowledgements | boolean | No | The value indicating whether to batch functional acknowledgements. |
|  needImplementationAcknowledgement | boolean | No | The value indicating whether implementation acknowledgement is needed. |
|  implementationAcknowledgementVersion | string | No | The implementation acknowledgement version. |
|  batchImplementationAcknowledgements | boolean | No | The value indicating whether to batch implementation acknowledgements. |
|  needLoopForValidMessages | boolean | No | The value indicating whether a loop is needed for valid messages. |
|  sendSynchronousAcknowledgement | boolean | No | The value indicating whether to send synchronous acknowledgement. |
|  acknowledgementControlNumberPrefix | string | No | The acknowledgement control number prefix. |
|  acknowledgementControlNumberSuffix | string | No | The acknowledgement control number suffix. |
|  acknowledgementControlNumberLowerBound | integer | No | The acknowledgement control number lower bound. |
|  acknowledgementControlNumberUpperBound | integer | No | The acknowledgement control number upper bound. |
|  rolloverAcknowledgementControlNumber | boolean | No | The value indicating whether to rollover acknowledgement control number. |


<a id="X12MessageFilter" />
### X12MessageFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageFilterType | enum | No | The message filter type. - NotSpecified, Include, Exclude |


<a id="X12SecuritySettings" />
### X12SecuritySettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  authorizationQualifier | string | No | The authorization qualifier. |
|  authorizationValue | string | No | The authorization value. |
|  securityQualifier | string | No | The security qualifier. |
|  passwordValue | string | No | The password value. |


<a id="X12ProcessingSettings" />
### X12ProcessingSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maskSecurityInfo | boolean | No | The value indicating whether to mask security information. |
|  convertImpliedDecimal | boolean | No | The value indicating whether to convert numerical type to implied decimal. |
|  preserveInterchange | boolean | No | The value indicating whether to preserve interchange. |
|  suspendInterchangeOnError | boolean | No | The value indicating whether to suspend interchange on error. |
|  createEmptyXmlTagsForTrailingSeparators | boolean | No | The value indicating whether to create empty xml tags for trailing separators. |
|  useDotAsDecimalSeparator | boolean | No | The value indicating whether to use dot as decimal separator. |


<a id="X12EnvelopeOverride" />
### X12EnvelopeOverride object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  targetNamespace | string | No | The target namespace on which this envelope settings has to be applied. |
|  protocolVersion | string | No | The protocol version on which this envelope settings has to be applied. |
|  messageId | string | No | The message id on which this envelope settings has to be applied. |
|  responsibleAgencyCode | integer | No | The responsible agency code. |
|  headerVersion | string | No | The header version. |
|  senderApplicationId | string | No | The sender application id. |
|  receiverApplicationId | string | No | The receiver application id. |
|  functionalIdentifierCode | string | No | The functional identifier code. |
|  dateFormat | enum | No | The date format. - NotSpecified, CCYYMMDD, YYMMDD |
|  timeFormat | enum | No | The time format. - NotSpecified, HHMM, HHMMSS, HHMMSSdd, HHMMSSd |


<a id="X12ValidationOverride" />
### X12ValidationOverride object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id on which the validation settings has to be applied. |
|  validateEDITypes | boolean | No | The value indicating whether to validate EDI types. |
|  validateXSDTypes | boolean | No | The value indicating whether to validate XSD types. |
|  allowLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to allow leading and trailing spaces and zeroes. |
|  validateCharacterSet | boolean | No | The value indicating whether to validate character Set. |
|  trimLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to trim leading and trailing spaces and zeroes. |
|  trailingSeparatorPolicy | enum | No | The trailing separator policy. - NotSpecified, NotAllowed, Optional, Mandatory |


<a id="X12MessageIdentifier" />
### X12MessageIdentifier object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id. |


<a id="X12SchemaReference" />
### X12SchemaReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id. |
|  senderApplicationId | string | No | The sender application id. |
|  schemaVersion | string | No | The schema version. |
|  schemaName | string | No | The schema name. |


<a id="X12DelimiterOverrides" />
### X12DelimiterOverrides object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  protocolVersion | string | No | The protocol version. |
|  messageId | string | No | The message id. |
|  dataElementSeparator | integer | No | The data element separator. |
|  componentSeparator | integer | No | The component separator. |
|  segmentTerminator | integer | No | The segment terminator. |
|  segmentTerminatorSuffix | enum | No | The segment terminator suffix. - NotSpecified, None, CR, LF, CRLF |
|  replaceCharacter | integer | No | The replacement character. |
|  replaceSeparatorsInPayload | boolean | No | The value indicating whether to replace separators in payload. |
|  targetNamespace | string | No | The target namespace on which this delimiter settings has to be applied. |


<a id="EdifactValidationSettings" />
### EdifactValidationSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  validateCharacterSet | boolean | No | The value indicating whether to validate character set in the message. |
|  checkDuplicateInterchangeControlNumber | boolean | No | The value indicating whether to check for duplicate interchange control number. |
|  interchangeControlNumberValidityDays | integer | No | The validity period of interchange control number. |
|  checkDuplicateGroupControlNumber | boolean | No | The value indicating whether to check for duplicate group control number. |
|  checkDuplicateTransactionSetControlNumber | boolean | No | The value indicating whether to check for duplicate transaction set control number. |
|  validateEDITypes | boolean | No | The value indicating whether to Whether to validate EDI types. |
|  validateXSDTypes | boolean | No | The value indicating whether to Whether to validate XSD types. |
|  allowLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to allow leading and trailing spaces and zeroes. |
|  trimLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to trim leading and trailing spaces and zeroes. |
|  trailingSeparatorPolicy | enum | No | The trailing separator policy. - NotSpecified, NotAllowed, Optional, Mandatory |


<a id="EdifactFramingSettings" />
### EdifactFramingSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  serviceCodeListDirectoryVersion | string | No | The service code list directory version. |
|  characterEncoding | string | No | The character encoding. |
|  protocolVersion | integer | No | The protocol version. |
|  dataElementSeparator | integer | No | The data element separator. |
|  componentSeparator | integer | No | The component separator. |
|  segmentTerminator | integer | No | The segment terminator. |
|  releaseIndicator | integer | No | The release indicator. |
|  repetitionSeparator | integer | No | The repetition separator. |
|  characterSet | enum | No | The EDIFACT frame setting characterSet. - NotSpecified, UNOB, UNOA, UNOC, UNOD, UNOE, UNOF, UNOG, UNOH, UNOI, UNOJ, UNOK, UNOX, UNOY, KECA |
|  decimalPointIndicator | enum | No | The EDIFACT frame setting decimal indicator. - NotSpecified, Comma, Decimal |
|  segmentTerminatorSuffix | enum | No | The EDIFACT frame setting segment terminator suffix. - NotSpecified, None, CR, LF, CRLF |


<a id="EdifactEnvelopeSettings" />
### EdifactEnvelopeSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  groupAssociationAssignedCode | string | No | The group association assigned code. |
|  communicationAgreementId | string | No | The communication agreement id. |
|  applyDelimiterStringAdvice | boolean | No | The value indicating whether to apply delimiter string advice. |
|  createGroupingSegments | boolean | No | The value indicating whether to create grouping segments. |
|  enableDefaultGroupHeaders | boolean | No | The value indicating whether to enable default group headers. |
|  recipientReferencePasswordValue | string | No | The recipient reference password value. |
|  recipientReferencePasswordQualifier | string | No | The recipient reference password qualifier. |
|  applicationReferenceId | string | No | The application reference id. |
|  processingPriorityCode | string | No | The processing priority code. |
|  interchangeControlNumberLowerBound | integer | No | The interchange control number lower bound. |
|  interchangeControlNumberUpperBound | integer | No | The interchange control number upper bound. |
|  rolloverInterchangeControlNumber | boolean | No | The value indicating whether to rollover interchange control number. |
|  interchangeControlNumberPrefix | string | No | The interchange control number prefix. |
|  interchangeControlNumberSuffix | string | No | The interchange control number suffix. |
|  senderReverseRoutingAddress | string | No | The sender reverse routing address. |
|  receiverReverseRoutingAddress | string | No | The receiver reverse routing address. |
|  functionalGroupId | string | No | The functional group id. |
|  groupControllingAgencyCode | string | No | The group controlling agency code. |
|  groupMessageVersion | string | No | The group message version. |
|  groupMessageRelease | string | No | The group message release. |
|  groupControlNumberLowerBound | integer | No | The group control number lower bound. |
|  groupControlNumberUpperBound | integer | No | The group control number upper bound. |
|  rolloverGroupControlNumber | boolean | No | The value indicating whether to rollover group control number. |
|  groupControlNumberPrefix | string | No | The group control number prefix. |
|  groupControlNumberSuffix | string | No | The group control number suffix. |
|  groupApplicationReceiverQualifier | string | No | The group application receiver qualifier. |
|  groupApplicationReceiverId | string | No | The group application receiver id. |
|  groupApplicationSenderQualifier | string | No | The group application sender qualifier. |
|  groupApplicationSenderId | string | No | The group application sender id. |
|  groupApplicationPassword | string | No | The group application password. |
|  overwriteExistingTransactionSetControlNumber | boolean | No | The value indicating whether to overwrite existing transaction set control number. |
|  transactionSetControlNumberPrefix | string | No | The transaction set control number prefix. |
|  transactionSetControlNumberSuffix | string | No | The transaction set control number suffix. |
|  transactionSetControlNumberLowerBound | integer | No | The transaction set control number lower bound. |
|  transactionSetControlNumberUpperBound | integer | No | The transaction set control number upper bound. |
|  rolloverTransactionSetControlNumber | boolean | No | The value indicating whether to rollover transaction set control number. |
|  isTestInterchange | boolean | No | The value indicating whether the message is a test interchange. |
|  senderInternalIdentification | string | No | The sender internal identification. |
|  senderInternalSubIdentification | string | No | The sender internal sub identification. |
|  receiverInternalIdentification | string | No | The receiver internal identification. |
|  receiverInternalSubIdentification | string | No | The receiver internal sub identification. |


<a id="EdifactAcknowledgementSettings" />
### EdifactAcknowledgementSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  needTechnicalAcknowledgement | boolean | No | The value indicating whether technical acknowledgement is needed. |
|  batchTechnicalAcknowledgements | boolean | No | The value indicating whether to batch the technical acknowledgements. |
|  needFunctionalAcknowledgement | boolean | No | The value indicating whether functional acknowledgement is needed. |
|  batchFunctionalAcknowledgements | boolean | No | The value indicating whether to batch functional acknowledgements. |
|  needLoopForValidMessages | boolean | No | The value indicating whether a loop is needed for valid messages. |
|  sendSynchronousAcknowledgement | boolean | No | The value indicating whether to send synchronous acknowledgement. |
|  acknowledgementControlNumberPrefix | string | No | The acknowledgement control number prefix. |
|  acknowledgementControlNumberSuffix | string | No | The acknowledgement control number suffix. |
|  acknowledgementControlNumberLowerBound | integer | No | The acknowledgement control number lower bound. |
|  acknowledgementControlNumberUpperBound | integer | No | The acknowledgement control number upper bound. |
|  rolloverAcknowledgementControlNumber | boolean | No | The value indicating whether to rollover acknowledgement control number. |


<a id="EdifactMessageFilter" />
### EdifactMessageFilter object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageFilterType | enum | No | The message filter type. - NotSpecified, Include, Exclude |


<a id="EdifactProcessingSettings" />
### EdifactProcessingSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maskSecurityInfo | boolean | No | The value indicating whether to mask security information. |
|  preserveInterchange | boolean | No | The value indicating whether to preserve interchange. |
|  suspendInterchangeOnError | boolean | No | The value indicating whether to suspend interchange on error. |
|  createEmptyXmlTagsForTrailingSeparators | boolean | No | The value indicating whether to create empty xml tags for trailing separators. |
|  useDotAsDecimalSeparator | boolean | No | The value indicating whether to use dot as decimal separator. |


<a id="EdifactEnvelopeOverride" />
### EdifactEnvelopeOverride object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id on which this envelope settings has to be applied. |
|  messageVersion | string | No | The message version on which this envelope settings has to be applied. |
|  messageRelease | string | No | The message release version on which this envelope settings has to be applied. |
|  messageAssociationAssignedCode | string | No | The message association assigned code. |
|  targetNamespace | string | No | The target namespace on which this envelope settings has to be applied. |
|  functionalGroupId | string | No | The functional group id. |
|  senderApplicationQualifier | string | No | The sender application qualifier. |
|  senderApplicationId | string | No | The sender application id. |
|  receiverApplicationQualifier | string | No | The receiver application qualifier. |
|  receiverApplicationId | string | No | The receiver application id. |
|  controllingAgencyCode | string | No | The controlling agency code. |
|  groupHeaderMessageVersion | string | No | The group header message version. |
|  groupHeaderMessageRelease | string | No | The group header message release. |
|  associationAssignedCode | string | No | The association assigned code. |
|  applicationPassword | string | No | The application password. |


<a id="EdifactMessageIdentifier" />
### EdifactMessageIdentifier object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id on which this envelope settings has to be applied. |


<a id="EdifactSchemaReference" />
### EdifactSchemaReference object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id. |
|  messageVersion | string | No | The message version. |
|  messageRelease | string | No | The message release version. |
|  senderApplicationId | string | No | The sender application id. |
|  senderApplicationQualifier | string | No | The sender application qualifier. |
|  associationAssignedCode | string | No | The association assigned code. |
|  schemaName | string | No | The schema name. |


<a id="EdifactValidationOverride" />
### EdifactValidationOverride object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id on which the validation settings has to be applied. |
|  enforceCharacterSet | boolean | No | The value indicating whether to validate character Set. |
|  validateEDITypes | boolean | No | The value indicating whether to validate EDI types. |
|  validateXSDTypes | boolean | No | The value indicating whether to validate XSD types. |
|  allowLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to allow leading and trailing spaces and zeroes. |
|  trailingSeparatorPolicy | enum | No | The trailing separator policy. - NotSpecified, NotAllowed, Optional, Mandatory |
|  trimLeadingAndTrailingSpacesAndZeroes | boolean | No | The value indicating whether to trim leading and trailing spaces and zeroes. |


<a id="EdifactDelimiterOverride" />
### EdifactDelimiterOverride object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  messageId | string | No | The message id. |
|  messageVersion | string | No | The message version. |
|  messageRelease | string | No | The message releaseversion. |
|  dataElementSeparator | integer | No | The data element separator. |
|  componentSeparator | integer | No | The component separator. |
|  segmentTerminator | integer | No | The segment terminator. |
|  repetitionSeparator | integer | No | The repetition separator. |
|  segmentTerminatorSuffix | enum | No | The segment terminator suffix. - NotSpecified, None, CR, LF, CRLF |
|  decimalPointIndicator | enum | No | The decimal point indicator. - NotSpecified, Comma, Decimal |
|  releaseIndicator | integer | No | The release indicator. |
|  messageAssociationAssignedCode | string | No | The message association assigned code. |
|  targetNamespace | string | No | The target namespace on which this delimiter settings has to be applied. |

