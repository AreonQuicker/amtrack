using System.Collections.Generic;
using System.Linq;
using Amtrack.Data_V2.Data;
namespace Amtrack.Services.Users
{
	public class UsersController : IUsersController
	{
		private readonly AmtrackMainContext amtrackMainContext;

		public UsersController(AmtrackMainContext amtrackMainContext)
		{
			this.amtrackMainContext = amtrackMainContext;
		}

		public IEnumerable<Data_V2.Data.Users> GetAllUsers()
		{
			var users = (from s in amtrackMainContext.Users select s);

			return users;
		}
	}
}
