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
			if(!string.IsNullOrEmpty(host))
				cacheStore.Init(host, port);
			else
				cacheStore.Init();

			//TODO
		}

		#endregion

		#region Public Abstract Methods
		public abstract void DeleteAllInternal<T>();
		public abstract void FlushALLInternal();
		public abstract IList<T> Get<T>(string[] keys);
		public abstract T Get<T>(string key);
		public abstract IList<T> GetAll<T>();
		public abstract IList<T> GetAll<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues);
		public abstract void SetInternal(object value);
		public abstract void SetInternal<T>(string key, T value);
		public abstract void SetInternal<T>(T value);
		public abstract void SetInternalAll(IEnumerable<object> values);
		public abstract void SetInternalAll<T>(IEnumerable<KeyValuePair<string, T>> values);
		#endregion
	}

}
