using Amtrack.Cache.Store;

namespace Amtrack.Cache.Test
{
	class A
	{
		public string Name { get; set; }
		public string Surname { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			ICacheStore cacheStore = new CacheStore(new System.Collections.Generic.Dictionary<ConfigurationType, object>()
			{
				[ConfigurationType.AppKey] = "APP"
			});

			cacheStore.Init("127.0.0.1:6379");

			AddValues(cacheStore);

			var TestValue = cacheStore.Get<A>("TEST");
			var TestValues = cacheStore.GetAll<A>();
		}

		static void AddValues(ICacheStore cacheStore)
		{
			cacheStore.Set("TEST", new A() { Name = "Gideon" });
			cacheStore.Set("TEST2", new A() { Name = "Andre" });
		}
	}
}
