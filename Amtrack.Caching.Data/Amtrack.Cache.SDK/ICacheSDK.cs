using System.Collections.Generic;

namespace Amtrack.Cache.SDK
{
    public interface ICacheSDK
    {
        void SetInternal<T>(string key, T cacheItem);
        T Get<T>(string key);
        void SetInternal<T>(T cacheItem);
        void ClearAllInternalCache();
        void ClearInteralEntityCache<T>();
        IList<T> AllValues<T>();
        void InitCache(string host, int? port);
    }

}
