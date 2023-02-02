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
	public partial class Maintanance : Form
	{
		public Maintanance()
		{
			InitializeComponent();
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			UserControllerImpl objUserControllerImpl = new UserControllerImpl();
			UserInsertDTO objUserInsertDTO = objUserControllerImpl.insertUser(Convert.ToInt32(txtuid.Text), txtusername.Text, txtpassword.Text, Convert.ToInt32(txtuserlevel.Text), txtemail.Text);
			MessageBox.Show(objUserInsertDTO.Message);
			clear();
			reloaddata();
			
		}

		private void Maintanance_Load(object sender, EventArgs e)
		{
			reloaddata();
		}

		private void reloaddata()
		{
			IUserController objIUserController = new UserControllerImpl();
			List<UserDTO> lstUserDTOs = objIUserController.getAllUser();

			if (lstUserDTOs == null)
			{
				MessageBox.Show("No User Found");

			}
			else
			{
				dataGridView1.DataSource = lstUserDTOs;
			}

			btnupdate.Enabled = false;

		}

		private void btnclear_Click(object sender, EventArgs e)
		{
			clear();
		}

		private void clear()
		{
			txtemail.Clear();
			txtpassword.Clear();
			txtuid.Clear();
			txtusername.Clear();
			
			
			
		}
	}
}
