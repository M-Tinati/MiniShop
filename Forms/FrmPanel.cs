using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniShop.Forms
{
    public partial class FrmPanel : Form
    {
        FrmLogin frmlogin = new();
        SQLiteConnection con = new SQLiteConnection("DataSource=minishopDB.db");

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


        void Refresh()
        {
            string Q_load = "SELECT * FROM ProductInsert";
            SQLiteCommand cmd = new SQLiteCommand(Q_load, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProducts.DataSource = dt;
            dgvProducts.Columns["priceProduct"].DefaultCellStyle.Format = "N0";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string Q_ADD = "INSERT INTO ProductInsert (nameProduct,countPoduct,priceProduct,profitProduct) VALUES(@name,@count,@price,@profit)";
            SQLiteCommand cmd = new SQLiteCommand(Q_ADD, con);
            cmd.Parameters.AddWithValue("@name", TxtProductName.Text);
            cmd.Parameters.AddWithValue("@price", NumProductBuy.Value);
            cmd.Parameters.AddWithValue("@count", NumProductCount.Value);
            cmd.Parameters.AddWithValue("@profit", NumProductProfit.Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Refresh();
            MessageBox.Show("ذخیره شد");
        }
//        nameProduct
//        countPoduct
//        priceProduct
//        profitProduct
    }
}
