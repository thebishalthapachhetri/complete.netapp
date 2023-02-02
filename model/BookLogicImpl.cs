using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class BookLogicImpl : IBookLogic
	{
		public List<Books> getAllBooks()
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			List<Books> lstAllBooks = objBookDAO_Impl.getAllBooks();
			return lstAllBooks;

		}
		
		public List<Reserve> getReservedBooks()
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			List<Reserve> lstAllReservedBook = objBookDAO_Impl.getReservedBooks();
			return lstAllReservedBook;

		}
		public List<Borrowed> getBorrowedBooks()
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			List<Borrowed> lstAllBorrowedBook = objBookDAO_Impl.getBorrowedBooks();
			return lstAllBorrowedBook;

		}

		public Books getBookbyBookName(string BookName)
		{

			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			Books objBooks = objBookDAO_Impl.getBookbyBookName(BookName);
			return objBooks;
		}
		public Books getBookbyPublisher(string Publisher)
		{

			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			Books objBooks = objBookDAO_Impl.getBookbyPublisher(Publisher);
			return objBooks;
		}
		public Books getBookbyPublishYear(int PublishYear)
		{

			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			Books objBooks = objBookDAO_Impl.getBookbyPublishYear(PublishYear);
			return objBooks;
		}


		public int insertBook(string isbn, string BookName, int author, int category, int language, int publishedyear, int pages, string publisher)
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			int uInsertStatus = objBookDAO_Impl.insertBook(isbn, BookName, author, category, language, publishedyear, pages, publisher);

			return uInsertStatus;
		}


		public int insertAuthor(int AID, string AuthorName)
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			int authorInsertStatus = objBookDAO_Impl.insertAuthor(AID, AuthorName);

			return authorInsertStatus;
		}

		public int insertCategory(int CID,string CategoryName)
		{ 
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			int categoryInsertStatus = objBookDAO_Impl.insertCategory(CID, CategoryName);

			return categoryInsertStatus;
		}

		public int insertLanguage(int LID, string LanguageName)
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			int languageInsertStatus = objBookDAO_Impl.insertLanguage(LID,LanguageName);

			return languageInsertStatus;
		}

		public int deleteBook(string bookName)
		{
			BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
			int uInsertStatus = objBookDAO_Impl.deleteBook(bookName);

			return uInsertStatus;
		}

	}
}
