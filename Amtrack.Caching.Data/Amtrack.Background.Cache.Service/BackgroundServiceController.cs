using System;
using System.Collections.Generic;
using System.Text;
using Amtrack.Background.Cache.Service.AsyncCacheServices;
using Amtrack.Background.Cache.Service.BackgroundCacheServices;
using Amtrack.Cache.Store;
using Amtrack.DependencyInjection;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service
{
    public class BackgroundServiceController
    {
        private readonly IList<IBackgroundCacheService> _backgroundCacheServices = null;
        private readonly IAmtrackLogger _amtrackLogger = null;

        public BackgroundServiceController()
        {
            _amtrackLogger = DependencyInjector.Retrieve<IAmtrackLogger>();
            _backgroundCacheServices = new List<IBackgroundCacheService>();

            Register();
        }

        private void Register()
        {
            var backgroundService = DependencyInjector.Retrieve<IBackgroundCacheService>();
          
            var cacheStore = DependencyInjector.Retrieve<ICacheStore>();

            backgroundService.Init(new List<IAsyncCacheService>
            {
                new AsyncUserCacheService(cacheStore,_amtrackLogger, true)
            });

            _backgroundCacheServices.Add(backgroundService);
        }

        public bool Start()
        {
            foreach(var backgroundCacheService in _backgroundCacheServices)
            {
                backgroundCacheService.Start();
            }

            return true;
        }

        public bool Stop()
        {
            foreach(var backgroundCacheService in _backgroundCacheServices)
            {
                backgroundCacheService.Stop();
            }

            return true;
        }

        public static BackgroundServiceController Instance => new BackgroundServiceController();
    }
}
