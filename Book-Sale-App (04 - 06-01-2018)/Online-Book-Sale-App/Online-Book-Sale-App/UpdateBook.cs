using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Sale_App
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }
        RemoveBook removeBook = new RemoveBook();
        BookShopEntities db = new BookShopEntities();
        Books selectedBook;

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            removeBook.listCombobox(comboBox1);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = db.Books.Where(param => param.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault();
            book_update_name.Text = selectedBook.Name;
            book_update_author.Text = selectedBook.Author;
            book_update_release_date.Text = selectedBook.Release_Date;
            book_update_genre.Text = selectedBook.Genre;
            book_update_cover.Text = selectedBook.Cover;
            book_update_weight.Text = selectedBook.Weight.ToString();
            book_update_isbn.Text = selectedBook.Isbn;
            book_update_piece.Text = selectedBook.Piece.ToString();
            book_update_price.Text = selectedBook.Price.ToString();
            pictureBox1.ImageLocation = @"BookImages/"+selectedBook.Image_Src;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedBook.Name = book_update_name.Text;
            selectedBook.Author = book_update_author.Text;
            selectedBook.Release_Date = book_update_release_date.Text;
            selectedBook.Genre = book_update_genre.Text;
            selectedBook.Cover = book_update_cover.Text;
            selectedBook.Weight = Convert.ToInt16(book_update_weight.Text);
            selectedBook.Isbn = book_update_isbn.Text;
            selectedBook.Piece = Convert.ToInt32(book_update_piece.Text);
            selectedBook.Price = Convert.ToInt16(book_update_price.Text);
            db.SaveChanges();
            MessageBox.Show("All changes saved successfully !");
            this.Hide();
        }
    }
}
