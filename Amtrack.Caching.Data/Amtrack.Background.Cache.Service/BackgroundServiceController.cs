using System.Collections.Generic;
using Amtrack.Background.Cache.Service.AsyncCacheServices;
using Amtrack.Background.Cache.Service.BackgroundCacheServices;
using Amtrack.Cache.Store;
using Amtrack.DependencyInjection;
using Amtrack.Logger;
using Amtrack.Models.Cache;

namespace Amtrack.Background.Cache.Service
{
	public class BackgroundServiceController
	{
		private readonly IList<IBackgroundCacheService> _backgroundCacheServices = null;
		private readonly IAmtrackLogger _amtrackLogger = null;

		public BackgroundServiceController()
		{
			_amtrackLogger = DependencyInjector.Retrieve<IAmtrackLogger>();
			_backgroundCacheServices = new List<IBackgroundCacheService>();

			Register();
		}

		private void Register()
		{
			var cacheStore = DependencyInjector.Retrieve<ICacheStore>();

			var backgroundService = DependencyInjector.Retrieve<IBackgroundCacheService>();

			backgroundService.Init(new List<IAsyncCacheService>
			{
			   new AsyncCacheService<ICacheModel>(cacheStore,_amtrackLogger, true,"Users", "GetUserCacheModel"),
			   new AsyncInventoryCacheService(cacheStore, _amtrackLogger, true, "GetInventoryCacheModel")
			});

			_backgroundCacheServices.Add(backgroundService);
		}

		public bool Start()
		{
			foreach(var backgroundCacheService in _backgroundCacheServices)
			{
				backgroundCacheService.Start();
			}

			return true;
		}

		public bool Stop()
		{
			foreach(var backgroundCacheService in _backgroundCacheServices)
			{
				backgroundCacheService.Stop();
			}

			return true;
		}

		public static BackgroundServiceController Instance => new BackgroundServiceController();
	}
}
