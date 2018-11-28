using System.Threading;
using Amtrack.Logger;

namespace Amtrack.Caching.Background.Module
{
	public abstract class BaseBackgroundService : IBackgroundService
	{
		#region Private Readonly Variables   

		#endregion

		#region Protected Variables
		protected CancellationTokenSource cancellationTokenSource;
		protected IAmtrackLogger Logger { get; }
		protected bool stop = false;
		protected bool running = false;
		#endregion

		#region Private Variables      
		private Thread _thread = null;
		#endregion

		#region Public Properties
		public bool IsRunning => running;
		public string Name => _thread?.Name;
		#endregion

		protected BaseBackgroundService(
		   IAmtrackLogger logger)
		{

			cancellationTokenSource = new CancellationTokenSource();
			Logger = logger;
		}

		#region Public Methods
		public virtual bool Start()
		{
			if(_thread == null
				&& !running)
			{
				stop = false;
				running = false;
				cancellationTokenSource = new CancellationTokenSource();
				_thread = new Thread(Process);
				_thread.Start();

				return true;
			}

			return false;
		}

		public virtual bool Stop()
		{
			cancellationTokenSource.Cancel();
			stop = true;

			while(IsRunning)
			{
				Thread.Sleep(250);
			}

			running = false;
			_thread = null;

			return true;
		}

		public abstract void Process();

		public bool CanStart()
		{
			if(_thread == null
				&& !running)
			{
				return true;
			}

			return false;
		}
		#endregion
	}
}
