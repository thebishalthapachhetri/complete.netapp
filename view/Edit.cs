using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matts_Battle_Plan
{
	public partial class Edit : Form
	{
		public Edit()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			EditAuthor objEditAuthor = new EditAuthor();
			objEditAuthor.ShowDialog();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			EditCategory objEditCategory = new EditCategory();
			objEditCategory.ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			EditAuthor objEditAuthor = new EditAuthor();
			objEditAuthor.ShowDialog();
		}
	}
}
