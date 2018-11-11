using System;
using System.Collections.Generic;
using System.Text;

namespace Amtrack.Background.Cache.Service
{
    public interface IBackgroundCacheService
    {
        bool Start();
        bool Stop();
        void Process();
        bool IsRunning { get; }
        string Name { get; }
    }
}
