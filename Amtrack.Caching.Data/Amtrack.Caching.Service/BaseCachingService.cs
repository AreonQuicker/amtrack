using System;
using System.Collections.Generic;
using System.Text;
using Amtrack.Caching.Repository;
using Amtrack.Core.Repositories;
using Amtrack.Core.Services;

namespace Amtrack.Caching.Service
{
    public class BaseCachingService : CoreBaseService
    {
        protected readonly ICachingRepository cachingRepository;

        public BaseCachingService(ICachingRepository cachingRepository)
        {
            this.cachingRepository = cachingRepository;
        }
    }
}
