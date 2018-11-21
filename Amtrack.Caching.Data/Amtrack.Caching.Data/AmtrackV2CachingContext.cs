using Microsoft.EntityFrameworkCore;

namespace Amtrack.Caching.Data
{
	public class AmtrackV2CachingContext : DbContext
	{
		public AmtrackV2CachingContext()
		{
		}

		public AmtrackV2CachingContext(DbContextOptions<AmtrackV2CachingContext> options)
			: base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer(@"server=ACG-SERV-TST2\ACTST5;database=amtrack;uid=sa;pwd=F15HP@15T;Max Pool Size=300;");
			}
		}

		/// <inheritdoc />
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
