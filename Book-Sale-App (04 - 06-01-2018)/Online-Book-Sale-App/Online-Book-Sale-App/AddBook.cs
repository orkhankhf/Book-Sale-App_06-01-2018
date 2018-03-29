using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Sale_App
{
    public partial class AddBook : Form
    {
        private string imgPathAndName;
        private string imgName;
        private string imgSource;
        private bool imgSelected = false;
        public AddBook()
        {
            InitializeComponent();
        }

        private void select_new_img_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void add_new_book_btn_Click(object sender, EventArgs e)
        {
            SaveImageToLocation();
            if (imgSelected)
            {
                SaveBookToDb(
                    _name: book_add_name.Text.ToString(),
                    _author: book_add_author.Text.ToString(),
                    _release_date: book_add_release.Text.ToString(),
                    _genre: book_add_genre.Text.ToString(),
                    _cover: book_add_cover.Text.ToString(),
                    _weight: Convert.ToInt32(book_add_weight.Text),
                    _isbn: book_add_isbn.Text.ToString(),
                    _piece: Convert.ToInt32(book_add_piece.Text),
                    _price: Convert.ToInt32(book_add_price.Text),
                    _image_Src: imgSource
                );
            }
        }





        public void OpenFileDialog()
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            img.Title = "Choose Cover Image";

            if (img.ShowDialog() == DialogResult.OK)
            {
                imgSelected = true;
                imgPathAndName = img.FileName;
                imgName = img.SafeFileName;
            }
        }
        public void SaveImageToLocation()
        {
            if (imgSelected)
            {
                Random random = new Random();
                int rand = random.Next(100000, 999999);
                Directory.CreateDirectory("BookImages");
                File.Copy(sourceFileName: imgPathAndName,destFileName: "BookImages/" + rand + "-" + imgName);
                imgSource = rand + "-" + imgName;
            }
            else
            {
                MessageBox.Show("Please select an cover image !");
            }
        }
        public void SaveBookToDb(string _name, string _author, string _release_date, string _genre, string _cover, int _weight, string _isbn, int _piece, int _price, string _image_Src)
        {
            BookShopEntities db = new BookShopEntities();
            var NewBook = new Books()
            {
                Name = _name,
                Author = _author,
                Release_Date = _release_date,
                Genre = _genre,
                Cover = _cover,
                Weight = _weight,
                Isbn = _isbn,
                Piece = _piece,
                Price = _price,
                Image_Src = _image_Src
            };

            db.Books.Add(NewBook);
            try
            {
                db.SaveChanges();
                this.Hide();
                MessageBox.Show("Book added!");
            }
            catch
            {
                
            }
        }
            
    }
}
