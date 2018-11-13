using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Background.Cache.Service.AsyncCacheServices;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service.BackgroundCacheServices
{
    public class BackgroundCacheService : BaseBackgroundCacheService
    {
        public BackgroundCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger)
            : base(cacheStore, logger, nameof(BackgroundCacheService))
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

                    //Set Data
                    foreach(var syncCacheService in syncCacheServices)
                    {
                        (bool, string, Exception) result = syncCacheService.SetDataAsync(cancellationTokenSource.Token).Result;

                        if(result.Item1)
                        {

                        }
                        else
                        {

                        }
                        //TODO
                    }

                    //Set Data
                    var tasks = asyncCacheServices
                         .Select(s => s.SetDataAsync(cancellationTokenSource.Token))
                         .ToList();

                    var results = Task.WhenAll(tasks).Result;

                    foreach(var result in results)
                    {
                        //TODO
                    }

                    //TODO
                    if(!stop)
                        Thread.Sleep(1000);
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
