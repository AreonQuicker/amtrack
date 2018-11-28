using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amtrack.Cache.Store;
using Amtrack.Caching.Service;
using Amtrack.DependencyInjection;
using Amtrack.Logger;
using Amtrack.Models.Cache;

namespace Amtrack.Caching.Background.Module
{
	public class AsyncCacheService<T> : BaseAsyncCacheService where T : ICacheModel
	{
		private readonly MethodInfo[] methods;

		public AsyncCacheService(
		  ICacheStore cacheStore,
		  IAmtrackLogger logger,
		  bool synchronous,
		  string serviceName,
		  params MethodInfo[] methods)
		   : base(cacheStore, logger, synchronous, serviceName)
		{
			this.methods = methods;
		}

		public override bool SetData(CancellationToken cancellationToken)
		{
			var cachingService = DependencyInjector.Retrieve<ICachingService>();

			Type type = cachingService.GetType();

			if(type != null)
			{
				foreach(var method in methods)
				{
					logger.LogInfo($"Saving Cache For Service {ServiceName} On Method {method} - Start");

					var methodInfo = type.GetMethod(method.MethodName);

					if(methodInfo != null)
					{
						T result = (T)methodInfo.Invoke(cachingService, null);

						var propertyTypes = result.GetType().GetProperties();

						var propertyInfos = (from p in propertyTypes
											 from pi in (method.PropertyInfos ?? new List<PropertyInfo>())
											 .Where(w => w.PropertyName == p.Name).DefaultIfEmpty()
											 select new
											 {
												 Property = p,
												 PropertyType = p.PropertyType,
												 PropertyName = p.Name,
												 ConnectionFields = pi?.ConnectionFields
											 })
											 .ToList();

						foreach(var propertyInfo in propertyInfos)
						{
							var propertyValue = propertyInfo.Property.GetValue(result, null);

							if(propertyValue != null
								&& propertyValue is IEnumerable<object>)
							{
								var values = ((IEnumerable<object>)propertyValue);

								Action<bool> action = (multiple) =>
								{
									if(propertyInfo.ConnectionFields != null
									&& propertyInfo.ConnectionFields.Any())
										cacheStore.SetAll(values, propertyInfo.ConnectionFields.ToArray(), multiple);
									else
										cacheStore.SetAll(values, multiple);
								};

								RetryAction(action, 2);
							}
						}
					}

					logger.LogInfo($"Saving Cache For Service {ServiceName} On Method {method} - Complete");
				}
			}

			return true;
		}

		public override bool DeleteData(CancellationToken cancellationToken)
		{
			var cachingService = DependencyInjector.Retrieve<ICachingService>();

			Type type = cachingService.GetType();

			if(type != null)
			{
				foreach(var method in methods)
				{
					logger.LogInfo($"Deleting Cache For Service {ServiceName} On Method {method} - Start");

					var methodInfo = type.GetMethod(method.MethodName);

					if(methodInfo != null)
					{
						var propertyTypes = methodInfo.ReturnType.GetProperties();

						foreach(var propertyType in propertyTypes)
						{
							if(typeof(IEnumerable<object>).IsAssignableFrom(propertyType.PropertyType))
							{
								cacheStore.DeleteAll(propertyType.PropertyType.GetGenericArguments().FirstOrDefault());
							}
						}
					}

					logger.LogInfo($"Deleting Cache For Service {ServiceName} On Method {method} - Complete");
				}
			}

			return true;
		}
	}
}
