namespace MiniShop.Forms
{
    partial class FrmListProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvList = new DataGridView();
            ListName = new DataGridViewTextBoxColumn();
            ListCount = new DataGridViewTextBoxColumn();
            ListPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { ListName, ListCount, ListPrice, Total });
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(0, 0);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.Size = new Size(448, 480);
            dgvList.TabIndex = 0;
            // 
            // ListName
            // 
            ListName.HeaderText = "نام کالا";
            ListName.Name = "ListName";
            ListName.ReadOnly = true;
            // 
            // ListCount
            // 
            ListCount.HeaderText = "تعداد خریداری شده";
            ListCount.Name = "ListCount";
            ListCount.ReadOnly = true;
            // 
            // ListPrice
            // 
            ListPrice.HeaderText = "فی";
            ListPrice.Name = "ListPrice";
            ListPrice.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "جمع کل";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // FrmListProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 480);
            Controls.Add(dgvList);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmListProducts";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "لیست محصولات";
            Load += FrmListProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvList;
        private DataGridViewTextBoxColumn ListName;
        private DataGridViewTextBoxColumn ListCount;
        private DataGridViewTextBoxColumn ListPrice;
        private DataGridViewTextBoxColumn Total;
    }
}