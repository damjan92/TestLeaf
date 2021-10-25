using System;
using System.Collections.Generic;
using System.Text;
using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Sinks;

namespace TestLeaf.Helpers
{
	class CustomLogger
	{
        public CustomLogger()
        {
			var levelSwitch = new LoggingLevelSwitch();

			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.ControlledBy(levelSwitch)
				.WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
				.CreateLogger();
		}

        public void LogInfo(string info)
		{
			Log.Information(info);
		}

		public void LogDebug(string info)
		{
			Log.Debug(info);
		}

		public void LogWarn(string info)
        {
			Log.Warning(info);
        }

		public ILogger Logger(string info)
        {
			return Log.Logger;
        }

    }
}
