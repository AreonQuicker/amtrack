using System;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Cache.Store;
using Amtrack.DependencyInjection;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
    public abstract class BaseAsyncCacheService : IAsyncCacheService
    {
        protected readonly ICacheStore cacheStore;
        protected readonly IAmtrackLogger logger;

        public bool Synchronous { get; }

        protected BaseAsyncCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger,
           bool synchronous)
        {
            this.cacheStore = cacheStore;
            this.logger = logger;
            this.Synchronous = synchronous;
        }

        #region Public Methods
        public async Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken)
        {
            //TODO
            var metodKey = $"{nameof(BaseAsyncCacheService)} {nameof(DeleteDataAsync)}";

            try
            {
                bool result = await Task.Factory.StartNew<bool>(() =>
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    return DeleteData(cancellationToken);

                }, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);

                return (result, metodKey, null);
            }
            catch(OperationCanceledException ex)
            {
                //TODO
                return (false, metodKey, ex);
            }
            catch(Exception ex)
            {
                //TODO
                return (false, metodKey, ex);
            }
        }

        public async Task<(bool, string, Exception)> SetDataAsync(CancellationToken cancellationToken)
        {
            //TODO
            var metodKey = $"{nameof(BaseAsyncCacheService)} {nameof(SetDataAsync)}";

            try
            {
                bool result = await Task.Factory.StartNew<bool>(() =>
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    return SetData(cancellationToken);

                }, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);

                return (result, metodKey, null);
            }
            catch(OperationCanceledException ex)
            {
                //TODO
                return (false, metodKey, ex);
            }
            catch(Exception ex)
            {
                //TODO
                return (false, metodKey, ex);
            }
        }
        #endregion

        #region Public Abstract Methods     
        public abstract bool SetData(CancellationToken cancellationToken);

        public abstract bool DeleteData(CancellationToken cancellationToken);
        #endregion
    }
}
