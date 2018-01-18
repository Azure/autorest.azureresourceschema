
###############################################
# LEGACY 
# Instead: have bunch of configuration files sitting in a well-known spot, discover them, feed them to AutoRest, done.

regenExpected = (opts,done) ->
  outputDir = if !!opts.outputBaseDir then "#{opts.outputBaseDir}/#{opts.outputDir}" else opts.outputDir
  keys = Object.getOwnPropertyNames(opts.mappings)
  instances = keys.length

  for kkey in keys
    optsMappingsValue = opts.mappings[kkey]
    key = kkey.trim();
    
    swaggerFiles = (if optsMappingsValue instanceof Array then optsMappingsValue[0] else optsMappingsValue).split(";")
    args = [
      "--#{opts.language}",
      # "--clear-output-folder", # run multiple times on same folders (API version nests)
      "--output-folder=#{outputDir}/#{key}",
      "--license-header=#{if !!opts.header then opts.header else 'MICROSOFT_MIT_NO_VERSION'}"
    ]

    for swaggerFile in swaggerFiles
      args.push("--input-file=#{if !!opts.inputBaseDir then "#{opts.inputBaseDir}/#{swaggerFile}" else swaggerFile}")

    autorest args,() =>
      instances--
      return done() if instances is 0 

task 'regenerate', '', (done) ->
  regenExpected {
    'outputBaseDir': 'test',
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/a70ffe7159e60a9548679d2924b24fc96da929a5/specification',
    'mappings': {
      'ApiManagement':'apimanagement/resource-manager/Microsoft.ApiManagement/stable/2016-07-07/apimanagement.json',
      'Batch':'batch/resource-manager/Microsoft.Batch/stable/2015-12-01/BatchManagement.json',
      'CDN':'cdn/resource-manager/Microsoft.Cdn/stable/2015-06-01/cdn.json',
      'CDN ':'cdn/resource-manager/Microsoft.Cdn/stable/2016-04-02/cdn.json',
      'CognitiveServices':'cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2016-02-01-preview/cognitiveservices.json',
      'CommitmentPlans':'machinelearning/resource-manager/Microsoft.MachineLearning/preview/2016-05-01-preview/commitmentPlans.json',
      'Compute':'compute/resource-manager/Microsoft.Compute/stable/2015-06-15/compute.json',
      'Compute ':'compute/resource-manager/Microsoft.Compute/stable/2016-03-30/compute.json',
      'ContainerService':'compute/resource-manager/Microsoft.ContainerService/stable/2016-03-30/containerService.json',
      'DataLakeAnalytics':'datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/preview/2015-10-01-preview/account.json',
      'DataLakeStore':'datalake-store/resource-manager/Microsoft.DataLakeStore/preview/2015-10-01-preview/account.json',
      'DevTestLabs':'devtestlabs/resource-manager/Microsoft.DevTestLab/preview/2015-05-21-preview/DTL.json',
      'DNS':'dns/resource-manager/Microsoft.Network/preview/2015-05-04-preview/dns.json',
      'DNS ':'dns/resource-manager/Microsoft.Network/stable/2016-04-01/dns.json',
      'Insights':'monitor/resource-manager/microsoft.insights/stable/2016-03-01/alertRules_API.json',
      'Logic':'logic/resource-manager/Microsoft.Logic/preview/2015-02-01-preview/logic.json',
      'Logic ':'logic/resource-manager/Microsoft.Logic/stable/2016-06-01/logic.json',
      'MachineLearning':'machinelearning/resource-manager/Microsoft.MachineLearning/preview/2016-05-01-preview/webservices.json',
      'MobileEngagement':'mobileengagement/resource-manager/Microsoft.MobileEngagement/stable/2014-12-01/mobile-engagement.json',
      'Network':'network/resource-manager/Microsoft.Network/preview/2015-05-01-preview/network.json',
      'Network ':'network/resource-manager/Microsoft.Network/stable/2015-06-15/network.json',
      'Network  ':'network/resource-manager/Microsoft.Network/stable/2016-03-30/network.json',
      'Network   ':'network/resource-manager/Microsoft.Network/stable/2016-09-01/network.json',
      'NotificationHubs':'notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2016-03-01/notificationhubs.json',
      'PowerBIEmbedded':'powerbiembedded/resource-manager/Microsoft.PowerBI/stable/2016-01-29/powerbiembedded.json',
      'RecoveryServices':'recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2016-06-01/recoveryservicesbackup.json',
      'Redis':'redis/resource-manager/Microsoft.Cache/stable/2016-04-01/redis.json',
      'Resources/Locks':'resources/resource-manager/Microsoft.Authorization/stable/2016-09-01/locks.json',
      'Resources/Resources':'resources/resource-manager/Microsoft.Resources/stable/2016-09-01/resources.json',
      'Scheduler':'scheduler/resource-manager/Microsoft.Scheduler/stable/2016-03-01/scheduler.json',
      'Search':'search/resource-manager/Microsoft.Search/stable/2015-02-28/search.json',
      'ServerManagement':'servermanagement/resource-manager/Microsoft.ServerManagement/preview/2016-07-01-preview/servermanagement.json',
      'ServiceBus':'servicebus/resource-manager/Microsoft.ServiceBus/stable/2015-08-01/servicebus.json',
      'Storage':'storage/resource-manager/Microsoft.Storage/preview/2015-05-01-preview/storage.json',
      'Storage ':'storage/resource-manager/Microsoft.Storage/stable/2015-06-15/storage.json',
      'Storage  ':'storage/resource-manager/Microsoft.Storage/stable/2016-01-01/storage.json',
      'TrafficManager':'trafficmanager/resource-manager/Microsoft.Network/stable/2015-11-01/trafficmanager.json',
      'Web':'web/resource-manager/Microsoft.Web/stable/2015-08-01/service.json'
    },
    'outputDir': 'Resource/Expected',
    'language': 'azureresourceschema'
  },done
  return null
