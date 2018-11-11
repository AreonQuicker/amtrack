using System;
using System.Collections.Generic;
using System.Linq;

namespace Amtrack.Cache.Store
{
	internal class CacheLink
	{
		public string Key { get; set; }
		public HashSet<string> LinkKeys { get; set; }

		public CacheLink(string key, HashSet<string> linkKeys)
		{
			Key = key;
			LinkKeys = linkKeys;
		}
	}

	public class CacheStore : BaseCacheStore
	{
		public CacheStore(Dictionary<ConfigurationType, object> configurations)
			: base(configurations)
		{

		}

		#region Key Builders
		private string AppKey { get { return (string.IsNullOrWhiteSpace(appKey) ? "" : $"{appKey}."); } }
		private string Key<T>()
		{
			return $"{AppKey}{typeof(T).Name}";
		}
		private string Key<T>(string Key)
		{
			return $"{AppKey}{typeof(T).Name}.{Key}";
		}
		#endregion

		#region Public Methods
		public override void FlushALL()
		{
			if(!initialized)
				base.redisClient.FlushAll();
		}

		public override IList<T> Get<T>(string[] keys)
		{
			if(!initialized)
				return null;

			return base.redisClient.GetAll<T>(keys.Select(k => Key<T>(k)))
				.Values
				.Where(w => w != null)
				.ToList();
		}

		public override T Get<T>(string Key)
		{
			if(!initialized)
				return default(T);

			return base.redisClient.Get<T>(Key<T>(Key));
		}

		public override IList<T> GetAll<T>()
		{
			if(!initialized)
				return null;

			var cacheLink = base.redisClient.Get<CacheLink>(Key<T>());

			if(cacheLink != null
				&& cacheLink.LinkKeys.Any())
			{
				return Get<T>(cacheLink.LinkKeys.ToArray());
			}

			return null;
		}

		public override void Set<T>(string key, T value, TimeSpan cacheTimeSpan = default(TimeSpan))
		{
			if(initialized)
			{
				var cacheLink = base.redisClient.Get<CacheLink>(Key<T>());
				if(cacheLink == null)
					cacheLink = new CacheLink(Key<T>(), new HashSet<string>());

				cacheLink.LinkKeys.Add(key);

				if(cacheTimeSpan != default(TimeSpan))
				{
					base.redisClient.Set<CacheLink>(Key<T>(), cacheLink, cacheTimeSpan);
					base.redisClient.Set<T>(Key<T>(key), value, cacheTimeSpan);
				}
				else
				{
					base.redisClient.Set<CacheLink>(Key<T>(), cacheLink);
					base.redisClient.Set<T>(Key<T>(key), value);
				}
			}
		}

		public override void Remove<T>(string key)
		{
			if(initialized)
				base.redisClient.Remove(Key<T>(key));

		}

		public override void Remove<T>(string[] keys)
		{
			if(initialized)
				base.redisClient.RemoveAll(keys.Select(k => Key<T>(k)));
		}

		public override void DeleteAll<T>()
		{
			if(initialized)
			{
				var cacheLink = base.redisClient.Get<CacheLink>(Key<T>());

				if(cacheLink != null)
				{
					Remove<T>(cacheLink.LinkKeys.ToArray());
					base.redisClient.Remove(cacheLink.Key);
				}
			}
		} 
		#endregion
	}
}
