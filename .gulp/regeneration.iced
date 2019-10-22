
###############################################
# LEGACY 
# Instead: have bunch of configuration files sitting in a well-known spot, discover them, feed them to AutoRest, done.

regenExpected = (opts,done) ->
  keys = Object.getOwnPropertyNames(opts.mappings)
  instances = keys.length

  for kkey in keys
    value = opts.mappings[kkey]
    key = kkey.trim();

    args = [
      # uncomment for local debugging "--#{opts.language}.debugger=true",
      "--#{opts.language}",
      "--output-folder=#{__dirname}/../#{opts.outputDir}/#{key}",
      "--tag=all-api-versions",
      "--title=none"
    ]

    args.push("#{opts.inputBaseDir}/#{value.basePath}/readme.md")

    for apiVersion in value.apiVersions
      args2 = args.slice()
      args2.push("--api-version=#{apiVersion}")
      autorest args2,() =>
        instances--
        return done() if instances is 0 

task 'regenerate', '', (done) ->
  regenExpected {
    'outputDir': 'test/Resource/Expected',
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/282efa7dd8301ba615d8741f740f1ed7f500fed1/specification',
    'mappings': {
      'Microsoft.AlertsManagement': { basePath: 'alertsmanagement/resource-manager', apiVersions: [ '2018-05-05', '2018-05-05-preview', '2019-03-01', '2019-03-01-preview', '2019-05-05-preview', '2019-06-01' ]},
      'Microsoft.Attestation': { basePath: 'attestation/resource-manager', apiVersions: [ '2018-09-01-preview' ]},
      'Microsoft.AzureData': { basePath: 'azuredata/resource-manager', apiVersions: [ '2017-03-01-preview' ]},
      'Microsoft.Blockchain': { basePath: 'blockchain/resource-manager', apiVersions: [ '2018-06-01-preview' ]},
      'Microsoft.BotService': { basePath: 'botservice/resource-manager', apiVersions: [ '2017-12-01', '2018-07-12' ]},
      'Microsoft.CognitiveServices': { basePath: 'cognitiveservices/resource-manager', apiVersions: [ '2016-02-01-preview', '2017-04-18' ]},
      'Microsoft.ContainerInstance': { basePath: 'containerinstance/resource-manager', apiVersions: [ '2017-08-01-preview', '2017-10-01-preview', '2017-12-01-preview', '2018-02-01-preview', '2018-04-01', '2018-06-01', '2018-09-01', '2018-10-01' ]},
      'Microsoft.DocumentDB': { basePath: 'cosmos-db/resource-manager', apiVersions: [ '2015-04-08', '2019-08-01', '2019-08-01-preview' ]},
      'Microsoft.ContainerRegistry': { basePath: 'containerregistry/resource-manager', apiVersions: [ '2016-06-27-preview', '2017-03-01', '2017-06-01-preview', '2017-10-01', '2018-02-01-preview', '2018-09-01', '2019-04-01', '2019-05-01', '2019-05-01-preview', '2019-06-01-preview' ]},
      'Microsoft.CustomProviders': { basePath: 'customproviders/resource-manager', apiVersions: [ '2018-09-01-preview' ]},
      'Microsoft.DataBox': { basePath: 'databox/resource-manager', apiVersions: [ '2018-01-01', '2019-09-01' ]},
      'Microsoft.ContainerService': { basePath: 'containerservice/resource-manager', apiVersions: [ '2016-03-30', '2016-09-30', '2017-01-31', '2017-07-01', '2017-08-31', '2017-09-30', '2018-03-31', '2018-08-01-preview', '2018-09-30-preview', '2019-02-01', '2019-04-01', '2019-04-30', '2019-06-01', '2019-08-01', '2019-09-30' ]},        
      'Microsoft.DataBoxEdge': { basePath: 'databoxedge/resource-manager', apiVersions: [ '2019-03-01', '2019-07-01' ]},
      'Microsoft.Databricks': { basePath: 'databricks/resource-manager', apiVersions: [ '2018-04-01' ]},
      'Microsoft.DataFactory': { basePath: 'datafactory/resource-manager', apiVersions: [ '2017-09-01-preview', '2018-06-01' ]},
      'Microsoft.DataShare': { basePath: 'datashare/resource-manager', apiVersions: [ '2018-11-01-preview' ]},
      'Microsoft.DeploymentManager': { basePath: 'deploymentmanager/resource-manager', apiVersions: [ '2018-09-01-preview' ]},
      'Microsoft.DevOps': { basePath: 'devops/resource-manager', apiVersions: [ '2019-07-01-preview' ]},
      'Microsoft.DevSpaces': { basePath: 'devspaces/resource-manager', apiVersions: [ '2019-04-01' ]},
      'Microsoft.DevTestLab': { basePath: 'devtestlabs/resource-manager', apiVersions: [ '2015-05-21-preview', '2016-05-15', '2018-09-15' ]},
      'Microsoft.HDInsight': { basePath: 'hdinsight/resource-manager', apiVersions: [ '2015-03-01-preview', '2018-06-01-preview' ]},
      'Microsoft.EnterpriseKnowledgeGraph': { basePath: 'EnterpriseKnowledgeGraph/resource-manager', apiVersions: [ '2018-12-03' ]},
      'Microsoft.AAD': { basePath: 'domainservices/resource-manager', apiVersions: [ '2017-01-01', '2017-06-01' ]},
      'Microsoft.EventHub': { basePath: 'eventhub/resource-manager', apiVersions: [ '2014-09-01', '2015-08-01', '2017-04-01', '2018-01-01-preview' ]},
      'Microsoft.HanaOnAzure': { basePath: 'hanaonazure/resource-manager', apiVersions: [ '2017-11-03-preview' ]},
      'Microsoft.HybridData': { basePath: 'hybriddatamanager/resource-manager', apiVersions: [ '2016-06-01' ]},
      'Microsoft.IoTSpaces': { basePath: 'iotspaces/resource-manager', apiVersions: [ '2017-10-01-preview' ]},
      'Microsoft.LabServices': { basePath: 'labservices/resource-manager', apiVersions: [ '2018-10-15' ]},
      'Microsoft.MachineLearningCompute': { basePath: 'machinelearningcompute/resource-manager', apiVersions: [ '2017-06-01-preview', '2017-08-01-preview' ]},
      'Microsoft.Maintenance': { basePath: 'maintenance/resource-manager', apiVersions: [ '2018-06-01-preview' ]},
      'Microsoft.ManagedNetwork': { basePath: 'managednetwork/resource-manager', apiVersions: [ '2019-06-01-preview' ]},
      'Microsoft.DBforMariaDB': { basePath: 'mariadb/resource-manager', apiVersions: [ '2018-06-01', '2018-06-01-preview' ]},
      'Microsoft.DBforMySQL': { basePath: 'mysql/resource-manager', apiVersions: [ '2017-12-01', '2017-12-01-preview' ]},
      'Microsoft.PolicyInsights': { basePath: 'policyinsights/resource-manager', apiVersions: [ '2017-08-09-preview', '2017-10-17-preview', '2017-12-12-preview', '2018-04-04', '2018-07-01-preview', '2019-10-01' ]},
      'Microsoft.Peering': { basePath: 'peering/resource-manager', apiVersions: [ '2019-08-01-preview', '2019-09-01-preview' ]},
      'Microsoft.Portal': { basePath: 'portal/resource-manager', apiVersions: [ '2015-08-01-preview', '2018-10-01-preview', '2019-01-01-preview' ]},
      'Microsoft.DBforPostgreSQL': { basePath: 'postgresql/resource-manager', apiVersions: [ '2017-12-01', '2017-12-01-preview' ]},
      'Microsoft.Relay': { basePath: 'relay/resource-manager', apiVersions: [ '2016-07-01', '2017-04-01' ]},
      'Microsoft.ServiceBus': { basePath: 'servicebus/resource-manager', apiVersions: [ '2014-09-01', '2015-08-01', '2017-04-01', '2018-01-01-preview' ]},
      'Microsoft.ServiceFabric': { basePath: 'servicefabric/resource-manager', apiVersions: [ '2016-09-01', '2017-07-01-preview', '2018-02-01', '2019-03-01', '2019-03-01-preview', '2019-06-01-preview' ]},
      'Microsoft.ServiceFabricMesh': { basePath: 'servicefabricmesh/resource-manager', apiVersions: [ '2018-07-01-preview', '2018-09-01-preview' ]},
      'Microsoft.SqlVirtualMachine': { basePath: 'sqlvirtualmachine/resource-manager', apiVersions: [ '2017-03-01-preview' ]},
      'Microsoft.StorageCache': { basePath: 'storagecache/resource-manager', apiVersions: [ '2019-08-01-preview', '2019-11-01' ]},
      'Microsoft.StorageSync': { basePath: 'storagesync/resource-manager', apiVersions: [ '2017-06-05-preview', '2018-04-02', '2018-07-01', '2018-10-01', '2019-02-01', '2019-03-01', '2019-06-01' ]},
      'Microsoft.VMwareCloudSimple': { basePath: 'vmwarecloudsimple/resource-manager', apiVersions: [ '2019-04-01' ]},
      'Microsoft.TimeSeriesInsights': { basePath: 'timeseriesinsights/resource-manager', apiVersions: [ '2017-02-28-preview', '2017-11-15', '2018-08-15-preview' ]},       
      'Microsoft.VirtualMachineImages': { basePath: 'imagebuilder/resource-manager', apiVersions: [ '2018-02-01-preview', '2019-02-01-preview', '2019-05-01-preview' ]},   
      'Microsoft.WindowsIoT': { basePath: 'windowsiot/resource-manager', apiVersions: [ '2018-02-16-preview', '2019-06-01' ]},
      'Microsoft.Web': { basePath: 'web/resource-manager', apiVersions: [ '2018-02-01', '2018-11-01' ] },
    },
    'language': 'azureresourceschema'
  },done
  return null
