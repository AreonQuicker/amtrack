﻿using System;
using System.Collections.Generic;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
	public abstract class BaseCacheSDK : ICacheSDK
	{
		protected IInternalCacheStore internalCacheStore;
		protected ICacheStore cacheStore;
		protected DateTime date;
		protected TimeSpan defaultInternalCacheTimeSpan;

		protected BaseCacheSDK(Dictionary<ConfigurationType, object> configurations, bool initCacheStore, bool useInternalCacheStore)
		{
			if(useInternalCacheStore)
			{
				defaultInternalCacheTimeSpan = (TimeSpan)configurations[ConfigurationType.DefaultInternalCacheTimeSpan];
				internalCacheStore = new InternalCacheStore(defaultInternalCacheTimeSpan);
				date = DateTime.Now;
			}

			cacheStore = new CacheStore(configurations, initCacheStore);

		}

		#region Protected Methods
		protected void RemoveAllExpiredInternal<T>()
		{
			if(internalCacheStore != null
				&& date.Add(defaultInternalCacheTimeSpan) < DateTime.Now)
			{
				internalCacheStore.RemoveAllExpired<T>();
				date = DateTime.Now;
			}
		}
		#endregion

		#region Public Methods
		public void InitCache(string host, int? port)
		{
			if(!string.IsNullOrEmpty(host))
				cacheStore.Init(host, port);
			else
				cacheStore.Init();

			//TODO Load all cache
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
		public abstract IList<T> GetAllMultiple<T>();
		#endregion
	}

}
