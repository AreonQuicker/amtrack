using System;
using System.Collections.Generic;
using Amtrack.Cache.SDK;
using Amtrack.Cache.Store;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Cache.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurations = new Dictionary<ConfigurationType, object>()
            {
                [ConfigurationType.AppKey] = "Amtrack.Cache",
                [ConfigurationType.DefaultCacheTimeSpan] = new TimeSpan(0, 10, 0),
                [ConfigurationType.DefaultInternalCacheTimeSpan] = new TimeSpan(0, 10, 0),
                [ConfigurationType.Host] = "127.0.0.1:6379"
            };

            ICacheSDK cacheSDK = new CacheSDK(configurations, true);

            var usersVos = cacheSDK.AllValues<UserVO>();


            var users2Vos = cacheSDK.AllValues<UserVO>();
        }
    }
}
