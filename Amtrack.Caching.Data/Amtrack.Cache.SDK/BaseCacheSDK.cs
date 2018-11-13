using System;
using System.Collections.Generic;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
    public abstract class BaseCacheSDK : ICacheSDK
    {
        protected IInternalCacheStore internalCacheStore;
        protected ICacheStore cacheStore;
        protected bool isLoaded = false;

        protected BaseCacheSDK(Dictionary<ConfigurationType, object> configurations, bool initCacheStore = false)
        {
            cacheStore = new CacheStore(configurations, initCacheStore);
            internalCacheStore = new InternalCacheStore((TimeSpan)configurations[ConfigurationType.DefaultInternalCacheTimeSpan]);
        }

        #region Public Methods
        public void InitCache(string host, int? port)
        {
            cacheStore.Init(host, port);

            var types = cacheStore.GetAllTypes();

            foreach(var type in types)
            {
                var values = cacheStore.GetAll(type);

                foreach(var value in values)
                {
                    internalCacheStore.Set(value);
                }
            }
        }
        #endregion

        #region Public Abstract Methods
        public abstract IList<T> AllValues<T>();
        public abstract void ClearAllInternalCache();
        public abstract void ClearInteralEntityCache<T>();
        public abstract T Get<T>(string key);
        public abstract void SetInternal<T>(string key, T cacheItem);
        public abstract void SetInternal<T>(T cacheItem);
        #endregion
    }

}
