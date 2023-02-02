using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class BookInsertDTO
	{
		int status;
		string message;

		public int Status { get => status; set => status = value; }
		public string Message { get => message; set => message = value; }
	}
}
