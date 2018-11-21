using System;
using System.Collections.Generic;
using Amtrack.Amtrack.Data;
using Amtrack.Amtrack_V2.Data;
using Amtrack.Background.Cache.Service.BackgroundCacheServices;
using Amtrack.Cache.Store;
using Amtrack.Caching.Data;
using Amtrack.Caching.Repository;
using Amtrack.Caching.Service;
using Amtrack.Logger;
using Amtrack.StockCheck.Data;
using Unity;
using Unity.Extension;
using Unity.Injection;
using Unity.Lifetime;

namespace Amtrack.Background.Cache.Service
{
	public class DependencyOfCacheExtension : UnityContainerExtension
	{
		protected override void Initialize()
		{
			NLog.LogManager.Configuration = new AmtrackConfiguration(Enumeration.LoggerTargetTypes.Console);

			Container.RegisterType<IAmtrackLogger, AmtrackLogger>(new ContainerControlledLifetimeManager(), new InjectionConstructor
			  (
				 LoggerNames.Amtrack_Cache,
				 true
			  ));

			//TODO Load config
			var configurations = new Dictionary<ConfigurationType, object>()
			{
				[ConfigurationType.AppKey] = "Amtrack.Cache",
				[ConfigurationType.DefaultCacheTimeSpan] = new TimeSpan(0, 1, 0),
				[ConfigurationType.Host] = "127.0.0.1:6379"
			};

			Container.RegisterType<ICacheStore, CacheStore>
			(
			  new ContainerControlledLifetimeManager()
			  , new InjectionConstructor
			  (
				 configurations,
				 true
			  )
			);

			Container.RegisterType<ICachingRepository, CachingRepository>
		   (
			  new InjectionConstructor
			 (
				new AmtrackV2Context(),
				new AmtrackContext(),
				new AmtrackStockCheckContext(),
				new AmtrackStockCheckCachingContext()
			 )
		   );

			Container.RegisterType<ICachingService, CachingService>();

			Container.RegisterType<IBackgroundCacheService, BackgroundCacheService>();
		}
	}
}
