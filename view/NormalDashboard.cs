﻿using System;
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
	public partial class NormalDashboard : Form
	{
		public NormalDashboard()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void NormalUserDashboard_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			BrowseAndSearch objBrowseAndSearch = new BrowseAndSearch();
			objBrowseAndSearch.ShowDialog();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			Edit objEdit = new Edit();
			objEdit.ShowDialog();

		}
	}
}
