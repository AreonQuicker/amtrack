using System;
using System.Threading;
using System.Threading.Tasks;
using Amtrack.Cache.Store;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
	public abstract class BaseAsyncCacheService : IAsyncCacheService
	{
		#region Protected ReadOnly
		protected readonly ICacheStore cacheStore;
		protected readonly IAmtrackLogger logger;
		#endregion

		#region Public Properties
		public bool Synchronous { get; }
		public string ServiceName { get; }
		#endregion

		protected BaseAsyncCacheService(
		   ICacheStore cacheStore,
		   IAmtrackLogger logger,
		   bool synchronous,
		   string serviceName)
		{
			this.cacheStore = cacheStore;
			this.logger = logger;
			this.Synchronous = synchronous;
			this.ServiceName = serviceName;
		}

		#region Public Methods
		public async Task<(bool, string, Exception)> DeleteDataAsync(CancellationToken cancellationToken)
		{
			logger.LogInfo($"Deleting Cache For Service {ServiceName} - Start");

			try
			{
				bool result = await Task.Factory.StartNew<bool>(() =>
				{
					cancellationToken.ThrowIfCancellationRequested();

					return DeleteData(cancellationToken);

				}, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);

				return (result, ServiceName, null);
			}
			catch(OperationCanceledException ex)
			{
				logger.LogWarning(ex, $"Deleting Cache For Service {ServiceName} - Stop");

				return (false, ServiceName, ex);
			}
			catch(Exception ex)
			{
				logger.LogError(ex, $"Deleting Cache For Service {ServiceName} - Failed");

				return (false, ServiceName, ex);
			}
			finally
			{
				logger.LogInfo($"Deleting Cache For Service {ServiceName} - Complete");
			}
		}

		public async Task<(bool, string, Exception)> SetDataAsync(CancellationToken cancellationToken)
		{
			logger.LogInfo($"Saving Cache For Service {ServiceName} - Start");

			try
			{
				bool result = await Task.Factory.StartNew<bool>(() =>
				{
					cancellationToken.ThrowIfCancellationRequested();

					return SetData(cancellationToken);

				}, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);

				return (result, ServiceName, null);
			}
			catch(OperationCanceledException ex)
			{
				logger.LogInfo($"Saving Cache For Service {ServiceName} - Stop");

				return (false, ServiceName, ex);

			}
			catch(Exception ex)
			{
				logger.LogInfo($"Saving Cache For Service {ServiceName} - Failed");

				return (false, ServiceName, ex);
			}
			finally
			{
				logger.LogInfo($"Saving Cache For Service {ServiceName} - Complete");
			}
		}
		#endregion

		#region Public Abstract Methods     
		public abstract bool SetData(CancellationToken cancellationToken);

		public abstract bool DeleteData(CancellationToken cancellationToken);
		#endregion
	}
}
