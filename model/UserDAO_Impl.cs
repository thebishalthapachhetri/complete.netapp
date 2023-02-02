using Model.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
	class UserDAO_Impl : IUserDAO
	{
		public User getUserByUsernameAndPassword(string username, string password)
		{

			TabUserTableAdapter objTabUserTableAdapter = new TabUserTableAdapter();
			UserDataSet.TabUserDataTable objTabUserDataTable = objTabUserTableAdapter.GetUserByUsernameAndPassword(username, password);

			int dataCount = objTabUserDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else
			{
				User objUser = new User();
				DataRow selectedUser = objTabUserDataTable.Rows[0];
				objUser.UID = Convert.ToInt32(selectedUser["UID"].ToString());
				objUser.Username = selectedUser["UserName"].ToString();
				objUser.Password = selectedUser["Password"].ToString();
				objUser.Userlevel = Convert.ToInt32(selectedUser["UserLevel"].ToString());
				return objUser;
			}
		}


		public int insertUser(int uid, string username, string password, int userlevel, string email)
		{

			TabUserTableAdapter objTabUserTableAdapter = new TabUserTableAdapter();

			int iInsertStatus = objTabUserTableAdapter.InsertQueryUser(username, password, userlevel, email);

			return iInsertStatus;



		}

		public List<User> getAllUser()
		{

			TabUserTableAdapter objTabUserTableAdapter = new TabUserTableAdapter();
			UserDataSet.TabUserDataTable objTabUserDataTable = objTabUserTableAdapter.GetData();

			int dataCount = objTabUserDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else

			{
				List<User> lstOfUser = new List<User>();

				foreach (DataRow row in objTabUserDataTable.Rows)
				{
					User objUser = new User();

					objUser.UID = Convert.ToInt32(row["UID"].ToString());
					objUser.Username = row["UserName"].ToString();
					objUser.Password = row["Password"].ToString();
					objUser.Userlevel = Convert.ToInt32(row["UserLevel"].ToString());
					objUser.Email = row["UserEmail"].ToString();
					

					lstOfUser.Add(objUser);
				}

				return lstOfUser;
			}

		}
	}
}
