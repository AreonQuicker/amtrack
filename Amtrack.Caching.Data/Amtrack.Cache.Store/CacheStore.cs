using System;
using System.Collections.Generic;
using System.Linq;

namespace Amtrack.Cache.Store
{
    internal class CacheLink
    {
        public string Key { get; set; }
        public HashSet<string> LinkKeys { get; set; }
        public Type Type { get; set; }

        public CacheLink(string key, Type type, HashSet<string> linkKeys)
        {
            Key = key;
            LinkKeys = linkKeys;
            Type = type;

        }
    }

    public class CacheStore : BaseCacheStore
    {
        public CacheStore(Dictionary<ConfigurationType, object> configurations, bool init = false)
            : base(configurations, init)
        {

        }

        #region Key Builders
        private string AppKey { get { return (string.IsNullOrWhiteSpace(appKey) ? "" : $"{appKey}."); } }
        private string Key<T>()
        {
            return $"Type::{AppKey}{typeof(T).Name}";
        }
        private string Key(string name)
        {
            return $"Type::{AppKey}{name}";
        }
        private string Key<T>(string key)
        {
            return $"Key::{AppKey}{typeof(T).Name}.{key}";
        }
        private string Key(string key, string name)
        {
            return $"Key::{AppKey}{name}.{key}";
        }
        #endregion

        #region Public Methods
        public override void FlushALL()
        {
            if(!initialized)
                redisClient.FlushDb();
        }

        public override IList<T> Get<T>(string[] keys)
        {
            if(!initialized)
                return new List<T>();

            return redisClient.GetAll<T>(keys.Select(k => Key<T>(k)))
                .Values
                .Where(w => w != null)
                .ToList();
        }

        public override T Get<T>(string Key)
        {
            if(!initialized)
                return default(T);

            return redisClient.Get<T>(Key<T>(Key));
        }

        public override IList<T> GetAll<T>()
        {
            if(!initialized)
                return new List<T>();

            var cacheLink = redisClient.Get<CacheLink>(Key<T>());

            if(cacheLink != null
                && cacheLink.LinkKeys.Any())
            {
                return Get<T>(cacheLink.LinkKeys.ToArray());
            }

            return new List<T>();
        }

        public override void Set<T>(string key, T value)
        {
            if(initialized)
            {
                lock(lockObject)
                {

                    var cacheLink = redisClient.Get<CacheLink>(Key<T>());

                    if(cacheLink == null)
                        cacheLink = new CacheLink(Key<T>(), typeof(T), new HashSet<string>());

                    cacheLink.LinkKeys.Add(key);

                    redisClient.Add<CacheLink>(Key<T>(), cacheLink);
                    redisClient.Add<T>(Key<T>(key), value);
                }
            }
        }

        public override void Set<T>(string key, T value, TimeSpan cacheTimeSpan = default(TimeSpan))
        {

            if(initialized)
            {
                lock(lockObject)
                {

                    var cacheLink = redisClient.Get<CacheLink>(Key<T>());

                    if(cacheLink == null)
                        cacheLink = new CacheLink(Key<T>(), typeof(T), new HashSet<string>());

                    cacheLink.LinkKeys.Add(key);

                    if(cacheTimeSpan != default(TimeSpan))
                    {
                        DateTime cacheExpiry = DateTime.Now.Add(cacheTimeSpan);

                        redisClient.Add<CacheLink>(Key<T>(), cacheLink, cacheExpiry);
                        redisClient.Add<T>(Key<T>(key), value, cacheTimeSpan);
                    }
                    else
                    {
                        DateTime cacheExpiry = DateTime.Now.Add(defaultCacheTimeSpan);

                        redisClient.Add<CacheLink>(Key<T>(), cacheLink);
                        redisClient.Add<T>(Key<T>(key), value);
                    }
                }
            }
        }

        public override void Remove<T>(string key)
        {
            if(initialized)
                redisClient.Remove(Key<T>(key));

        }

        public override void Remove<T>(string[] keys)
        {
            if(initialized)
                redisClient.RemoveAll(keys.Select(k => Key<T>(k)));
        }

        public override void DeleteAll<T>()
        {
            if(initialized)
            {
                var cacheLink = redisClient.Get<CacheLink>(Key<T>());

                if(cacheLink != null)
                {
                    Remove<T>(cacheLink.LinkKeys.ToArray());
                    redisClient.Remove(cacheLink.Key);
                }
            }
        }

        public override IList<Type> GetAllTypes()
        {
            if(!initialized)
                return new List<Type>();

            var keys = redisClient.SearchKeys("Type::*");

            var cacheLinks = Get<CacheLink>(keys.ToArray());

            return cacheLinks
                .Select(s => s.Type)
                .ToList();
        }

        public override IList<object> GetAll(Type type)
        {
            if(!initialized)
                return new List<object>();

            var cacheLink = redisClient.Get<CacheLink>(Key(type.Name));

            if(cacheLink != null
                && cacheLink.LinkKeys.Any())
            {
                return Get(cacheLink.LinkKeys.ToArray(), type);
            }

            return new List<object>();
        }

        public override IList<object> Get(string[] keys, Type type)
        {
            if(!initialized)
                return new List<object>();

            return redisClient.GetAll<object>(keys.Select(k => Key(k, type.Name)))
                .Values
                .Where(w => w != null)
                .ToList();
        }

        public override void Set(object value)
        {
            if(initialized)
            {
                lock(lockObject)
                {
                    string key = null;
                    Type type = value.GetType();

                    var eProperty = type.GetProperty("CacheKey", typeof(string));
                    if(eProperty != null)
                        key = eProperty.GetValue(value) as string;

                    if(!string.IsNullOrEmpty(key))
                    {
                        var cacheLink = redisClient.Get<CacheLink>(Key(type.Name));

                        if(cacheLink == null)
                            cacheLink = new CacheLink(Key(type.Name), type, new HashSet<string>());

                        cacheLink.LinkKeys.Add(key);

                        redisClient.Add<CacheLink>(Key(type.Name), cacheLink);
                        redisClient.Add<object>(Key(key, type.Name), value); 
                    }
                }
            }
        }
        #endregion
    }
}
