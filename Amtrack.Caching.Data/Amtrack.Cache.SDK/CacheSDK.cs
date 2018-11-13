using System.Collections.Generic;
using System.Linq;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
    public class CacheSDK : BaseCacheSDK
    {
        public CacheSDK(Dictionary<ConfigurationType, object> configurations, bool initCacheStore = false)
            : base(configurations, initCacheStore)
        {

        }

        public override IList<T> AllValues<T>()
        {
            var values = internalCacheStore.AllValues<T>();

            if(!values.Any())
            {
                values = cacheStore.GetAll<T>();

                foreach(var value in values)
                {
                    SetInternal<T>(value);
                }
            }

            return values;
        }

        public override void ClearAllInternalCache()
        {
            internalCacheStore.ClearAllCache();
        }

        public override void ClearInteralEntityCache<T>()
        {
            internalCacheStore.ClearEntityCache<T>();
        }

        public override T Get<T>(string key)
        {
            var value = internalCacheStore.Get<T>(key);

            if(value.Equals(default(T)))
            {
                value = cacheStore.Get<T>(key);

                if(value.Equals(default(T)))
                    SetInternal<T>(key, value);
            }

            return value;
        }

        public override void SetInternal<T>(string key, T cacheItem)
        {
            internalCacheStore.Set<T>(key, cacheItem);
        }

        public override void SetInternal<T>(T cacheItem)
        {
            internalCacheStore.Set<T>(cacheItem);
        }
    }

}
