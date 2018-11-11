using System;
using System.Collections.Generic;
using ServiceStack.Redis;

namespace Amtrack.Cache.Store
{
    public enum ConfigurationType
    {
        DefaultCacheTimeSpan = 0,
        AppKey = 1
    }

    public abstract class BaseCacheStore : ICacheStore
    {
        #region Private Variables
        private readonly Dictionary<ConfigurationType, object> _configurations = null; 
        #endregion

        #region Protected Variables
        protected string appKey;
        protected TimeSpan defaultCacheTimeSpan;
        protected RedisClient redisClient;
        protected bool initialized = false;
        #endregion

        protected BaseCacheStore(Dictionary<ConfigurationType, object> configurations)
        {
            this._configurations = configurations;
        }

        #region Private Methods
        private void Init()
        {
            if(_configurations.ContainsKey(ConfigurationType.DefaultCacheTimeSpan))
                defaultCacheTimeSpan = (TimeSpan)_configurations[ConfigurationType.DefaultCacheTimeSpan];
            else
                defaultCacheTimeSpan = new TimeSpan(0, 10, 0);

            if(_configurations.ContainsKey(ConfigurationType.AppKey))
                appKey = (string)_configurations[ConfigurationType.AppKey];
            else
                appKey = Guid.NewGuid().ToString();

            initialized = true;
        }

        #endregion
        #region Public Methods

        public void Init(string host)
        {
            redisClient = new RedisClient(host);

            Init();
        }

        public void Init(string host, int Port)
        {
            redisClient = new RedisClient(host, Port);

            Init();
        }
        #endregion

        #region Abstract Methods
        public abstract void FlushALL();
        public abstract IList<T> Get<T>(string[] keys);
        public abstract T Get<T>(string Key);
        public abstract IList<T> GetAll<T>();
        public abstract void Set<T>(string key, T value, TimeSpan cacheTimeSpan = default(TimeSpan));
        public abstract void Remove<T>(string key);
        public abstract void Remove<T>(string[] keys);
        public abstract void DeleteAll<T>();
        #endregion
    }
}
