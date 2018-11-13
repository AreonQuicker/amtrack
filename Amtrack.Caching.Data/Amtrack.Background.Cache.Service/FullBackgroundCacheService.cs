using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service
{
    public class FullBackgroundCacheService : BaseBackgroundCacheService
    {
        public FullBackgroundCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger)
            : base(cacheStore, logger)
        {
        }

        #region Public Methods
        public override void Process()
        {
            try
            {
                while(true)
                {
                    running = true;

                    if(stop)
                        return;

                    //Remove Data
                    foreach(var syncCacheService in _syncCacheServices)
                    {
                        (bool, string, Exception) result = syncCacheService.DeleteDataAsync(cancellationTokenSource.Token).Result;

                        //TODO
                    }

                    //Set Data
                    foreach(var syncCacheService in _syncCacheServices)
                    {
                        (bool, string, Exception) result = syncCacheService.SetDataAsync(cancellationTokenSource.Token).Result;

                        //TODO
                    }

                    //Remove Data
                    var tasks = _asyncCacheServices
                        .Select(s => s.DeleteDataAsync(cancellationTokenSource.Token))
                        .ToList();

                    (bool, string, Exception)[] results = Task.WhenAll(tasks).Result;

                    foreach(var result in results)
                    {
                        //TODO
                    }

                    //Set Data
                    tasks = _asyncCacheServices
                         .Select(s => s.SetDataAsync(cancellationTokenSource.Token))
                         .ToList();

                    results = Task.WhenAll(tasks).Result;

                    foreach(var result in results)
                    {
                        //TODO
                    }

                    //TODO
                    if(!stop)
                        Thread.Sleep(100000);
                }

            }
            catch(Exception ex)
            {
                //TODO
                throw;
            }
            finally
            {
                running = false;
            }
        }
        #endregion

    }
}
