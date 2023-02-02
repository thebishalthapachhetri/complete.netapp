using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
	public class UserControllerImpl : IUserController
	{

		public List<UserDTO> getAllUser()
		{
			UserLogicImpl objUserLogicImpl = new UserLogicImpl();
			List<User> lstAllUser = objUserLogicImpl.getAllUser();

		

			if (lstAllUser == null)
			{
				return null;
			}
			else
			{
				List<UserDTO> lstAllUserDTOs = new List<UserDTO>();


				foreach (User aUser in lstAllUser)
				{
					UserDTO objUserDTO = new UserDTO();
					objUserDTO.Uid = aUser.UID;
					objUserDTO.Username = aUser.Username;
					objUserDTO.Password = aUser.Password;
					objUserDTO.Userlevel = aUser.Userlevel;
					objUserDTO.Useremail = aUser.Email;
					lstAllUserDTOs.Add(objUserDTO);
					
				}
				return lstAllUserDTOs;
			}

		}

		public UserLoginDTO validateUserLogin( string username,  string password)
		{
			IUserLogic objUserLogicImpl = new UserLogicImpl();
			User objUser = objUserLogicImpl.validateUserLogin(username, password);

			UserLoginDTO objUserLoginDTO = null;
			

			if (objUser == null)
			{
				return objUserLoginDTO;
			}
			else
			{
				objUserLoginDTO = new UserLoginDTO();
				objUserLoginDTO.UserLevel = objUser.Userlevel;
				return objUserLoginDTO;
			}
		}

		public UserInsertDTO insertUser(int uid, string username, string password, int userlevel, string email)
		{
			UserLogicImpl objUserLogicImpl = new UserLogicImpl();
			int iInsertStatus = objUserLogicImpl.insertUser(uid, username, password, userlevel, email);
			UserInsertDTO objUserInsertDTO = new UserInsertDTO();
			objUserInsertDTO.IStatusCode = iInsertStatus;
			if (iInsertStatus == 0)
			{
				objUserInsertDTO.Message = "Unable to add user";

			}

			else
			{
				objUserInsertDTO.Message = "User Added";

			}


			return objUserInsertDTO;


		}

	}
}