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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void adminpanel_btn_Click(object sender, EventArgs e)
        {
            Adminpanel AdminpanelLogIn = new Adminpanel();
            AdminpanelLogIn.ShowDialog();
        }


        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
