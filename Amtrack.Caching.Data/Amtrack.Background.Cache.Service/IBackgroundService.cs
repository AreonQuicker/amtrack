namespace Amtrack.Background.Cache.Service
{
	public interface IBackgroundService
	{
		bool CanStart();
		bool Start();
		bool Stop();
		bool IsRunning { get; }
		string Name { get; }
	}
}
