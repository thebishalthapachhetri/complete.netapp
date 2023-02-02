using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public interface IUserController
	{
		UserLoginDTO validateUserLogin(string username, string password);

		UserInsertDTO insertUser(int uid, string username, string password, int userlevel, string email);

		List<UserDTO> getAllUser();
	}
}
