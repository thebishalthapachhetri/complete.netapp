using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class LanguageDTO
	{
		int lid;
		string languageName;

		public int Lid { get => lid; set => lid = value; }
		public string LanguageName { get => languageName; set => languageName = value; }
	}
}
