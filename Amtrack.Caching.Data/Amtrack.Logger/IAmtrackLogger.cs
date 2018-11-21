using System;

namespace Amtrack.Logger
{
	/// <summary>
	///     Defines the contract for a logger.
	/// </summary>
	public interface IAmtrackLogger
	{
		#region Public Properties

		/// <summary>
		///     Gets a value indicating whether logging is enabled for the debug level.
		/// </summary>
		/// <value><c>true</c> if logging is enabled for the debug level; otherwise, <c>false</c>.</value>
		bool IsDebugLoggingEnabled { get; }

		/// <summary>
		///     Gets a value indicating whether logging is enabled for the error level.
		/// </summary>
		/// <value><c>true</c> if logging is enabled for the error level; otherwise, <c>false</c>.</value>
		bool IsErrorLoggingEnabled { get; }

		/// <summary>
		///     Gets a value indicating whether logging is enabled for the fatal level.
		/// </summary>
		/// <value><c>true</c> if logging is enabled for the fatal level; otherwise, <c>false</c>.</value>
		bool IsFatalLoggingEnabled { get; }

		/// <summary>
		///     Gets a value indicating whether logging is enabled for the info level.
		/// </summary>
		/// <value><c>true</c> if logging is enabled for the info level; otherwise, <c>false</c>.</value>
		bool IsInfoLoggingEnabled { get; }

		/// <summary>
		///     Gets a value indicating whether logging is enabled for the trace level.
		/// </summary>
		/// <value><c>true</c> if logging is enabled for the trace level; otherwise, <c>false</c>.</value>
		bool IsTraceLoggingEnabled { get; }

		/// <summary>
		///     Gets a value indicating whether logging is enabled for the warning level.
		/// </summary>
		/// <value><c>true</c> if logging is enabled for the warning level; otherwise, <c>false</c>.</value>
		bool IsWarningLoggingEnabled { get; }

		#endregion

		#region Public Methods and Operators

		/// <summary>
		///     Writes a diagnostic message at the debug level.
		/// </summary>
		/// <typeparam name="T">The type of the value.</typeparam>
		/// <param name="value">The value to be written.</param>
		void LogDebug<T>(T value);

		/// <summary>
		///     Writes a diagnostic message and exception at the debug level.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">The message to be written.</param>
		void LogDebug(Exception exception, string message);

		/// <summary>
		///     Writes a diagnostic message at the error level.
		/// </summary>
		/// <typeparam name="T">The type of the value.</typeparam>
		/// <param name="value">The value to be written.</param>
		void LogError<T>(T value);

		/// <summary>
		///     Writes a diagnostic message and exception at the error level.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">The message to be written.</param>
		void LogError(Exception exception, string message);

		/// <summary>
		///     Writes a diagnostic message at the fatal level.
		/// </summary>
		/// <typeparam name="T">The type of the value.</typeparam>
		/// <param name="value">The value to be written.</param>
		void LogFatal<T>(T value);

		/// <summary>
		///     Writes a diagnostic message and exception at the fatal level.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">The message to be written.</param>
		void LogFatal(Exception exception, string message);

		/// <summary>
		///     Writes a diagnostic message at the info level.
		/// </summary>
		/// <typeparam name="T">The type of the value.</typeparam>
		/// <param name="value">The value to be written.</param>
		void LogInfo<T>(T value);

		/// <summary>
		///     Writes a diagnostic message and exception at the info level.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">The message to be written.</param>
		void LogInfo(Exception exception, string message);

		/// <summary>
		///     Writes a diagnostic message at the trace level.
		/// </summary>
		/// <typeparam name="T">The type of the value.</typeparam>
		/// <param name="value">The value to be written.</param>
		void LogTrace<T>(T value);

		/// <summary>
		///     Writes a diagnostic message and exception at the trace level.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">The message to be written.</param>
		void LogTrace(Exception exception, string message);

		/// <summary>
		///     Writes a diagnostic message at the warning level.
		/// </summary>
		/// <typeparam name="T">The type of the value.</typeparam>
		/// <param name="value">The value to be written.</param>
		void LogWarning<T>(T value);

		/// <summary>
		///     Writes a diagnostic message and exception at the warning level.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">The message to be written.</param>
		void LogWarning(Exception exception, string message);

		#endregion
	}
}
