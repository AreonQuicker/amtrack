using System.Collections.Generic;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
	public class MethodInfo
	{
		public string MethodName { get; set; }
		public List<PropertyInfo> PropertyInfos { get; set; }
	}
}
