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
	public partial class AdminDashboard : Form
	{
		public AdminDashboard()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			BrowseAndSearch objBrowseAndSearch = new BrowseAndSearch();
			objBrowseAndSearch.ShowDialog();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Maintanance objMaintanance = new Maintanance();
			objMaintanance.ShowDialog();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

			
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
		
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void AdminDashboard_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			report objreport = new report();
			objreport.ShowDialog();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
