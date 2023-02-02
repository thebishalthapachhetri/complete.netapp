using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class UserInsertDTO
	{
		int iStatusCode;
		string message;

		public int IStatusCode { get => iStatusCode; set => iStatusCode = value; }
		public string Message { get => message; set => message = value; }
	}
}
