using System;
using Amtrack.DependencyInjection;

namespace Amtrack.Background.Cache.Service
{
	class Program
	{
		static void Main(string[] args)
		{
			//TODO
			Console.WriteLine("Start Cache Service");

			SetupUnity();

			var backgroundServiceController = BackgroundServiceController.Instance;

			backgroundServiceController.Start();

			Console.WriteLine("Press any key to stop");
			Console.ReadLine();

			backgroundServiceController.Stop();
		}

		static void SetupUnity()
		{
			DependencyInjector.AddExtension<DependencyOfCacheExtension>();
		}
	}

}