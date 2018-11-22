using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amtrack.Cache.Store
{

	public class CacheStore : BaseCacheStore
	{
		#region Private ReadOnly Variables
		private readonly CacheDictionary<Type> mainCacheDictionary;
		#endregion

		public CacheStore(Dictionary<ConfigurationType, object> configurations, bool init = false)
			: base(configurations, init)
		{
			mainCacheDictionary = new CacheDictionary<Type>(connectionMultiplexer, AppKey);
		}

		#region Private Methods
		private CacheDictionary<List<string>> ConnectionCacheDictionaryInstance(Type type) =>
		new CacheDictionary<List<string>>(connectionMultiplexer, ConnectionTypeKey(type.Name));

		private CacheDictionary<List<string>> ConnectionCacheDictionaryInstance<T>() =>
		  new CacheDictionary<List<string>>(connectionMultiplexer, ConnectionTypeKey<T>());

		private CacheDictionary<T> CacheDictionaryInstance<T>() =>
			new CacheDictionary<T>(connectionMultiplexer, TypeKey<T>());

		private CacheDictionary<object> CacheDictionaryInstance(Type type) =>
		  new CacheDictionary<object>(connectionMultiplexer, TypeKey(type.Name));
		#endregion

		#region Public Methods
		public override void DeleteAll<T>()
		{
			lock(lockObject)
			{
				var cacheDictionary = CacheDictionaryInstance<T>();

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance<T>();

				if(mainCacheDictionary.ContainsKey(TypeKey<T>()))
					mainCacheDictionary.Remove(TypeKey<T>());

				cacheDictionary.Clear();

				connectionCacheDictionary.Clear();
			}
		}

		public override void DeleteAll(Type type)
		{
			lock(lockObject)
			{
				var cacheDictionary = CacheDictionaryInstance(type);

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance(type);

				if(mainCacheDictionary.ContainsKey(TypeKey(type.Name)))
					mainCacheDictionary.Remove(TypeKey(type.Name));

				cacheDictionary.Clear();

				connectionCacheDictionary.Clear();
			}
		}

		public override void FlushALL()
		{
			throw new NotImplementedException();
		}

		public override IList<T> Get<T>(string[] keys)
		{
			keys = keys
				.Select(s => Key<T>(s))
				.ToArray();

			var values = CacheDictionaryInstance<T>().GetValues(keys);

			if(values == null)
				return new List<T>();

			return values;
		}

		public override T Get<T>(string key)
		{
			return CacheDictionaryInstance<T>().GetValue(Key<T>(key));
		}

		public override IList<T> GetAll<T>()
		{
			var values = CacheDictionaryInstance<T>()
				.Values;

			if(values == null)
				return new List<T>();

			return values.ToList();
		}

		public override IList<T> GetAll<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues)
		{
			return Get<T>(GetAllKeys<T>(connectionType, connectionValues).ToArray());
		}

		public override IList<Type> GetAllTypes()
		{
			return mainCacheDictionary
				.Values
				.ToList();
		}

		public override void Remove<T>(string key)
		{
			lock(lockObject)
			{
				var cacheDictionary = CacheDictionaryInstance<T>();

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance<T>();

				cacheDictionary.Remove(key);

				//TODO REMOVE KEY FROM connectionCacheDictionary
			}
		}

		public override void Remove<T>(string[] keys)
		{
			lock(lockObject)
			{
				var cacheDictionary = CacheDictionaryInstance<T>();

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance<T>();


				foreach(var key in keys)
					cacheDictionary.Remove(key);

				//TODO REMOVE KEY FROM connectionCacheDictionary
			}
		}

		public override void Remove(string[] keys, Type type)
		{
			lock(lockObject)
			{
				var cacheDictionary = CacheDictionaryInstance(type);

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance(type);

				foreach(var key in keys)
					cacheDictionary.Remove(key);

				//TODO REMOVE KEY FROM connectionCacheDictionary
			}
		}

		public override void Set(object value)
		{
			lock(lockObject)
			{
				var type = value.GetType();

				if(!mainCacheDictionary.ContainsKey(TypeKey(type.Name)))
					mainCacheDictionary.Add(TypeKey(type.Name), type);

				var cacheKey = value.GetValue("CacheKey");

				if(!string.IsNullOrEmpty(cacheKey))
					CacheDictionaryInstance(type).Add(Key(cacheKey, type.Name), value);
			}
		}

		public override void Set<T>(string key, T value)
		{
			lock(lockObject)
			{
				if(!mainCacheDictionary.ContainsKey(TypeKey<T>()))
					mainCacheDictionary.Add(TypeKey<T>(), typeof(T));

				CacheDictionaryInstance<T>().Add(Key<T>(key), value);
			}
		}

		public override void SetAll(IEnumerable<object> values)
		{
			lock(lockObject)
			{
				var type = values.FirstOrDefault().GetType();

				if(!mainCacheDictionary.ContainsKey(TypeKey(type.Name)))
					mainCacheDictionary.Add(TypeKey(type.Name), type);

				var redisValues =
					 values
					 .AsParallel()
					 .Select(s => new KeyValuePair<string, object>(Key(s.GetValue("CacheKey"), type.Name), s));

				CacheDictionaryInstance(type).AddMultiple(redisValues);
			}
		}

		public override void SetAll<T>(IEnumerable<KeyValuePair<string, T>> values)
		{
			lock(lockObject)
			{
				if(!mainCacheDictionary.ContainsKey(TypeKey<T>()))
					mainCacheDictionary.Add(TypeKey<T>(), typeof(T));

				values = values
					.AsParallel()
					.Select(s => new KeyValuePair<string, T>(Key<T>(s.Key), s.Value));

				CacheDictionaryInstance<T>().AddMultiple(values);
			}
		}

		public override void Set(object value, string[] connectionsFields)
		{
			lock(lockObject)
			{
				var type = value.GetType();

				if(!mainCacheDictionary.ContainsKey(TypeKey(type.Name)))
					mainCacheDictionary.Add(TypeKey(type.Name), type);

				var cacheKey = value.GetValue("CacheKey");

				if(!string.IsNullOrEmpty(cacheKey))
				{
					var connectionCacheDictionary = ConnectionCacheDictionaryInstance(type);

					Parallel.ForEach(connectionsFields.Distinct(), (connectionsField) =>
					{
						if(value.GetValue(connectionsField, out var connectionsFieldValue))
						{
							var linkKey = LinkKey(connectionsField, connectionsFieldValue);

							var redisValue = connectionCacheDictionary.GetValue(linkKey);

							if(redisValue == null)
								redisValue = new List<string>();

							redisValue.Add(cacheKey);

							connectionCacheDictionary.Add(linkKey, redisValue.Distinct().ToList());
						}
					});

					CacheDictionaryInstance(type).Add(Key(cacheKey, type.Name), value);
				}
			}
		}

		public override void Set<T>(string key, T value, string[] connectionsFields)
		{
			lock(lockObject)
			{
				if(!mainCacheDictionary.ContainsKey(TypeKey<T>()))
					mainCacheDictionary.Add(TypeKey<T>(), typeof(T));

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance<T>();

				Parallel.ForEach(connectionsFields.Distinct(), (connectionsField) =>
				{
					if(value.GetValue(connectionsField, out var connectionsFieldValue))
					{
						var linkKey = LinkKey(connectionsField, connectionsFieldValue);

						var redisValue = connectionCacheDictionary.GetValue(linkKey);

						if(redisValue == null)
							redisValue = new List<string>();

						redisValue.Add(key);

						connectionCacheDictionary.Add(linkKey, redisValue.Distinct().ToList());
					}
				});

				CacheDictionaryInstance<T>().Add(Key<T>(key), value);
			}
		}

		public override void SetAll(IEnumerable<object> values, string[] connectionsFields)
		{
			lock(lockObject)
			{
				var type = values.FirstOrDefault().GetType();

				if(!mainCacheDictionary.ContainsKey(TypeKey(type.Name)))
					mainCacheDictionary.Add(TypeKey(type.Name), type);

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance(type);

				Parallel.ForEach(connectionsFields.Distinct(), (connectionsField) =>
				{
					var gValues = values
					.GroupBy(g => g.GetValue(connectionsField))
					.Select(s => new { connectionsFieldValue = s.Key, keys = s.Select(ss => ss.GetValue("CacheKey")) })
					.ToList();

					foreach(var gValue in gValues)
					{
						var linkKey = LinkKey(connectionsField, gValue.connectionsFieldValue);

						var redisValue = connectionCacheDictionary.GetValue(linkKey);

						if(redisValue == null)
							redisValue = new List<string>();

						redisValue.AddRange(gValue.keys);

						connectionCacheDictionary.Add(linkKey, redisValue.Distinct().ToList());
					}

				});

				var redisValues =
					 values
					 .AsParallel()
					 .Select(s => new KeyValuePair<string, object>(Key(s.GetValue("CacheKey"), type.Name), s));

				CacheDictionaryInstance(type).AddMultiple(redisValues);
			}
		}

		public override void SetAll<T>(IEnumerable<KeyValuePair<string, T>> values, string[] connectionsFields)
		{
			lock(lockObject)
			{
				if(!mainCacheDictionary.ContainsKey(TypeKey<T>()))
					mainCacheDictionary.Add(TypeKey<T>(), typeof(T));

				var connectionCacheDictionary = ConnectionCacheDictionaryInstance<T>();

				Parallel.ForEach(connectionsFields.Distinct(), (connectionsField) =>
				{
					var gValues = values
					.GroupBy(g => g.Value.GetValue(connectionsField))
					.Select(s => new { connectionsFieldValue = s.Key, keys = s.Select(ss => ss.Key) })
					.ToList();

					foreach(var gValue in gValues)
					{
						var linkKey = LinkKey(connectionsField, gValue.connectionsFieldValue);

						var redisValue = connectionCacheDictionary.GetValue(linkKey);

						if(redisValue == null)
							redisValue = new List<string>();

						redisValue.AddRange(gValue.keys);

						connectionCacheDictionary.Add(linkKey, redisValue.Distinct().ToList());
					}
				});

				values = values
					.AsParallel()
					.Select(s => new KeyValuePair<string, T>(Key<T>(s.Key), s.Value));

				CacheDictionaryInstance<T>().AddMultiple(values);
			}
		}

		public override int GetAllCount<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues)
		{
			return GetAllKeys<T>(connectionType, connectionValues).Count;
		}

		public override IList<string> GetAllKeys<T>(ConnectionType connectionType, params ConnectionValue[] connectionValues)
		{
			var connectionCacheDictionary = ConnectionCacheDictionaryInstance<T>();
			if(connectionValues.Any())
			{
				var connectionValuesD = connectionValues
					.GroupBy(g => g.Field)
					.ToDictionary(d => d.Key, d => d.FirstOrDefault());

				List<List<string>> values = null;

				if(!connectionValues.All(a => a.ConnectionValueType == ConnectionValueType.Equals))
				{
					var dKeys = connectionCacheDictionary.Keys;

					if(dKeys == null)
						return new List<string>();

					var rkeys = connectionValuesD
						.AsParallel()
						.Select(s =>
						{
							switch(s.Value.ConnectionValueType)
							{
								case ConnectionValueType.Contains:
									return dKeys.Where(w => w.Contains(LinkKey(s.Value.Field, s.Value.Value))).ToList();
								case ConnectionValueType.StartsWith:
									return dKeys.Where(w => w.StartsWith(LinkKey(s.Value.Field, s.Value.Value))).ToList();
								case ConnectionValueType.EndWith:
									return dKeys.Where(w => w.EndsWith(LinkKey(s.Value.Field, s.Value.Value))).ToList();
								default:
									return dKeys.Where(w => w.Equals(LinkKey(s.Value.Field, s.Value.Value), StringComparison.CurrentCultureIgnoreCase)).ToList();
							}

						})
						.ToList();

					values = rkeys
							.AsParallel()
							.Select(s =>
							{
								return connectionCacheDictionary.GetValues(s.ToArray())
								.SelectMany(ss => ss)
								.ToList();
							})
							.ToList();
				}
				else
				{
					values = connectionValuesD
						.AsParallel()
						.Select(s => connectionCacheDictionary.GetValue(s.Value.Value))
						.ToList();
				}

				var keys = values.FirstOrDefault();

				if(keys == null)
					keys = new List<string>();

				if(connectionType == ConnectionType.And)
				{
					foreach(var value in values)
					{
						keys = keys
							.Intersect(value)
							.ToList();
					}
				}
				else
				{
					keys = values
						.SelectMany(s => s)
						.ToList();
				}


				return keys;
			}

			return new List<string>();
		}
		#endregion
	}
}
