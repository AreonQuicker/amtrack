using System;
using System.Collections.Generic;

namespace Amtrack.Cache.Store
{
	public interface ICacheStore
	{
		void Init(string host);
		void Init(string host, int Port);

		void Set<T>(string key, T value, TimeSpan cacheTimeSpan = default(TimeSpan));

		IList<T> GetAll<T>();
		IList<T> Get<T>(string[] keys);
		T Get<T>(string Key);

		void FlushALL();
		void Remove<T>(string key);
		void Remove<T>(string[] keys);
		void DeleteAll<T>();
	}
}
