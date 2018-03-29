using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Online_Book_Sale_App
{
    public partial class RemoveBook : Form
    {
        public RemoveBook()
        {
            InitializeComponent();
        }
        BookShopEntities db = new BookShopEntities();
        public int bookIdDelete;
        public string bookSrcDelete;
        private void RemoveBook_Load(object sender, EventArgs e)
        {
            listCombobox(comboBox1);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBook = db.Books.Where(param => param.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault();
            bookIdDelete = selectedBook.Id;
            bookSrcDelete = selectedBook.Image_Src;
            label2.Text = selectedBook.Id.ToString();
            label4.Text = selectedBook.Author;
            pictureBox1.ImageLocation = @"BookImages/" + selectedBook.Image_Src;
        }

        private void remove_book_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteBook = db.Books.Where(param => param.Id == bookIdDelete).FirstOrDefault();
                db.Books.Remove(deleteBook);
                db.SaveChanges();
                File.Delete(path: @"BookImages/" + bookSrcDelete);
                MessageBox.Show("Selected book is succesfully deleted !");
                listCombobox(comboBox1);
                label2.Text = "(Not Selected)";
                label4.Text = "(Not Selected)";
                pictureBox1.ImageLocation = "";
            }
            catch
            {

            }
        }
        public void listCombobox(ComboBox _comboBox)
        {
            _comboBox.Items.Clear();
            foreach (var book in db.Books.ToList())
            {
                _comboBox.Items.Add(book.Name);
            }
        }
    }
}
