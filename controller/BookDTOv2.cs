using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class BookDTOv2
	{

		int rowCount;
		string message;
		string ISBN;
		string BookName;
		int Author;
		int Category;
		int Language;
		int PublishYear;
		int Pages;
		string Publisher;

		public string ISBN1 { get => ISBN; set => ISBN = value; }
		public string BookName1 { get => BookName; set => BookName = value; }
		public int Author1 { get => Author; set => Author = value; }
		public int Category1 { get => Category; set => Category = value; }
		public int Language1 { get => Language; set => Language = value; }
		public int PublishYear1 { get => PublishYear; set => PublishYear = value; }
		public int Pages1 { get => Pages; set => Pages = value; }
		public string Publisher1 { get => Publisher; set => Publisher = value; }
		public int RowCount { get => rowCount; set => rowCount = value; }
		public string Message { get => message; set => message = value; }
	}
}
