using System.Collections.Generic;
using System.Linq;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
	public class CacheSDK : BaseCacheSDK
	{
		public CacheSDK(Dictionary<ConfigurationType, object> configurations, bool initCacheStore, bool useInternalCacheStore)
			: base(configurations, initCacheStore, useInternalCacheStore)
		{

		}

		#region Public Methods
		public override void DeleteAllInternal<T>()
		{
			if(internalCacheStore != null)
				internalCacheStore.DeleteAll<T>();
		}

		public override void FlushALLInternal()
		{
			if(internalCacheStore != null)
				internalCacheStore.FlushALL();
		}

		public override IList<T> Get<T>(string[] keys)
		{
			if(internalCacheStore != null)
			{
				var values = internalCacheStore.Get<T>(keys);

				if(values.Count != keys.Length)
				{
					values = cacheStore.Get<T>(keys);

					if(values.Any())
						internalCacheStore.SetAll((IEnumerable<object>)values);

					RemoveAllExpiredInternal<T>();
				}

				return values;
			}
			else
			{
				return cacheStore.Get<T>(keys);
			}
		}

		public override T Get<T>(string key)
		{
			if(internalCacheStore != null)
			{
				var value = internalCacheStore.Get<T>(key);

				if(value == null)
				{
					value = cacheStore.Get<T>(key);

					if(value != null)
						internalCacheStore.Set<T>(key, value);

					RemoveAllExpiredInternal<T>();
				}

				return value;
			}
			else
			{
				return cacheStore.Get<T>(key);
			}
		}

		public override IList<T> GetAll<T>()
		{
			if(internalCacheStore != null)
			{
				var values = internalCacheStore.GetAll<T>(typeof(T).Name);

				if(!values.Any())
				{
					values = cacheStore.GetAll<T>();

					if(values.Any())
						internalCacheStore.SetAll((IEnumerable<object>)values, typeof(T).Name);

					RemoveAllExpiredInternal<T>();
				}

				return values;
			}
			else
			{
				return cacheStore.GetAll<T>();
			}
		}

		public override IList<T> GetAll<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues)
		{
			var keys = cacheStore.GetAllKeys<T>(connectionType, connectionValues);

			if(internalCacheStore != null)
			{
				var key = $"{typeof(T).Name}-{connectionValues.GetType().Name}";

				var values = internalCacheStore.GetAll<T>(connectionType, key, connectionValues);

				if(values.Count != keys.Count)
				{
					values = cacheStore.Get<T>(keys.ToArray());

					if(values.Any())
						internalCacheStore.SetAll((IEnumerable<object>)values, key);

					RemoveAllExpiredInternal<T>();
				}

				return values;
			}
			else
			{
				return cacheStore.Get<T>(keys.ToArray());
			}
		}

		public override void SetInternal(object value)
		{
			if(internalCacheStore != null)
				internalCacheStore.Set(value);
		}

		public override void SetInternal<T>(string key, T value)
		{
			if(internalCacheStore != null)
				internalCacheStore.Set<T>(key, value);
		}

		public override void SetInternal<T>(T value)
		{
			if(internalCacheStore != null)
				internalCacheStore.Set<T>(value);
		}

		public override void SetInternalAll(IEnumerable<object> values)
		{
			if(internalCacheStore != null)
				internalCacheStore.SetAll(values);
		}

		public override void SetInternalAll<T>(IEnumerable<KeyValuePair<string, T>> values)
		{
			if(internalCacheStore != null)
				internalCacheStore.SetAll<T>(values);
		}
		#endregion
	}

}
