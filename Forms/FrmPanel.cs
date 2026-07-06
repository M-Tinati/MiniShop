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
            Refresh();
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
        /*
         * بخش افزودن رو باید اپدیت و فیکس بکنی
         * ضرب تعداد کالا بر فی
         *nameProduct
         *countPoduct
         *priceProduct
         *profitProduct
         */
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


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string Q_UPDATE = "UPDATE ProductInsert SET nameProduct=@name,countPoduct=@count,priceProduct=@price,profitProduct=@profit WHERE ID=@ID";
            SQLiteCommand cmd = new SQLiteCommand(Q_UPDATE, con);
            cmd.Parameters.AddWithValue("@ID", NumIdEdit.Text);
            cmd.Parameters.AddWithValue("@name", TxtNameEdit.Text);
            cmd.Parameters.AddWithValue("@price", NumPriceEdit.Value);
            cmd.Parameters.AddWithValue("@count", NumCountEdit.Value);
            cmd.Parameters.AddWithValue("@profit", NumProfitEdit.Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Refresh();
            MessageBox.Show("ویرایش انجام شد");
            NumIdEdit.Value = 0;
            TxtNameEdit.Text = "";
            NumPriceEdit.Value = 0;
            NumCountEdit.Value = 0;
            NumProfitEdit.Value = 0;


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string Q_DELETE = "DELETE FROM ProductInsert WHERE ID=@ID";
            SQLiteCommand cmd = new SQLiteCommand(Q_DELETE, con);
            cmd.Parameters.AddWithValue("@ID", NumIdEdit.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Refresh();
            MessageBox.Show("حذف انجام شد");
        }


        /// <summary>
        /// داده های دیتاگریدویو رو توی فرم دوم میبرم
        /// باید ازش نمونه بسازم که توی کاسنتارکتورش تون دیتاگرید ویو مد نظرمو اضافه کنم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBuyProducts_Click(object sender, EventArgs e)
        {
            FrmListProducts frm2 = new(dgvProducts);
            frm2.ShowDialog();
        }
        
    }
    
}
