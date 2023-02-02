using Model.BookDataSetTableAdapters;
using Model.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	class BookDAO_Impl : IBookDAO
	{


		public int insertBook(string isbn, string BookName, int author, int category, int language, int publishedyear, int pages, string publisher)
		{

			
			TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();

			int uInsertStatus = objTabBookTableAdapter.InsertQuerybook(isbn, BookName, author, category,language,publishedyear,pages,publisher);

			return uInsertStatus;
		}
		//---------------------------
		public int insertAuthor(int AID, string AuthorName)
		{


			TabAuthorTableAdapter objTabAuthorTableAdapter = new TabAuthorTableAdapter();

			int authorInsertStatus = objTabAuthorTableAdapter.InsertQueryAuthor(AuthorName);

			return authorInsertStatus;
		}

		public int insertCategory(int CID, string CategoryName)
		{


			TabCategoryTableAdapter objTabCategoryTableAdapter = new TabCategoryTableAdapter();

			int categoryInsertStatus = objTabCategoryTableAdapter.InsertQueryCategory(CategoryName);

			return categoryInsertStatus;
		}
		public int insertLanguage(int LID, string LanguageName)
		{


			TabLanguageTableAdapter objTabLanguageTableAdapter = new TabLanguageTableAdapter();

			int languageInsertStatus = objTabLanguageTableAdapter.InsertQueryLanguage(LanguageName);

			return languageInsertStatus;
		}
		//--------------------------------

		public Books getBookbyBookName(string BookName)
		{
			TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();
			BookDataSet.TabBookDataTable objTabBookDataTable = objTabBookTableAdapter.GetBookByBookName(BookName);

			int dataCount = objTabBookDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else
			{
				Books objBooks = new Books();
				DataRow selectedUser = objTabBookDataTable.Rows[0];
				objBooks.ISBN1 = selectedUser["ISBN"].ToString();
				objBooks.BookName1 = selectedUser["BookName"].ToString();
				objBooks.Author1 = Convert.ToInt32(selectedUser["Author"].ToString());
				objBooks.Category1 = Convert.ToInt32(selectedUser["Category"].ToString());
				objBooks.Language1 = Convert.ToInt32(selectedUser["Language"].ToString());
				objBooks.PublishYear1 = Convert.ToInt32(selectedUser["PublishYear"].ToString());
				objBooks.Pages1 = Convert.ToInt32(selectedUser["Pages"].ToString());
				objBooks.Publisher1 = selectedUser["Publisher"].ToString();
				return objBooks;
			}
		}

		public Books getBookbyPublisher(string Publisher)
		{
			TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();
			BookDataSet.TabBookDataTable objTabBookDataTable = objTabBookTableAdapter.GetBookByPublisher(Publisher);

			int dataCount = objTabBookDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else
			{
				Books objBooks = new Books();
				DataRow selectedUser = objTabBookDataTable.Rows[0];
				objBooks.ISBN1 = selectedUser["ISBN"].ToString();
				objBooks.BookName1 = selectedUser["BookName"].ToString();
				objBooks.Author1 = Convert.ToInt32(selectedUser["Author"].ToString());
				objBooks.Category1 = Convert.ToInt32(selectedUser["Category"].ToString());
				objBooks.Language1 = Convert.ToInt32(selectedUser["Language"].ToString());
				objBooks.PublishYear1 = Convert.ToInt32(selectedUser["PublishYear"].ToString());
				objBooks.Pages1 = Convert.ToInt32(selectedUser["Pages"].ToString());
				objBooks.Publisher1 = selectedUser["Publisher"].ToString();
				return objBooks;
			}
		}
		public Books getBookbyPublishYear(int PublishYear)
		{
			TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();
			BookDataSet.TabBookDataTable objTabBookDataTable = objTabBookTableAdapter.GetBookByPublishYear(PublishYear);

			int dataCount = objTabBookDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else
			{
				Books objBooks = new Books();
				DataRow selectedUser = objTabBookDataTable.Rows[0];
				objBooks.ISBN1 = selectedUser["ISBN"].ToString();
				objBooks.BookName1 = selectedUser["BookName"].ToString();
				objBooks.Author1 = Convert.ToInt32(selectedUser["Author"].ToString());
				objBooks.Category1 = Convert.ToInt32(selectedUser["Category"].ToString());
				objBooks.Language1 = Convert.ToInt32(selectedUser["Language"].ToString());
				objBooks.PublishYear1 = Convert.ToInt32(selectedUser["PublishYear"].ToString());
				objBooks.Pages1 = Convert.ToInt32(selectedUser["Pages"].ToString());
				objBooks.Publisher1 = selectedUser["Publisher"].ToString();
				return objBooks;
			}
		}


		public List<Books> getAllBooks()
		{
			TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();
			BookDataSet.TabBookDataTable objTabBookDataTable = objTabBookTableAdapter.GetData();

			int dataCount = objTabBookDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else

			{
				List<Books> lstOfDepartment = new List<Books>();

				foreach (DataRow row in objTabBookDataTable.Rows)
				{
					Books objBooks = new Books();

					objBooks.ISBN1 = row["ISBN"].ToString();
					objBooks.BookName1 = row["BookName"].ToString();
					objBooks.Author1 = Convert.ToInt32(row["Author"].ToString());
					objBooks.Category1 = Convert.ToInt32(row["Category"].ToString());
					objBooks.Language1 = Convert.ToInt32(row["Language"].ToString());
					objBooks.PublishYear1 = Convert.ToInt32(row["PublishYear"].ToString());
					objBooks.Pages1 = Convert.ToInt32(row["Pages"].ToString());
					objBooks.Publisher1 = row["Publisher"].ToString();

					lstOfDepartment.Add(objBooks);
				}

				return lstOfDepartment;
			}

			

		}




		public List<Reserve> getReservedBooks()
		{


			TabReservedTableAdapter objTabReservedTableAdapter = new TabReservedTableAdapter();
			DataSet1.TabReservedDataTable objTabReservedDataTable = objTabReservedTableAdapter.GetData();

			int dataCount = objTabReservedDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else

			{
				List<Reserve> lstOfReservedBook = new List<Reserve>();

				foreach (DataRow row in objTabReservedDataTable.Rows)
				{
					Reserve objReserve = new Reserve();

					objReserve.Rid = Convert.ToInt32(row["RID"].ToString());
					objReserve.Uid = Convert.ToInt32(row["UID"].ToString());
					objReserve.Isbn = row["ISBN"].ToString();
					objReserve.ReservedDate = row["ReservedDate"].ToString();

					lstOfReservedBook.Add(objReserve);
				}

				return lstOfReservedBook;
			}
			



		}

		public  List<Borrowed> getBorrowedBooks()
		{


			TabBorrowTableAdapter objTabBorrowTableAdapter = new TabBorrowTableAdapter();
			BookDataSet.TabBorrowDataTable objTabBorrowDataTable = objTabBorrowTableAdapter.GetData();

			int dataCount = objTabBorrowDataTable.Count;
			if (dataCount == 0)
			{
				return null;
			}
			else

			{
				List<Borrowed> lstOfBorrowedBook = new List<Borrowed>();

				foreach (DataRow row in objTabBorrowDataTable.Rows)
				{
					Borrowed objBorrowed = new Borrowed();

					objBorrowed.Bid = Convert.ToInt32(row["BID"].ToString());
					objBorrowed.Uid = Convert.ToInt32(row["UID"].ToString());
					objBorrowed.Isbn = row["ISBN"].ToString();
					objBorrowed.BorrowDate = row["BorrowDate"].ToString();
					objBorrowed.ReturnDate = row["ReturnDate"].ToString();
					objBorrowed.ActualReturnDate = row["ActualReturnDate"].ToString();
					objBorrowed.LateFee = row["LateFee"].ToString();

					lstOfBorrowedBook.Add(objBorrowed);
				}

				return lstOfBorrowedBook;
			}
			
		}


		public int deleteBook(string bookName)
		{
			TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();

			int uInsertStatus = objTabBookTableAdapter.DeleteQueryBookByBookName(bookName);
			return uInsertStatus;
		}

	}
}
