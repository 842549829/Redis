using System.Collections.Generic;
using Redis.Base;

namespace Redis
{
    /// <summary>
    /// ZSet
    /// </summary>
    public class DoRedisZSet : DoRedisBase
    {
        #region 添加
        /// <summary>
        /// 添加key/value，默认分数是从1.多*10的9次方以此递增的,自带自增效果
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>reulst</returns>
        public bool AddItemToSortedSet(string key, string value)
        {
            return Core.AddItemToSortedSet(key, value);
        }

        /// <summary>
        /// 添加key/value,并设置value的分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="score">score</param>
        /// <returns>result</returns>
        public bool AddItemToSortedSet(string key, string value, double score)
        {
            return Core.AddItemToSortedSet(key, value, score);
        }

        /// <summary>
        /// 为key添加values集合，values集合中每个value的分数设置为score
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="values">values</param>
        /// <param name="score">score</param>
        /// <returns>rel</returns>
        public bool AddRangeToSortedSet(string key, List<string> values, double score)
        {
            return Core.AddRangeToSortedSet(key, values, score);
        }

        /// <summary>
        /// 为key添加values集合，values集合中每个value的分数设置为score
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="values">values</param>
        /// <param name="score">score</param>
        /// <returns>rel</returns>
        public bool AddRangeToSortedSet(string key, List<string> values, long score)
        {
            return Core.AddRangeToSortedSet(key, values, score);
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取key的所有集合
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public List<string> GetAllItemsFromSortedSet(string key)
        {
            return Core.GetAllItemsFromSortedSet(key);
        }

        /// <summary>
        /// 获取key的所有集合，倒叙输出
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public List<string> GetAllItemsFromSortedSetDesc(string key)
        {
            return Core.GetAllItemsFromSortedSetDesc(key);
        }

        /// <summary>
        /// 获取可以的说有集合，带分数
        /// </summary>
        /// <param name="key"></param>
        /// <returns>rel</returns>
        public IDictionary<string, double> GetAllWithScoresFromSortedSet(string key)
        {
            return Core.GetAllWithScoresFromSortedSet(key);
        }

        /// <summary>
        /// 获取key为value的下标值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>rel</returns>
        public long GetItemIndexInSortedSet(string key, string value)
        {
            return Core.GetItemIndexInSortedSet(key, value);
        }

        /// <summary>
        /// 倒叙排列获取key为value的下标值
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>rel</returns>
        public long GetItemIndexInSortedSetDesc(string key, string value)
        {
            return Core.GetItemIndexInSortedSetDesc(key, value);
        }

        /// <summary>
        /// 获取key为value的分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>rel</returns>
        public double GetItemScoreInSortedSet(string key, string value)
        {
            return Core.GetItemScoreInSortedSet(key, value);
        }

        /// <summary>
        /// 获取key所有集合的数据总数
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public long GetSortedSetCount(string key)
        {
            return Core.GetSortedSetCount(key);
        }

        /// <summary>
        /// key集合数据从分数为fromscore到分数为toscore的数据总数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromScore">fromScore</param>
        /// <param name="toScore">toScore</param>
        /// <returns>rel</returns>
        public long GetSortedSetCount(string key, double fromScore, double toScore)
        {
            return Core.GetSortedSetCount(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合从高分到低分排序数据，分数从fromscore到分数为toscore的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromScore">fromscore</param>
        /// <param name="toScore">toScore</param>
        /// <returns>rel</returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, double fromScore, double toScore)
        {
            return Core.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合从低分到高分排序数据，分数从fromscore到分数为toscore的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromScore">fromscore</param>
        /// <param name="toScore">toScore</param>
        /// <returns>rel</returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, double fromScore, double toScore)
        {
            return Core.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合从高分到低分排序数据，分数从fromscore到分数为toscore的数据，带分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromScore">fromscore</param>
        /// <param name="toScore">toScore</param>
        /// <returns>rel</returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, double fromScore, double toScore)
        {
            return Core.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        ///  获取key集合从低分到高分排序数据，分数从fromscore到分数为toscore的数据，带分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromScore">fromscore</param>
        /// <param name="toScore">toScore</param>
        /// <returns>rel</returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, double fromScore, double toScore)
        {
            return Core.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        ///  获取key集合数据，下标从fromRank到分数为toRank的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromRank">fromRank</param>
        /// <param name="toRank">toRank</param>
        /// <returns>rel</returns>
        public List<string> GetRangeFromSortedSet(string key, int fromRank, int toRank)
        {
            return Core.GetRangeFromSortedSet(key, fromRank, toRank);
        }

        /// <summary>
        /// 获取key集合倒叙排列数据，下标从fromRank到分数为toRank的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromRank">fromRank</param>
        /// <param name="toRank">toRank</param>
        /// <returns>rel</returns>
        public List<string> GetRangeFromSortedSetDesc(string key, int fromRank, int toRank)
        {
            return Core.GetRangeFromSortedSetDesc(key, fromRank, toRank);
        }

        /// <summary>
        /// 获取key集合数据，下标从fromRank到分数为toRank的数据，带分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromRank">fromRank</param>
        /// <param name="toRank">toRank</param>
        /// <returns>rel</returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSet(string key, int fromRank, int toRank)
        {
            return Core.GetRangeWithScoresFromSortedSet(key, fromRank, toRank);
        }

        /// <summary>
        ///  获取key集合倒叙排列数据，下标从fromRank到分数为toRank的数据，带分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromRank">fromRank</param>
        /// <param name="toRank">toRank</param>
        /// <returns>rel</returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetDesc(string key, int fromRank, int toRank)
        {
            return Core.GetRangeWithScoresFromSortedSetDesc(key, fromRank, toRank);
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除key为value的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>rel</returns>
        public bool RemoveItemFromSortedSet(string key, string value)
        {
            return Core.RemoveItemFromSortedSet(key, value);
        }

        /// <summary>
        /// 删除下标从minRank到maxRank的key集合数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="minRank">minRank</param>
        /// <param name="maxRank">maxRank</param>
        /// <returns>rel</returns>
        public long RemoveRangeFromSortedSet(string key, int minRank, int maxRank)
        {
            return Core.RemoveRangeFromSortedSet(key, minRank, maxRank);
        }

        /// <summary>
        /// 删除分数从fromscore到toscore的key集合数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="fromScore">fromscore</param>
        /// <param name="toScore">toScore</param>
        /// <returns>rel</returns>
        public long RemoveRangeFromSortedSetByScore(string key, double fromScore, double toScore)
        {
            return Core.RemoveRangeFromSortedSetByScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 删除key集合中分数最大的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public string PopItemWithHighestScoreFromSortedSet(string key)
        {
            return Core.PopItemWithHighestScoreFromSortedSet(key);
        }

        /// <summary>
        /// 删除key集合中分数最小的数据
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>rel</returns>
        public string PopItemWithLowestScoreFromSortedSet(string key)
        {
            return Core.PopItemWithLowestScoreFromSortedSet(key);
        }
        #endregion

        #region 其它
        /// <summary>
        /// 判断key集合中是否存在value数据
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <returns>rel</returns>
        public bool SortedSetContainsItem(string key, string value)
        {
            return Core.SortedSetContainsItem(key, value);
        }

        /// <summary>
        /// 为key集合值为value的数据，分数加scoreby，返回相加后的分数
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="scoreBy">scoreBy</param>
        /// <returns>rel</returns>
        public double IncrementItemInSortedSet(string key, string value, double scoreBy)
        {
            return Core.IncrementItemInSortedSet(key, value, scoreBy);
        }

        /// <summary>
        /// 获取keys多个集合的交集，并把交集添加的newkey集合中，返回交集数据的总数
        /// </summary>
        /// <param name="newkey">newKey</param>
        /// <param name="keys">keys</param>
        /// <returns>rel</returns>
        public long StoreIntersectFromSortedSets(string newkey, string[] keys)
        {
            return Core.StoreIntersectFromSortedSets(newkey, keys);
        }

        /// <summary>
        /// 获取keys多个集合的并集，并把并集数据添加到newkey集合中，返回并集数据的总数
        /// </summary>
        /// <param name="newkey">newKeys</param>
        /// <param name="keys">keys</param>
        /// <returns>rel</returns>
        public long StoreUnionFromSortedSets(string newkey, string[] keys)
        {
            return Core.StoreUnionFromSortedSets(newkey, keys);
        }
        #endregion
    }
}