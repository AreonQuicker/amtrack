using System.Collections.Generic;

namespace Amtrack.Caching.Background.Module
{
	public class MethodInfo
	{
		public string MethodName { get; set; }
		public List<PropertyInfo> PropertyInfos { get; set; }
	}
}
