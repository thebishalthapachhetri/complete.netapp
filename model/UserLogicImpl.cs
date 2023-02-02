using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class UserLogicImpl : IUserLogic
	{

		public List<User> getAllUser()
		{
			IUserDAO objUserDAO_Impl = new UserDAO_Impl();
			List<User> lstAllUser = objUserDAO_Impl.getAllUser();
			return lstAllUser;

		}
		public User validateUserLogin(string username, string password)
		{
			IUserDAO objUserDAO_Impl = new UserDAO_Impl();
			User objUser = objUserDAO_Impl.getUserByUsernameAndPassword(username, password);
			
			if (objUser == null)
			{
				return null;
			}
			else
			{
				return objUser;
			}

		}

		public int insertUser(int uid, string username, string password, int userlevel, string email)
		{
			UserDAO_Impl objUserDAO_Impl = new UserDAO_Impl();
			int iInsertStatus = objUserDAO_Impl.insertUser(uid, username, password, userlevel, email);

			return iInsertStatus;
		}
	}
}
