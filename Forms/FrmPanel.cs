using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class FrmPanel : Form
    {
        FrmLogin frmlogin = new();
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            frmlogin.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
