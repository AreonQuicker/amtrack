using System.Collections.Generic;
using System.Linq;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
	//TODO NotImplementedException
	public class CacheSDK : BaseCacheSDK
	{
		public CacheSDK(Dictionary<ConfigurationType, object> configurations, bool initCacheStore = false)
			: base(configurations, initCacheStore)
		{

		}

		#region Public Methods
		public override void DeleteAllInternal<T>()
		{
			internalCacheStore.DeleteAll<T>();
		}

		public override void FlushALLInternal()
		{
			internalCacheStore.FlushALL();
		}

		public override IList<T> Get<T>(string[] keys)
		{
			var values = internalCacheStore.Get<T>(keys);

			if(values.Count != keys.Length)
			{
				values = cacheStore.Get<T>(keys);

				if(values.Any())
					internalCacheStore.SetAll((IEnumerable<object>)values);
			}

			return values;
		}

		public override T Get<T>(string key)
		{
			var value = internalCacheStore.Get<T>(key);

			if(value == null)
			{
				value = cacheStore.Get<T>(key);

				if(value != null)
					internalCacheStore.Set<T>(key, value);
			}

			return value;
		}

		public override IList<T> GetAll<T>()
		{
			var values = internalCacheStore.GetAll<T>(typeof(T).Name);

			if(!values.Any())
			{
				values = cacheStore.GetAll<T>();

				if(values.Any())
					internalCacheStore.SetAll((IEnumerable<object>)values, typeof(T).Name);
			}

			return values;
		}

		public override IList<T> GetAll<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues)
		{
			var key = $"{typeof(T).Name}-{connectionValues.GetType().Name}";

			var keys = cacheStore.GetAllKeys<T>(connectionType, connectionValues);

			var values = internalCacheStore.GetAll<T>(connectionType, key, connectionValues);

			if(values.Count != keys.Count)
			{
				values = cacheStore.Get<T>(keys.ToArray());

				if(values.Any())
					internalCacheStore.SetAll((IEnumerable<object>)values, key);
			}

			return values;
		}

		public override void SetInternal(object value)
		{
			internalCacheStore.Set(value);
		}

		public override void SetInternal<T>(string key, T value)
		{
			internalCacheStore.Set<T>(key, value);
		}

		public override void SetInternal<T>(T value)
		{
			internalCacheStore.Set<T>(value);
		}

		public override void SetInternalAll(IEnumerable<object> values)
		{
			internalCacheStore.SetAll(values);
		}

		public override void SetInternalAll<T>(IEnumerable<KeyValuePair<string, T>> values)
		{
			internalCacheStore.SetAll<T>(values);
		}
		#endregion
	}

}
