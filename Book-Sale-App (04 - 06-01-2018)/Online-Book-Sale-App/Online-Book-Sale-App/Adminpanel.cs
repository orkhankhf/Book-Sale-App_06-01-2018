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
    public partial class Adminpanel : Form
    {
        public Adminpanel()
        {
            InitializeComponent();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            BookShopEntities db = new BookShopEntities();
            foreach (var admins in db.Admin)
            {
                //admins.Username DB-daki usernameleri alir ve admin_username adli textboxa daxil edilen deyerlerle qarsilasdirir.
                if(admins.Username == admin_username.Text && admins.Password == admin_password.Text)
                {
                    AdminpanelLogged AdminpanelLogged = new AdminpanelLogged();
                    this.Hide();
                    AdminpanelLogged.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
