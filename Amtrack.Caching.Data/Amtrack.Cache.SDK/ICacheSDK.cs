using System.Collections.Generic;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
	public interface ICacheSDK
	{
		void InitCache(string host, int? port);

		void SetInternal(object value);
		void SetInternal<T>(string key, T value);
		void SetInternal<T>(T value);

		void SetInternalAll(IEnumerable<object> values);
		void SetInternalAll<T>(IEnumerable<KeyValuePair<string, T>> values);

		IList<T> GetAll<T>();
		IList<T> GetAll<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues);

		IList<T> Get<T>(string[] keys);
		T Get<T>(string key);

		void DeleteAllInternal<T>();

		void FlushALLInternal();
	}

}
