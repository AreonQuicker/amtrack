using System;

namespace Amtrack.Amtrack_V2.Data.Data
{
	public partial class AccountAccountManagers
	{
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public int FkAccountId { get; set; }
		public Guid FkUserId { get; set; }
		public int FkBrandId { get; set; }
		public string Brand { get; set; }
		public int Flags { get; set; }

		public Accounts FkAccount { get; set; }
		public Users User { get; set; }
	}
}
