using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
    public interface IAsyncCacheService
    {
        Task<(bool,string, Exception)> AddDataAsync(CancellationToken cancellationToken);
        Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken);
    }
}
