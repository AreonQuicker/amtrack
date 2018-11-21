﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
	public interface IAsyncCacheService
	{
		bool Synchronous { get; }
		string ServiceName { get; }
		Task<(bool, string, Exception)> SetDataAsync(CancellationToken cancellationToken);
		Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken);
	}
}
