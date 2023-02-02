
namespace Matts_Battle_Plan
{
	partial class reserve
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserve));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 126);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(799, 382);
			this.dataGridView1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(25, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(107, 104);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(170, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 44);
			this.label1.TabIndex = 18;
			this.label1.Text = "Reserved Items";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(685, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 39);
			this.button1.TabIndex = 19;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// reserve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(836, 539);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.dataGridView1);
			this.Name = "reserve";
			this.Text = "reserve";
			this.Load += new System.EventHandler(this.reserve_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}