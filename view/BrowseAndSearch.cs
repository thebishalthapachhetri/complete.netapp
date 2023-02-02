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
	public partial class BrowseAndSearch : Form
	{
		public BrowseAndSearch()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void BrowseAndSearch_Load(object sender, EventArgs e)
		{
			browseload();
		}

		private void browseload()
		{
			IBookController objBookControllerImpl = new BookControllerImpl();
			List<BookDTO> lstBookDTOs = objBookControllerImpl.getAllBooks();

			if (lstBookDTOs == null)
			{
				MessageBox.Show("No Books Found");

			}
			else
			{
				dataGridView1.DataSource = lstBookDTOs;
			}
		}

		private void clear()
		{
			txtisbn.Clear();
			txtbookname.Clear();
			txtauthor.Clear();
			txtcategory.Clear();
			txtlanguage.Clear();
			txtpublishyear.Clear();
			txtpages.Clear();
			txtpublisher.Clear();
		}
		private void uncheck()
		{
			radbookname.Checked = false;
			radpublisher.Checked = false;
			radyear.Checked = false;
		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			
			if (radyear.Checked)
			{

				IBookController objBookControllerImpl = new BookControllerImpl();
				BookDTO objBookDTO = objBookControllerImpl.getBookbyPublishYear(Convert.ToInt32(txtpublishyear.Text));
				if (objBookDTO == null)
				{
					MessageBox.Show("No Books found");
				}
				else
				{
					txtisbn.Text = objBookDTO.ISBN1.ToString();
					txtbookname.Text = objBookDTO.BookName1.ToString();
					txtauthor.Text = objBookDTO.Author1.ToString();
					txtcategory.Text = objBookDTO.Category1.ToString();
					txtlanguage.Text = objBookDTO.Language1.ToString();
					txtpublishyear.Text = objBookDTO.PublishYear1.ToString();
					txtpages.Text = objBookDTO.Pages1.ToString();
					txtpublisher.Text = objBookDTO.Publisher1.ToString();
					uncheck();


				}
			}

			else if (radpublisher.Checked)
			{

				IBookController objBookControllerImpl = new BookControllerImpl();
				BookDTO objBookDTO = objBookControllerImpl.getBookbyPublisher(txtpublisher.Text);
				if (objBookDTO == null)
				{
					MessageBox.Show("No Books found");
				}
				else
				{
					txtisbn.Text = objBookDTO.ISBN1.ToString();
					txtbookname.Text = objBookDTO.BookName1.ToString();
					txtauthor.Text = objBookDTO.Author1.ToString();
					txtcategory.Text = objBookDTO.Category1.ToString();
					txtlanguage.Text = objBookDTO.Language1.ToString();
					txtpublishyear.Text = objBookDTO.PublishYear1.ToString();
					txtpages.Text = objBookDTO.Pages1.ToString();
					txtpublisher.Text = objBookDTO.Publisher1.ToString();
					uncheck();

				}
			}

			else if(radbookname.Checked)

			{


				IBookController objBookControllerImpl = new BookControllerImpl();
				BookDTO objBookDTO = objBookControllerImpl.getBookbyBookName(txtbookname.Text);
				//BookDTO objBookDTO1 = objBookControllerImpl.getBookbyPublishYear(Convert.ToInt32(txtpublishyear.Text));
				if (objBookDTO == null)
				{
					MessageBox.Show("No Books found");
				}
				else
				{
					txtisbn.Text = objBookDTO.ISBN1.ToString();
					txtbookname.Text = objBookDTO.BookName1.ToString();
					txtauthor.Text = objBookDTO.Author1.ToString();
					txtcategory.Text = objBookDTO.Category1.ToString();
					txtlanguage.Text = objBookDTO.Language1.ToString();
					txtpublishyear.Text = objBookDTO.PublishYear1.ToString();
					txtpages.Text = objBookDTO.Pages1.ToString();
					txtpublisher.Text = objBookDTO.Publisher1.ToString();
					/*txtisbn.Text = objBookDTO.ISBN1.ToString();
					txtbookname.Text = objBookDTO1.BookName1.ToString();
					txtauthor.Text = objBookDTO1.Author1.ToString();
					txtcategory.Text = objBookDTO1.Category1.ToString();
					txtlanguage.Text = objBookDTO1.Language1.ToString();
					txtpublishyear.Text = objBookDTO1.PublishYear1.ToString();
					txtpages.Text = objBookDTO1.Pages1.ToString();
					txtpublisher.Text = objBookDTO1.Publisher1.ToString();*/
					uncheck();
				}

			}

			else
			{
				MessageBox.Show("Please select by which you want to search");
				
			}
		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtpages_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			BookControllerImpl objBookControllerImpl = new BookControllerImpl();
			BookInsertDTO objBookInsertDTO = objBookControllerImpl.insertBook(txtisbn.Text, txtbookname.Text, Convert.ToInt32(txtauthor.Text), Convert.ToInt32(txtcategory.Text), Convert.ToInt32(txtlanguage.Text), Convert.ToInt32(txtpublishyear.Text), Convert.ToInt32(txtpages.Text), txtpublisher.Text);
			MessageBox.Show(objBookInsertDTO.Message);
			browseload();
			clear();
			
		}

		private void btnback_Click(object sender, EventArgs e)
		{
			this.Hide();
			
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			BookControllerImpl objBookControllerImpl = new BookControllerImpl();
			BookInsertDTO objBookDeleteDTO = objBookControllerImpl.deleteBook(txtbookname.Text);
			MessageBox.Show(objBookDeleteDTO.Message);
			browseload();
			clear();
			
		}
	}
}
