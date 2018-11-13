using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Amtrack.Logger;

namespace Amtrack.Background.Cache.Service
{
   public abstract class BaseBackgroundService : IBackgroundService
    {
        #region protected Readonly Variables   
        protected CancellationTokenSource cancellationTokenSource;
        private readonly string _threadName;
        #endregion

        #region Private Variables      
        private Thread _thread = null;
        protected bool stop = false;
        protected bool running = false;
        #endregion

        #region Public Properties
        public bool IsRunning => running;
        public string Name => _thread?.Name;
        #endregion

        protected BaseBackgroundService(
           IAmtrackLogger logger,
           string threadName)
        {

            cancellationTokenSource = new CancellationTokenSource();
            _threadName = threadName;
        }

        #region Public Methods
        public virtual bool Start()
        {
            if(_thread == null
                && !running
                && stop)
            {               

                stop = false;
                running = false;
                cancellationTokenSource = new CancellationTokenSource();
                _thread = new Thread(Process);
                _thread.Name = _threadName;
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
                && !running
                && stop)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
