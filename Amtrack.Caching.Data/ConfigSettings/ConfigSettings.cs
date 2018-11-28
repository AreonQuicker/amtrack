using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConfigSettings
{
	public class ConfigSettings
	{
		private readonly Dictionary<string, object> configValues;

		private static Lazy<ConfigSettings> config => new Lazy<ConfigSettings>(() =>
		{
			return new ConfigSettings();
		});

		private ConfigSettings()
		{
			var environment = Environment.GetEnvironmentVariable("ENVIRONMENT");

			configValues = new Dictionary<string, object>();

			dynamic enviromentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);

			foreach(var enviromentVariable in enviromentVariables)
			{
				if(!configValues.ContainsKey(enviromentVariable.Key.ToString()))
				{
					configValues.Add(enviromentVariable.Key.ToString(), enviromentVariable.Value.ToString());
				}
			}

			if(File.Exists("config.json") 
				&& !string.IsNullOrEmpty(environment))
			{
				dynamic jsonConfig = JsonConvert.DeserializeObject(File.ReadAllText("config.json"));
				dynamic e;

				if((e = jsonConfig[environment]) != null)
				{
					dynamic k = null;
					dynamic v = null;

					foreach(var value in e)
					{
						if((k = value["Key"]) != null
							&& (v = value["Value"]) != null)
						{
							if(!configValues.ContainsKey(k.ToString()))
								configValues.Add(k.ToString(), v.ToString());
						}				
					}
				}
			}			
		}

		public object GetValue(string key) => configValues.ContainsKey(key) ? configValues[key] : null;

		public static ConfigSettings Instance => config.Value;
	}
}
