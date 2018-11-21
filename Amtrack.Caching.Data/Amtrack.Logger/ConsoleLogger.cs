using System;

using NLog;

namespace Amtrack.Logger
{
	public sealed class ConsoleLogger : IAmtrackLogger
	{
		#region Fields

		/// <summary>
		///     The logger instance.
		/// </summary>
		private readonly ILogger _logger;

		#endregion

		#region Constructors and Destructors

		/// <summary>
		///     Initializes a new instance of the <see cref="ConsoleLogger" /> class.
		/// </summary>
		public ConsoleLogger()
		{
			LogManager.Configuration = new ConsoleLoggingConfiguration();
			_logger = LogManager.GetLogger(nameof(ConsoleLogger));
		}

		#endregion

		#region IAmtrackLogger

		/// <inheritdoc />
		public bool IsDebugLoggingEnabled => _logger?.IsDebugEnabled ?? false;

		/// <inheritdoc />
		public bool IsErrorLoggingEnabled => _logger?.IsErrorEnabled ?? false;

		/// <inheritdoc />
		public bool IsFatalLoggingEnabled => _logger?.IsFatalEnabled ?? false;

		/// <inheritdoc />
		public bool IsInfoLoggingEnabled => _logger?.IsInfoEnabled ?? false;

		/// <inheritdoc />
		public bool IsTraceLoggingEnabled => _logger?.IsTraceEnabled ?? false;

		/// <inheritdoc />
		public bool IsWarningLoggingEnabled => _logger?.IsWarnEnabled ?? false;

		/// <inheritdoc />
		public void LogDebug<T>(T value)
		{
			if(IsDebugLoggingEnabled)
				_logger?.Debug(value);
		}

		/// <inheritdoc />
		public void LogDebug(Exception exception, string message)
		{
			if(IsDebugLoggingEnabled)
				_logger?.Debug(exception, message);
		}

		/// <inheritdoc />
		public void LogError<T>(T value)
		{
			if(IsErrorLoggingEnabled)
				_logger?.Error(value);
		}

		/// <inheritdoc />
		public void LogError(Exception exception, string message)
		{
			if(IsErrorLoggingEnabled)
				_logger?.Error(exception, message);
		}

		/// <inheritdoc />
		public void LogFatal<T>(T value)
		{
			if(IsFatalLoggingEnabled)
				_logger?.Fatal(value);
		}

		/// <inheritdoc />
		public void LogFatal(Exception exception, string message)
		{
			if(IsFatalLoggingEnabled)
				_logger?.Fatal(exception, message);
		}

		/// <inheritdoc />
		public void LogInfo<T>(T value)
		{
			if(IsInfoLoggingEnabled)
				_logger?.Info(value);
		}

		/// <inheritdoc />
		public void LogInfo(Exception exception, string message)
		{
			if(IsInfoLoggingEnabled)
				_logger?.Info(exception, message);
		}

		/// <inheritdoc />
		public void LogTrace<T>(T value)
		{
			if(IsTraceLoggingEnabled)
				_logger?.Trace(value);
		}

		/// <inheritdoc />
		public void LogTrace(Exception exception, string message)
		{
			if(IsTraceLoggingEnabled)
				_logger?.Trace(exception, message);
		}

		/// <inheritdoc />
		public void LogWarning<T>(T value)
		{
			if(IsWarningLoggingEnabled)
				_logger.Warn(value);
		}

		/// <inheritdoc />
		public void LogWarning(Exception exception, string message)
		{
			if(IsWarningLoggingEnabled)
				_logger.Warn(exception, message);
		}

		#endregion
	}
}
