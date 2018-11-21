using System;
using System.Net.Http;
using NLog;

namespace Amtrack.Logger
{
	public static class LoggingExtensions
	{
		public static void LogHttpRequest(this ILogger logger, HttpRequestMessage httpRequest, object requestBody = null)
		{
			//TODO
			throw new NotImplementedException();
		}

		public static HttpResponseMessage LogHttpResponse(this ILogger logger, HttpResponseMessage httpResponse)
		{
			//TODO
			throw new NotImplementedException();
		}
	}
}
