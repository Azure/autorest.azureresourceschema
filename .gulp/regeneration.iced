
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
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/ddfe040e3/specification',
    'mappings': {
      'Microsoft.AlertsManagement': { basePath: 'alertsmanagement/resource-manager', tags: [ 'schema-alertsmanagement-2018-05-05', 'schema-alertsmanagement-2018-05-05-preview', 'schema-alertsmanagement-2019-03-01', 'schema-alertsmanagement-2019-05-05-preview', 'schema-alertsmanagement-2019-06-01' ]},
      'Microsoft.Attestation': { basePath: 'attestation/resource-manager', tags: [ 'schema-attestation-2018-09-01-preview' ]},
      'Microsoft.Automation': { basePath: 'automation/resource-manager', tags: ['schema-automation-2020-01-13-preview'] },
      'Microsoft.AzureData': { basePath: 'azuredata/resource-manager', tags: [ 'schema-azuredata-2019-07-24-preview' ]},
      'Microsoft.Blockchain': { basePath: 'blockchain/resource-manager', tags: [ 'schema-blockchain-2018-06-01-preview' ]},
      'Microsoft.BotService': { basePath: 'botservice/resource-manager', tags: [ 'schema-botservice-2017-12-01', 'schema-botservice-2018-07-12' ]},
      'Microsoft.CognitiveServices': { basePath: 'cognitiveservices/resource-manager', tags: [ 'schema-cognitiveservices-2016-02-01-preview', 'schema-cognitiveservices-2017-04-18' ]},
      'Microsoft.Consumption': { basePath: 'consumption/resource-manager', tags: [ 'schema-consumption-2018-10-01' ]},
      'Microsoft.ContainerInstance': { basePath: 'containerinstance/resource-manager', tags: [ 'schema-containerinstance-2017-08-01-preview', 'schema-containerinstance-2017-10-01-preview', 'schema-containerinstance-2017-12-01-preview', 'schema-containerinstance-2018-02-01-preview', 'schema-containerinstance-2018-04-01', 'schema-containerinstance-2018-06-01', 'schema-containerinstance-2018-09-01', 'schema-containerinstance-2018-10-01' ]},
      'Microsoft.DocumentDB': { basePath: 'cosmos-db/resource-manager', tags: [ 'schema-documentdb-2015-04-08', 'schema-documentdb-2019-08-01', 'schema-documentdb-2019-08-01-preview' ]},
      'Microsoft.ContainerRegistry': { basePath: 'containerregistry/resource-manager', tags: [ 'schema-containerregistry-2016-06-27-preview', 'schema-containerregistry-2017-03-01', 'schema-containerregistry-2017-06-01-preview', 'schema-containerregistry-2017-10-01', 'schema-containerregistry-2018-02-01-preview', 'schema-containerregistry-2018-09-01', 'schema-containerregistry-2019-04-01', 'schema-containerregistry-2019-05-01', 'schema-containerregistry-2019-05-01-preview', 'schema-containerregistry-2019-06-01-preview' ]},
      'Microsoft.CustomProviders': { basePath: 'customproviders/resource-manager', tags: [ 'schema-customproviders-2018-09-01-preview' ]},
      'Microsoft.DataBox': { basePath: 'databox/resource-manager', tags: [ 'schema-databox-2018-01-01', 'schema-databox-2019-09-01' ]},
      'Microsoft.ContainerService': { basePath: 'containerservice/resource-manager', tags: [ 'schema-containerservice-2016-03-30', 'schema-containerservice-2016-09-30', 'schema-containerservice-2017-01-31', 'schema-containerservice-2017-07-01', 'schema-containerservice-2017-08-31', 'schema-containerservice-2017-09-30', 'schema-containerservice-2018-03-31', 'schema-containerservice-2018-08-01-preview', 'schema-containerservice-2018-09-30-preview', 'schema-containerservice-2019-02-01', 'schema-containerservice-2019-04-01', 'schema-containerservice-2019-04-30', 'schema-containerservice-2019-06-01', 'schema-containerservice-2019-08-01', 'schema-containerservice-2019-09-30' ]},
      'Microsoft.DataBoxEdge': { basePath: 'databoxedge/resource-manager', tags: [ 'schema-databoxedge-2019-03-01', 'schema-databoxedge-2019-07-01' ]},
      'Microsoft.Databricks': { basePath: 'databricks/resource-manager', tags: [ 'schema-databricks-2018-04-01' ]},
      'Microsoft.DataFactory': { basePath: 'datafactory/resource-manager', tags: [ 'schema-datafactory-2017-09-01-preview', 'schema-datafactory-2018-06-01' ]},
      'Microsoft.DataShare': { basePath: 'datashare/resource-manager', tags: [ 'schema-datashare-2018-11-01-preview' ]},
      'Microsoft.DeploymentManager': { basePath: 'deploymentmanager/resource-manager', tags: [ 'schema-deploymentmanager-2018-09-01-preview' ]},
      'Microsoft.DevOps': { basePath: 'devops/resource-manager', tags: [ 'schema-devops-2019-07-01-preview' ]},
      'Microsoft.DevSpaces': { basePath: 'devspaces/resource-manager', tags: [ 'schema-devspaces-2019-04-01' ]},
      'Microsoft.DevTestLab': { basePath: 'devtestlabs/resource-manager', tags: [ 'schema-devtestlab-2015-05-21-preview', 'schema-devtestlab-2016-05-15', 'schema-devtestlab-2018-09-15' ]},
      'Microsoft.HDInsight': { basePath: 'hdinsight/resource-manager', tags: [ 'schema-hdinsight-2015-03-01-preview', 'schema-hdinsight-2018-06-01-preview' ]},
      'Microsoft.EnterpriseKnowledgeGraph': { basePath: 'EnterpriseKnowledgeGraph/resource-manager', tags: [ 'schema-enterpriseknowledgegraph-2018-12-03' ]},
      'Microsoft.AAD': { basePath: 'domainservices/resource-manager', tags: [ 'schema-aad-2017-01-01', 'schema-aad-2017-06-01' ]},
      'Microsoft.EventHub': { basePath: 'eventhub/resource-manager', tags: [ 'schema-eventhub-2014-09-01', 'schema-eventhub-2015-08-01', 'schema-eventhub-2017-04-01', 'schema-eventhub-2018-01-01-preview' ]},
      'Microsoft.HanaOnAzure': { basePath: 'hanaonazure/resource-manager', tags: [ 'schema-hanaonazure-2017-11-03-preview' ]},
      'Microsoft.HybridData': { basePath: 'hybriddatamanager/resource-manager', tags: [ 'schema-hybriddata-2016-06-01' ]},
      'Microsoft.IoTSpaces': { basePath: 'iotspaces/resource-manager', tags: [ 'schema-iotspaces-2017-10-01-preview' ]},
      'Microsoft.LabServices': { basePath: 'labservices/resource-manager', tags: [ 'schema-labservices-2018-10-15' ]},
      'Microsoft.Logic': { basePath: 'logic/resource-manager', tags: [ 'schema-logic-2019-05-01' ]},
      'Microsoft.MachineLearningCompute': { basePath: 'machinelearningcompute/resource-manager', tags: [ 'schema-machinelearningcompute-2017-06-01-preview', 'schema-machinelearningcompute-2017-08-01-preview' ]},
      'Microsoft.Maintenance': { basePath: 'maintenance/resource-manager', tags: [ 'schema-maintenance-2018-06-01-preview' ]},
      'Microsoft.ManagedNetwork': { basePath: 'managednetwork/resource-manager', tags: [ 'schema-managednetwork-2019-06-01-preview' ]},
      'Microsoft.DBforMariaDB': { basePath: 'mariadb/resource-manager', tags: [ 'schema-dbformariadb-2018-06-01', 'schema-dbformariadb-2018-06-01-preview' ]},
      'Microsoft.DBforMySQL': { basePath: 'mysql/resource-manager', tags: [ 'schema-dbformysql-2017-12-01', 'schema-dbformysql-2017-12-01-preview' ]},
      'Microsoft.PolicyInsights': { basePath: 'policyinsights/resource-manager', tags: [ 'schema-policyinsights-2018-04-04', 'schema-policyinsights-2018-07-01-preview', 'schema-policyinsights-2019-10-01' ]},
      'Microsoft.Peering': { basePath: 'peering/resource-manager', tags: [ 'schema-peering-2019-08-01-preview', 'schema-peering-2019-09-01-preview' ]},
      'Microsoft.Portal': { basePath: 'portal/resource-manager', tags: [ 'schema-portal-2015-08-01-preview', 'schema-portal-2018-10-01-preview', 'schema-portal-2019-01-01-preview' ]},
      'Microsoft.DBforPostgreSQL': { basePath: 'postgresql/resource-manager', tags: [ 'schema-dbforpostgresql-2017-12-01', 'schema-dbforpostgresql-2017-12-01-preview' ]},
      'Microsoft.Relay': { basePath: 'relay/resource-manager', tags: [ 'schema-relay-2016-07-01', 'schema-relay-2017-04-01' ]},
      'Microsoft.ServiceBus': { basePath: 'servicebus/resource-manager', tags: [ 'schema-servicebus-2015-08-01', 'schema-servicebus-2017-04-01', 'schema-servicebus-2018-01-01-preview' ]},
      'Microsoft.ServiceFabric': { basePath: 'servicefabric/resource-manager', tags: [ 'schema-servicefabric-2016-09-01', 'schema-servicefabric-2018-02-01', 'schema-servicefabric-2019-03-01', 'schema-servicefabric-2019-03-01-preview', 'schema-servicefabric-2019-06-01-preview' ]},
      'Microsoft.ServiceFabricMesh': { basePath: 'servicefabricmesh/resource-manager', tags: [ 'schema-servicefabricmesh-2018-07-01-preview', 'schema-servicefabricmesh-2018-09-01-preview' ]},
      'Microsoft.Sql': { basePath: 'sql/resource-manager', tags: [ 'schema-sql-2014-04-01', 'schema-sql-2015-05-01-preview', 'schema-sql-2017-03-01-preview', 'schema-sql-2017-10-01-preview', 'schema-sql-2018-06-01-preview' ]},
      'Microsoft.SqlVirtualMachine': { basePath: 'sqlvirtualmachine/resource-manager', tags: [ 'schema-sqlvirtualmachine-2017-03-01-preview' ]},
      'Microsoft.StorageCache': { basePath: 'storagecache/resource-manager', tags: [ 'schema-storagecache-2019-08-01-preview', 'schema-storagecache-2019-11-01' ]},
      'Microsoft.StorageSync': { basePath: 'storagesync/resource-manager', tags: [ 'schema-storagesync-2017-06-05-preview', 'schema-storagesync-2018-04-02', 'schema-storagesync-2018-07-01', 'schema-storagesync-2018-10-01', 'schema-storagesync-2019-02-01', 'schema-storagesync-2019-03-01', 'schema-storagesync-2019-06-01' ]},
      'Microsoft.VMwareCloudSimple': { basePath: 'vmwarecloudsimple/resource-manager', tags: [ 'schema-vmwarecloudsimple-2019-04-01' ]},
      'Microsoft.TimeSeriesInsights': { basePath: 'timeseriesinsights/resource-manager', tags: [ 'schema-timeseriesinsights-2017-02-28-preview', 'schema-timeseriesinsights-2017-11-15', 'schema-timeseriesinsights-2018-08-15-preview' ]},
      'Microsoft.VirtualMachineImages': { basePath: 'imagebuilder/resource-manager', tags: [ 'schema-virtualmachineimages-2018-02-01-preview', 'schema-virtualmachineimages-2019-02-01-preview', 'schema-virtualmachineimages-2019-05-01-preview' ]},
      'Microsoft.WindowsIoT': { basePath: 'windowsiot/resource-manager', tags: [ 'schema-windowsiot-2018-02-16-preview', 'schema-windowsiot-2019-06-01' ]},
      'Microsoft.Web': { basePath: 'web/resource-manager', tags: [ 'schema-web-2018-02-01', 'schema-web-2018-11-01' ] },
    },
    'language': 'azureresourceschema'
  },done
  return null
