using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Amtrack.Cache.SDK
{
    public abstract class BaseInternalCacheStore : IInternalCacheStore
    {
        protected TimeSpan defaultCacheTimeSpan = default(TimeSpan);
        protected ConcurrentDictionary<Type, object> store = null;

        protected BaseInternalCacheStore(TimeSpan defaultCacheTimeSpan)
        {
            store = new ConcurrentDictionary<Type, object>();
            //TODO
            this.defaultCacheTimeSpan = defaultCacheTimeSpan;
        }

        #region Public Methods
        public abstract IList<T> AllValues<T>();
        public abstract void ClearAllCache();
        public abstract void ClearEntityCache<T>();
        public abstract T Get<T>(string key);
        public abstract void Set<T>(string key, T cacheItem);
        public abstract void Set<T>(T cacheItem);
        #endregion
    }

}
