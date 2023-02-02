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
	public partial class borrow : Form
	{
		public borrow()
		{
			InitializeComponent();
		}

		private void borrow_Load(object sender, EventArgs e)
		{
			IBookController objIBookController = new BookControllerImpl();
			List<BorrowedDTO> lstAllBorrowedBookDTOs = objIBookController.getBorrowedBooks();

			if (lstAllBorrowedBookDTOs == null)
			{
				MessageBox.Show("No record Found");

			}
			else
			{
				dataGridView1.DataSource = lstAllBorrowedBookDTOs;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			report objreport = new report();
			objreport.ShowDialog();
		}
	}
}
