using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Amtrack.Cache.SDK
{
    public class InternalCacheStore : BaseInternalCacheStore
    {
        public InternalCacheStore(TimeSpan defaultCacheTimeSpan)
            : base(defaultCacheTimeSpan)
        {

        }

        #region Public Methods
        public override void Set<T>(string key, T cacheItem)
        {

            Type typeOfCache = typeof(EntityCache<T>);
            EntityCache<T> entityCacheStore = null;

            if(store.ContainsKey(typeOfCache))
                entityCacheStore = store[typeOfCache] as EntityCache<T>;
            else
            {
                entityCacheStore = new EntityCache<T>();
                store.TryAdd(typeOfCache, entityCacheStore);
            }

            entityCacheStore.Set(key, cacheItem);

        }

        public override T Get<T>(string key)
        {
            if(string.IsNullOrEmpty(key))
                return default(T);

            Type typeOfCache = typeof(EntityCache<T>);

            if(store.ContainsKey(typeOfCache))
            {
                var entityCacheStore = store[typeOfCache] as EntityCache<T>;

                var value = entityCacheStore.Get(key);

                if(value != null
                    && (value.DateAdded.Add(defaultCacheTimeSpan) < DateTime.Now))
                    return value.Value;
            }

            return default(T);
        }

        public override void Set<T>(T cacheItem)
        {
            Type typeOfCache = typeof(EntityCache<T>);
            EntityCache<T> entityCacheStore = null;

            if(store.ContainsKey(typeOfCache))
                entityCacheStore = store[typeOfCache] as EntityCache<T>;
            else
            {
                entityCacheStore = new EntityCache<T>();
                store.TryAdd(typeOfCache, entityCacheStore);
            }

            entityCacheStore.Set(cacheItem);

        }

        public override void ClearAllCache()
        {
            store = new ConcurrentDictionary<Type, object>();
        }

        public override void ClearEntityCache<T>()
        {
            Type typeOfCache = typeof(EntityCache<T>);

            store.TryRemove(typeOfCache, out object val);
        }

        public override IList<T> AllValues<T>()
        {
            Type typeOfCache = typeof(EntityCache<T>);
            EntityCache<T> entityCacheStore = null;

            if(store.ContainsKey(typeOfCache))
            {
                entityCacheStore = store[typeOfCache] as EntityCache<T>;

                return entityCacheStore.AllValues
                    .Where(w => (w.DateAdded.Add(defaultCacheTimeSpan) < DateTime.Now))
                    .Select(s => s.Value)
                    .ToList();
            }

            return new List<T>();
        }
        #endregion

        #region Private Classes
        private class EntityCache<T>
        {
            private readonly Dictionary<string, EntityCacheItem<T>> _store = null;

            public EntityCache()
            {
                _store = new Dictionary<string, EntityCacheItem<T>>();
            }

            #region Public Methods
            public IList<EntityCacheItem<T>> AllValues => _store.Values.Select(v => v).ToList();

            public EntityCacheItem<T> Get(string key)
            {
                if(_store.ContainsKey(key))
                    return _store[key];

                return null;
            }

            public void Set(string key, T cacheItem)
            {
                if(_store.ContainsKey(key))
                    _store.Remove(key);

                _store.Add(key, new EntityCacheItem<T>(cacheItem));
            }

            public void Set(T cacheItem)
            {
                string key = null;
                Type type = cacheItem.GetType();

                var eProperty = type.GetProperty("CacheKey", typeof(string));
                if(eProperty != null)
                    key = eProperty.GetValue(cacheItem) as string;

                if(key != null)
                {
                    if(_store.ContainsKey(key))
                        _store.Remove(key);

                    _store.Add(key, new EntityCacheItem<T>(cacheItem));
                }
            }
            #endregion

        }

        private class EntityCacheItem<T>
        {
            private readonly T _entity = default(T);

            #region Public Properties
            public DateTime DateAdded { get; set; }
            public T Value { get { return _entity; } }
            #endregion

            public EntityCacheItem(T cacheItem)
            {
                _entity = cacheItem;
                DateAdded = DateTime.Now;
            }
        }
        #endregion
    }

}
