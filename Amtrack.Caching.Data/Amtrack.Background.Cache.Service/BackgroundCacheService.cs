using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Background.Cache.Service.AsyncCacheServices;
using Amtrack.Cache.Store;
using Amtrack.Caching.Service;
using Amtrack.Logger;
using System.Linq;

namespace Amtrack.Background.Cache.Service
{
    public class BackgroundCacheService : IBackgroundCacheService
    {
        #region Private Readonly Variables
        private readonly IList<IAsyncCacheService> _syncCacheServices;
        private readonly IList<IAsyncCacheService> _asyncCacheServices;
        #endregion

        #region Private Variables
        private CancellationTokenSource cancellationTokenSource;
        private Thread _thread = null;
        private bool stop = false;
        private bool running = false;
        #endregion

        #region Public Properties
        public bool IsRunning => running;
        public string Name => _thread?.Name; 
        #endregion

        public BackgroundCacheService(ICachingService cachingService,
           ICacheStore cacheStore,
           IAmtrackLogger logger)
        {
            _syncCacheServices = new List<IAsyncCacheService>();
            _asyncCacheServices = new List<IAsyncCacheService>();
            cancellationTokenSource = new CancellationTokenSource();

            _syncCacheServices.Add(new AsyncUserCacheService(cachingService, cacheStore, logger));
        }

        #region Public Methods
        public bool Start()
        {
            if(_thread == null)
            {
                cancellationTokenSource = new CancellationTokenSource();
                _thread = new Thread(Process);
                _thread.Name = nameof(BackgroundCacheService);
                _thread.Start();

                return true;
            }

            return false;
        }

        public bool Stop()
        {
            cancellationTokenSource.Cancel();
            stop = true;

            while(IsRunning)
            {
                Thread.Sleep(250);
            }

            running = false;
            _thread = null;
            stop = false;
            return true;
        }

        public void Process()
        {
            try
            {
                while(true)
                {
                    running = true;

                    if(stop)
                        return;

                    foreach(var syncCacheService in _syncCacheServices)
                    {
                        (bool, string, Exception) result = syncCacheService.DeleteDataAsync(cancellationTokenSource.Token).Result;

                        //TODO
                    }

                    foreach(var syncCacheService in _syncCacheServices)
                    {
                        (bool, string, Exception) result = syncCacheService.AddDataAsync(cancellationTokenSource.Token).Result;

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

                    //Remove Data
                    tasks = _asyncCacheServices
                         .Select(s => s.AddDataAsync(cancellationTokenSource.Token))
                         .ToList();

                    results = Task.WhenAll(tasks).Result;

                    foreach(var result in results)
                    {
                        //TODO
                    }

                    //TODO
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
