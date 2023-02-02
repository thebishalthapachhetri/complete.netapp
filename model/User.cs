using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class User
	{
		int uID;
		string username;
		string password;
		int userlevel;
		string email;

		public int UID { get => uID; set => uID = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public int Userlevel { get => userlevel; set => userlevel = value; }
		public string Email { get => email; set => email = value; }
	}
}
