
namespace Matts_Battle_Plan
{
	partial class borrow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrow));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(29, 176);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(957, 350);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(216, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 44);
			this.label1.TabIndex = 1;
			this.label1.Text = "Borrowed Items";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(29, 15);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(132, 118);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(847, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 39);
			this.button1.TabIndex = 17;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// borrow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1002, 569);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "borrow";
			this.Text = "borrow";
			this.Load += new System.EventHandler(this.borrow_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button button1;
	}
}