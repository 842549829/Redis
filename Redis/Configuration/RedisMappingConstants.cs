namespace Redis.Configuration
{
    /// <summary>
    /// 配置节点名称
    /// </summary>
    public class RedisMappingConstants
    {
        /// <summary>
        /// 配置文件映射节点
        /// </summary>
        public const string RedisConfiguration = "redisConfiguration";

        /// <summary>
        /// 数据库实例名称
        /// </summary>
        public const string DbAttributeName = "db";

        /// <summary>
        /// 可写的Redis链接地址
        /// </summary>
        public const string WriteServerConStrAttributeName = "writeServerConStr";

        /// <summary>
        /// 可读的Redis链接地址
        /// </summary>
        public const string ReadServerConStrAttributeName = "readServerConStr";

        /// <summary>
        /// 最大写链接数
        /// </summary>
        public const string MaxWritePoolSizeAttributeName = "maxWritePoolSize";

        /// <summary>
        /// 最大读链接数
        /// </summary>
        public const string MaxReadPoolSizeAttributeName = "maxReadPoolSize";

        /// <summary>
        /// 自动重启
        /// </summary>
        public const string AutoStartAttributeName = "autoStart";

        /// <summary>
        /// 本地缓存到期时间，单位:秒
        /// </summary>
        public const string LocalCacheTimeAttributeName = "localCacheTime";

        /// <summary>
        /// 是否记录日志,该设置仅用于排查redis运行时出现的问题,如redis工作正常,请关闭该项
        /// </summary>
        public const string RecordeLogAttributeName = "recordeLog";
    }
}