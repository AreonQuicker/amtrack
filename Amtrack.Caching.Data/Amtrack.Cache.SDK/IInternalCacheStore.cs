using System.Collections.Generic;

namespace Amtrack.Cache.SDK
{
    public interface IInternalCacheStore
    {
        void Set<T>(string key, T cacheItem);
        T Get<T>(string key);
        void Set<T>(T cacheItem);
        void ClearAllCache();
        void ClearEntityCache<T>();
        IList<T> AllValues<T>();
    }

}
