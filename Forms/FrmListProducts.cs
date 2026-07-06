using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class FrmListProducts : Form
    {
        //اضافه کردن ورودی دیتاگرید ویو
        public FrmListProducts(DataGridView dgv)
        {
            InitializeComponent();
            this.AutoScroll = true;
            /// <summary>
            /// با حلقه به دیتاگرید جدید به ترتیب سلول که ساختی توی فرم جدید دیتا وارد میکنی
            /// دیتایی که از فرم قبل باید بدی
            /// 
            /// </summary>    
            foreach (DataGridViewRow row in dgv.Rows)
            {

                decimal price = Convert.ToDecimal(row.Cells["priceProduct"].Value);
                decimal count = Convert.ToDecimal(row.Cells["countPoduct"].Value);
                dgvList.Rows.Add(
                    row.Cells["nameProduct"].Value,
                    price,
                    count,
                    price * count
                    );
                
            }
        }

        private void FrmListProducts_Load(object sender, EventArgs e)
        {
            
            
        }
        
    }
}
