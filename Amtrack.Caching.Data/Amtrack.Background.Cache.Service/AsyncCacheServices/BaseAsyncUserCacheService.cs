using System;
using System.Threading;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
    public abstract class BaseAsyncUserCacheService : IAsyncCacheService
    {
        protected readonly ICacheStore cacheStore;
        protected readonly IAmtrackLogger logger;

        protected BaseAsyncUserCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger)
        {
            this.cacheStore = cacheStore;
            this.logger = logger;
        }

        #region Public Abstract Methods
        public abstract System.Threading.Tasks.Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task<(bool, string, Exception)> SetDataAsync(CancellationToken cancellationToken);
        #endregion
    }
}
