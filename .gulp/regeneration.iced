
###############################################
# LEGACY 
# Instead: have bunch of configuration files sitting in a well-known spot, discover them, feed them to AutoRest, done.

regenExpected = (opts,done) ->
  keys = Object.getOwnPropertyNames(opts.mappings)
  instances = 0

  for kkey in keys
    value = opts.mappings[kkey]
    instances += value.tags.length

  for kkey in keys
    value = opts.mappings[kkey]
    key = kkey.trim();

    args = [
      # uncomment for local debugging "--#{opts.language}.debugger=true",
      "--#{opts.language}",
      "--output-folder=#{__dirname}/../#{opts.outputDir}/#{key}",
      "--title=none"
    ]

    args.push("#{opts.inputBaseDir}/#{value.basePath}/readme.md")

    for tag in value.tags
      args2 = args.slice()
      if tag == 'multiapi'
        args2.push("--multiapi")
      else
        args2.push("--tag=#{tag}")
      autorest args2,() =>
        instances--
        return done() if instances is 0

task 'regenerate', '', (done) ->
  regenExpected {
    'outputDir': 'test/Resource/Expected',
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/909b2c3/specification',
    'mappings': {
      'Microsoft.AlertsManagement': { basePath: 'alertsmanagement/resource-manager', tags: ['multiapi'] },
      'Microsoft.Attestation': { basePath: 'attestation/resource-manager', tags: ['package-2018-09-preview'] },
      'Microsoft.AzureData': { basePath: 'azuredata/resource-manager', tags: ['package-preview-2019-07'] },
      'Microsoft.Blockchain': { basePath: 'blockchain/resource-manager', tags: ['package-2018-06-01-preview'] },
      'Microsoft.BotService': { basePath: 'botservice/resource-manager', tags: ['package-2017-12-01', 'package-2018-07-12'] },
      'Microsoft.CognitiveServices': { basePath: 'cognitiveservices/resource-manager', tags: ['package-2016-02-preview', 'package-2017-04'] },
      'Microsoft.Consumption': { basePath: 'consumption/resource-manager', tags: ['package-2018-10'] },
      'Microsoft.ContainerInstance': { basePath: 'containerinstance/resource-manager', tags: ['multiapi'] },
      'Microsoft.DocumentDB': { basePath: 'cosmos-db/resource-manager', tags: ['package-2015-04', 'package-2019-08-preview'] },
      'Microsoft.ContainerRegistry': { basePath: 'containerregistry/resource-manager', tags: ['multiapi'] },
      'Microsoft.CustomProviders': { basePath: 'customproviders/resource-manager', tags: ['package-2018-09-01-preview'] },
      'Microsoft.DataBox': { basePath: 'databox/resource-manager', tags: ['package-2018-01', 'package-2019-09'] },
      'Microsoft.ContainerService': { basePath: 'containerservice/resource-manager', tags: ['multiapi'] },
      'Microsoft.DataBoxEdge': { basePath: 'databoxedge/resource-manager', tags: ['package-2019-03', 'package-2019-07'] },
      'Microsoft.Databricks': { basePath: 'databricks/resource-manager', tags: ['package-2018-04-01'] },
      'Microsoft.DataFactory': { basePath: 'datafactory/resource-manager', tags: ['package-2017-09-preview', 'package-2018-06'] },
      'Microsoft.DataShare': { basePath: 'datashare/resource-manager', tags: ['package-2018-11-01-preview'] },
      'Microsoft.DeploymentManager': { basePath: 'deploymentmanager/resource-manager', tags: ['package-2018-09-01-preview'] },
      'Microsoft.DevOps': { basePath: 'devops/resource-manager', tags: ['package-2019-07-01-preview'] },
      'Microsoft.DevSpaces': { basePath: 'devspaces/resource-manager', tags: ['package-2019-04-01'] },
      'Microsoft.DevTestLab': { basePath: 'devtestlabs/resource-manager', tags: ['package-2015-05-preview', 'package-2016-05', 'package-2018-09'] },
      'Microsoft.HDInsight': { basePath: 'hdinsight/resource-manager', tags: ['package-2015-03-preview', 'package-2018-06-preview'] },
      'Microsoft.EnterpriseKnowledgeGraph': { basePath: 'EnterpriseKnowledgeGraph/resource-manager', tags: ['package-2018-12-03'] },
      'Microsoft.AAD': { basePath: 'domainservices/resource-manager', tags: ['package-2017-01', 'package-2017-06'] },
      'Microsoft.EventHub': { basePath: 'eventhub/resource-manager', tags: ['package-2014-09', 'package-2015-08', 'package-2017-04', 'package-2018-01-preview'] },
      'Microsoft.HanaOnAzure': { basePath: 'hanaonazure/resource-manager', tags: ['package-2017-11'] },
      'Microsoft.HybridData': { basePath: 'hybriddatamanager/resource-manager', tags: ['package-2016-06'] },
      'Microsoft.IoTSpaces': { basePath: 'iotspaces/resource-manager', tags: ['package-2017-10-preview'] },
      'Microsoft.LabServices': { basePath: 'labservices/resource-manager', tags: ['package-2018-10'] },
      'Microsoft.Logic': { basePath: 'logic/resource-manager', tags: ['package-2019-05'] },
      'Microsoft.MachineLearningCompute': { basePath: 'machinelearningcompute/resource-manager', tags: ['package-2017-06-preview', 'package-2017-08-preview'] },
      'Microsoft.Maintenance': { basePath: 'maintenance/resource-manager', tags: ['package-2018-06-preview'] },
      'Microsoft.ManagedNetwork': { basePath: 'managednetwork/resource-manager', tags: ['package-2019-06-01-preview'] },
      'Microsoft.DBforMariaDB': { basePath: 'mariadb/resource-manager', tags: ['2018-06-01-preview', 'package-2018-06-01'] },
      'Microsoft.DBforMySQL': { basePath: 'mysql/resource-manager', tags: ['package-2017-12-01-preview', 'package-2017-12-01'] },
      'Microsoft.PolicyInsights': { basePath: 'policyinsights/resource-manager', tags: ['multiapi'] },
      'Microsoft.Peering': { basePath: 'peering/resource-manager', tags: ['package-2019-08-01-preview', 'package-2019-09-01-preview'] },
      'Microsoft.Portal': { basePath: 'portal/resource-manager', tags: ['package-2015-08-01-preview', 'package-2018-10-01-preview', 'package-2019-01-01-preview'] },
      'Microsoft.DBforPostgreSQL': { basePath: 'postgresql/resource-manager', tags: ['package-2017-12-01', 'package-2017-12-01-preview'] },
      'Microsoft.Relay': { basePath: 'relay/resource-manager', tags: ['package-2016-07', 'package-2017-04'] },
      'Microsoft.ServiceBus': { basePath: 'servicebus/resource-manager', tags: ['multiapi'] },
      'Microsoft.ServiceFabric': { basePath: 'servicefabric/resource-manager', tags: ['multiapi'] },
      'Microsoft.ServiceFabricMesh': { basePath: 'servicefabricmesh/resource-manager', tags: ['package-2018-07-01-preview', 'package-2018-09-01-preview'] },
      'Microsoft.Sql': { basePath: 'sql/resource-manager', tags: ['multiapi'] },
      'Microsoft.SqlVirtualMachine': { basePath: 'sqlvirtualmachine/resource-manager', tags: ['package-2017-03-01-preview'] },
      'Microsoft.StorageCache': { basePath: 'storagecache/resource-manager', tags: ['package-2019-08', 'package-2019-11-01'] },
      'Microsoft.StorageSync': { basePath: 'storagesync/resource-manager', tags: ['multiapi'] },
      'Microsoft.VMwareCloudSimple': { basePath: 'vmwarecloudsimple/resource-manager', tags: ['package-2019-04-01'] },
      'Microsoft.TimeSeriesInsights': { basePath: 'timeseriesinsights/resource-manager', tags: ['2017-02-preview', 'package-2017-11-15', 'package-2018-08-preview'] },
      'Microsoft.VirtualMachineImages': { basePath: 'imagebuilder/resource-manager', tags: ['package-2018-02', 'package-2019-02', 'package-preview-2019-05'] },
      'Microsoft.WindowsIoT': { basePath: 'windowsiot/resource-manager', tags: ['package-2018-02-preview', 'package-2019-06'] },
      'Microsoft.Web': { basePath: 'web/resource-manager', tags: ['package-2018-02-only', 'package-2018-11-only'] },
    },
    'language': 'azureresourceschema'
  },done
  return null
