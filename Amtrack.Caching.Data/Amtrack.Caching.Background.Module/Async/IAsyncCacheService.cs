using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amtrack.Caching.Background.Module
{
	public interface IAsyncCacheService
	{
		bool Synchronous { get; }
		string ServiceName { get; }
		Task<(bool, string, Exception)> SetDataAsync(CancellationToken cancellationToken);
		Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken);
	}
}
