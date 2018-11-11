using Amtrack.Caching.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Amtrack.Caching.Data
{
	public class CachingContext : DbContext
	{
		DbSet<Test> Tests { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

	}
}
