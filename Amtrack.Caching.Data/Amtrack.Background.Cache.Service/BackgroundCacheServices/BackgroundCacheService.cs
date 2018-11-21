using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service.BackgroundCacheServices
{
	public class BackgroundCacheService : BaseBackgroundCacheService
	{
		public BackgroundCacheService(
		   ICacheStore cacheStore,
		   IAmtrackLogger logger)
			: base(cacheStore, logger)
		{

		}

		#region Public Methods
		public override void Process()
		{
			Logger.LogInfo($"Processing Cache For Background Service {nameof(BackgroundCacheService)} - Start");

			try
			{
				while(true)
				{
					running = true;

					if(stop)
						return;

					foreach(var syncCacheService in syncCacheServices)
					{
						Logger.LogInfo($"Processing Cache For Service {syncCacheService.ServiceName} - Start");

						(bool, string, Exception) result = syncCacheService.SetDataAsync(cancellationTokenSource.Token).Result;

						//TODO
						if(result.Item1)
						{

						}
						else
						{

						}

						Logger.LogInfo($"Processing Cache For Service {syncCacheService.ServiceName} - Complete");
					}

					Logger.LogInfo($"Processing Cache For Services Async {string.Join(",", asyncCacheServices.Select(s => s.ServiceName))} - Start");

					var tasks = asyncCacheServices
						  .Select(s => s.SetDataAsync(cancellationTokenSource.Token))
						  .ToList();

					var results = Task.WhenAll(tasks).Result;

					Logger.LogInfo($"Processing Cache For Services Async {string.Join(",", asyncCacheServices.Select(s => s.ServiceName))} - Complete");

					//TODO
					foreach(var result in results)
					{

					}

					if(!stop)
						Thread.Sleep(1000);
				}

			}
			catch(Exception ex)
			{
				Logger.LogError(ex, $"Processing Cache For Background Service {nameof(BackgroundCacheService)} - Failed");

				throw;
			}
			finally
			{
				Logger.LogInfo($"Processing Cache For Background Service {nameof(BackgroundCacheService)} - Complete");

				running = false;
			}
		}
		#endregion

	}
}
