using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class AuthorInsertDTO
	{
		int astatus;
		string amessage;

		public int Astatus { get => astatus; set => astatus = value; }
		public string Amessage { get => amessage; set => amessage = value; }
	}
}
