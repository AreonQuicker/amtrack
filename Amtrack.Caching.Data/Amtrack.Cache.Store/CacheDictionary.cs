using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using StackExchange.Redis;

//TODO Set serialize back
namespace Amtrack.Cache.Store
{
	public class CacheDictionary<TValue> : IDictionary<string, TValue>
	{
		private readonly ConnectionMultiplexer _cnn;
		private readonly string _redisKey;

		public CacheDictionary(string host)
		{

			string redisConnection = $"{host},ssl=false,allowAdmin=true,ConnectRetry=3,ConnectTimeout=5000,defaultDatabase=1";

			_cnn = ConnectionMultiplexer.Connect(redisConnection);
		}

		public CacheDictionary(ConnectionMultiplexer connectionMultiplexer, string redisKey)
		{
			_redisKey = redisKey;
			_cnn = connectionMultiplexer;
		}

		#region Private Methods
		private IDatabase GetRedisDb()
		{
			return _cnn.GetDatabase();
		}
		#endregion

		#region Public Methods
		public void Add(string key, TValue value)
		{
			GetRedisDb()
				.HashSet(_redisKey, key, value.ObjectToString());
		}

		public bool ContainsKey(string key)
		{
			return GetRedisDb()
				.HashExists(_redisKey, key);
		}

		public bool Remove(string key)
		{
			return GetRedisDb()
				.HashDelete(_redisKey, key);
		}

		public bool TryGetValue(string key, out TValue value)
		{
			var redisValue = GetRedisDb()
				.HashGet(_redisKey, key);

			if(redisValue.IsNull)
			{
				value = default(TValue);
				return false;
			}

			value = redisValue
				.ToString()
				.StringToObject<TValue>();

			return true;
		}

		public TValue GetValue(string key)
		{
			var redisValue = GetRedisDb()
				.HashGet(_redisKey, key);

			if(redisValue.IsNull)
				return default(TValue);

			return redisValue
				.ToString()
				.StringToObject<TValue>();
		}

		public IList<TValue> GetValues(string[] keys)
		{
			var redisValues = keys
				.AsParallel()
				.Select(s => GetRedisDb()
				.HashGet(_redisKey, (RedisValue)s))
				.Where(w => !w.IsNull)
				.ToList();

			if(!redisValues.Any())
				return new List<TValue>();

			return redisValues
				.AsParallel()
				.Select(s => s.ToString().StringToObject<TValue>())
				.Where(w => w != null)
				.ToList();
		}

		public ICollection<TValue> Values => new Collection<TValue>(GetRedisDb().HashValues(_redisKey)
			  .AsParallel()
			  .Select(h => h.ToString()
			  .StringToObject<TValue>()).ToList());

		public ICollection<string> Keys => new Collection<string>(GetRedisDb().HashKeys(_redisKey)
			  .Select(h => h.ToString()).ToList());

		public TValue this[string key]
		{
			get
			{
				var redisValue = GetRedisDb()
					.HashGet(_redisKey, key);

				return redisValue.IsNull
					? default(TValue)
					: redisValue
					.ToString()
					.StringToObject<TValue>();
			}
			set
			{
				Add(key, value);
			}
		}

		public void Add(KeyValuePair<string, TValue> item)
		{
			Add(item.Key, item.Value);
		}

		public void Clear()
		{
			GetRedisDb()
				.KeyDelete(_redisKey);
		}

		public bool Contains(KeyValuePair<string, TValue> item)
		{
			return GetRedisDb()
				.HashExists(_redisKey, item.Key);
		}

		public void CopyTo(KeyValuePair<string, TValue>[] array, int arrayIndex)
		{
			GetRedisDb()
				.HashGetAll(_redisKey)
				.CopyTo(array, arrayIndex);
		}

		public int Count
		{
			get { return (int)GetRedisDb().HashLength(_redisKey); }
		}

		public bool IsReadOnly
		{
			get { return false; }
		}

		public bool Remove(KeyValuePair<string, TValue> item)
		{
			return Remove(item.Key);
		}

		public IEnumerator<KeyValuePair<string, TValue>> GetEnumerator()
		{
			var db = GetRedisDb();

			foreach(var hashKey in db.HashKeys(_redisKey))
			{
				var redisValue = db.HashGet(_redisKey, hashKey);
				yield return new KeyValuePair<string, TValue>(hashKey.ToString(), redisValue.ToString().StringToObject<TValue>());
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			yield return GetEnumerator();
		}

		public void AddMultiple(IEnumerable<KeyValuePair<string, TValue>> items)
		{
			GetRedisDb()
				.HashSet(_redisKey, items
				.AsParallel()
				.Select(i => new HashEntry(i.Key, i.Value.ObjectToString()))
				.ToArray());
		}
		#endregion
	}
}
