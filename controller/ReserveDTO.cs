using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class ReserveDTO
	{
		int rid;
		int uid;
		string isbn;
		string reservedDate;

		public int Rid { get => rid; set => rid = value; }
		public int Uid { get => uid; set => uid = value; }
		public string Isbn { get => isbn; set => isbn = value; }
		public string ReservedDate { get => reservedDate; set => reservedDate = value; }
	}
}
