
namespace Matts_Battle_Plan
{
	partial class report
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(438, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Reserved books";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(188, 130);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(116, 112);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 15;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(433, 130);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(116, 112);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 16;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(193, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Borrowed Books";
			// 
			// report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.label4);
			this.Name = "report";
			this.Text = "report";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label5;
	}
}