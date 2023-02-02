
namespace Matts_Battle_Plan
{
	partial class Maintanance
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtusername = new System.Windows.Forms.TextBox();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtuid = new System.Windows.Forms.TextBox();
			this.btnclear = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btnadd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtuserlevel = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtusername
			// 
			this.txtusername.Location = new System.Drawing.Point(147, 126);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(102, 22);
			this.txtusername.TabIndex = 30;
			// 
			// txtpassword
			// 
			this.txtpassword.Location = new System.Drawing.Point(147, 168);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(102, 22);
			this.txtpassword.TabIndex = 29;
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(147, 214);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(102, 22);
			this.txtemail.TabIndex = 28;
			// 
			// txtuid
			// 
			this.txtuid.Location = new System.Drawing.Point(147, 86);
			this.txtuid.Name = "txtuid";
			this.txtuid.Size = new System.Drawing.Size(102, 22);
			this.txtuid.TabIndex = 26;
			// 
			// btnclear
			// 
			this.btnclear.Location = new System.Drawing.Point(150, 367);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(75, 23);
			this.btnclear.TabIndex = 25;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(36, 367);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 24;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(150, 316);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(75, 23);
			this.btnupdate.TabIndex = 23;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(36, 316);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 22;
			this.btnadd.Text = "Add User";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 255);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 17);
			this.label6.TabIndex = 21;
			this.label6.Text = "UserLevel";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 20;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 171);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "Username";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "User ID";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(312, 51);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(465, 371);
			this.dataGridView1.TabIndex = 31;
			// 
			// txtuserlevel
			// 
			this.txtuserlevel.FormattingEnabled = true;
			this.txtuserlevel.Items.AddRange(new object[] {
            "1",
            "2"});
			this.txtuserlevel.Location = new System.Drawing.Point(147, 255);
			this.txtuserlevel.Name = "txtuserlevel";
			this.txtuserlevel.Size = new System.Drawing.Size(102, 24);
			this.txtuserlevel.TabIndex = 33;
			// 
			// Maintanance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtuserlevel);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtusername);
			this.Controls.Add(this.txtpassword);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.txtuid);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Maintanance";
			this.Text = "Maintanance";
			this.Load += new System.EventHandler(this.Maintanance_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.TextBox txtuid;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox txtuserlevel;
	}
}