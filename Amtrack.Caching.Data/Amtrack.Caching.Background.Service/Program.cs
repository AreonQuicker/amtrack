using System;
using Amtrack.Caching.Background.Module;
using Amtrack.DependencyInjection;
using StackExchange.Redis;
using static System.Console;

namespace Amtrack.Caching.Background.Service
{

	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Start Service");

			DependencyInjector.AddExtension<DependencyOfCacheExtension>();

			var backgroundServiceController = BackgroundServiceController.Instance;

			backgroundServiceController.Start();

			WriteLine("Press any key to stop...");
			ReadKey();

			backgroundServiceController.Stop();
		}
	}
}
