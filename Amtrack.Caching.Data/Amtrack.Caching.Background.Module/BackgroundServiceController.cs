using System.Collections.Generic;
using Amtrack.Cache.Store;
using Amtrack.DependencyInjection;
using Amtrack.Logger;
using Amtrack.Models.Cache;

namespace Amtrack.Caching.Background.Module
{
	//Create service
	//Create a scheduler
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
			  new AsyncCacheService<ICacheModel>(cacheStore,_amtrackLogger, true,"Users", new MethodInfo{ MethodName = "GetUserCacheModel" } ),

			  new AsyncCacheService<ICacheModel>(cacheStore,_amtrackLogger, true,"Accounts", new MethodInfo
			  {
				  MethodName = "GetAccountCacheModel" ,
				  PropertyInfos = new List<PropertyInfo>
				  {
					new PropertyInfo{
						PropertyName = "Accounts",
						ConnectionFields = new List<string> { "CustomerCode" }
					}
				  }
			  }),

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
