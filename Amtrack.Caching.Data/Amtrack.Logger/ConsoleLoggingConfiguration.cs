using System.Text;

using NLog;
using NLog.Conditions;
using NLog.Config;
using NLog.Targets;

namespace Amtrack.Logger
{
	/// <summary>
	///     Represents the logging configuration for a console logger.
	///     Implements the <see cref="NLog.Config.LoggingConfiguration">LoggingConfiguration</see> class.
	/// </summary>
	/// <seealso cref="NLog.Config.LoggingConfiguration">LoggingConfiguration class</seealso>
	public sealed class ConsoleLoggingConfiguration : LoggingConfiguration
	{
		#region Constructors and Destructors

		/// <summary>
		///     Initializes a new instance of the <see cref="ConsoleLoggingConfiguration" /> class.
		/// </summary>
		public ConsoleLoggingConfiguration()
		{
			ConfigureConsoleTargets();
		}

		#endregion

		#region Public Properties

		/// <summary>
		///     Gets or sets a value indicating whether to output exception details.
		/// </summary>
		/// <value><c>true</c> if exception details should be displayed; otherwise, <c>false</c>.</value>
		public bool OutputExceptionDetails { get; set; } = true;

		#endregion

		#region Public Methods and Operators

		/// <summary>
		///     Configures the console targets.
		/// </summary>
		public void ConfigureConsoleTargets()
		{
			var debugTarget = CreateConsoleTarget
			(
				"Debug"
				, new ConsoleRowHighlightingRule
				{
					Condition = ConditionParser.ParseExpression("level==LogLevel.Debug")
					,
					ForegroundColor = ConsoleOutputColor.Blue
				}
			);

			var errorTarget = CreateConsoleTarget
			(
				"Error"
				, new ConsoleRowHighlightingRule
				{
					Condition = ConditionParser.ParseExpression("level==LogLevel.Error")
					,
					ForegroundColor = ConsoleOutputColor.Red
				}
			);

			var fatalTarget = CreateConsoleTarget
			(
				"Fatal"
				, new ConsoleRowHighlightingRule
				{
					Condition = ConditionParser.ParseExpression("level==LogLevel.Fatal")
					,
					ForegroundColor = ConsoleOutputColor.DarkRed
				}
			);

			var infoTarget = CreateConsoleTarget
			(
				"Info"
				, new ConsoleRowHighlightingRule
				{
					Condition = ConditionParser.ParseExpression("level==LogLevel.Info")
					,
					ForegroundColor = ConsoleOutputColor.NoChange
				}
			);

			var traceTarget = CreateConsoleTarget
			(
				"Trace"
				, new ConsoleRowHighlightingRule
				{
					Condition = ConditionParser.ParseExpression("level==LogLevel.Trace")
					,
					ForegroundColor = ConsoleOutputColor.Magenta
				}
			);

			var warningTarget = CreateConsoleTarget
			(
				"Warning"
				, new ConsoleRowHighlightingRule
				{
					Condition = ConditionParser.ParseExpression("level==LogLevel.Warn")
					,
					ForegroundColor = ConsoleOutputColor.Yellow
				}
			);

			AddRuleForOneLevel(LogLevel.Debug, debugTarget);
			AddRuleForOneLevel(LogLevel.Error, errorTarget);
			AddRuleForOneLevel(LogLevel.Fatal, fatalTarget);
			AddRuleForOneLevel(LogLevel.Info, infoTarget);
			AddRuleForOneLevel(LogLevel.Trace, traceTarget);
			AddRuleForOneLevel(LogLevel.Warn, warningTarget);
		}

		/// <summary>
		///     Creates the console <see cref="NLog.Targets.Target">Target</see>.
		/// </summary>
		/// <param name="targetName">Name of the target.</param>
		/// <param name="rowHighlightingRule">The row highlighting rule.</param>
		/// <returns>A new target with the specified name.</returns>
		public ColoredConsoleTarget CreateConsoleTarget
			(string targetName, ConsoleRowHighlightingRule rowHighlightingRule)
		{
			var target = new ColoredConsoleTarget
				(targetName)
			{
				DetectConsoleAvailable = true
					,
				Encoding = Encoding.UTF8
					,
				Layout = CreateTargetLayout()
					,
				RowHighlightingRules = { rowHighlightingRule }
			};

			return target;
		}

		/// <summary>
		///     Creates the target layout.
		/// </summary>
		/// <returns>The target layout.</returns>
		public string CreateTargetLayout()
		{
			var layoutBuilder = new StringBuilder();
			layoutBuilder.Append(@"${date:format=dd MMM yyyy HH\:mm\:ss} ${level:uppercase=true} ${literal:text==>} ");

			layoutBuilder.Append
			(
				OutputExceptionDetails
					? @"${exception:format=Message,Data,StackTrace:innerFormat=Message,Data,StackTrace:maxInnerExceptionLevel=10}"
					: @"${message:withException=false}"
			);

			return layoutBuilder.ToString();
		}

		#endregion
	}
}
