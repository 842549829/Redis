using System.Configuration;

namespace Redis.Configuration
{
    /// <summary>
    /// RedisSettings
    /// </summary>
    public sealed class RedisSettings : ConfigurationSection
    {
        /// <summary>
        /// GetConfig
        /// </summary>
        /// <returns>RedisSettings</returns>
        public static RedisSettings GetConfig()
        {
            RedisSettings section = GetConfig(RedisMappingConstants.RedisConfiguration);
            return section;
        }

        /// <summary>
        /// sectionName
        /// </summary>
        /// <param name="sectionName">sectionName</param>
        /// <returns>RedisSettings</returns>
        public static RedisSettings GetConfig(string sectionName)
        {
            RedisSettings section = (RedisSettings)ConfigurationManager.GetSection(sectionName);
            if (section == null)
            {
                throw new ConfigurationErrorsException("Section " + sectionName + " is not found.");
            }
            return section;
        }

        /// <summary>
        /// DB
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.DbAttributeName, IsKey = true, IsRequired = true)]
        public int Db
        {
            get
            {
                return (int)this[RedisMappingConstants.DbAttributeName];
            }

            set
            {
                this[RedisMappingConstants.DbAttributeName] = value;
            }
        }

        /// <summary>
        /// 可写的Redis链接地址
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.WriteServerConStrAttributeName, IsRequired = true)]
        public string WriteServerConStr
        {
            get
            {
                return (string)this[RedisMappingConstants.WriteServerConStrAttributeName];
            }

            set
            {
                this[RedisMappingConstants.WriteServerConStrAttributeName] = value;
            }
        }

        /// <summary>
        /// 可读的Redis链接地址
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.ReadServerConStrAttributeName, IsRequired = true)]
        public string ReadServerConStr
        {
            get
            {
                return (string)this[RedisMappingConstants.ReadServerConStrAttributeName];
            }

            set
            {
                this[RedisMappingConstants.ReadServerConStrAttributeName] = value;
            }
        }

        /// <summary>
        /// 最大写链接数
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.MaxWritePoolSizeAttributeName, IsRequired = true)]
        public int MaxWritePoolSize
        {
            get
            {
                return (int)this[RedisMappingConstants.MaxWritePoolSizeAttributeName];
            }

            set
            {
                this[RedisMappingConstants.MaxWritePoolSizeAttributeName] = value;
            }
        }

        /// <summary>
        /// 最大写链接数
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.MaxReadPoolSizeAttributeName, IsRequired = true)]
        public int MaxReadPoolSize
        {
            get
            {
                return (int)this[RedisMappingConstants.MaxReadPoolSizeAttributeName];
            }

            set
            {
                this[RedisMappingConstants.MaxReadPoolSizeAttributeName] = value;
            }
        }

        /// <summary>
        /// 自动重启
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.AutoStartAttributeName, IsRequired = true)]
        public bool AutoStart
        {
            get
            {
                return (bool)this[RedisMappingConstants.AutoStartAttributeName];
            }

            set
            {
                this[RedisMappingConstants.AutoStartAttributeName] = value;
            }
        }

        /// <summary>
        /// 本地缓存到期时间，单位:秒
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.LocalCacheTimeAttributeName, IsRequired = true)]
        public int LocalCacheTime
        {
            get
            {
                return (int)this[RedisMappingConstants.LocalCacheTimeAttributeName];
            }

            set
            {
                this[RedisMappingConstants.LocalCacheTimeAttributeName] = value;
            }
        }

        /// <summary>
        /// 是否记录日志,该设置仅用于排查redis运行时出现的问题,如redis工作正常,请关闭该项
        /// </summary>
        [ConfigurationProperty(RedisMappingConstants.RecordeLogAttributeName, IsRequired = true)]
        public bool RecordeLog
        {
            get
            {
                return (bool)this[RedisMappingConstants.RecordeLogAttributeName];
            }

            set
            {
                this[RedisMappingConstants.RecordeLogAttributeName] = value;
            }
        }
    }
}