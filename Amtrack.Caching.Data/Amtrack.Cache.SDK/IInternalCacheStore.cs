using System.Collections.Generic;
using Amtrack.Cache.Store;

namespace Amtrack.Cache.SDK
{
	//TODO Change Names
	public interface IInternalCacheStore
	{
		void Set(object value);
		void Set<T>(string key, T value);
		void Set<T>(T value);

		void SetAll(IEnumerable<object> values, string eKey);
		void SetAll<T>(IEnumerable<KeyValuePair<string, T>> values, string eKey);

		void SetAll(IEnumerable<object> values);
		void SetAll<T>(IEnumerable<KeyValuePair<string, T>> values);

		IList<T> GetAll<T>(string eKey);
		IList<T> GetAll<T>();
		IList<T> GetAll<T>(ConnectionType connectionType, string eKey, params ConnectionValue[] connectionValues);
		IList<T> GetAll<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues);

		IList<T> Get<T>(string[] keys);
		T Get<T>(string key);

		void DeleteAll<T>();

		void FlushALL();
	}

}
