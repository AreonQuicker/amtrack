using System;
using System.Linq;
using System.Threading;
using Amtrack.Cache.Store;
using Amtrack.Caching.Service;
using Amtrack.DependencyInjection;
using Amtrack.Logger;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
	public class AsyncUserCacheService : BaseAsyncCacheService
	{
		public AsyncUserCacheService(
		   ICacheStore cacheStore,
		   IAmtrackLogger logger,
		   bool synchronous,
		   string serviceName)
			: base(cacheStore, logger, synchronous, serviceName)
		{

		}

		public override bool SetData(CancellationToken cancellationToken)
		{
			logger.LogInfo($"Saving Cache For Service {ServiceName} On Method {"GetUserCacheModel"} - Start");

			var cachingService = DependencyInjector.Retrieve<ICachingService>();

			var userCacheModel = cachingService.GetUserCacheModel();

			if(userCacheModel == null)
				throw new NullReferenceException(nameof(userCacheModel));

			var securityLevelValues = userCacheModel.SecurityLevels
				.ToDictionary(d => d.CacheKey, d => d);

			cacheStore.SetAll<SecurityLevelVO>(securityLevelValues);

			var userValues = userCacheModel.Users
			  .ToDictionary(d => d.CacheKey, d => d);

			cacheStore.SetAll<UserVO>(userValues);

			logger.LogInfo($"Saving Cache For Service {ServiceName} On Method {"GetUserCacheModel"} - Complete");

			return true;
		}

		public override bool DeleteData(CancellationToken cancellationToken)
		{
			logger.LogInfo($"Deleting Cache For Service {ServiceName} On Method {"GetUserCacheModel"} - Start");

			cacheStore.DeleteAll<SecurityLevelVO>();

			cacheStore.DeleteAll<UserVO>();

			logger.LogInfo($"Deleting Cache For Service {ServiceName} On Method {"GetUserCacheModel"} - Complete");

			return true;
		}
	}
}
