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

	public abstract class CacheStoreBase : ICacheStore
	{
		Dictionary<ConfigurationType, object> configurations = null;

		protected string appKey;
		protected TimeSpan defaultCacheTimeSpan;
		protected RedisClient redisClient;
		protected bool initialized = false;

		public CacheStoreBase(Dictionary<ConfigurationType, object> configurations)
		{
			this.configurations = configurations;
		}

		private void Init()
		{
			if(configurations.ContainsKey(ConfigurationType.DefaultCacheTimeSpan))
				defaultCacheTimeSpan = (TimeSpan)configurations[ConfigurationType.DefaultCacheTimeSpan];
			else
				defaultCacheTimeSpan = new TimeSpan(0, 10, 0);

			if(configurations.ContainsKey(ConfigurationType.AppKey))
				appKey = (string)configurations[ConfigurationType.AppKey];
			else
				appKey = Guid.NewGuid().ToString();

			initialized = true;
		}

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

		public abstract void FlushALL();
		public abstract IList<T> Get<T>(string[] keys);
		public abstract T Get<T>(string Key);
		public abstract IList<T> GetAll<T>();
		public abstract IList<T> Search<T>(string pattern);
		public abstract void Set<T>(string key, T value, TimeSpan cacheTimeSpan = default(TimeSpan));
		public abstract void Remove<T>(string key);
		public abstract void Remove<T>(string[] keys);
		public abstract void DeleteAll<T>();
	}
}
