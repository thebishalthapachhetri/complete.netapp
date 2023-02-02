using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Author
	{
		int aid;
		string authorName;

		public int Aid { get => aid; set => aid = value; }
		public string AuthorName { get => authorName; set => authorName = value; }
	}
}
