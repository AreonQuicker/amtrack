using System.Collections.Generic;
using Amtrack.Background.Cache.Service.AsyncCacheServices;

namespace Amtrack.Background.Cache.Service.BackgroundCacheServices
{
	public interface IBackgroundCacheService : IBackgroundService
	{
		void Init(IList<IAsyncCacheService> asyncCacheServices);
	}
}
