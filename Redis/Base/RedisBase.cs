using System;
using ServiceStack.Redis;

namespace Redis.Base
{
    /// <summary>
    /// RedisBase类，是redis操作的基类，继承自IDisposable接口，主要用于释放内存
    /// </summary>
    public abstract class RedisBase : IDisposable
    {
        /// <summary>
        /// 当前连接
        /// </summary>
        public static IRedisClient Core { get; private set; }

        /// <summary>
        /// 是否关闭连接
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static RedisBase()
        {
            Core = RedisManager.GetClient();
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing">是否释放</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Core.Dispose();
                    Core = null;
                }
            }
            this._disposed = true;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 保存数据DB文件到硬盘
        /// </summary>
        public void Save()
        {
            Core.Save();
        }

        /// <summary>
        /// 异步保存数据DB文件到硬盘
        /// </summary>
        public void SaveAsync()
        {
            Core.SaveAsync();
        }
    }
}