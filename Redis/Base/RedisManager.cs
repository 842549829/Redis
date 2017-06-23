using System.Linq;
using Redis.Configuration;
using ServiceStack.Redis;

namespace Redis.Base
{
    /// <summary>
    /// RedisManager
    /// </summary>
    public class RedisManager
    {
        /// <summary>
        /// RedisMappingElement
        /// </summary>
        private static RedisSettings redisSettings;

        /// <summary>
        /// 连接池
        /// </summary>
        private static PooledRedisClientManager pooledRedisClientManager;

        /// <summary>
        /// 创建链接池管理对象
        /// </summary>
        private static void CreateManager()
        {
            string[] WriteServerConStr = SplitString(redisSettings.WriteServerConStr, ",");
            string[] ReadServerConStr = SplitString(redisSettings.ReadServerConStr, ",");
            pooledRedisClientManager = new PooledRedisClientManager(ReadServerConStr, WriteServerConStr,
                new RedisClientManagerConfig
                {
                    MaxWritePoolSize = redisSettings.MaxWritePoolSize,
                    MaxReadPoolSize = redisSettings.MaxReadPoolSize,
                    AutoStart = redisSettings.AutoStart,
                    DefaultDb = redisSettings.Db
                });
        }

        /// <summary>
        /// 地址拆分
        /// </summary>
        /// <param name="strSource">strSource</param>
        /// <param name="split">split</param>
        /// <returns>result</returns>
        private static string[] SplitString(string strSource, string split)
        {
            return strSource.Split(split.ToArray());
        }

        /// <summary>
        /// 获取连接
        /// </summary>
        /// <param name="sectionName">节点名称</param>
        public static IRedisClient GetClient(string sectionName = null)
        {
            if (pooledRedisClientManager == null)
            {
                redisSettings = sectionName == null ? RedisSettings.GetConfig() : RedisSettings.GetConfig(sectionName);
                CreateManager();
            }
            return pooledRedisClientManager?.GetClient();
        }
    }
}