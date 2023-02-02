using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	interface IUserDAO
	{
		User getUserByUsernameAndPassword(string username, string password);

		List<User> getAllUser();

		int insertUser(int uid, string username, string password, int userlevel, string email);
	}
}
