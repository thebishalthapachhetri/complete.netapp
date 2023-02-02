
namespace Matts_Battle_Plan
{
	partial class BrowseAndSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseAndSearch));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtisbn = new System.Windows.Forms.TextBox();
			this.txtbookname = new System.Windows.Forms.TextBox();
			this.txtauthor = new System.Windows.Forms.TextBox();
			this.btnsearch = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtpublishyear = new System.Windows.Forms.TextBox();
			this.txtlanguage = new System.Windows.Forms.TextBox();
			this.txtcategory = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtpages = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtpublisher = new System.Windows.Forms.TextBox();
			this.publisher = new System.Windows.Forms.Label();
			this.radyear = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.radbookname = new System.Windows.Forms.RadioButton();
			this.radpublisher = new System.Windows.Forms.RadioButton();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.btnback = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(424, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(602, 55);
			this.label1.TabIndex = 6;
			this.label1.Text = "Browse and search books";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
			this.pictureBox2.Location = new System.Drawing.Point(35, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(146, 126);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(434, 161);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(789, 549);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 17);
			this.label2.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(65, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "BookName";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(68, 318);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Author";
			// 
			// txtisbn
			// 
			this.txtisbn.Location = new System.Drawing.Point(236, 229);
			this.txtisbn.Name = "txtisbn";
			this.txtisbn.Size = new System.Drawing.Size(111, 22);
			this.txtisbn.TabIndex = 11;
			// 
			// txtbookname
			// 
			this.txtbookname.Location = new System.Drawing.Point(236, 273);
			this.txtbookname.Name = "txtbookname";
			this.txtbookname.Size = new System.Drawing.Size(111, 22);
			this.txtbookname.TabIndex = 12;
			this.txtbookname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txtauthor
			// 
			this.txtauthor.Location = new System.Drawing.Point(236, 318);
			this.txtauthor.Name = "txtauthor";
			this.txtauthor.Size = new System.Drawing.Size(111, 22);
			this.txtauthor.TabIndex = 13;
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(288, 616);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(72, 31);
			this.btnsearch.TabIndex = 14;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(69, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "ISBN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(68, 362);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 21;
			this.label6.Text = "Category";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// txtpublishyear
			// 
			this.txtpublishyear.Location = new System.Drawing.Point(236, 451);
			this.txtpublishyear.Name = "txtpublishyear";
			this.txtpublishyear.Size = new System.Drawing.Size(111, 22);
			this.txtpublishyear.TabIndex = 20;
			// 
			// txtlanguage
			// 
			this.txtlanguage.Location = new System.Drawing.Point(236, 409);
			this.txtlanguage.Name = "txtlanguage";
			this.txtlanguage.Size = new System.Drawing.Size(111, 22);
			this.txtlanguage.TabIndex = 19;
			// 
			// txtcategory
			// 
			this.txtcategory.Location = new System.Drawing.Point(236, 362);
			this.txtcategory.Name = "txtcategory";
			this.txtcategory.Size = new System.Drawing.Size(111, 22);
			this.txtcategory.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(65, 456);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Published Year";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(65, 409);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 17);
			this.label8.TabIndex = 16;
			this.label8.Text = "Language";
			// 
			// txtpages
			// 
			this.txtpages.Location = new System.Drawing.Point(236, 501);
			this.txtpages.Name = "txtpages";
			this.txtpages.Size = new System.Drawing.Size(111, 22);
			this.txtpages.TabIndex = 23;
			this.txtpages.TextChanged += new System.EventHandler(this.txtpages_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(68, 501);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 17);
			this.label9.TabIndex = 22;
			this.label9.Text = "Pages";
			// 
			// txtpublisher
			// 
			this.txtpublisher.Location = new System.Drawing.Point(236, 543);
			this.txtpublisher.Name = "txtpublisher";
			this.txtpublisher.Size = new System.Drawing.Size(111, 22);
			this.txtpublisher.TabIndex = 25;
			this.txtpublisher.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// publisher
			// 
			this.publisher.AutoSize = true;
			this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.publisher.Location = new System.Drawing.Point(70, 543);
			this.publisher.Name = "publisher";
			this.publisher.Size = new System.Drawing.Size(76, 17);
			this.publisher.TabIndex = 24;
			this.publisher.Text = "Publisher";
			// 
			// radyear
			// 
			this.radyear.AutoSize = true;
			this.radyear.Location = new System.Drawing.Point(68, 594);
			this.radyear.Name = "radyear";
			this.radyear.Size = new System.Drawing.Size(199, 21);
			this.radyear.TabIndex = 26;
			this.radyear.TabStop = true;
			this.radyear.Text = "Search with publised year?";
			this.radyear.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(431, 132);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(241, 17);
			this.label11.TabIndex = 28;
			this.label11.Text = "Search you book by name or by year";
			// 
			// radbookname
			// 
			this.radbookname.AutoSize = true;
			this.radbookname.Location = new System.Drawing.Point(68, 621);
			this.radbookname.Name = "radbookname";
			this.radbookname.Size = new System.Drawing.Size(208, 21);
			this.radbookname.TabIndex = 30;
			this.radbookname.TabStop = true;
			this.radbookname.Text = "Searching with book namer?";
			this.radbookname.UseVisualStyleBackColor = true;
			// 
			// radpublisher
			// 
			this.radpublisher.AutoSize = true;
			this.radpublisher.Location = new System.Drawing.Point(68, 648);
			this.radpublisher.Name = "radpublisher";
			this.radpublisher.Size = new System.Drawing.Size(191, 21);
			this.radpublisher.TabIndex = 31;
			this.radpublisher.TabStop = true;
			this.radpublisher.Text = "Searching with publisher?";
			this.radpublisher.UseVisualStyleBackColor = true;
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(252, 706);
			this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(72, 31);
			this.btnupdate.TabIndex = 35;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(156, 706);
			this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(72, 31);
			this.btndelete.TabIndex = 34;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(68, 706);
			this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(72, 31);
			this.btnsave.TabIndex = 33;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			// 
			// btnback
			// 
			this.btnback.Location = new System.Drawing.Point(345, 706);
			this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(72, 31);
			this.btnback.TabIndex = 36;
			this.btnback.Text = "Back";
			this.btnback.UseVisualStyleBackColor = true;
			this.btnback.Click += new System.EventHandler(this.btnback_Click);
			// 
			// BrowseAndSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1421, 840);
			this.Controls.Add(this.btnback);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.radpublisher);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.radbookname);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.radyear);
			this.Controls.Add(this.txtpublisher);
			this.Controls.Add(this.publisher);
			this.Controls.Add(this.txtpages);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtpublishyear);
			this.Controls.Add(this.txtlanguage);
			this.Controls.Add(this.txtcategory);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtauthor);
			this.Controls.Add(this.txtbookname);
			this.Controls.Add(this.txtisbn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "BrowseAndSearch";
			this.Text = "BrowseAndSearch";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BrowseAndSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtisbn;
		private System.Windows.Forms.TextBox txtbookname;
		private System.Windows.Forms.TextBox txtauthor;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtpublishyear;
		private System.Windows.Forms.TextBox txtlanguage;
		private System.Windows.Forms.TextBox txtcategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtpages;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtpublisher;
		private System.Windows.Forms.Label publisher;
		private System.Windows.Forms.RadioButton radyear;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RadioButton radbookname;
		private System.Windows.Forms.RadioButton radpublisher;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Button btnback;
	}
}