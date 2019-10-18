
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

    argsArray = []
    for apiVersion in value.apiVersions
      args2 = args.slice()
      args2.push("--api-version=#{apiVersion}")

      argsArray.push(args2)

    # Avoid overloading autorest by chaining commands for each namespace
    autorestSequential argsArray, () => 
      instances--
      return done() if instances is 0

task 'regenerate', '', (done) ->
  regenExpected {
    'outputDir': 'test/Resource/Expected',
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/f1fdf4a5adfb067c78e4625e293ad4bbc97789c7/specification',
    'mappings': {
      'Microsoft.BotService': { basePath: 'botservice/resource-manager', apiVersions: [ '2017-12-01', '2018-07-12' ] },
      'Microsoft.DataBox': { basePath: 'databox/resource-manager', apiVersions: [ '2018-01-01' ] },
      'Microsoft.DataBoxEdge': { basePath: 'databoxedge/resource-manager', apiVersions: [ '2019-03-01', '2019-07-01' ] },
      'Microsoft.Databricks': { basePath: 'databricks/resource-manager', apiVersions: [ '2018-04-01' ] },
      'Microsoft.DevSpaces': { basePath: 'devspaces/resource-manager', apiVersions: [ '2019-04-01' ] },
      'Microsoft.DocumentDB': { basePath: 'cosmos-db/resource-manager', apiVersions: [ '2015-04-08', '2019-08-01' ] },
      'Microsoft.EnterpriseKnowledgeGraph': { basePath: 'EnterpriseKnowledgeGraph/resource-manager', apiVersions: [ '2018-12-03' ] },
      'Microsoft.EventHub': { basePath: 'eventhub/resource-manager', apiVersions: [ '2014-09-01', '2015-08-01', '2017-04-01', '2018-01-01-preview' ] },
      'Microsoft.IoTSpaces': { basePath: 'iotspaces/resource-manager', apiVersions: [ '2017-10-01-preview' ] },
      'Microsoft.KeyVault': { basePath: 'keyvault/resource-manager', apiVersions: [ '2015-06-01', '2016-10-01', '2018-02-14', '2018-02-14-preview' ] },
      'Microsoft.LabServices': { basePath: 'labservices/resource-manager', apiVersions: [ '2018-10-15' ] },
      'Microsoft.MachineLearningCompute': { basePath: 'machinelearningcompute/resource-manager', apiVersions: [ '2017-06-01-preview', '2017-08-01-preview' ] },
      'Microsoft.Portal': { basePath: 'portal/resource-manager', apiVersions: [ '2015-08-01-preview', '2018-10-01-preview', '2019-01-01-preview' ] },
      'Microsoft.Relay': { basePath: 'relay/resource-manager', apiVersions: [ '2016-07-01', '2017-04-01' ] },
      'Microsoft.ServiceBus': { basePath: 'servicebus/resource-manager', apiVersions: [ '2015-08-01', '2017-04-01', '2018-01-01-preview' ] },
      'Microsoft.ServiceFabric': { basePath: 'servicefabric/resource-manager', apiVersions: [ '2016-09-01', '2017-07-01-preview', '2018-02-01', '2019-03-01', '2019-03-01-preview' ] },
      'Microsoft.ServiceFabricMesh': { basePath: 'servicefabricmesh/resource-manager', apiVersions: [ '2018-07-01-preview', '2018-09-01-preview' ] },
      'Microsoft.SqlVirtualMachine': { basePath: 'sqlvirtualmachine/resource-manager', apiVersions: [ '2017-03-01-preview' ] },
      'Microsoft.StorageSync': { basePath: 'storagesync/resource-manager', apiVersions: [ '2017-06-05-preview', '2018-04-02', '2018-07-01', '2018-10-01', '2019-02-01', '2019-03-01' ] },
      'Microsoft.WindowsIoT': { basePath: 'windowsiot/resource-manager', apiVersions: [ '2018-02-16-preview', '2019-06-01' ] },
      'Microsoft.Insights': { basePath: 'monitor/resource-manager', apiVersions: [ '2015-04-01', '2015-07-01', '2016-03-01', '2016-09-01', '2017-03-01-preview', '2017-04-01', '2017-12-01-preview', '2018-01-01', '2018-03-01', '2018-04-16', '2018-06-01-preview', '2018-09-01', '2018-11-27-preview', '2019-03-01', '2019-06-01' ] },
    },
    'language': 'azureresourceschema'
  },done
  return null
