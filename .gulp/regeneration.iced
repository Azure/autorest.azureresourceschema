
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
    'inputBaseDir': 'test/Resource/Swagger',
    'mappings': {
      'ApiManagement':'ApiManagement/2016-07-07/apimanagement.json',
      'Batch':'Batch/2015-12-01/BatchManagement.json',
      'CDN':'CDN/2015-06-01/cdn.json',
      'CDN ':'CDN/2016-04-02/cdn.json',
      'CognitiveServices':'CognitiveServices/2016-02-01-preview/cognitiveservices.json',
      'CommitmentPlans':'CommitmentPlans/2016-05-01-preview/commitmentPlans.json',
      'Compute':'Compute/2015-06-15/compute.json',
      'Compute ':'Compute/2016-03-30/compute.json',
      'ContainerService':'ContainerService/2016-03-30/containerService.json',
      'DataLakeAnalytics':'DataLakeAnalytics/2015-10-01-preview/account.json',
      'DataLakeStore':'DataLakeStore/2015-10-01-preview/account.json',
      'DevTestLabs':'DevTestLabs/2015-05-21-preview/DTL.json',
      'DNS':'DNS/2015-05-04-preview/dns.json',
      'DNS ':'DNS/2016-04-01/dns.json',
      'Insights':'Insights/2016-03-01/insightsManagementClient.json',
      'Logic':'Logic/2015-02-01-preview/logic.json',
      'Logic ':'Logic/2016-06-01/logic.json',
      'MachineLearning':'MachineLearning/2016-05-01-preview/webservices.json',
      'MobileEngagement':'MobileEngagement/2014-12-01/mobile-engagement.json',
      'Network':'Network/2015-05-01-preview/network.json',
      'Network ':'Network/2015-06-15/network.json',
      'Network  ':'Network/2016-03-30/network.json',
      'Network   ':'Network/2016-09-01/network.json',
      'NotificationHubs':'NotificationHubs/2016-03-01/notificationhubs.json',
      'PowerBIEmbedded':'PowerBIEmbedded/2016-01-29/powerbiembedded.json',
      'RecoveryServices':'RecoveryServices/2016-06-01/recoveryservices.json',
      'Redis':'Redis/2016-04-01/redis.json',
      'Resources/Locks':'Resources/Locks/2016-09-01/locks.json',
      'Resources/Resources':'Resources/Resources/2016-09-01/resources.json',
      'Scheduler':'Scheduler/2016-03-01/scheduler.json',
      'Search':'Search/2015-02-28/search.json',
      'ServerManagement':'ServerManagement/2016-07-01-preview/servermanagement.json',
      'ServiceBus':'ServiceBus/2015-08-01/servicebus.json',
      'Storage':'Storage/2015-05-01-preview/storage.json',
      'Storage ':'Storage/2015-06-15/storage.json',
      'Storage  ':'Storage/2016-01-01/storage.json',
      'TrafficManager':'TrafficManager/2015-11-01/trafficmanager.json',
      'Web':'Web/2015-08-01/web.json'
    },
    'outputDir': 'Resource/Expected',
    'language': 'azureresourceschema'
  },done
  return null