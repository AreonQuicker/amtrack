using System.Collections.Generic;
using System.Threading;
using Amtrack.Background.Cache.Service.AsyncCacheServices;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service
{
    public abstract class BaseBackgroundCacheService : IBackgroundCacheService
    {
        #region Private Readonly Variables
        protected readonly IList<IAsyncCacheService> _syncCacheServices;
        protected readonly IList<IAsyncCacheService> _asyncCacheServices;
        #endregion

        #region Private Variables
        protected CancellationTokenSource cancellationTokenSource;
        private Thread _thread = null;
        protected bool stop = false;
        protected bool running = false;
        #endregion

        #region Public Properties
        public bool IsRunning => running;
        public string Name => _thread?.Name;
        #endregion

        protected BaseBackgroundCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger)
        {
            _syncCacheServices = new List<IAsyncCacheService>();
            _asyncCacheServices = new List<IAsyncCacheService>();
            cancellationTokenSource = new CancellationTokenSource();

            _syncCacheServices.Add(new AsyncUserCacheService(cacheStore, logger));
        }

        #region Public Methods
        public bool Start()
        {
            if(_thread == null)
            {
                cancellationTokenSource = new CancellationTokenSource();
                _thread = new Thread(Process);
                _thread.Name = nameof(BaseBackgroundCacheService);
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

        public abstract void Process();
        #endregion
    }
}
