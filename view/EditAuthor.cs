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
	public partial class EditAuthor : Form
	{
		public EditAuthor()
		{
			InitializeComponent();
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			BookControllerImpl objBookControllerImpl = new BookControllerImpl();
			AuthorInsertDTO objAuthorInsertDTO = objBookControllerImpl.insertAuthor(Convert.ToInt32(txtaid.Text), txtauthorname.Text);
			MessageBox.Show(objAuthorInsertDTO.Amessage);
		}
	}
}
