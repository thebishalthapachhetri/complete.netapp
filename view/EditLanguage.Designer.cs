
namespace Matts_Battle_Plan
{
	partial class EditLanguage
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
			this.btnsearch = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btnadd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtlanguagename = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtlid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(505, 202);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(79, 23);
			this.btnsearch.TabIndex = 17;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(469, 364);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(79, 23);
			this.btndelete.TabIndex = 16;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(373, 364);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(79, 23);
			this.btnupdate.TabIndex = 15;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(260, 364);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(106, 23);
			this.btnadd.TabIndex = 14;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(250, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(348, 55);
			this.label3.TabIndex = 13;
			this.label3.Text = "Edit Language";
			// 
			// txtlanguagename
			// 
			this.txtlanguagename.Location = new System.Drawing.Point(363, 271);
			this.txtlanguagename.Name = "txtlanguagename";
			this.txtlanguagename.Size = new System.Drawing.Size(89, 22);
			this.txtlanguagename.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(240, 274);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "LaguageName";
			// 
			// txtlid
			// 
			this.txtlid.Location = new System.Drawing.Point(363, 202);
			this.txtlid.Name = "txtlid";
			this.txtlid.Size = new System.Drawing.Size(89, 22);
			this.txtlid.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(240, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "LID";
			// 
			// EditLanguage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtlanguagename);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtlid);
			this.Controls.Add(this.label1);
			this.Name = "EditLanguage";
			this.Text = "EditLanguage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtlanguagename;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtlid;
		private System.Windows.Forms.Label label1;
	}
}