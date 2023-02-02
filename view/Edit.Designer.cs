
namespace Matts_Battle_Plan
{
	partial class Edit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabLanguageTableAdapter1 = new Model.BookDataSetTableAdapters.TabLanguageTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(54, 40);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(116, 112);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 20;
			this.pictureBox3.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(208, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(581, 44);
			this.label3.TabIndex = 21;
			this.label3.Text = "Edit Category/Language/Author";
			// 
			// tabLanguageTableAdapter1
			// 
			this.tabLanguageTableAdapter1.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(216, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 49);
			this.label1.TabIndex = 22;
			this.label1.Text = "Edit Category";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(216, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(313, 49);
			this.label2.TabIndex = 23;
			this.label2.Text = "Edit Language";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(216, 312);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(245, 49);
			this.label4.TabIndex = 24;
			this.label4.Text = "Edit Author";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox3);
			this.Name = "Edit";
			this.Text = "Edit";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private Model.BookDataSetTableAdapters.TabLanguageTableAdapter tabLanguageTableAdapter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
	}
}