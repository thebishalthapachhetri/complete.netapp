using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public interface IBookLogic
	{
		List<Books> getAllBooks();
		List<Reserve> getReservedBooks();
		List<Borrowed> getBorrowedBooks();
		Books getBookbyBookName(string BookName);
		Books getBookbyPublisher(string Publisher);

		int insertBook(string isbn, string BookName, int author, int category, int language, int publishedyear, int pages, string publisher);

		int insertAuthor(int AID, string AuthorName);
		int insertCategory(int CID, string CategoryName);
		int insertLanguage(int LID, string LanguageName);
		int deleteBook(string bookName);
	}
}
