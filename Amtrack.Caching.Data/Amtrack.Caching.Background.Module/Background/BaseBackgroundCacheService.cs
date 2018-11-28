using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Caching.Background.Module
{
	public abstract class BaseBackgroundCacheService : BaseBackgroundService, IBackgroundCacheService
	{

		#region protected Variables   
		protected IList<IAsyncCacheService> asyncCacheServices;
		protected IList<IAsyncCacheService> syncCacheServices;
		#endregion

		#region Private Variables      
		#endregion

		protected BaseBackgroundCacheService(
		   ICacheStore cacheStore,
		   IAmtrackLogger logger)
			: base(logger)
		{

			cancellationTokenSource = new CancellationTokenSource();
		}

		#region Public Methods
		public void Init(IList<IAsyncCacheService> asyncCacheServices)
		{
			this.asyncCacheServices = asyncCacheServices
				 .Where(w => !w.Synchronous)
				 .ToList();

			this.syncCacheServices = asyncCacheServices
				.Where(w => w.Synchronous)
				.ToList();
		}
		#endregion
	}
}
