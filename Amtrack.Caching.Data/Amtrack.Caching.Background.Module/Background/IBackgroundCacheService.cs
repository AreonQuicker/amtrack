using System.Collections.Generic;

namespace Amtrack.Caching.Background.Module
{
	public interface IBackgroundCacheService : IBackgroundService
	{
		void Init(IList<IAsyncCacheService> asyncCacheServices);
	}
}
