using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public class LanguageInsertDTO
	{
		int lstatus;
		string lmessage;

		public int Lstatus { get => lstatus; set => lstatus = value; }
		public string Lmessage { get => lmessage; set => lmessage = value; }
	}
}
