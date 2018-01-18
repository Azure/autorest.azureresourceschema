
###############################################
# LEGACY 
# Instead: have bunch of configuration files sitting in a well-known spot, discover them, feed them to AutoRest, done.

regenExpected = (opts,done) ->
  keys = Object.getOwnPropertyNames(opts.mappings)
  instances = keys.length

  for kkey in keys
    value = opts.mappings[kkey]
    # swaggerFiles = [swaggerFiles] if !(swaggerFiles instanceof Array)
    key = kkey.trim();

    args = [
      "--#{opts.language}.output-folder=#{__dirname}/../#{opts.outputDir}/#{key}",
      # "--clear-output-folder", # run multiple times on same folders (API version nests)
      "--title=title",
      "--license-header=#{if !!opts.header then opts.header else 'MICROSOFT_MIT_NO_VERSION'}"
    ]

    # for swaggerFile in swaggerFiles
    #   args.push("--input-file=#{if !!opts.inputBaseDir then "#{opts.inputBaseDir}/#{swaggerFile}" else swaggerFile}")
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
    'inputBaseDir': 'https://github.com/Azure/azure-rest-api-specs/blob/olydis-patches/specification',
    'mappings': {
      'Compute': { folder: 'compute', tags: [ 'package-2017-12', 'package-2017-03', 'package-2016-04-preview', 'package-2016-03', 'package-2015-06-preview' ] },
      # 'ApiManagement':'apimanagement/resource-manager/Microsoft.ApiManagement/stable/2017-03-01/apimanagement.json',
      # 'Batch':'batch/resource-manager/Microsoft.Batch/stable/2015-12-01/BatchManagement.json',
      # 'CDN':'cdn/resource-manager/Microsoft.Cdn/stable/2015-06-01/cdn.json',
      # 'CDN ':'cdn/resource-manager/Microsoft.Cdn/stable/2016-04-02/cdn.json',
      # 'CognitiveServices':'cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2016-02-01-preview/cognitiveservices.json',
      # 'CommitmentPlans':'machinelearning/resource-manager/Microsoft.MachineLearning/preview/2016-05-01-preview/commitmentPlans.json',
      # 'Compute':'compute/resource-manager/Microsoft.Compute/stable/2015-06-15/compute.json',
      # 'Compute ':'compute/resource-manager/Microsoft.Compute/stable/2016-03-30/compute.json',
      # 'Compute  ': [ 'compute/resource-manager/Microsoft.Compute/stable/2017-03-30/compute.json', 'compute/resource-manager/Microsoft.Compute/stable/2017-03-30/disk.json'],
      # 'ContainerService':'compute/resource-manager/Microsoft.ContainerService/stable/2016-03-30/containerService.json',
      # 'DataLakeAnalytics':'datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/preview/2015-10-01-preview/account.json',
      # 'DataLakeStore':'datalake-store/resource-manager/Microsoft.DataLakeStore/preview/2015-10-01-preview/account.json',
      # 'DevTestLabs':'devtestlabs/resource-manager/Microsoft.DevTestLab/preview/2015-05-21-preview/DTL.json',
      # 'DevTestLabs ':'devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2016-05-15/DTL.json',
      # 'DNS':'dns/resource-manager/Microsoft.Network/preview/2015-05-04-preview/dns.json',
      # 'DNS ':'dns/resource-manager/Microsoft.Network/stable/2016-04-01/dns.json',
      # 'Insights':'monitor/resource-manager/microsoft.insights/stable/2016-03-01/alertRules_API.json',
      # 'Insights ':'monitor/resource-manager/microsoft.insights/stable/2017-04-01/actionGroups_API.json',
      # 'Insights  ':'monitor/resource-manager/microsoft.insights/stable/2017-04-01/activityLogAlerts_API.json',
      # 'Logic':'logic/resource-manager/Microsoft.Logic/preview/2015-02-01-preview/logic.json',
      # 'Logic ':'logic/resource-manager/Microsoft.Logic/stable/2016-06-01/logic.json',
      # 'MachineLearning':'machinelearning/resource-manager/Microsoft.MachineLearning/preview/2016-05-01-preview/webservices.json',
      # 'MobileEngagement':'mobileengagement/resource-manager/Microsoft.MobileEngagement/stable/2014-12-01/mobile-engagement.json',
      # 'Network':'network/resource-manager/Microsoft.Network/preview/2015-05-01-preview/network.json',
      # 'Network ':'network/resource-manager/Microsoft.Network/stable/2015-06-15/network.json',
      # 'Network  ':'network/resource-manager/Microsoft.Network/stable/2016-03-30/network.json',
      # 'Network   ':'network/resource-manager/Microsoft.Network/stable/2016-09-01/virtualNetwork.json',
      # 'NotificationHubs':'notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2016-03-01/notificationhubs.json',
      # 'PowerBIEmbedded':'powerbiembedded/resource-manager/Microsoft.PowerBI/stable/2016-01-29/powerbiembedded.json',
      # 'RecoveryServices':'recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2016-06-01/recoveryservicesbackup.json',
      # 'Redis':'redis/resource-manager/Microsoft.Cache/stable/2016-04-01/redis.json',
      # 'Resources':'resources/resource-manager/Microsoft.Authorization/stable/2016-09-01/locks.json',
      # 'Resources ':'resources/resource-manager/Microsoft.Resources/stable/2016-02-01/resources.json',
      # 'Scheduler':'scheduler/resource-manager/Microsoft.Scheduler/stable/2016-03-01/scheduler.json',
      # 'Search':'search/resource-manager/Microsoft.Search/stable/2015-02-28/search.json',
      # 'ServerManagement':'servermanagement/resource-manager/Microsoft.ServerManagement/preview/2016-07-01-preview/servermanagement.json',
      # 'ServiceBus':'servicebus/resource-manager/Microsoft.ServiceBus/stable/2015-08-01/servicebus.json',
      # 'Storage':'storage/resource-manager/Microsoft.Storage/preview/2015-05-01-preview/storage.json',
      # 'Storage ':'storage/resource-manager/Microsoft.Storage/stable/2015-06-15/storage.json',
      # 'Storage  ':'storage/resource-manager/Microsoft.Storage/stable/2016-01-01/storage.json',
      # 'TrafficManager':'trafficmanager/resource-manager/Microsoft.Network/stable/2015-11-01/trafficmanager.json',
      # 'Web':'web/resource-manager/Microsoft.Web/stable/2016-08-01/WebApps.json'
    },
    'language': 'azureresourceschema'
  },done
  return null
