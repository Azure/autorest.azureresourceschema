# Microsoft.Web/sites/slots template reference
API Version: 2016-08-01
## Template format

To create a Microsoft.Web/sites/slots resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Web/sites/slots",
  "apiVersion": "2016-08-01",
  "kind": "string",
  "location": "string",
  "tags": {},
  "properties": {
    "enabled": "boolean",
    "hostNameSslStates": [
      {
        "name": "string",
        "sslState": "string",
        "virtualIP": "string",
        "thumbprint": "string",
        "toUpdate": "boolean",
        "hostType": "string"
      }
    ],
    "serverFarmId": "string",
    "reserved": "boolean",
    "siteConfig": {
      "numberOfWorkers": "integer",
      "defaultDocuments": [
        "string"
      ],
      "netFrameworkVersion": "string",
      "phpVersion": "string",
      "pythonVersion": "string",
      "nodeVersion": "string",
      "linuxFxVersion": "string",
      "requestTracingEnabled": "boolean",
      "requestTracingExpirationTime": "string",
      "remoteDebuggingEnabled": "boolean",
      "remoteDebuggingVersion": "string",
      "httpLoggingEnabled": "boolean",
      "logsDirectorySizeLimit": "integer",
      "detailedErrorLoggingEnabled": "boolean",
      "publishingUsername": "string",
      "appSettings": [
        {
          "name": "string",
          "value": "string"
        }
      ],
      "connectionStrings": [
        {
          "name": "string",
          "connectionString": "string",
          "type": "string"
        }
      ],
      "handlerMappings": [
        {
          "extension": "string",
          "scriptProcessor": "string",
          "arguments": "string"
        }
      ],
      "documentRoot": "string",
      "scmType": "string",
      "use32BitWorkerProcess": "boolean",
      "webSocketsEnabled": "boolean",
      "alwaysOn": "boolean",
      "javaVersion": "string",
      "javaContainer": "string",
      "javaContainerVersion": "string",
      "appCommandLine": "string",
      "managedPipelineMode": "string",
      "virtualApplications": [
        {
          "virtualPath": "string",
          "physicalPath": "string",
          "preloadEnabled": "boolean",
          "virtualDirectories": [
            {
              "virtualPath": "string",
              "physicalPath": "string"
            }
          ]
        }
      ],
      "loadBalancing": "string",
      "experiments": {
        "rampUpRules": [
          {
            "actionHostName": "string",
            "reroutePercentage": "number",
            "changeStep": "number",
            "changeIntervalInMinutes": "integer",
            "minReroutePercentage": "number",
            "maxReroutePercentage": "number",
            "changeDecisionCallbackUrl": "string",
            "name": "string"
          }
        ]
      },
      "limits": {
        "maxPercentageCpu": "number",
        "maxMemoryInMb": "integer",
        "maxDiskSizeInMb": "integer"
      },
      "autoHealEnabled": "boolean",
      "autoHealRules": {
        "triggers": {
          "requests": {
            "count": "integer",
            "timeInterval": "string"
          },
          "privateBytesInKB": "integer",
          "statusCodes": [
            {
              "status": "integer",
              "subStatus": "integer",
              "win32Status": "integer",
              "count": "integer",
              "timeInterval": "string"
            }
          ],
          "slowRequests": {
            "timeTaken": "string",
            "count": "integer",
            "timeInterval": "string"
          }
        },
        "actions": {
          "actionType": "string",
          "customAction": {
            "exe": "string",
            "parameters": "string"
          },
          "minProcessExecutionTime": "string"
        }
      },
      "tracingOptions": "string",
      "vnetName": "string",
      "cors": {
        "allowedOrigins": [
          "string"
        ]
      },
      "push": {
        "kind": "string",
        "properties": {
          "isPushEnabled": "boolean",
          "tagWhitelistJson": "string",
          "tagsRequiringAuth": "string",
          "dynamicTagsJson": "string"
        }
      },
      "apiDefinition": {
        "url": "string"
      },
      "autoSwapSlotName": "string",
      "localMySqlEnabled": "boolean",
      "ipSecurityRestrictions": [
        {
          "ipAddress": "string",
          "subnetMask": "string"
        }
      ]
    },
    "scmSiteAlsoStopped": "boolean",
    "hostingEnvironmentProfile": {
      "id": "string"
    },
    "clientAffinityEnabled": "boolean",
    "clientCertEnabled": "boolean",
    "hostNamesDisabled": "boolean",
    "containerSize": "integer",
    "dailyMemoryTimeQuota": "integer",
    "cloningInfo": {
      "correlationId": "string",
      "overwrite": "boolean",
      "cloneCustomHostNames": "boolean",
      "cloneSourceControl": "boolean",
      "sourceWebAppId": "string",
      "hostingEnvironment": "string",
      "appSettingsOverrides": {},
      "configureLoadBalancing": "boolean",
      "trafficManagerProfileId": "string",
      "trafficManagerProfileName": "string",
      "ignoreQuotas": "boolean"
    },
    "snapshotInfo": {
      "kind": "string",
      "properties": {
        "snapshotTime": "string",
        "recoveryTarget": {
          "location": "string",
          "id": "string"
        },
        "overwrite": "boolean",
        "recoverConfiguration": "boolean",
        "ignoreConflictingHostNames": "boolean"
      }
    },
    "httpsOnly": "boolean"
  },
  "identity": {
    "type": {}
  },
  "resources": []
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Web/sites/slots" />
### Microsoft.Web/sites/slots object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Web/sites/slots |
|  apiVersion | enum | Yes | 2016-08-01 |
|  kind | string | No | Kind of resource. |
|  location | string | Yes | Resource Location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Site resource specific properties - [SiteProperties object](#SiteProperties) |
|  identity | object | No | [ManagedServiceIdentity object](#ManagedServiceIdentity) |
|  resources | array | No | [virtualNetworkConnections](./slots/virtualNetworkConnections.md) [siteextensions](./slots/siteextensions.md) [publicCertificates](./slots/publicCertificates.md) [premieraddons](./slots/premieraddons.md) [hybridconnection](./slots/hybridconnection.md) [hostNameBindings](./slots/hostNameBindings.md) [functions](./slots/functions.md) [domainOwnershipIdentifiers](./slots/domainOwnershipIdentifiers.md) [deployments](./slots/deployments.md) |


<a id="SiteProperties" />
### SiteProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  enabled | boolean | No | <code>true</code> if the app is enabled; otherwise, <code>false</code>. Setting this value to false disables the app (takes the app offline). |
|  hostNameSslStates | array | No | Hostname SSL states are used to manage the SSL bindings for app's hostnames. - [HostNameSslState object](#HostNameSslState) |
|  serverFarmId | string | No | Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}". |
|  reserved | boolean | No | <code>true</code> if reserved; otherwise, <code>false</code>. |
|  siteConfig | object | No | Configuration of the app. - [SiteConfig object](#SiteConfig) |
|  scmSiteAlsoStopped | boolean | No | <code>true</code> to stop SCM (KUDU) site when the app is stopped; otherwise, <code>false</code>. The default is <code>false</code>. |
|  hostingEnvironmentProfile | object | No | App Service Environment to use for the app. - [HostingEnvironmentProfile object](#HostingEnvironmentProfile) |
|  clientAffinityEnabled | boolean | No | <code>true</code> to enable client affinity; <code>false</code> to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is <code>true</code>. |
|  clientCertEnabled | boolean | No | <code>true</code> to enable client certificate authentication (TLS mutual authentication); otherwise, <code>false</code>. Default is <code>false</code>. |
|  hostNamesDisabled | boolean | No | <code>true</code> to disable the public hostnames of the app; otherwise, <code>false</code>. If <code>true</code>, the app is only accessible via API management process. |
|  containerSize | integer | No | Size of the function container. |
|  dailyMemoryTimeQuota | integer | No | Maximum allowed daily memory-time quota (applicable on dynamic apps only). |
|  cloningInfo | object | No | If specified during app creation, the app is cloned from a source app. - [CloningInfo object](#CloningInfo) |
|  snapshotInfo | object | No | If specified during app creation, the app is created from a previous snapshot. - [SnapshotRecoveryRequest object](#SnapshotRecoveryRequest) |
|  httpsOnly | boolean | No | HttpsOnly: configures a web site to accept only https requests. Issues redirect forhttp requests |


<a id="ManagedServiceIdentity" />
### ManagedServiceIdentity object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  type | object | No | Type of managed service identity. |


<a id="HostNameSslState" />
### HostNameSslState object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Hostname. |
|  sslState | enum | No | SSL type. - Disabled, SniEnabled, IpBasedEnabled |
|  virtualIP | string | No | Virtual IP address assigned to the hostname if IP based SSL is enabled. |
|  thumbprint | string | No | SSL certificate thumbprint. |
|  toUpdate | boolean | No | Set to <code>true</code> to update existing hostname. |
|  hostType | enum | No | Indicates whether the hostname is a standard or repository hostname. - Standard or Repository |


<a id="SiteConfig" />
### SiteConfig object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  numberOfWorkers | integer | No | Number of workers. |
|  defaultDocuments | array | No | Default documents. - string |
|  netFrameworkVersion | string | No | .NET Framework version. |
|  phpVersion | string | No | Version of PHP. |
|  pythonVersion | string | No | Version of Python. |
|  nodeVersion | string | No | Version of Node.js. |
|  linuxFxVersion | string | No | Linux App Framework and version |
|  requestTracingEnabled | boolean | No | <code>true</code> if request tracing is enabled; otherwise, <code>false</code>. |
|  requestTracingExpirationTime | string | No | Request tracing expiration time. |
|  remoteDebuggingEnabled | boolean | No | <code>true</code> if remote debugging is enabled; otherwise, <code>false</code>. |
|  remoteDebuggingVersion | string | No | Remote debugging version. |
|  httpLoggingEnabled | boolean | No | <code>true</code> if HTTP logging is enabled; otherwise, <code>false</code>. |
|  logsDirectorySizeLimit | integer | No | HTTP logs directory size limit. |
|  detailedErrorLoggingEnabled | boolean | No | <code>true</code> if detailed error logging is enabled; otherwise, <code>false</code>. |
|  publishingUsername | string | No | Publishing user name. |
|  appSettings | array | No | Application settings. - [NameValuePair object](#NameValuePair) |
|  connectionStrings | array | No | Connection strings. - [ConnStringInfo object](#ConnStringInfo) |
|  handlerMappings | array | No | Handler mappings. - [HandlerMapping object](#HandlerMapping) |
|  documentRoot | string | No | Document root. |
|  scmType | enum | No | SCM type. - None, Dropbox, Tfs, LocalGit, GitHub, CodePlexGit, CodePlexHg, BitbucketGit, BitbucketHg, ExternalGit, ExternalHg, OneDrive, VSO |
|  use32BitWorkerProcess | boolean | No | <code>true</code> to use 32-bit worker process; otherwise, <code>false</code>. |
|  webSocketsEnabled | boolean | No | <code>true</code> if WebSocket is enabled; otherwise, <code>false</code>. |
|  alwaysOn | boolean | No | <code>true</code> if Always On is enabled; otherwise, <code>false</code>. |
|  javaVersion | string | No | Java version. |
|  javaContainer | string | No | Java container. |
|  javaContainerVersion | string | No | Java container version. |
|  appCommandLine | string | No | App command line to launch. |
|  managedPipelineMode | enum | No | Managed pipeline mode. - Integrated or Classic |
|  virtualApplications | array | No | Virtual applications. - [VirtualApplication object](#VirtualApplication) |
|  loadBalancing | enum | No | Site load balancing. - WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash |
|  experiments | object | No | This is work around for polymophic types. - [Experiments object](#Experiments) |
|  limits | object | No | Site limits. - [SiteLimits object](#SiteLimits) |
|  autoHealEnabled | boolean | No | <code>true</code> if Auto Heal is enabled; otherwise, <code>false</code>. |
|  autoHealRules | object | No | Auto Heal rules. - [AutoHealRules object](#AutoHealRules) |
|  tracingOptions | string | No | Tracing options. |
|  vnetName | string | No | Virtual Network name. |
|  cors | object | No | Cross-Origin Resource Sharing (CORS) settings. - [CorsSettings object](#CorsSettings) |
|  push | object | No | Push endpoint settings. - [PushSettings object](#PushSettings) |
|  apiDefinition | object | No | Information about the formal API definition for the app. - [ApiDefinitionInfo object](#ApiDefinitionInfo) |
|  autoSwapSlotName | string | No | Auto-swap slot name. |
|  localMySqlEnabled | boolean | No | <code>true</code> to enable local MySQL; otherwise, <code>false</code>. |
|  ipSecurityRestrictions | array | No | IP security restrictions. - [IpSecurityRestriction object](#IpSecurityRestriction) |


<a id="HostingEnvironmentProfile" />
### HostingEnvironmentProfile object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  id | string | No | Resource ID of the App Service Environment. |


<a id="CloningInfo" />
### CloningInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  correlationId | string | No | Correlation ID of cloning operation. This ID ties multiple cloning operationstogether to use the same snapshot. - globally unique identifier |
|  overwrite | boolean | No | <code>true</code> to overwrite destination app; otherwise, <code>false</code>. |
|  cloneCustomHostNames | boolean | No | <code>true</code> to clone custom hostnames from source app; otherwise, <code>false</code>. |
|  cloneSourceControl | boolean | No | <code>true</code> to clone source control from source app; otherwise, <code>false</code>. |
|  sourceWebAppId | string | Yes | ARM resource ID of the source app. App resource ID is of the form /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots. |
|  hostingEnvironment | string | No | App Service Environment. |
|  appSettingsOverrides | object | No | Application setting overrides for cloned app. If specified, these settings override the settings cloned from source app. Otherwise, application settings from source app are retained. |
|  configureLoadBalancing | boolean | No | <code>true</code> to configure load balancing for source and destination app. |
|  trafficManagerProfileId | string | No | ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource ID is of the form /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}. |
|  trafficManagerProfileName | string | No | Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile does not already exist. |
|  ignoreQuotas | boolean | No | <code>true</code> if quotas should be ignored; otherwise, <code>false</code>. |


<a id="SnapshotRecoveryRequest" />
### SnapshotRecoveryRequest object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  kind | string | No | Kind of resource. |
|  properties | object | No | SnapshotRecoveryRequest resource specific properties - [SnapshotRecoveryRequestProperties object](#SnapshotRecoveryRequestProperties) |


<a id="NameValuePair" />
### NameValuePair object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Pair name. |
|  value | string | No | Pair value. |


<a id="ConnStringInfo" />
### ConnStringInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | No | Name of connection string. |
|  connectionString | string | No | Connection string value. |
|  type | enum | No | Type of database. - MySql, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, ApiHub, DocDb, RedisCache, PostgreSQL |


<a id="HandlerMapping" />
### HandlerMapping object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  extension | string | No | Requests with this extension will be handled using the specified FastCGI application. |
|  scriptProcessor | string | No | The absolute path to the FastCGI application. |
|  arguments | string | No | Command-line arguments to be passed to the script processor. |


<a id="VirtualApplication" />
### VirtualApplication object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  virtualPath | string | No | Virtual path. |
|  physicalPath | string | No | Physical path. |
|  preloadEnabled | boolean | No | <code>true</code> if preloading is enabled; otherwise, <code>false</code>. |
|  virtualDirectories | array | No | Virtual directories for virtual application. - [VirtualDirectory object](#VirtualDirectory) |


<a id="Experiments" />
### Experiments object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  rampUpRules | array | No | List of ramp-up rules. - [RampUpRule object](#RampUpRule) |


<a id="SiteLimits" />
### SiteLimits object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  maxPercentageCpu | number | No | Maximum allowed CPU usage percentage. |
|  maxMemoryInMb | integer | No | Maximum allowed memory usage in MB. |
|  maxDiskSizeInMb | integer | No | Maximum allowed disk size usage in MB. |


<a id="AutoHealRules" />
### AutoHealRules object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  triggers | object | No | Conditions that describe when to execute the auto-heal actions. - [AutoHealTriggers object](#AutoHealTriggers) |
|  actions | object | No | Actions to be executed when a rule is triggered. - [AutoHealActions object](#AutoHealActions) |


<a id="CorsSettings" />
### CorsSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  allowedOrigins | array | No | Gets or sets the list of origins that should be allowed to make cross-origincalls (for example: http://example.com:12345). Use "*" to allow all. - string |


<a id="PushSettings" />
### PushSettings object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  kind | string | No | Kind of resource. |
|  properties | object | No | PushSettings resource specific properties - [PushSettingsProperties object](#PushSettingsProperties) |


<a id="ApiDefinitionInfo" />
### ApiDefinitionInfo object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  url | string | No | The URL of the API definition. |


<a id="IpSecurityRestriction" />
### IpSecurityRestriction object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  ipAddress | string | Yes | IP address the security restriction is valid for. |
|  subnetMask | string | No | Subnet mask for the range of IP addresses the restriction is valid for. |


<a id="SnapshotRecoveryRequestProperties" />
### SnapshotRecoveryRequestProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  snapshotTime | string | No | Point in time in which the app recovery should be attempted, formatted as a DateTime string. |
|  recoveryTarget | object | No | Specifies the web app that snapshot contents will be written to. - [SnapshotRecoveryTarget object](#SnapshotRecoveryTarget) |
|  overwrite | boolean | Yes | If <code>true</code> the recovery operation can overwrite source app; otherwise, <code>false</code>. |
|  recoverConfiguration | boolean | No | If true, site configuration, in addition to content, will be reverted. |
|  ignoreConflictingHostNames | boolean | No | If true, custom hostname conflicts will be ignored when recovering to a target web app.This setting is only necessary when RecoverConfiguration is enabled. |


<a id="VirtualDirectory" />
### VirtualDirectory object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  virtualPath | string | No | Path to virtual application. |
|  physicalPath | string | No | Physical path. |


<a id="RampUpRule" />
### RampUpRule object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  actionHostName | string | No | Hostname of a slot to which the traffic will be redirected if decided to. E.g. myapp-stage.azurewebsites.net. |
|  reroutePercentage | number | No | Percentage of the traffic which will be redirected to <code>ActionHostName</code>. |
|  changeStep | number | No | In auto ramp up scenario this is the step to to add/remove from <code>ReroutePercentage</code> until it reaches <code>MinReroutePercentage</code> or <code>MaxReroutePercentage</code>. Site metrics are checked every N minutes specificed in <code>ChangeIntervalInMinutes</code>.Custom decision algorithm can be provided in TiPCallback site extension which URL can be specified in <code>ChangeDecisionCallbackUrl</code>. |
|  changeIntervalInMinutes | integer | No | Specifies interval in mimuntes to reevaluate ReroutePercentage. |
|  minReroutePercentage | number | No | Specifies lower boundary above which ReroutePercentage will stay. |
|  maxReroutePercentage | number | No | Specifies upper boundary below which ReroutePercentage will stay. |
|  changeDecisionCallbackUrl | string | No | Custom decision algorithm can be provided in TiPCallback site extension which URL can be specified. See TiPCallback site extension for the scaffold and contracts.https://www.siteextensions.net/packages/TiPCallback/ |
|  name | string | No | Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the experiment. |


<a id="AutoHealTriggers" />
### AutoHealTriggers object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  requests | object | No | A rule based on total requests. - [RequestsBasedTrigger object](#RequestsBasedTrigger) |
|  privateBytesInKB | integer | No | A rule based on private bytes. |
|  statusCodes | array | No | A rule based on status codes. - [StatusCodesBasedTrigger object](#StatusCodesBasedTrigger) |
|  slowRequests | object | No | A rule based on request execution time. - [SlowRequestsBasedTrigger object](#SlowRequestsBasedTrigger) |


<a id="AutoHealActions" />
### AutoHealActions object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  actionType | enum | No | Predefined action to be taken. - Recycle, LogEvent, CustomAction |
|  customAction | object | No | Custom action to be taken. - [AutoHealCustomAction object](#AutoHealCustomAction) |
|  minProcessExecutionTime | string | No | Minimum time the process must executebefore taking the action |


<a id="PushSettingsProperties" />
### PushSettingsProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  isPushEnabled | boolean | Yes | Gets or sets a flag indicating whether the Push endpoint is enabled. |
|  tagWhitelistJson | string | No | Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint. |
|  tagsRequiringAuth | string | No | Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.Tags can consist of alphanumeric characters and the following:'_', '@', '#', '.', ':', '-'. Validation should be performed at the PushRequestHandler. |
|  dynamicTagsJson | string | No | Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint. |


<a id="SnapshotRecoveryTarget" />
### SnapshotRecoveryTarget object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  location | string | No | Geographical location of the target web app, e.g. SouthEastAsia, SouthCentralUS |
|  id | string | No | ARM resource ID of the target app. /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots. |


<a id="RequestsBasedTrigger" />
### RequestsBasedTrigger object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  count | integer | No | Request Count. |
|  timeInterval | string | No | Time interval. |


<a id="StatusCodesBasedTrigger" />
### StatusCodesBasedTrigger object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  status | integer | No | HTTP status code. |
|  subStatus | integer | No | Request Sub Status. |
|  win32Status | integer | No | Win32 error code. |
|  count | integer | No | Request Count. |
|  timeInterval | string | No | Time interval. |


<a id="SlowRequestsBasedTrigger" />
### SlowRequestsBasedTrigger object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  timeTaken | string | No | Time taken. |
|  count | integer | No | Request Count. |
|  timeInterval | string | No | Time interval. |


<a id="AutoHealCustomAction" />
### AutoHealCustomAction object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  exe | string | No | Executable to be run. |
|  parameters | string | No | Parameters for the executable. |

