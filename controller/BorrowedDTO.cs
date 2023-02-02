using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class BorrowedDTO
	{
		int bid;
		int uid;
		string isbn;
		string borrowDate;
		string returnDate;
		string actualReturnDate;
		string lateFee;

		public int Bid { get => bid; set => bid = value; }
		public int Uid { get => uid; set => uid = value; }
		public string Isbn { get => isbn; set => isbn = value; }
		public string BorrowDate { get => borrowDate; set => borrowDate = value; }
		public string ReturnDate { get => returnDate; set => returnDate = value; }
		public string ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
		public string LateFee { get => lateFee; set => lateFee = value; }
	}
}
