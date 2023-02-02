using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class CategoryInsertDTO
	{
		int cstatus;
		string message;

		public int Cstatus { get => cstatus; set => cstatus = value; }
		public string Message { get => message; set => message = value; }
	}
}
