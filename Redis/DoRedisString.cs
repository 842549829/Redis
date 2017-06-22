using System;
using System.Collections.Generic;
using Redis.Base;

namespace Redis
{
    /// <summary>
    /// String
    /// </summary>
    public class DoRedisString : DoRedisBase
    {
        #region 赋值

        /// <summary>
        /// 设置key的value
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>result</returns>
        public bool Set<T>(string key, T value)
        {
            return Core.Set(key, value);
        }

        /// <summary>
        /// 设置key的value并设置过期时间
        /// </summary>
        /// /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="dt">dt</param>
        /// <returns>result</returns>
        public bool Set<T>(string key, T value, DateTime dt)
        {
            return Core.Set(key, value, dt);
        }

        /// <summary>
        /// 设置key的value并设置过期时间
        /// </summary>
        /// /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="sp">sp</param>
        /// <returns>result</returns>
        public bool Set<T>(string key, T value, TimeSpan sp)
        {
            return Core.Set(key, value, sp);
        }

        /// <summary>
        /// 设置多个key/value
        /// </summary>
        /// <param name="dic">dic</param>
        public void Set(Dictionary<string, string> dic)
        {
            Core.SetAll(dic);
        }

        #endregion

        #region 追加
        /// <summary>
        /// 在原有key的value值之后追加value
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>result</returns>
        public long Append(string key, string value)
        {
            return Core.AppendToValue(key, value);
        }
        #endregion

        #region 获取值

        /// <summary>
        /// 获取key的value值
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>value</returns>
        public string Get(string key)
        {
            return Core.GetValue(key);
        }

        /// <summary>
        /// 获取key的value值
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>value</returns>
        public T Get<T>(string key)
        {
            return Core.Get<T>(key);
        }

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        /// <param name="keys">keys</param>
        /// <returns>value</returns>
        public List<string> Get(List<string> keys)
        {
            return Core.GetValues(keys);
        }

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        /// <param name="keys">keys</param>
        /// <returns>value</returns>
        public List<T> Get<T>(List<string> keys)
        {
            return Core.GetValues<T>(keys);
        }
        #endregion

        #region 获取旧值赋上新值

        /// <summary>
        /// 获取旧值赋上新值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>result</returns>
        public string GetAndSetValue(string key, string value)
        {
            return Core.GetAndSetValue(key, value);
        }
        #endregion

        #region 辅助方法
        /// <summary>
        /// 获取值的长度
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>count</returns>
        public long GetCount(string key)
        {
            return Core.GetStringCount(key);
        }

        /// <summary>
        /// 自增1，返回自增后的值
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>id</returns>
        public long Incr(string key)
        {
            return Core.IncrementValue(key);
        }

        /// <summary>
        /// 自增count，返回自增后的值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="count">count</param>
        /// <returns>double</returns>
        public double IncrBy(string key, double count)
        {
            return Core.IncrementValueBy(key, count);
        }

        /// <summary>
        /// 自减1，返回自减后的值
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>long</returns>
        public long Decr(string key)
        {
            return Core.DecrementValue(key);
        }

        /// <summary>
        /// 自减count ，返回自减后的值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="count">count</param>
        /// <returns>long</returns>
        public long DecrBy(string key, int count)
        {
            return Core.DecrementValueBy(key, count);
        }
        #endregion
    }
}