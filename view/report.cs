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
	public partial class report : Form
	{
		public report()
		{
			InitializeComponent();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			borrow objborrow = new borrow();
			objborrow.ShowDialog();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			
			reserve objreserve = new reserve();
			objreserve.ShowDialog();
		}
	}
}
