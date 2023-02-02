
namespace Matts_Battle_Plan
{
	partial class EditAuthor
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtaid = new System.Windows.Forms.TextBox();
			this.txtauthorname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnsearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(222, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "AID";
			// 
			// txtaid
			// 
			this.txtaid.Location = new System.Drawing.Point(328, 179);
			this.txtaid.Name = "txtaid";
			this.txtaid.Size = new System.Drawing.Size(89, 22);
			this.txtaid.TabIndex = 1;
			// 
			// txtauthorname
			// 
			this.txtauthorname.Location = new System.Drawing.Point(328, 248);
			this.txtauthorname.Name = "txtauthorname";
			this.txtauthorname.Size = new System.Drawing.Size(89, 22);
			this.txtauthorname.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(222, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Author Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(182, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(272, 55);
			this.label3.TabIndex = 4;
			this.label3.Text = "Edit Author";
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(225, 341);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(106, 23);
			this.btnadd.TabIndex = 5;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(338, 341);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(79, 23);
			this.btnupdate.TabIndex = 6;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(434, 341);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(79, 23);
			this.btndelete.TabIndex = 7;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(470, 179);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(79, 23);
			this.btnsearch.TabIndex = 8;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			// 
			// EditAuthor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(687, 456);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtauthorname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtaid);
			this.Controls.Add(this.label1);
			this.Name = "EditAuthor";
			this.Text = "EditAuthor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtaid;
		private System.Windows.Forms.TextBox txtauthorname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnsearch;
	}
}