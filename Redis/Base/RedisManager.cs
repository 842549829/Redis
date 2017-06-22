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
        private static readonly RedisSettings redisSettings = RedisSettings.GetConfig();

        /// <summary>
        /// 连接池
        /// </summary>
        private static PooledRedisClientManager pooledRedisClientManager;

        /// <summary>
        /// 静态构造方法，初始化链接池管理对象
        /// </summary>
        static RedisManager()
        {
            CreateManager();
        }

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
        /// 客户端缓存操作对象
        /// </summary>
        public static IRedisClient GetClient()
        {
            if (pooledRedisClientManager == null)
            {
                CreateManager();
            }
            return pooledRedisClientManager?.GetClient();
        }
    }
}