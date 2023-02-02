using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class UserDTO
	{

		int uid;
		string username;
		string password;
		int userlevel;
		string useremail;

		public int Uid { get => uid; set => uid = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public int Userlevel { get => userlevel; set => userlevel = value; }
		public string Useremail { get => useremail; set => useremail = value; }
	}
}
