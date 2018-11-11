using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Cache.Store;
using Amtrack.Caching.Service;
using Amtrack.Logger;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
    public class AsyncUserCacheService : IAsyncCacheService
    {
        private readonly ICachingService _cachingService;
        private readonly ICacheStore _cacheStore;

        public AsyncUserCacheService(ICachingService cachingService,
           ICacheStore cacheStore,
           IAmtrackLogger logger)
        {
            this._cachingService = cachingService;
            this._cacheStore = cacheStore;
        }

        public async Task<(bool, string, Exception)> AddDataAsync(CancellationToken cancellationToken)
        {
            var metodKey = $"{nameof(AsyncUserCacheService)} {nameof(AddDataAsync)}";

            try
            {
                bool result = await Task.Factory.StartNew<bool>(() =>
                  {
                      cancellationToken.ThrowIfCancellationRequested();

                      var userCacheModel = _cachingService.GetUserCacheModel();

                      if(userCacheModel == null)
                          throw new NullReferenceException(nameof(userCacheModel));

                      foreach(var securityLevelVO in userCacheModel.SecurityLevels)
                      {
                          _cacheStore.Set(securityLevelVO.CacheKey, securityLevelVO);
                      }

                      foreach(var userVO in userCacheModel.Users)
                      {
                          _cacheStore.Set(userVO.CacheKey, userVO);
                      }

                      return true;

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

        public async Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken)
        {
            var metodKey = $"{nameof(AsyncUserCacheService)} {nameof(AddDataAsync)}";

            try
            {
                bool result = await Task.Factory.StartNew<bool>(() =>
                   {
                       cancellationToken.ThrowIfCancellationRequested();

                       _cacheStore.DeleteAll<SecurityLevelVO>();

                       _cacheStore.DeleteAll<UserVO>();

                       return true;

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
    }
}
