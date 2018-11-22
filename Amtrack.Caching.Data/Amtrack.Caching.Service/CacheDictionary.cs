using System;
using System.Collections.Generic;

namespace Amtrack.Caching.Service
{
	internal class CacheDictionary<TKey, TValue> : Dictionary<TKey, TValue>
	{
		public CacheDictionary()
			: base()
		{

		}

		public TValue GetValue(TKey key)
		{
			if(ContainsKey(key))
				return this[key];

			return default(TValue);
		}

		public static CacheDictionary<TKey, TValue> CreateDictionary(IEnumerable<TValue> values, Func<TValue, TKey> getKey, Func<TValue, TValue> getValue)
		{
			var cacheDictionary = new CacheDictionary<TKey, TValue>();

			foreach(var value in values)
			{
				var key = getKey(value);
				if(!cacheDictionary.ContainsKey(key))
					cacheDictionary.Add(key, getValue(value));
			}

			return cacheDictionary;
		}

		public static CacheDictionary<TKey, TValue> CreateDictionary(Dictionary<TKey, TValue> keyValuePairs)
		{
			var cacheDictionary = new CacheDictionary<TKey, TValue>();

			foreach(var keyValuePair in keyValuePairs)
				cacheDictionary.Add(keyValuePair.Key, keyValuePair.Value);

			return cacheDictionary;
		}
	}
}