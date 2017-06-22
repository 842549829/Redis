using System.Collections.Generic;
using Redis.Base;

namespace Redis
{
    /// <summary>
    /// Hash
    /// </summary>
    public class DoRedisHash : DoRedisBase
    {
        #region 添加
        /// <summary>
        /// 向hashid集合中添加key/value
        /// </summary>       
        /// <param name="hashid">hashid</param>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>result</returns>
        public bool SetEntryInHash(string hashid, string key, string value)
        {
            return Core.SetEntryInHash(hashid, key, value);
        }

        /// <summary>
        /// 如果hashid集合中存在key/value则不添加返回false，如果不存在在添加key/value,返回true
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>result</returns>
        public bool SetEntryInHashIfNotExists(string hashid, string key, string value)
        {
            return Core.SetEntryInHashIfNotExists(hashid, key, value);
        }

        /// <summary>
        /// 存储对象T t到hash集合中
        /// </summary>
        /// <param name="t">t</param>
        public void StoreAsHash<T>(T t)
        {
            Core.StoreAsHash(t);
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取对象T中ID为id的数据。
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>T</returns>
        public T GetFromHash<T>(object id)
        {
            return Core.GetFromHash<T>(id);
        }

        /// <summary>
        /// 获取所有hashid数据集的key/value数据集合
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <returns>result</returns>
        public Dictionary<string, string> GetAllEntriesFromHash(string hashid)
        {
            return Core.GetAllEntriesFromHash(hashid);
        }

        /// <summary>
        /// 获取hashid数据集中的数据总数
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <returns>result</returns>
        public long GetHashCount(string hashid)
        {
            return Core.GetHashCount(hashid);
        }

        /// <summary>
        /// 获取hashid数据集中所有key的集合
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <returns>result</returns>
        public List<string> GetHashKeys(string hashid)
        {
            return Core.GetHashKeys(hashid);
        }

        /// <summary>
        /// 获取hashid数据集中的所有value集合
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <returns>result</returns>
        public List<string> GetHashValues(string hashid)
        {
            return Core.GetHashValues(hashid);
        }

        /// <summary>
        /// 获取hashid数据集中，key的value数据
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <param name="key">key</param>
        /// <returns>result</returns>
        public string GetValueFromHash(string hashid, string key)
        {
            return Core.GetValueFromHash(hashid, key);
        }

        /// <summary>
        /// 获取hashid数据集中，多个keys的value集合
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <param name="keys">keys</param>
        /// <returns>result</returns>
        public List<string> GetValuesFromHash(string hashid, string[] keys)
        {
            return Core.GetValuesFromHash(hashid, keys);
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除hashid数据集中的key数据
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <param name="key">key</param>
        /// <returns>result</returns>
        public bool RemoveEntryFromHash(string hashid, string key)
        {
            return Core.RemoveEntryFromHash(hashid, key);
        }
        #endregion

        #region 其它
        /// <summary>
        /// 判断hashid数据集中是否存在key的数据
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <param name="key">key</param>
        /// <returns>result</returns>
        public bool HashContainsEntry(string hashid, string key)
        {
            return Core.HashContainsEntry(hashid, key);
        }

        /// <summary>
        /// 给hashid数据集key的value加countby，返回相加后的数据
        /// </summary>
        /// <param name="hashid">hashid</param>
        /// <param name="key">key</param>
        /// <param name="countBy">countBy</param>
        /// <returns>result</returns>
        public double IncrementValueInHash(string hashid, string key, double countBy)
        {
            return Core.IncrementValueInHash(hashid, key, countBy);
        }
        #endregion
    }
}