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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			IUserController objUserControllerImpl = new UserControllerImpl();
			UserLoginDTO objUserLoginDTO = objUserControllerImpl.validateUserLogin(txtusername.Text, txtpassword.Text);

			if( objUserLoginDTO == null)
			{
				MessageBox.Show("Invalid Username or Password");
			}
			else
			{

				this.Hide();
				if (objUserLoginDTO.UserLevel == 1)
				{
					AdminDashboard objAdminDashboard = new AdminDashboard();
					objAdminDashboard.ShowDialog();
				}
				if (objUserLoginDTO.UserLevel == 2)
				{
					NormalDashboard objNormalUserDashboard = new NormalDashboard();
					objNormalUserDashboard.ShowDialog();

				}
				
				
			}
		}
	}
}
