﻿using System;
using System.Collections.Generic;
using Redis.Base;
using ServiceStack.Redis;

namespace Redis
{
    /// <summary>
    /// List
    /// </summary>
    public class DoRedisList : DoRedisBase
    {
        #region 赋值
        /// <summary>
        /// 从左侧向list中添加值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public void LPush(string key, string value)
        {
            Core.PushItemToList(key, value);
        }

        /// <summary>
        /// 从左侧向list中添加值，并设置过期时间
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="dt">dt</param>
        public void LPush(string key, string value, DateTime dt)
        {
            Core.PushItemToList(key, value);
            Core.ExpireEntryAt(key, dt);
        }

        /// <summary>
        /// 从左侧向list中添加值，设置过期时间
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="sp">sp</param>
        public void LPush(string key, string value, TimeSpan sp)
        {
            Core.PushItemToList(key, value);
            Core.ExpireEntryIn(key, sp);
        }

        /// <summary>
        /// 从左侧向list中添加值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public void RPush(string key, string value)
        {
            Core.PrependItemToList(key, value);
        }

        /// <summary>
        /// 从右侧向list中添加值，并设置过期时间
        /// </summary>    
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="dt">dt</param>
        public void RPush(string key, string value, DateTime dt)
        {
            Core.PrependItemToList(key, value);
            Core.ExpireEntryAt(key, dt);
        }

        /// <summary>
        /// 从右侧向list中添加值，并设置过期时间
        /// </summary>        
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="sp">sp</param>
        public void RPush(string key, string value, TimeSpan sp)
        {
            Core.PrependItemToList(key, value);
            Core.ExpireEntryIn(key, sp);
        }

        /// <summary>
        /// 添加key/value
        /// </summary>     
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public void Add(string key, string value)
        {
            Core.AddItemToList(key, value);
        }

        /// <summary>
        /// 添加key/value ,并设置过期时间
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="dt">dt</param>
        public void Add(string key, string value, DateTime dt)
        {
            Core.AddItemToList(key, value);
            Core.ExpireEntryAt(key, dt);
        }

        /// <summary>
        /// 添加key/value。并添加过期时间
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="sp">sp</param>
        public void Add(string key, string value, TimeSpan sp)
        {
            Core.AddItemToList(key, value);
            Core.ExpireEntryIn(key, sp);
        }

        /// <summary>
        /// 为key添加多个值
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="values">value</param>
        public void Add(string key, List<string> values)
        {
            Core.AddRangeToList(key, values);
        }

        /// <summary>
        /// 为key添加多个值，并设置过期时间
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="values">value</param>
        /// <param name="dt">dt</param>
        public void Add(string key, List<string> values, DateTime dt)
        {
            Core.AddRangeToList(key, values);
            Core.ExpireEntryAt(key, dt);
        }

        /// <summary>
        /// 为key添加多个值，并设置过期时间
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="values">value</param>
        /// <param name="sp">sp</param>
        public void Add(string key, List<string> values, TimeSpan sp)
        {
            Core.AddRangeToList(key, values);
            Core.ExpireEntryIn(key, sp);
        }
        #endregion

        #region 获取值
        /// <summary>
        /// 获取list中key包含的数据数量
        /// </summary>  
        /// <param name="key"></param>
        /// <returns>long</returns>
        public long Count(string key)
        {
            return Core.GetListCount(key);
        }

        /// <summary>
        /// 获取key包含的所有数据集合
        /// </summary>  
        /// <param name="key">key</param>
        /// <returns>result</returns>
        public List<string> Get(string key)
        {
            return Core.GetAllItemsFromList(key);
        }

        /// <summary>
        /// 获取key中下标为star到end的值集合
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="star">star</param>
        /// <param name="end">end</param>
        /// <returns>result</returns>
        public List<string> Get(string key, int star, int end)
        {
            return Core.GetRangeFromList(key, star, end);
        }
        #endregion

