using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Matts_Battle_Plan
{
	public partial class EditLanguage : Form
	{
		public EditLanguage()
		{
			InitializeComponent();
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			BookControllerImpl objBookControllerImpl = new BookControllerImpl();
			LanguageInsertDTO objLanguageInsertDTO = objBookControllerImpl.insertLanguage(Convert.ToInt32(txtlid.Text), txtlanguagename.Text);
			MessageBox.Show(objLanguageInsertDTO.Lmessage);
		}
	}
}
