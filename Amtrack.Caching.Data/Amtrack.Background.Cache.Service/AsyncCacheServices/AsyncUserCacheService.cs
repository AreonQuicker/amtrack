using System;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Cache.Store;
using Amtrack.Caching.Service;
using Amtrack.DependencyInjection;
using Amtrack.Logger;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
    public class AsyncUserCacheService : BaseAsyncUserCacheService
    {

        public AsyncUserCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger)
            : base(cacheStore, logger)
        {

        }

        public override async Task<(bool, string, Exception)> SetDataAsync(CancellationToken cancellationToken)
        {
            var cachingService = DependencyInjector.Retrieve<ICachingService>();

            var metodKey = $"{nameof(AsyncUserCacheService)} {nameof(SetDataAsync)}";

            try
            {
                bool result = await Task.Factory.StartNew<bool>(() =>
                  {
                      cancellationToken.ThrowIfCancellationRequested();

                      var userCacheModel = cachingService.GetUserCacheModel();

                      if(userCacheModel == null)
                          throw new NullReferenceException(nameof(userCacheModel));

                      foreach(var securityLevelVO in userCacheModel.SecurityLevels)
                      {
                          cacheStore.Set(securityLevelVO.CacheKey, securityLevelVO);
                      }

                      foreach(var userVO in userCacheModel.Users)
                      {
                          cacheStore.Set(userVO.CacheKey, userVO);
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

        public override async Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken)
        {
            var metodKey = $"{nameof(AsyncUserCacheService)} {nameof(DeleteDataAsync)}";

            try
            {
                bool result = await Task.Factory.StartNew<bool>(() =>
                   {
                       cancellationToken.ThrowIfCancellationRequested();

                       cacheStore.DeleteAll<SecurityLevelVO>();

                       cacheStore.DeleteAll<UserVO>();

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
