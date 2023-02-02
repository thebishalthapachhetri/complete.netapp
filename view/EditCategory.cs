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
	public partial class EditCategory : Form
	{
		public EditCategory()
		{
			InitializeComponent();
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			BookControllerImpl objBookControllerImpl = new BookControllerImpl();
			CategoryInsertDTO objCategoryInsertDTO = objBookControllerImpl.insertCategory(Convert.ToInt32(txtcid.Text), txtcategoryname.Text);
			MessageBox.Show(objCategoryInsertDTO.Message);
		}
	}
}
