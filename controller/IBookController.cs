using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
	public interface IBookController
	{
		BookDTO getBookbyBookName(string BookName);
		BookDTO getBookbyPublishYear(int PublishYear);
		BookDTO getBookbyPublisher(string Publisher);
		List<BookDTO> getAllBooks();
		List<ReserveDTO> getReservedBooks();
		List<BorrowedDTO> getBorrowedBooks();

		BookInsertDTO  insertBook(string isbn, string BookName, int author, int category, int language, int publishedyear, int pages, string publisher);
		AuthorInsertDTO insertAuthor(int AID, string AuthorName);
		CategoryInsertDTO insertCategory(int CID, string CategoryName);
		LanguageInsertDTO insertLanguage(int LID, string LanguageName);

		BookInsertDTO deleteBook(string bookName);
	}
}
