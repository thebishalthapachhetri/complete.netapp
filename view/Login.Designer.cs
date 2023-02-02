
namespace Matts_Battle_Plan
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.lblforgetpassword = new System.Windows.Forms.Label();
			this.btnlogin = new System.Windows.Forms.Button();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblforgetpassword
			// 
			this.lblforgetpassword.AutoSize = true;
			this.lblforgetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblforgetpassword.Location = new System.Drawing.Point(270, 566);
			this.lblforgetpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblforgetpassword.Name = "lblforgetpassword";
			this.lblforgetpassword.Size = new System.Drawing.Size(121, 17);
			this.lblforgetpassword.TabIndex = 9;
			this.lblforgetpassword.Text = "Forgot password?";
			// 
			// btnlogin
			// 
			this.btnlogin.Location = new System.Drawing.Point(321, 614);
			this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(100, 28);
			this.btnlogin.TabIndex = 8;
			this.btnlogin.Text = "LOG IN";
			this.btnlogin.UseVisualStyleBackColor = true;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// txtpassword
			// 
			this.txtpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtpassword.Location = new System.Drawing.Point(274, 510);
			this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.PasswordChar = '*';
			this.txtpassword.Size = new System.Drawing.Size(208, 22);
			this.txtpassword.TabIndex = 7;
			// 
			// txtusername
			// 
			this.txtusername.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtusername.Location = new System.Drawing.Point(274, 444);
			this.txtusername.Margin = new System.Windows.Forms.Padding(4);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(208, 22);
			this.txtusername.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(227, 48);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(323, 338);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(271, 419);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Username";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(271, 489);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "Password";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(773, 730);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblforgetpassword);
			this.Controls.Add(this.btnlogin);
			this.Controls.Add(this.txtpassword);
			this.Controls.Add(this.txtusername);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblforgetpassword;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

