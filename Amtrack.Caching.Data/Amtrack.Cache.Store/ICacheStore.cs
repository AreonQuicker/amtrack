using System;
using System.Collections.Generic;

namespace Amtrack.Cache.Store
{
    public interface ICacheStore
    {
        TimeSpan DefaultCacheTimeSpan { get; }

        void Init(string host);
        void Init(string host, int? Port);

        void Set<T>(string key, T value);
        void Set<T>(string key, T value, TimeSpan cacheTimeSpan = default(TimeSpan));

        IList<object> GetAll(Type type);
        IList<T> GetAll<T>();
        IList<T> Get<T>(string[] keys);
        IList<object> Get(string[] keys, Type type);
        T Get<T>(string Key);
        IList<Type> GetAllTypes();

        void FlushALL();
        void Remove<T>(string key);
        void Remove<T>(string[] keys);
        void DeleteAll<T>();
    }
}
