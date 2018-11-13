﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amtrack.Background.Cache.Service.AsyncCacheServices;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service.BackgroundCacheServices
{
    public abstract class BaseBackgroundCacheService : BaseBackgroundService, IBackgroundCacheService
    {

        #region protected Variables   
        protected IList<IAsyncCacheService> asyncCacheServices;
        protected IList<IAsyncCacheService> syncCacheServices;
        #endregion

        #region Private Variables      
        #endregion    

        protected BaseBackgroundCacheService(
           ICacheStore cacheStore,
           IAmtrackLogger logger,
           string threadName)
            : base(logger, threadName)
        {

            cancellationTokenSource = new CancellationTokenSource();
        }

        #region Public Methods
        public void Init(IList<IAsyncCacheService> asyncCacheServices)
        {
            this.asyncCacheServices = asyncCacheServices
                 .Where(w => !w.Synchronous)
                 .ToList();

            this.syncCacheServices = asyncCacheServices
                .Where(w => w.Synchronous)
                .ToList();
        }      
        #endregion
    }
}