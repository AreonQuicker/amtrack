using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Newtonsoft;

namespace Amtrack.Cache.Store
{
    public enum ConfigurationType
    {
        DefaultCacheTimeSpan = 0,
        AppKey = 1,
        DefaultInternalCacheTimeSpan = 2,
        Host = 3,
        Port = 4
    }

    public abstract class BaseCacheStore : ICacheStore
    {
        #region Private Variables
        private readonly Dictionary<ConfigurationType, object> _configurations = null;
        #endregion

        #region Protected Variables
        protected string appKey;
        protected StackExchangeRedisCacheClient redisClient;
        protected bool initialized = false;
        protected object lockObject = new object();
        protected TimeSpan defaultCacheTimeSpan;
        #endregion

        #region Public Properties     
        public TimeSpan DefaultCacheTimeSpan => defaultCacheTimeSpan;
        #endregion

        protected BaseCacheStore(Dictionary<ConfigurationType, object> configurations, bool init = false)
        {
            _configurations = configurations;

            if(init)
            {
                if(configurations.ContainsKey(ConfigurationType.Port))
                    Init((string)configurations[ConfigurationType.Host], (int?)configurations[ConfigurationType.Host]);
                else
                    Init((string)configurations[ConfigurationType.Host]);
            }
        }

        #region Private Methods 
        public void Init(string host, int? Port)
        {
            //Configure the serializer
            var serializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };

            var serializer = new NewtonsoftSerializer(serializerSettings);

            redisClient = new StackExchangeRedisCacheClient(serializer, host);

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
            Init(host, null);
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
        public abstract IList<Type> GetAllTypes();
        public abstract IList<object> GetAll(Type type);
        public abstract IList<object> Get(string[] keys, Type type);
        public abstract void Set<T>(string key, T value);
        #endregion
    }
}
