using Amtrack.Caching.Background.Module;
using Amtrack.DependencyInjection;
using static System.Console;

namespace Amtrack.Caching.Background.Service
{
	class Program
	{
		static void Main(string[] args)
		{
			DependencyInjector.AddExtension<DependencyOfCacheExtension>();

			var backgroundServiceController = BackgroundServiceController.Instance;

			backgroundServiceController.Start();

			WriteLine("Press any key to stop...");
			ReadKey();

			backgroundServiceController.Stop();
		}
	}
}
