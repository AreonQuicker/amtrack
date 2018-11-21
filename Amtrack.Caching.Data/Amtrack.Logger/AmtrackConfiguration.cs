using System.Data;

using Amtrack.Enumeration;

using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;

namespace Amtrack.Logger
{
	public class AmtrackConfiguration : LoggingConfiguration
	{
		#region Constructors and Destructors

		/// <summary>
		///     Initializes a new instance of the <see cref="Configuration" /> class.
		/// </summary>
		/// <remarks>
		///     The logging configuration will be loaded from the database by default.
		/// </remarks>
		public AmtrackConfiguration()
		{
			ConfigureDatabaseTargets();
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="Configuration" /> class.
		/// </summary>
		/// <param name="connectionString">The connection string to use.</param>
		protected AmtrackConfiguration(string connectionString)
		{
			ConnectionString = connectionString;
			ConfigureDatabaseTargets();
		}

		#endregion
		public AmtrackConfiguration(LoggerTargetTypes loggerTarget, params string[] values)
		{
			switch(loggerTarget)
			{
				case LoggerTargetTypes.Default:
				case LoggerTargetTypes.Database:
					ConnectionString = values[0];
					ConfigureDatabaseTargets();
					break;
				case LoggerTargetTypes.File:
					ConfigureFileTargets(values[0]);
					break;
				case LoggerTargetTypes.Console:
					ConfigureConsoleTargets();
					break;
				default:
					throw new System.Exception("Logger Target Not Supported.");
			}
		}


		#region Properties

		/// <summary>
		///     Gets or sets the database connection string.
		/// </summary>
		/// <value>
		///     The database connection string.
		/// </value>
		protected string ConnectionString { get; set; }

		#endregion

		#region Methods

		/// <summary>
		///     Configures a default <see cref="NLog.Targets.DatabaseTarget" /> for Info, Warning, Error and Critical log levels.
		/// </summary>
		protected void ConfigureDatabaseTargets()
		{
			var infoLevelTarget = CreateDefaultDatabaseTarget("Info");
			var warningLevelTarget = CreateDefaultDatabaseTarget("Warning");
			var errorLevelTarget = CreateDefaultDatabaseTarget("Error");
			var crticalLevelTarget = CreateDefaultDatabaseTarget("Critical");

			infoLevelTarget.Parameters.Add(new DatabaseParameterInfo { Name = "@callSite", Layout = "${callsite}" });
			warningLevelTarget.Parameters.Add(new DatabaseParameterInfo { Name = "@callSite", Layout = "${callsite}" });

			errorLevelTarget.Parameters.Add
			(
				new DatabaseParameterInfo
				{
					Name = "@exception"
					,
					Layout = "${exception:format=Method,Message,Data:separator=|}"
				}
			);

			errorLevelTarget.Parameters.Add(new DatabaseParameterInfo { Name = "@callSite", Layout = "${callsite}" });

			errorLevelTarget.Parameters.Add
				(new DatabaseParameterInfo { Name = "@stackTrace", Layout = "${exception:format=stackTrace}" });

			errorLevelTarget.Parameters.Add
			(
				new DatabaseParameterInfo
				{
					Name = "@innerException"
					,
					Layout =
						"${exception:format=Message,Data:innerFormat=Message,Data:MaxInnerExceptionLevel=2:InnerExceptionSeparator=|}"
				}
			);

			crticalLevelTarget.Parameters.Add
			(
				new DatabaseParameterInfo
				{
					Name = "@exception"
					,
					Layout = "${exception:format=Method,Message,Data:separator=|}"
				}
			);

			crticalLevelTarget.Parameters.Add(new DatabaseParameterInfo { Name = "@callSite", Layout = "${callsite}" });

			crticalLevelTarget.Parameters.Add
				(new DatabaseParameterInfo { Name = "@stackTrace", Layout = "${exception:format=stackTrace}" });

			crticalLevelTarget.Parameters.Add
			(
				new DatabaseParameterInfo
				{
					Name = "@innerException"
					,
					Layout =
						"${exception:format=Message,Data:innerFormat=Message,Data:MaxInnerExceptionLevel=2:InnerExceptionSeparator=|}"
				}
			);

			AddRule(LogLevel.Trace, LogLevel.Info, infoLevelTarget);
			AddRuleForOneLevel(LogLevel.Warn, warningLevelTarget);
			AddRuleForOneLevel(LogLevel.Error, errorLevelTarget);
			AddRuleForOneLevel(LogLevel.Fatal, crticalLevelTarget);
		}
		protected void ConfigureFileTargets(string logFolder)
		{
			var infoLevelTarget = CreateDefaultFileTarget(logFolder, "Info");
			var warningLevelTarget = CreateDefaultFileTarget(logFolder, "Warning");
			var errorLevelTarget = CreateDefaultFileTarget(logFolder, "Error");
			var crticalLevelTarget = CreateDefaultFileTarget(logFolder, "Critical");

			((JsonLayout)infoLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));

			((JsonLayout)warningLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));

			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("exception", "${exception:format=Method,Message,Data:separator=|}"));
			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));
			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("stackTrace", "${exception:format=stackTrace}"));
			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("innerException", "${exception:format=Message,Data:innerFormat=Message,Data:MaxInnerExceptionLevel=2:InnerExceptionSeparator=|}"));

			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("exception", "${exception:format=Method,Message,Data:separator=|}"));
			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));
			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("stackTrace", "${exception:format=stackTrace}"));
			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("innerException", "${exception:format=Message,Data:innerFormat=Message,Data:MaxInnerExceptionLevel=2:InnerExceptionSeparator=|}"));

			AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Info, infoLevelTarget);
			AddRuleForOneLevel(NLog.LogLevel.Warn, warningLevelTarget);
			AddRuleForOneLevel(NLog.LogLevel.Error, errorLevelTarget);
			AddRuleForOneLevel(NLog.LogLevel.Fatal, crticalLevelTarget);
		}
		protected void ConfigureConsoleTargets()
		{
			var infoLevelTarget = CreateDefaultConsoleTarget("Info");
			var warningLevelTarget = CreateDefaultConsoleTarget("Warning");
			var errorLevelTarget = CreateDefaultConsoleTarget("Error");
			var crticalLevelTarget = CreateDefaultConsoleTarget("Critical");

			((JsonLayout)infoLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));

			((JsonLayout)warningLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));

			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("exception", "${exception:format=Method,Message,Data:separator=|}"));
			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));
			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("stackTrace", "${exception:format=stackTrace}"));
			((JsonLayout)errorLevelTarget.Layout).Attributes.Add(new JsonAttribute("innerException", "${exception:format=Message,Data:innerFormat=Message,Data:MaxInnerExceptionLevel=2:InnerExceptionSeparator=|}"));

			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("exception", "${exception:format=Method,Message,Data:separator=|}"));
			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("callSite", "${callsite}"));
			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("stackTrace", "${exception:format=stackTrace}"));
			((JsonLayout)crticalLevelTarget.Layout).Attributes.Add(new JsonAttribute("innerException", "${exception:format=Message,Data:innerFormat=Message,Data:MaxInnerExceptionLevel=2:InnerExceptionSeparator=|}"));

			AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Info, infoLevelTarget);
			AddRuleForOneLevel(NLog.LogLevel.Warn, warningLevelTarget);
			AddRuleForOneLevel(NLog.LogLevel.Error, errorLevelTarget);
			AddRuleForOneLevel(NLog.LogLevel.Fatal, crticalLevelTarget);
		}

		/// <summary>
		///     Creates a <see cref="NLog.Targets.DatabaseTarget" /> using default parameters.
		/// </summary>
		/// <param name="targetName">Name of the target.</param>
		/// <returns>The new database target.</returns>
		private DatabaseTarget CreateDefaultDatabaseTarget(string targetName)
		{
			var target = new DatabaseTarget
			{
				CommandText = "[dbo].[NLog_AddEntry_p]"
				,
				CommandType = CommandType.StoredProcedure
				,
				Name = targetName
				,
				ConnectionString = ConnectionString
				,
				DBProvider = "sqlserver"
			};

			target.Parameters.Add(new DatabaseParameterInfo { Name = "@machineName", Layout = "${machinename}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@message", Layout = "${message}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@level", Layout = "${level}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@logger", Layout = "${logger}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@logged", Layout = "${date}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@siteName", Layout = "${iis-site-name}" });

			return target;
		}

		private FileTarget CreateDefaultFileTarget(string logPath, string targetName)
		{
			var baseLogDir = logPath;
			var fileNameLayout = "${processname}/${date:format=dd-MM-yyyy}/${logger}_${level}.log";

			var target = new FileTarget
			{
				Name = targetName,
				AutoFlush = true,
				CreateDirs = true,
				EnableArchiveFileCompression = true,
				Encoding = System.Text.Encoding.UTF8,
				LineEnding = LineEndingMode.CRLF,
				FileName = $"{baseLogDir}/{fileNameLayout}"
			};

			target.Layout = new JsonLayout
			{
				Attributes = {
					new JsonAttribute( "machinename","${machinename}"),
					new JsonAttribute( "message","${message}"),
					new JsonAttribute( "time","${time}"),
					new JsonAttribute( "siteName","${iis-site-name}"),
				}
			};

			/*
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@machineName", Layout = "${machinename}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@message", Layout = "${message}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@level", Layout = "${level}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@logger", Layout = "${logger}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@logged", Layout = "${date}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@siteName", Layout = "${iis-site-name}" });
			*/

			return target;
		}

		private ConsoleTarget CreateDefaultConsoleTarget(string targetName)
		{
			var target = new ConsoleTarget
			{
				Name = targetName
			};

			target.Layout = new JsonLayout
			{
				Attributes = {
					new JsonAttribute( "machinename","${machinename}"),
					new JsonAttribute( "message","${message}"),
					new JsonAttribute( "time","${time}"),
					new JsonAttribute( "siteName","${iis-site-name}"),
				}
			};

			/*
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@machineName", Layout = "${machinename}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@message", Layout = "${message}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@level", Layout = "${level}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@logger", Layout = "${logger}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@logged", Layout = "${date}" });
			target.Parameters.Add(new DatabaseParameterInfo { Name = "@siteName", Layout = "${iis-site-name}" });
			*/

			return target;
		}

		#endregion
	}
}
