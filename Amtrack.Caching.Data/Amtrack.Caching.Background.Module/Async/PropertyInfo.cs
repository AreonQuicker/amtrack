using System.Collections.Generic;

namespace Amtrack.Caching.Background.Module
{
	public class PropertyInfo
	{
		public string PropertyName { get; set; }
		public List<string> ConnectionFields { get; set; }
	}
}
