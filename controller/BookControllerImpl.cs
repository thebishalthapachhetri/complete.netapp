using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
	public class BookControllerImpl : IBookController
	{

		public List<BookDTO> getAllBooks()
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			List<Books> lstAllBooks = objBookLogicImpl.getAllBooks();

			//

			if (lstAllBooks == null)
			{
				return null;
			}
			else
			{
				List<BookDTO> lstAllBookDTOs = new List<BookDTO>();
				
				
				foreach (Books aBooks in lstAllBooks)
				{
					BookDTO objBookDTO = new BookDTO();
					objBookDTO.ISBN1 = aBooks.ISBN1;
					objBookDTO.BookName1 = aBooks.BookName1;
					objBookDTO.Author1 = aBooks.Author1;
					objBookDTO.Category1 = aBooks.Category1;
					objBookDTO.Language1 = aBooks.Language1;
					objBookDTO.PublishYear1 = aBooks.PublishYear1;
					objBookDTO.Pages1 = aBooks.Pages1;
					objBookDTO.Publisher1 = aBooks.Publisher1;
					lstAllBookDTOs.Add(objBookDTO);
				}
				return lstAllBookDTOs;
			}

		}
		
		public List<ReserveDTO> getReservedBooks()
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			List<Reserve> lstAllReservedBooks = objBookLogicImpl.getReservedBooks();

			//

			if (lstAllReservedBooks == null)
			{
				return null;
			}
			else
			{
				List<ReserveDTO> lstReservedBookDTOs = new List<ReserveDTO>();
				
				
				foreach (Reserve aReserve in lstAllReservedBooks)
				{
					ReserveDTO objReserveDTO = new ReserveDTO();
					objReserveDTO.Rid = aReserve.Rid;
					objReserveDTO.Uid = aReserve.Uid;
					objReserveDTO.Isbn = aReserve.Isbn;
					objReserveDTO.ReservedDate = aReserve.ReservedDate;

					lstReservedBookDTOs.Add(objReserveDTO);
				}
				return lstReservedBookDTOs;				;
			}

		}

		public List<BorrowedDTO> getBorrowedBooks()
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			List<Borrowed> lstAllBorrowedBooks = objBookLogicImpl.getBorrowedBooks();

			//

			if (lstAllBorrowedBooks == null)
			{
				return null;
			}
			else
			{
				List<BorrowedDTO> lstBorrowedBookDTOs = new List<BorrowedDTO>();


				foreach (Borrowed aBorrowed in lstAllBorrowedBooks)
				{
					BorrowedDTO objBorrowedDTO = new BorrowedDTO();
					objBorrowedDTO.Bid = aBorrowed.Bid;
					objBorrowedDTO.Uid = aBorrowed.Uid;
					objBorrowedDTO.Isbn = aBorrowed.Isbn;
					objBorrowedDTO.BorrowDate = aBorrowed.BorrowDate;
					objBorrowedDTO.ReturnDate = aBorrowed.ReturnDate;
					objBorrowedDTO.ActualReturnDate = aBorrowed.ActualReturnDate;
					objBorrowedDTO.LateFee = aBorrowed.LateFee;

					lstBorrowedBookDTOs.Add(objBorrowedDTO);
				}
				return lstBorrowedBookDTOs; 
			}

		}



		public BookDTO getBookbyBookName(string BookName)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			Books objBooks = objBookLogicImpl.getBookbyBookName(BookName);

			BookDTO objBookDTO = null;
			if( objBooks == null)
			{
				return null;
			}
			else
			{
				objBookDTO = new BookDTO();
				objBookDTO.ISBN1 = objBooks.ISBN1;
				objBookDTO.BookName1 = objBooks.BookName1;
				objBookDTO.Author1 = objBooks.Author1;
				objBookDTO.Category1 = objBooks.Category1;
				objBookDTO.Language1 = objBooks.Language1;
				objBookDTO.PublishYear1 = objBooks.PublishYear1;
				objBookDTO.Pages1 = objBooks.Pages1;
				objBookDTO.Publisher1 = objBooks.Publisher1;

				return objBookDTO;

			}


		}

		public BookDTO getBookbyPublisher(string Publisher)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			Books objBooks = objBookLogicImpl.getBookbyPublisher(Publisher);

			BookDTO objBookDTO = null;
			if (objBooks == null)
			{
				return null;
			}
			else
			{
				objBookDTO = new BookDTO();
				objBookDTO.ISBN1 = objBooks.ISBN1;
				objBookDTO.BookName1 = objBooks.BookName1;
				objBookDTO.Author1 = objBooks.Author1;
				objBookDTO.Category1 = objBooks.Category1;
				objBookDTO.Language1 = objBooks.Language1;
				objBookDTO.PublishYear1 = objBooks.PublishYear1;
				objBookDTO.Pages1 = objBooks.Pages1;
				objBookDTO.Publisher1 = objBooks.Publisher1;

				return objBookDTO;

			}


		}


		public BookDTO getBookbyPublishYear(int PublishYear)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			Books objBooks = objBookLogicImpl.getBookbyPublishYear(PublishYear);

			BookDTO objBookDTO = null;
			if (objBooks == null)
			{
				return null;
			}
			else
			{
				objBookDTO = new BookDTO();
				objBookDTO.ISBN1 = objBooks.ISBN1;
				objBookDTO.BookName1 = objBooks.BookName1;
				objBookDTO.Author1 = objBooks.Author1;
				objBookDTO.Category1 = objBooks.Category1;
				objBookDTO.Language1 = objBooks.Language1;
				objBookDTO.PublishYear1 = objBooks.PublishYear1;
				objBookDTO.Pages1 = objBooks.Pages1;
				objBookDTO.Publisher1 = objBooks.Publisher1;

				return objBookDTO;

			}


		}

		public BookInsertDTO insertBook(string isbn, string BookName, int author, int category, int language, int publishedyear, int pages, string publisher)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			int uInsertStatus = objBookLogicImpl.insertBook(isbn, BookName, author, category, language, publishedyear, pages, publisher);
			BookInsertDTO objBookInsertDTO = new BookInsertDTO();
			objBookInsertDTO.Status = uInsertStatus;
			if (uInsertStatus == 0)
			{
				objBookInsertDTO.Message = "Unable to add book";

			}

			else
			{
				objBookInsertDTO.Message = "Book Added";

			}


			return objBookInsertDTO;


		}

		public AuthorInsertDTO insertAuthor(int AID, string AuthorName)
		{
			IBookLogic objBookLogicImpl = new BookLogicImpl();
			int authorInsertStatus = objBookLogicImpl.insertAuthor(AID, AuthorName);
			AuthorInsertDTO objAuthorInsertDTO = new AuthorInsertDTO();
			objAuthorInsertDTO.Astatus = authorInsertStatus;
			if(authorInsertStatus == 0)
			{
				objAuthorInsertDTO.Amessage = "Unable to Add user";

			}
			else
			{
				objAuthorInsertDTO.Amessage = "User Added";
			}

			return objAuthorInsertDTO;
		}

		public CategoryInsertDTO insertCategory(int CID, string CategoryName)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			int categoryInsertStatus = objBookLogicImpl.insertCategory(CID, CategoryName);
			CategoryInsertDTO objCategoryInsertDTO = new CategoryInsertDTO();
			objCategoryInsertDTO.Cstatus = categoryInsertStatus;
			if (categoryInsertStatus == 0)
			{
				objCategoryInsertDTO.Message = "Unable to Add Category";

			}
			else
			{
				objCategoryInsertDTO.Message = "Category Added";
			}

			return objCategoryInsertDTO;
		}


		public LanguageInsertDTO insertLanguage(int LID, string LanguageName)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			int languageInsertStatus = objBookLogicImpl.insertLanguage(LID, LanguageName);
			LanguageInsertDTO objLanguageInsertDTO = new LanguageInsertDTO();
			objLanguageInsertDTO.Lstatus = languageInsertStatus;
			if (languageInsertStatus == 0)
			{
				objLanguageInsertDTO.Lmessage = "Unable to Add Language";

			}
			else
			{
				objLanguageInsertDTO.Lmessage = "Language Added";
			}

			return objLanguageInsertDTO;
		}


		public BookInsertDTO deleteBook(string bookName)
		{
			BookLogicImpl objBookLogicImpl = new BookLogicImpl();
			int udeleteStatus = objBookLogicImpl.deleteBook(bookName);
			BookInsertDTO objBookdeleteDTO = new BookInsertDTO();
			objBookdeleteDTO.Status = udeleteStatus;
			if (udeleteStatus == 0)
			{
				objBookdeleteDTO.Message = "Unable to delete";

			}

			else
			{
				objBookdeleteDTO.Message = "Book Deleted";

			}


			return objBookdeleteDTO;
		}
	}
}
