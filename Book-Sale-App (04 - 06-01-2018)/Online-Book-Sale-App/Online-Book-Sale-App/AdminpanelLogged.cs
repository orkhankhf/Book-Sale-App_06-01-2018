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
    public partial class AdminpanelLogged : Form
    {

        public AdminpanelLogged()
        {
            InitializeComponent();
        }

        private void AdminpanelLogged_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void add_book_btn_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void delete_book_btn_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook();
            removeBook.ShowDialog();
        }

        private void update_book_btn_Click(object sender, EventArgs e)
        {
            UpdateBook updateBook = new UpdateBook();
            updateBook.ShowDialog();
        }
    }
}
