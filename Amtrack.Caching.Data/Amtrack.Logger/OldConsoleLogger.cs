using System;

namespace Amtrack.Logger
{
    //TODO
    public class OldConsoleLogger : IAmtrackLogger
    {
        public bool IsDebugLoggingEnabled => throw new NotImplementedException();

        public bool IsErrorLoggingEnabled => throw new NotImplementedException();

        public bool IsFatalLoggingEnabled => throw new NotImplementedException();

        public bool IsInfoLoggingEnabled => throw new NotImplementedException();

        public bool IsTraceLoggingEnabled => throw new NotImplementedException();

        public bool IsWarningLoggingEnabled => throw new NotImplementedException();

        public void LogDebug<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void LogDebug(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public void LogError<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public void LogFatal<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void LogFatal(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public void LogInfo<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public void LogTrace<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void LogTrace(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(Exception exception, string message)
        {
            throw new NotImplementedException();
        }
    }
}
