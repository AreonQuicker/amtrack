using System.ComponentModel.DataAnnotations;

namespace Amtrack.Caching.Data.Models
{
	public class Test
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