        #region 阻塞命令
        /// <summary>
        ///  阻塞命令：从list中keys的尾部移除一个值，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="sp">sp</param>
        /// <returns>result</returns>
        public string BlockingPopItemFromList(string key, TimeSpan? sp)
        {
            return Core.BlockingDequeueItemFromList(key, sp);
        }

        /// <summary>
        ///  阻塞命令：从list中keys的尾部移除一个值，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="keys">keys</param>
        /// <param name="sp">sp</param>
        /// <returns>ItemRef</returns>
        public ItemRef BlockingPopItemFromLists(string[] keys, TimeSpan? sp)
        {
            return Core.BlockingPopItemFromLists(keys, sp);
        }

        /// <summary>
        ///  阻塞命令：从list中keys的尾部移除一个值，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="sp">sp</param>
        /// <returns>result</returns>
        public string BlockingDequeueItemFromList(string key, TimeSpan? sp)
        {
            return Core.BlockingDequeueItemFromList(key, sp);
        }

        /// <summary>
        /// 阻塞命令：从list中keys的尾部移除一个值，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="keys">keys</param>
        /// <param name="sp">sp</param>
        /// <returns>ItemRef</returns>
        public ItemRef BlockingDequeueItemFromLists(string[] keys, TimeSpan? sp)
        {
            return Core.BlockingDequeueItemFromLists(keys, sp);
        }

        /// <summary>
        /// 阻塞命令：从list中key的头部移除一个值，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="keys">keys</param>
        /// <param name="sp">sp</param>
        /// <returns>rel</returns>
        public string BlockingRemoveStartFromList(string keys, TimeSpan? sp)
        {
            return Core.BlockingRemoveStartFromList(keys, sp);
        }

        /// <summary>
        /// 阻塞命令：从list中key的头部移除一个值，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="keys">keys</param>
        /// <param name="sp">sp</param>
        /// <returns>rel</returns>
        public ItemRef BlockingRemoveStartFromLists(string[] keys, TimeSpan? sp)
        {
            return Core.BlockingRemoveStartFromLists(keys, sp);
        }

        /// <summary>
        /// 阻塞命令：从list中一个fromkey的尾部移除一个值，添加到另外一个tokey的头部，并返回移除的值，阻塞时间为sp
        /// </summary>  
        /// <param name="fromkey">fromkey</param>
        /// <param name="tokey">tokey</param>
        /// <param name="sp">sp</param>
        public string BlockingPopAndPushItemBetweenLists(string fromkey, string tokey, TimeSpan? sp)
        {
            return Core.BlockingPopAndPushItemBetweenLists(fromkey, tokey, sp);
        }
        #endregion

        #region 删除
        /// <summary>
        /// 从尾部移除数据，返回移除的数据
        /// </summary>  
        /// <param name="key">key</param>
        public string PopItemFromList(string key)
        {
            return Core.PopItemFromList(key);
        }

        /// <summary>
        /// 移除list中，key/value,与参数相同的值，并返回移除的数量
        /// </summary>  
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>rel</returns>
        public long RemoveItemFromList(string key, string value)
        {
            return Core.RemoveItemFromList(key, value);
        }

        /// <summary>
        /// 从list的尾部移除一个数据，返回移除的数据
        /// </summary>  
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public string RemoveEndFromList(string key)
        {
            return Core.RemoveEndFromList(key);
        }

        /// <summary>
        /// 从list的头部移除一个数据，返回移除的值
        /// </summary>  
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public string RemoveStartFromList(string key)
        {
            return Core.RemoveStartFromList(key);
        }
        #endregion

        #region 其它
        /// <summary>
        /// 从一个list的尾部移除一个数据，添加到另外一个list的头部，并返回移动的值
        /// </summary>  
        /// <param name="fromKey">fromkey</param>
        /// <param name="toKey">tokey</param>
        /// <returns>rel</returns>
        public string PopAndPushItemBetweenLists(string fromKey, string toKey)
        {
            return Core.PopAndPushItemBetweenLists(fromKey, toKey);
        }
        #endregion
    }
}