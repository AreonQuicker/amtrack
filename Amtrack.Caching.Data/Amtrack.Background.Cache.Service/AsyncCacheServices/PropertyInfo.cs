using System.Collections.Generic;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
	public class PropertyInfo
	{
		public string PropertyName { get; set; }
		public List<string> ConnectionFields { get; set; }
	}
}
