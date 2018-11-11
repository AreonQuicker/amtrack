using System.Collections.Generic;

namespace Amtrack.Services.Users
{
	public interface IUsersController
	{
		IEnumerable<Amtrack.Data_V2.Data.Users> GetAllUsers();
	}
}
