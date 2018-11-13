using System;
using Amtrack.DependencyInjection;

namespace Amtrack.Background.Cache.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Cache Service");

            SetupUnity();

            var backgroundService = DependencyInjector.Retrieve<IBackgroundCacheService>();

            backgroundService.Start();

            Console.WriteLine("Press any key to stop");
            Console.ReadLine();

            backgroundService.Stop();
        }

        static void SetupUnity()
        {
            DependencyInjector.AddExtension<DependencyOfCacheExtension>();
        }
    }

}