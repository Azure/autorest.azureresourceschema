
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
      "--#{opts.language}.output-folder=#{__dirname}/../#{opts.outputDir}/#{key}",
      "--title=title"
    ]

    if value.file
      args.push("--input-file=#{value.file}")
    else
      args.push("#{opts.inputBaseDir}/#{value.folder}/resource-manager/readme.md")

    for tag in value.tags
      args2 = args.slice()
      args2.push("--tag=#{tag}")
      autorest args2,() =>
        instances--
        return done() if instances is 0 

task 'regenerate', '', (done) ->
  regenExpected {
    'outputDir': 'test/Resource/Expected',
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/ee4507de8c2ba506fb8a7a9decff67691ed4d336/specification',
    'mappings': {
      # 'Advisor': { folder: 'advisor', tags: [ 'package-2017-04', 'package-2017-03', 'package-2016-07-preview' ] },
      'AnalysisServices': { folder: 'analysisservices', tags: [ 'package-2017-08-beta', 'package-2017-07', 'package-2016-05' ] },
      'ApiManagement': { folder: 'apimanagement', tags: [ 'package-2017-03', 'package-2016-10' ] },
      # 'ApplicationInsights': { folder: 'applicationinsights', tags: [ 'package-2015-05' ] },
      # 'Authorization': { folder: 'authorization', tags: [ 'package-2015-07', 'package-2017-10-01-preview' ] },
      'Automation': { folder: 'automation', tags: [ 'package-2015-10', 'package-2017-05-preview' ] },
      'Batch': { folder: 'batch', tags: [ 'package-2017-09', 'package-2017-05', 'package-2017-01', 'package-2015-12' ] },
      # 'CDN': { folder: 'cdn', tags: [ 'package-2017-04', 'package-2016-10', 'package-2016-04', 'package-2015-06' ] },
      # 'CognitiveServices': { folder: 'cognitiveservices', tags: [ 'package-2017-04', 'package-2016-02-preview' ] },
      'Compute': { folder: 'compute', tags: [ 'package-compute-only-2017-12', 'package-skus-2017-09', 'package-2017-03', 'package-2016-04-preview', 'package-2016-03', 'package-2015-06-preview' ] },
      # 'Consumption': { folder: 'consumption', tags: [ 'package-2017-11', 'package-2017-04-preview', 'package-2017-12-preview' ] },
      'ContainerRegistry': { folder: 'containerregistry', tags: [ 'package-2017-10', 'package-2017-06-preview', 'package-2017-03', 'package-2016-06-preview' ] },
      # 'ContainerService': { folder: 'containerservices', tags: [ 'package-2017-09', 'package-2017-08', 'package-2017-07' ] },
      'CustomerInsights': { folder: 'customer-insights', tags: [ 'package-2017-04', 'package-2017-01' ] },
      # 'DataLakeAnalytics': { folder: 'datalake-analytics', tags: [ 'package-2016-11', 'package-2015-10-preview' ] },
      # 'DataLakeStore': { folder: 'datalake-store', tags: [ 'package-2016-11', 'package-2015-10-preview' ] },
      'DevTestLabs': { folder: 'devtestlabs', tags: [ 'package-2016-05', 'package-2015-05-preview' ] },
      # 'DNS': { folder: 'dns', tags: [ 'package-2017-09', 'package-2016-04', 'package-2015-05-preview' ] },
      # 'DomainServices': { folder: 'domainservices', tags: [ 'package-2017-06', 'package-2017-01' ] },
      'EventHub': { folder: 'eventhub', tags: [ 'package-2017-04', 'package-2015-08' ] },
      # 'IotHub': { folder: 'iothub', tags: [ 'package-2017-07', 'package-2017-01', 'package-2016-02' ] },
      # 'KeyVault': { folder: 'keyvault', tags: [ 'package-2016-10', 'package-2015-06' ] },
      'Logic': { folder: 'logic', tags: [ 'package-2016-06', 'package-2015-08-preview', 'package-2015-02-preview' ] }, # missing 'type: object'
      # 'Monitor': { folder: 'monitor', tags: [ 'package-2017-09' ] },
      'Network': { folder: 'network', tags: [ 'package-2017-10', 'package-2017-09', 'package-2017-08', 'package-2017-06', 'package-2017-03', 'package-2016-12', 'package-2016-09', 'package-2016-06', 'package-2016-03' ] },
      # 'NotificationHubs': { folder: 'notificationhubs', tags: [ 'package-2017-04', 'package-2016-03', 'package-2014-09' ] },
      # 'PowerBIEmbedded': { folder: 'powerbiembedded', tags: [ 'package-2016-01' ] },
      # 'ProvisioningServices': { folder: 'provisioningservices', tags: [ 'package-2017-08', 'package-2017-11' ] },
      'RecoveryServices': { folder: 'recoveryservices', tags: [ 'package-2016-12', 'package-2016-06' ] },
      # 'RecoveryServicesBackup': { folder: 'recoveryservicesbackup', tags: [ 'package-2017-07', 'package-2016-06' ] },
      # 'Redis': { folder: 'redis', tags: [ 'package-2017-10', 'package-2017-02', 'package-2016-04', 'package-2015-08' ] },
      'Relay': { folder: 'relay', tags: [ 'package-2017-04', 'package-2016-07' ] },
      # 'Reservations': { folder: 'reservations', tags: [ 'package-2017-11' ] },
      # 'Scheduler': { folder: 'scheduler', tags: [ 'package-2016-03', 'package-2016-01', 'package-2014-08-preview' ] },
      # 'Search': { folder: 'search', tags: [ 'package-2015-08', 'package-2015-02' ] },
      'ServiceBus': { folder: 'servicebus', tags: [ 'package-2017-04', 'package-2015-08' ] },
      'ServiceFabric': { folder: 'servicefabric', tags: [ 'package-2017-07', 'package-2016-09' ] }, # missing 'type: object'
      'Storage': { folder: 'storage', tags: [ 'package-2017-10', 'package-2017-06', 'package-2016-12', 'package-2016-05', 'package-2016-01', 'package-2015-06', 'package-2015-05-preview' ] },
      # 'TrafficManager': { folder: 'trafficmanager', tags: [ 'package-2017-09-preview', 'package-2017-05', 'package-2017-03', 'package-2015-11' ] },
      'Web': { folder: 'web', tags: [ 'package-2016-09' ] }, # missing 'type: object'
      # 'poly': { file: __dirname + "/../test/Resource/poly-service.json", tags: [ '' ] }
    },
    'language': 'azureresourceschema'
  },done
  return null
