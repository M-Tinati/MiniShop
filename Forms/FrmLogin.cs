using MiniShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UserLogin Admin = new UserLogin();
            if (TxtUserName.Text == Admin.Username & TxtUserPassword.Text == Admin.Password)
            {

                this.Close();
            }
            else
            {
                MessageBox.Show("عدم دسترسی");
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
