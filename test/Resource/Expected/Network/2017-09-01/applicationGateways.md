# Microsoft.Network/applicationGateways template reference
API Version: 2017-09-01
## Template format

To create a Microsoft.Network/applicationGateways resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Network/applicationGateways",
  "apiVersion": "2017-09-01",
  "id": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "sku": {
      "name": "string",
      "tier": "string",
      "capacity": "integer"
    },
    "sslPolicy": {
      "disabledSslProtocols": [
        "string"
      ],
      "policyType": "string",
      "policyName": "string",
      "cipherSuites": [
        "string"
      ],
      "minProtocolVersion": "string"
    },
    "gatewayIPConfigurations": [
      {
        "id": "string",
        "properties": {
          "subnet": {
            "id": "string"
          },
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "authenticationCertificates": [
      {
        "id": "string",
        "properties": {
          "data": "string",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "sslCertificates": [
      {
        "id": "string",
        "properties": {
          "data": "string",
          "password": "string",
          "publicCertData": "string",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "frontendIPConfigurations": [
      {
        "id": "string",
        "properties": {
          "privateIPAddress": "string",
          "privateIPAllocationMethod": "string",
          "subnet": {
            "id": "string"
          },
          "publicIPAddress": {
            "id": "string"
          },
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "frontendPorts": [
      {
        "id": "string",
        "properties": {
          "port": "integer",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "probes": [
      {
        "id": "string",
        "properties": {
          "protocol": "string",
          "host": "string",
          "path": "string",
          "interval": "integer",
          "timeout": "integer",
          "unhealthyThreshold": "integer",
          "pickHostNameFromBackendHttpSettings": boolean,
          "minServers": "integer",
          "match": {
            "body": "string",
            "statusCodes": [
              "string"
            ]
          },
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "backendAddressPools": [
      {
        "id": "string",
        "properties": {
          "backendIPConfigurations": [
            {
              "id": "string",
              "properties": {
                "applicationGatewayBackendAddressPools": [
                  "ApplicationGatewayBackendAddressPool"
                ],
                "loadBalancerBackendAddressPools": [
                  {
                    "id": "string",
                    "properties": {
                      "provisioningState": "string"
                    },
                    "name": "string",
                    "etag": "string"
                  }
                ],
                "loadBalancerInboundNatRules": [
                  {
                    "id": "string",
                    "properties": {
                      "frontendIPConfiguration": {
                        "id": "string"
                      },
                      "protocol": "string",
                      "frontendPort": "integer",
                      "backendPort": "integer",
                      "idleTimeoutInMinutes": "integer",
                      "enableFloatingIP": boolean,
                      "provisioningState": "string"
                    },
                    "name": "string",
                    "etag": "string"
                  }
                ],
                "privateIPAddress": "string",
                "privateIPAllocationMethod": "string",
                "privateIPAddressVersion": "string",
                "subnet": {
                  "id": "string",
                  "properties": {
                    "addressPrefix": "string",
                    "networkSecurityGroup": {
                      "id": "string",
                      "location": "string",
                      "tags": {},
                      "properties": {
                        "securityRules": [
                          {
                            "id": "string",
                            "properties": {
                              "description": "string",
                              "protocol": "string",
                              "sourcePortRange": "string",
                              "destinationPortRange": "string",
                              "sourceAddressPrefix": "string",
                              "sourceAddressPrefixes": [
                                "string"
                              ],
                              "sourceApplicationSecurityGroups": [
                                {
                                  "id": "string",
                                  "location": "string",
                                  "tags": {},
                                  "properties": {}
                                }
                              ],
                              "destinationAddressPrefix": "string",
                              "destinationAddressPrefixes": [
                                "string"
                              ],
                              "destinationApplicationSecurityGroups": [
                                {
                                  "id": "string",
                                  "location": "string",
                                  "tags": {},
                                  "properties": {}
                                }
                              ],
                              "sourcePortRanges": [
                                "string"
                              ],
                              "destinationPortRanges": [
                                "string"
                              ],
                              "access": "string",
                              "priority": "integer",
                              "direction": "string",
                              "provisioningState": "string"
                            },
                            "name": "string",
                            "etag": "string"
                          }
                        ],
                        "defaultSecurityRules": [
                          {
                            "id": "string",
                            "properties": {
                              "description": "string",
                              "protocol": "string",
                              "sourcePortRange": "string",
                              "destinationPortRange": "string",
                              "sourceAddressPrefix": "string",
                              "sourceAddressPrefixes": [
                                "string"
                              ],
                              "sourceApplicationSecurityGroups": [
                                {
                                  "id": "string",
                                  "location": "string",
                                  "tags": {},
                                  "properties": {}
                                }
                              ],
                              "destinationAddressPrefix": "string",
                              "destinationAddressPrefixes": [
                                "string"
                              ],
                              "destinationApplicationSecurityGroups": [
                                {
                                  "id": "string",
                                  "location": "string",
                                  "tags": {},
                                  "properties": {}
                                }
                              ],
                              "sourcePortRanges": [
                                "string"
                              ],
                              "destinationPortRanges": [
                                "string"
                              ],
                              "access": "string",
                              "priority": "integer",
                              "direction": "string",
                              "provisioningState": "string"
                            },
                            "name": "string",
                            "etag": "string"
                          }
                        ],
                        "resourceGuid": "string",
                        "provisioningState": "string"
                      },
                      "etag": "string"
                    },
                    "routeTable": {
                      "id": "string",
                      "location": "string",
                      "tags": {},
                      "properties": {
                        "routes": [
                          {
                            "id": "string",
                            "properties": {
                              "addressPrefix": "string",
                              "nextHopType": "string",
                              "nextHopIpAddress": "string",
                              "provisioningState": "string"
                            },
                            "name": "string",
                            "etag": "string"
                          }
                        ],
                        "provisioningState": "string"
                      },
                      "etag": "string"
                    },
                    "serviceEndpoints": [
                      {
                        "service": "string",
                        "locations": [
                          "string"
                        ],
                        "provisioningState": "string"
                      }
                    ],
                    "resourceNavigationLinks": [
                      {
                        "id": "string",
                        "properties": {
                          "linkedResourceType": "string",
                          "link": "string"
                        },
                        "name": "string"
                      }
                    ],
                    "provisioningState": "string"
                  },
                  "name": "string",
                  "etag": "string"
                },
                "primary": boolean,
                "publicIPAddress": {
                  "id": "string",
                  "location": "string",
                  "tags": {},
                  "sku": {
                    "name": "string"
                  },
                  "properties": {
                    "publicIPAllocationMethod": "string",
                    "publicIPAddressVersion": "string",
                    "dnsSettings": {
                      "domainNameLabel": "string",
                      "fqdn": "string",
                      "reverseFqdn": "string"
                    },
                    "ipAddress": "string",
                    "idleTimeoutInMinutes": "integer",
                    "resourceGuid": "string",
                    "provisioningState": "string"
                  },
                  "etag": "string",
                  "zones": [
                    "string"
                  ]
                },
                "applicationSecurityGroups": [
                  {
                    "id": "string",
                    "location": "string",
                    "tags": {},
                    "properties": {}
                  }
                ],
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string"
            }
          ],
          "backendAddresses": [
            {
              "fqdn": "string",
              "ipAddress": "string"
            }
          ],
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "backendHttpSettingsCollection": [
      {
        "id": "string",
        "properties": {
          "port": "integer",
          "protocol": "string",
          "cookieBasedAffinity": "string",
          "requestTimeout": "integer",
          "probe": {
            "id": "string"
          },
          "authenticationCertificates": [
            {
              "id": "string"
            }
          ],
          "connectionDraining": {
            "enabled": boolean,
            "drainTimeoutInSec": "integer"
          },
          "hostName": "string",
          "pickHostNameFromBackendAddress": boolean,
          "affinityCookieName": "string",
          "probeEnabled": boolean,
          "path": "string",
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "httpListeners": [
      {
        "id": "string",
        "properties": {
          "frontendIPConfiguration": {
            "id": "string"
          },
          "frontendPort": {
            "id": "string"
          },
          "protocol": "string",
          "hostName": "string",
          "sslCertificate": {
            "id": "string"
          },
          "requireServerNameIndication": boolean,
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "urlPathMaps": [
      {
        "id": "string",
        "properties": {
          "defaultBackendAddressPool": {
            "id": "string"
          },
          "defaultBackendHttpSettings": {
            "id": "string"
          },
          "defaultRedirectConfiguration": {
            "id": "string"
          },
          "pathRules": [
            {
              "id": "string",
              "properties": {
                "paths": [
                  "string"
                ],
                "backendAddressPool": {
                  "id": "string"
                },
                "backendHttpSettings": {
                  "id": "string"
                },
                "redirectConfiguration": {
                  "id": "string"
                },
                "provisioningState": "string"
              },
              "name": "string",
              "etag": "string",
              "type": "string"
            }
          ],
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "requestRoutingRules": [
      {
        "id": "string",
        "properties": {
          "ruleType": "string",
          "backendAddressPool": {
            "id": "string"
          },
          "backendHttpSettings": {
            "id": "string"
          },
          "httpListener": {
            "id": "string"
          },
          "urlPathMap": {
            "id": "string"
          },
          "redirectConfiguration": {
            "id": "string"
          },
          "provisioningState": "string"
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "redirectConfigurations": [
      {
        "id": "string",
        "properties": {
          "redirectType": "string",
          "targetListener": {
            "id": "string"
          },
          "targetUrl": "string",
          "includePath": boolean,
          "includeQueryString": boolean,
          "requestRoutingRules": [
            {
              "id": "string"
            }
          ],
          "urlPathMaps": [
            {
              "id": "string"
            }
          ],
          "pathRules": [
            {
              "id": "string"
            }
          ]
        },
        "name": "string",
        "etag": "string",
        "type": "string"
      }
    ],
    "webApplicationFirewallConfiguration": {
      "enabled": boolean,
      "firewallMode": "string",
      "ruleSetType": "string",
      "ruleSetVersion": "string",
      "disabledRuleGroups": [
        {
          "ruleGroupName": "string",
          "rules": [
            "integer"
          ]
        }
      ]
    },
    "resourceGuid": "string",
    "provisioningState": "string"
  },
  "etag": "string"
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Network/applicationGateways" />
### Microsoft.Network/applicationGateways object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Network/applicationGateways |
|  apiVersion | enum | Yes | 2017-09-01 |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | [ApplicationGatewayPropertiesFormat object](#ApplicationGatewayPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="ApplicationGatewayPropertiesFormat" />
### ApplicationGatewayPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  sku | object | No | SKU of the application gateway resource. - [ApplicationGatewaySku object](#ApplicationGatewaySku) |
|  sslPolicy | object | No | SSL policy of the application gateway resource. - [ApplicationGatewaySslPolicy object](#ApplicationGatewaySslPolicy) |
|  gatewayIPConfigurations | array | No | Subnets of application the gateway resource. - [ApplicationGatewayIPConfiguration object](#ApplicationGatewayIPConfiguration) |
|  authenticationCertificates | array | No | Authentication certificates of the application gateway resource. - [ApplicationGatewayAuthenticationCertificate object](#ApplicationGatewayAuthenticationCertificate) |
|  sslCertificates | array | No | SSL certificates of the application gateway resource. - [ApplicationGatewaySslCertificate object](#ApplicationGatewaySslCertificate) |
|  frontendIPConfigurations | array | No | Frontend IP addresses of the application gateway resource. - [ApplicationGatewayFrontendIPConfiguration object](#ApplicationGatewayFrontendIPConfiguration) |
|  frontendPorts | array | No | Frontend ports of the application gateway resource. - [ApplicationGatewayFrontendPort object](#ApplicationGatewayFrontendPort) |
|  probes | array | No | Probes of the application gateway resource. - [ApplicationGatewayProbe object](#ApplicationGatewayProbe) |
|  backendAddressPools | array | No | Backend address pool of the application gateway resource. - [ApplicationGatewayBackendAddressPool object](#ApplicationGatewayBackendAddressPool) |
|  backendHttpSettingsCollection | array | No | Backend http settings of the application gateway resource. - [ApplicationGatewayBackendHttpSettings object](#ApplicationGatewayBackendHttpSettings) |
|  httpListeners | array | No | Http listeners of the application gateway resource. - [ApplicationGatewayHttpListener object](#ApplicationGatewayHttpListener) |
|  urlPathMaps | array | No | URL path map of the application gateway resource. - [ApplicationGatewayUrlPathMap object](#ApplicationGatewayUrlPathMap) |
|  requestRoutingRules | array | No | Request routing rules of the application gateway resource. - [ApplicationGatewayRequestRoutingRule object](#ApplicationGatewayRequestRoutingRule) |
|  redirectConfigurations | array | No | Redirect configurations of the application gateway resource. - [ApplicationGatewayRedirectConfiguration object](#ApplicationGatewayRedirectConfiguration) |
|  webApplicationFirewallConfiguration | object | No | Web application firewall configuration. - [ApplicationGatewayWebApplicationFirewallConfiguration object](#ApplicationGatewayWebApplicationFirewallConfiguration) |
|  resourceGuid | string | No | Resource GUID property of the application gateway resource. |
|  provisioningState | string | No | Provisioning state of the application gateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewaySku" />
### ApplicationGatewaySku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Name of an application gateway SKU. - Standard_Small, Standard_Medium, Standard_Large, WAF_Medium, WAF_Large |
|  tier | enum | No | Tier of an application gateway. - Standard or WAF |
|  capacity | integer | No | Capacity (instance count) of an application gateway. |


<a id="ApplicationGatewaySslPolicy" />
### ApplicationGatewaySslPolicy object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  disabledSslProtocols | array | No | Ssl protocols to be disabled on application gateway. - TLSv1_0, TLSv1_1, TLSv1_2 |
|  policyType | enum | No | Type of Ssl Policy. - Predefined or Custom |
|  policyName | enum | No | Name of Ssl predefined policy. - AppGwSslPolicy20150501, AppGwSslPolicy20170401, AppGwSslPolicy20170401S |
|  cipherSuites | array | No | Ssl cipher suites to be enabled in the specified order to application gateway. - TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_3DES_EDE_CBC_SHA |
|  minProtocolVersion | enum | No | Minimum version of Ssl protocol to be supported on application gateway. - TLSv1_0, TLSv1_1, TLSv1_2 |


<a id="ApplicationGatewayIPConfiguration" />
### ApplicationGatewayIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayIPConfigurationPropertiesFormat object](#ApplicationGatewayIPConfigurationPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayAuthenticationCertificate" />
### ApplicationGatewayAuthenticationCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayAuthenticationCertificatePropertiesFormat object](#ApplicationGatewayAuthenticationCertificatePropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewaySslCertificate" />
### ApplicationGatewaySslCertificate object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewaySslCertificatePropertiesFormat object](#ApplicationGatewaySslCertificatePropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayFrontendIPConfiguration" />
### ApplicationGatewayFrontendIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayFrontendIPConfigurationPropertiesFormat object](#ApplicationGatewayFrontendIPConfigurationPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayFrontendPort" />
### ApplicationGatewayFrontendPort object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayFrontendPortPropertiesFormat object](#ApplicationGatewayFrontendPortPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayProbe" />
### ApplicationGatewayProbe object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayProbePropertiesFormat object](#ApplicationGatewayProbePropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayBackendAddressPool" />
### ApplicationGatewayBackendAddressPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayBackendAddressPoolPropertiesFormat object](#ApplicationGatewayBackendAddressPoolPropertiesFormat) |
|  name | string | No | Resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayBackendHttpSettings" />
### ApplicationGatewayBackendHttpSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayBackendHttpSettingsPropertiesFormat object](#ApplicationGatewayBackendHttpSettingsPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayHttpListener" />
### ApplicationGatewayHttpListener object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayHttpListenerPropertiesFormat object](#ApplicationGatewayHttpListenerPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayUrlPathMap" />
### ApplicationGatewayUrlPathMap object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayUrlPathMapPropertiesFormat object](#ApplicationGatewayUrlPathMapPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayRequestRoutingRule" />
### ApplicationGatewayRequestRoutingRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayRequestRoutingRulePropertiesFormat object](#ApplicationGatewayRequestRoutingRulePropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayRedirectConfiguration" />
### ApplicationGatewayRedirectConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayRedirectConfigurationPropertiesFormat object](#ApplicationGatewayRedirectConfigurationPropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="ApplicationGatewayWebApplicationFirewallConfiguration" />
### ApplicationGatewayWebApplicationFirewallConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | Yes | Whether the web application firewall is enabled or not. |
|  firewallMode | enum | Yes | Web application firewall mode. - Detection or Prevention |
|  ruleSetType | string | Yes | The type of the web application firewall rule set. Possible values are: 'OWASP'. |
|  ruleSetVersion | string | Yes | The version of the rule set type. |
|  disabledRuleGroups | array | No | The disabled rule groups. - [ApplicationGatewayFirewallDisabledRuleGroup object](#ApplicationGatewayFirewallDisabledRuleGroup) |


<a id="ApplicationGatewayIPConfigurationPropertiesFormat" />
### ApplicationGatewayIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  subnet | object | No | Reference of the subnet resource. A subnet from where application gateway gets its private address. - [SubResource object](#SubResource) |
|  provisioningState | string | No | Provisioning state of the application gateway subnet resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayAuthenticationCertificatePropertiesFormat" />
### ApplicationGatewayAuthenticationCertificatePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  data | string | No | Certificate public data. |
|  provisioningState | string | No | Provisioning state of the authentication certificate resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewaySslCertificatePropertiesFormat" />
### ApplicationGatewaySslCertificatePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  data | string | No | Base-64 encoded pfx certificate. Only applicable in PUT Request. |
|  password | string | No | Password for the pfx file specified in data. Only applicable in PUT request. |
|  publicCertData | string | No | Base-64 encoded Public cert data corresponding to pfx specified in data. Only applicable in GET request. |
|  provisioningState | string | No | Provisioning state of the SSL certificate resource Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayFrontendIPConfigurationPropertiesFormat" />
### ApplicationGatewayFrontendIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  privateIPAddress | string | No | PrivateIPAddress of the network interface IP Configuration. |
|  privateIPAllocationMethod | enum | No | PrivateIP allocation method. - Static or Dynamic |
|  subnet | object | No | Reference of the subnet resource. - [SubResource object](#SubResource) |
|  publicIPAddress | object | No | Reference of the PublicIP resource. - [SubResource object](#SubResource) |
|  provisioningState | string | No | Provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayFrontendPortPropertiesFormat" />
### ApplicationGatewayFrontendPortPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  port | integer | No | Frontend port |
|  provisioningState | string | No | Provisioning state of the frontend port resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayProbePropertiesFormat" />
### ApplicationGatewayProbePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  protocol | enum | No | Protocol. - Http or Https |
|  host | string | No | Host name to send the probe to. |
|  path | string | No | Relative path of probe. Valid path starts from '/'. Probe is sent to <Protocol>://<host>:<port><path> |
|  interval | integer | No | The probing interval in seconds. This is the time interval between two consecutive probes. Acceptable values are from 1 second to 86400 seconds. |
|  timeout | integer | No | the probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds. |
|  unhealthyThreshold | integer | No | The probe retry count. Backend server is marked down after consecutive probe failure count reaches UnhealthyThreshold. Acceptable values are from 1 second to 20. |
|  pickHostNameFromBackendHttpSettings | boolean | No | Whether the host header should be picked from the backend http settings. Default value is false. |
|  minServers | integer | No | Minimum number of servers that are always marked healthy. Default value is 0. |
|  match | object | No | Criterion for classifying a healthy probe response. - [ApplicationGatewayProbeHealthResponseMatch object](#ApplicationGatewayProbeHealthResponseMatch) |
|  provisioningState | string | No | Provisioning state of the backend http settings resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayBackendAddressPoolPropertiesFormat" />
### ApplicationGatewayBackendAddressPoolPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  backendIPConfigurations | array | No | Collection of references to IPs defined in network interfaces. - [NetworkInterfaceIPConfiguration object](#NetworkInterfaceIPConfiguration) |
|  backendAddresses | array | No | Backend addresses - [ApplicationGatewayBackendAddress object](#ApplicationGatewayBackendAddress) |
|  provisioningState | string | No | Provisioning state of the backend address pool resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayBackendHttpSettingsPropertiesFormat" />
### ApplicationGatewayBackendHttpSettingsPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  port | integer | No | Port |
|  protocol | enum | No | Protocol. - Http or Https |
|  cookieBasedAffinity | enum | No | Cookie based affinity. - Enabled or Disabled |
|  requestTimeout | integer | No | Request timeout in seconds. Application Gateway will fail the request if response is not received within RequestTimeout. Acceptable values are from 1 second to 86400 seconds. |
|  probe | object | No | Probe resource of an application gateway. - [SubResource object](#SubResource) |
|  authenticationCertificates | array | No | Array of references to application gateway authentication certificates. - [SubResource object](#SubResource) |
|  connectionDraining | object | No | Connection draining of the backend http settings resource. - [ApplicationGatewayConnectionDraining object](#ApplicationGatewayConnectionDraining) |
|  hostName | string | No | Host header to be sent to the backend servers. |
|  pickHostNameFromBackendAddress | boolean | No | Whether to pick host header should be picked from the host name of the backend server. Default value is false. |
|  affinityCookieName | string | No | Cookie name to use for the affinity cookie. |
|  probeEnabled | boolean | No | Whether the probe is enabled. Default value is false. |
|  path | string | No | Path which should be used as a prefix for all HTTP requests. Null means no path will be prefixed. Default value is null. |
|  provisioningState | string | No | Provisioning state of the backend http settings resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayHttpListenerPropertiesFormat" />
### ApplicationGatewayHttpListenerPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfiguration | object | No | Frontend IP configuration resource of an application gateway. - [SubResource object](#SubResource) |
|  frontendPort | object | No | Frontend port resource of an application gateway. - [SubResource object](#SubResource) |
|  protocol | enum | No | Protocol. - Http or Https |
|  hostName | string | No | Host name of HTTP listener. |
|  sslCertificate | object | No | SSL certificate resource of an application gateway. - [SubResource object](#SubResource) |
|  requireServerNameIndication | boolean | No | Applicable only if protocol is https. Enables SNI for multi-hosting. |
|  provisioningState | string | No | Provisioning state of the HTTP listener resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayUrlPathMapPropertiesFormat" />
### ApplicationGatewayUrlPathMapPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  defaultBackendAddressPool | object | No | Default backend address pool resource of URL path map. - [SubResource object](#SubResource) |
|  defaultBackendHttpSettings | object | No | Default backend http settings resource of URL path map. - [SubResource object](#SubResource) |
|  defaultRedirectConfiguration | object | No | Default redirect configuration resource of URL path map. - [SubResource object](#SubResource) |
|  pathRules | array | No | Path rule of URL path map resource. - [ApplicationGatewayPathRule object](#ApplicationGatewayPathRule) |
|  provisioningState | string | No | Provisioning state of the backend http settings resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayRequestRoutingRulePropertiesFormat" />
### ApplicationGatewayRequestRoutingRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ruleType | enum | No | Rule type. - Basic or PathBasedRouting |
|  backendAddressPool | object | No | Backend address pool resource of the application gateway.  - [SubResource object](#SubResource) |
|  backendHttpSettings | object | No | Frontend port resource of the application gateway. - [SubResource object](#SubResource) |
|  httpListener | object | No | Http listener resource of the application gateway.  - [SubResource object](#SubResource) |
|  urlPathMap | object | No | URL path map resource of the application gateway. - [SubResource object](#SubResource) |
|  redirectConfiguration | object | No | Redirect configuration resource of the application gateway. - [SubResource object](#SubResource) |
|  provisioningState | string | No | Provisioning state of the request routing rule resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayRedirectConfigurationPropertiesFormat" />
### ApplicationGatewayRedirectConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  redirectType | enum | No | Supported http redirection types - Permanent, Temporary, Found, SeeOther. - Permanent, Found, SeeOther, Temporary |
|  targetListener | object | No | Reference to a listener to redirect the request to. - [SubResource object](#SubResource) |
|  targetUrl | string | No | Url to redirect the request to. |
|  includePath | boolean | No | Include path in the redirected url. |
|  includeQueryString | boolean | No | Include query string in the redirected url. |
|  requestRoutingRules | array | No | Request routing specifying redirect configuration. - [SubResource object](#SubResource) |
|  urlPathMaps | array | No | Url path maps specifying default redirect configuration. - [SubResource object](#SubResource) |
|  pathRules | array | No | Path rules specifying redirect configuration. - [SubResource object](#SubResource) |


<a id="ApplicationGatewayFirewallDisabledRuleGroup" />
### ApplicationGatewayFirewallDisabledRuleGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ruleGroupName | string | Yes | The name of the rule group that will be disabled. |
|  rules | array | No | The list of rules that will be disabled. If null, all rules of the rule group will be disabled. - integer |


<a id="SubResource" />
### SubResource object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |


<a id="ApplicationGatewayProbeHealthResponseMatch" />
### ApplicationGatewayProbeHealthResponseMatch object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  body | string | No | Body that must be contained in the health response. Default value is empty. |
|  statusCodes | array | No | Allowed ranges of healthy status codes. Default range of healthy status codes is 200-399. - string |


<a id="NetworkInterfaceIPConfiguration" />
### NetworkInterfaceIPConfiguration object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Network interface IP configuration properties. - [NetworkInterfaceIPConfigurationPropertiesFormat object](#NetworkInterfaceIPConfigurationPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="ApplicationGatewayBackendAddress" />
### ApplicationGatewayBackendAddress object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  fqdn | string | No | Fully qualified domain name (FQDN). |
|  ipAddress | string | No | IP address |


<a id="ApplicationGatewayConnectionDraining" />
### ApplicationGatewayConnectionDraining object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | Yes | Whether connection draining is enabled or not. |
|  drainTimeoutInSec | integer | Yes | The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds. |


<a id="ApplicationGatewayPathRule" />
### ApplicationGatewayPathRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | [ApplicationGatewayPathRulePropertiesFormat object](#ApplicationGatewayPathRulePropertiesFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  type | string | No | Type of the resource. |


<a id="NetworkInterfaceIPConfigurationPropertiesFormat" />
### NetworkInterfaceIPConfigurationPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  applicationGatewayBackendAddressPools | array | No | The reference of ApplicationGatewayBackendAddressPool resource. - [ApplicationGatewayBackendAddressPool object](#ApplicationGatewayBackendAddressPool) |
|  loadBalancerBackendAddressPools | array | No | The reference of LoadBalancerBackendAddressPool resource. - [BackendAddressPool object](#BackendAddressPool) |
|  loadBalancerInboundNatRules | array | No | A list of references of LoadBalancerInboundNatRules. - [InboundNatRule object](#InboundNatRule) |
|  privateIPAddress | string | No | Private IP address of the IP configuration. |
|  privateIPAllocationMethod | enum | No | Defines how a private IP address is assigned. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  privateIPAddressVersion | enum | No | Available from Api-Version 2016-03-30 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: 'IPv4' and 'IPv6'. - IPv4 or IPv6 |
|  subnet | object | No | Subnet bound to the IP configuration. - [Subnet object](#Subnet) |
|  primary | boolean | No | Gets whether this is a primary customer address on the network interface. |
|  publicIPAddress | object | No | Public IP address bound to the IP configuration. - [PublicIPAddress object](#PublicIPAddress) |
|  applicationSecurityGroups | array | No | Application security groups in which the IP configuration is included. - [ApplicationSecurityGroup object](#ApplicationSecurityGroup) |
|  provisioningState | string | No | The provisioning state of the network interface IP configuration. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ApplicationGatewayPathRulePropertiesFormat" />
### ApplicationGatewayPathRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  paths | array | No | Path rules of URL path map. - string |
|  backendAddressPool | object | No | Backend address pool resource of URL path map path rule. - [SubResource object](#SubResource) |
|  backendHttpSettings | object | No | Backend http settings resource of URL path map path rule. - [SubResource object](#SubResource) |
|  redirectConfiguration | object | No | Redirect configuration resource of URL path map path rule. - [SubResource object](#SubResource) |
|  provisioningState | string | No | Path rule of URL path map resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="BackendAddressPool" />
### BackendAddressPool object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of load balancer backend address pool. - [BackendAddressPoolPropertiesFormat object](#BackendAddressPoolPropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="InboundNatRule" />
### InboundNatRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of load balancer inbound nat rule. - [InboundNatRulePropertiesFormat object](#InboundNatRulePropertiesFormat) |
|  name | string | No | Gets name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="Subnet" />
### Subnet object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of the subnet. - [SubnetPropertiesFormat object](#SubnetPropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="PublicIPAddress" />
### PublicIPAddress object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  sku | object | No | The public IP address SKU. - [PublicIPAddressSku object](#PublicIPAddressSku) |
|  properties | object | No | Public IP address properties. - [PublicIPAddressPropertiesFormat object](#PublicIPAddressPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |
|  zones | array | No | A list of availability zones denoting the IP allocated for the resource needs to come from. - string |


<a id="ApplicationSecurityGroup" />
### ApplicationSecurityGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | Properties of the application security group. - [ApplicationSecurityGroupPropertiesFormat object](#ApplicationSecurityGroupPropertiesFormat) |


<a id="BackendAddressPoolPropertiesFormat" />
### BackendAddressPoolPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  provisioningState | string | No | Get provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="InboundNatRulePropertiesFormat" />
### InboundNatRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  frontendIPConfiguration | object | No | A reference to frontend IP addresses. - [SubResource object](#SubResource) |
|  protocol | enum | No | Udp, Tcp, All |
|  frontendPort | integer | No | The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. |
|  backendPort | integer | No | The port used for the internal endpoint. Acceptable values range from 1 to 65535. |
|  idleTimeoutInMinutes | integer | No | The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. |
|  enableFloatingIP | boolean | No | Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint. |
|  provisioningState | string | No | Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="SubnetPropertiesFormat" />
### SubnetPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The address prefix for the subnet. |
|  networkSecurityGroup | object | No | The reference of the NetworkSecurityGroup resource. - [NetworkSecurityGroup object](#NetworkSecurityGroup) |
|  routeTable | object | No | The reference of the RouteTable resource. - [RouteTable object](#RouteTable) |
|  serviceEndpoints | array | No | An array of service endpoints. - [ServiceEndpointPropertiesFormat object](#ServiceEndpointPropertiesFormat) |
|  resourceNavigationLinks | array | No | Gets an array of references to the external resources using subnet. - [ResourceNavigationLink object](#ResourceNavigationLink) |
|  provisioningState | string | No | The provisioning state of the resource. |


<a id="PublicIPAddressSku" />
### PublicIPAddressSku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | No | Name of a public IP address SKU. - Basic or Standard |


<a id="PublicIPAddressPropertiesFormat" />
### PublicIPAddressPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  publicIPAllocationMethod | enum | No | The public IP allocation method. Possible values are: 'Static' and 'Dynamic'. - Static or Dynamic |
|  publicIPAddressVersion | enum | No | The public IP address version. Possible values are: 'IPv4' and 'IPv6'. - IPv4 or IPv6 |
|  dnsSettings | object | No | The FQDN of the DNS record associated with the public IP address. - [PublicIPAddressDnsSettings object](#PublicIPAddressDnsSettings) |
|  ipAddress | string | No | The IP address associated with the public IP address resource. |
|  idleTimeoutInMinutes | integer | No | The idle timeout of the public IP address. |
|  resourceGuid | string | No | The resource GUID property of the public IP resource. |
|  provisioningState | string | No | The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="NetworkSecurityGroup" />
### NetworkSecurityGroup object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | Properties of the network security group - [NetworkSecurityGroupPropertiesFormat object](#NetworkSecurityGroupPropertiesFormat) |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="RouteTable" />
### RouteTable object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  location | string | No | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | No | Properties of the route table. - [RouteTablePropertiesFormat object](#RouteTablePropertiesFormat) |
|  etag | string | No | Gets a unique read-only string that changes whenever the resource is updated. |


<a id="ServiceEndpointPropertiesFormat" />
### ServiceEndpointPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  service | string | No | The type of the endpoint service. |
|  locations | array | No | A list of locations. - string |
|  provisioningState | string | No | The provisioning state of the resource. |


<a id="ResourceNavigationLink" />
### ResourceNavigationLink object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Resource navigation link properties format. - [ResourceNavigationLinkFormat object](#ResourceNavigationLinkFormat) |
|  name | string | No | Name of the resource that is unique within a resource group. This name can be used to access the resource. |


<a id="PublicIPAddressDnsSettings" />
### PublicIPAddressDnsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  domainNameLabel | string | No | Gets or sets the Domain name label.The concatenation of the domain name label and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system. |
|  fqdn | string | No | Gets the FQDN, Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone. |
|  reverseFqdn | string | No | Gets or Sets the Reverse FQDN. A user-visible, fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.  |


<a id="NetworkSecurityGroupPropertiesFormat" />
### NetworkSecurityGroupPropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  securityRules | array | No | A collection of security rules of the network security group. - [SecurityRule object](#SecurityRule) |
|  defaultSecurityRules | array | No | The default security rules of network security group. - [SecurityRule object](#SecurityRule) |
|  resourceGuid | string | No | The resource GUID property of the network security group resource. |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="RouteTablePropertiesFormat" />
### RouteTablePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  routes | array | No | Collection of routes contained within a route table. - [Route object](#Route) |
|  provisioningState | string | No | The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="ResourceNavigationLinkFormat" />
### ResourceNavigationLinkFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  linkedResourceType | string | No | Resource type of the linked resource. |
|  link | string | No | Link to the external resource |


<a id="SecurityRule" />
### SecurityRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of the security rule - [SecurityRulePropertiesFormat object](#SecurityRulePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="Route" />
### Route object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID. |
|  properties | object | No | Properties of the route. - [RoutePropertiesFormat object](#RoutePropertiesFormat) |
|  name | string | No | The name of the resource that is unique within a resource group. This name can be used to access the resource. |
|  etag | string | No | A unique read-only string that changes whenever the resource is updated. |


<a id="SecurityRulePropertiesFormat" />
### SecurityRulePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  description | string | No | A description for this rule. Restricted to 140 chars. |
|  protocol | enum | Yes | Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'. - Tcp, Udp, * |
|  sourcePortRange | string | No | The source port or range. Integer or range between 0 and 65535. Asterix '*' can also be used to match all ports. |
|  destinationPortRange | string | No | The destination port or range. Integer or range between 0 and 65535. Asterix '*' can also be used to match all ports. |
|  sourceAddressPrefix | string | No | The CIDR or source IP range. Asterix '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.  |
|  sourceAddressPrefixes | array | No | The CIDR or source IP ranges. - string |
|  sourceApplicationSecurityGroups | array | No | The application security group specified as source. - [ApplicationSecurityGroup object](#ApplicationSecurityGroup) |
|  destinationAddressPrefix | string | No | The destination address prefix. CIDR or destination IP range. Asterix '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. |
|  destinationAddressPrefixes | array | No | The destination address prefixes. CIDR or destination IP ranges. - string |
|  destinationApplicationSecurityGroups | array | No | The application security group specified as destination. - [ApplicationSecurityGroup object](#ApplicationSecurityGroup) |
|  sourcePortRanges | array | No | The source port ranges. - string |
|  destinationPortRanges | array | No | The destination port ranges. - string |
|  access | enum | Yes | The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'. - Allow or Deny |
|  priority | integer | No | The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. |
|  direction | enum | Yes | The direction of the rule. The direction specifies if rule will be evaluated on incoming or outcoming traffic. Possible values are: 'Inbound' and 'Outbound'. - Inbound or Outbound |
|  provisioningState | string | No | The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |


<a id="RoutePropertiesFormat" />
### RoutePropertiesFormat object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  addressPrefix | string | No | The destination CIDR to which the route applies. |
|  nextHopType | enum | Yes | The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'. - VirtualNetworkGateway, VnetLocal, Internet, VirtualAppliance, None |
|  nextHopIpAddress | string | No | The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. |
|  provisioningState | string | No | The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'. |

