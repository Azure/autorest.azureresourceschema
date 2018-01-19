# Microsoft.Cache/Redis template reference
API Version: 2015-08-01
## Template format

To create a Microsoft.Cache/Redis resource, add the following JSON to the resources section of your template.

```json
{
  "name": "string",
  "type": "Microsoft.Cache/Redis",
  "apiVersion": "2015-08-01",
  "location": "string",
  "tags": {},
  "properties": {
    "redisVersion": "string",
    "sku": {
      "name": "string",
      "family": "string",
      "capacity": "integer"
    },
    "redisConfiguration": {},
    "enableNonSslPort": boolean,
    "tenantSettings": {},
    "shardCount": "integer",
    "virtualNetwork": "string",
    "subnet": "string",
    "staticIP": "string"
  }
}
```
## Property values

The following tables describe the values you need to set in the schema.

<a id="Microsoft.Cache/Redis" />
### Microsoft.Cache/Redis object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | string | Yes |  |
|  type | enum | Yes | Microsoft.Cache/Redis |
|  apiVersion | enum | Yes | 2015-08-01 |
|  location | string | Yes | Resource location. |
|  tags | object | No | Resource tags. |
|  properties | object | Yes | Redis cache properties. - [RedisProperties object](#RedisProperties) |


<a id="RedisProperties" />
### RedisProperties object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  redisVersion | string | No | RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored. |
|  sku | object | Yes | What SKU of Redis cache to deploy. - [Sku object](#Sku) |
|  redisConfiguration | object | No | All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc. |
|  enableNonSslPort | boolean | No | If the value is true, then the non-SLL Redis server port (6379) will be enabled. |
|  tenantSettings | object | No | tenantSettings |
|  shardCount | integer | No | The number of shards to be created on a Premium Cluster Cache. |
|  virtualNetwork | string | No | The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1 |
|  subnet | string | No | Required when deploying a Redis cache inside an existing Azure Virtual Network. |
|  staticIP | string | No | Required when deploying a Redis cache inside an existing Azure Virtual Network. |


<a id="Sku" />
### Sku object
|  Name | Type | Required | Value |
|  ---- | ---- | ---- | ---- |
|  name | enum | Yes | What type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). - Basic, Standard, Premium |
|  family | enum | Yes | Which family to use. Valid values: (C, P). - C or P |
|  capacity | integer | Yes | What size of Redis cache to deploy. Valid values: for C family (0, 1, 2, 3, 4, 5, 6), for P family (1, 2, 3, 4). |

