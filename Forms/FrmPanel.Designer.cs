namespace MiniShop.Forms
{
    partial class FrmPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanel));
            tabControl = new TabControl();
            TapPageProdouct = new TabPage();
            dgvProducts = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            countPoduct = new DataGridViewTextBoxColumn();
            priceProduct = new DataGridViewTextBoxColumn();
            profitProduct = new DataGridViewTextBoxColumn();
            groupBoxAmont = new GroupBox();
            NumProfitEdit = new NumericUpDown();
            label5 = new Label();
            label1 = new Label();
            NumPriceEdit = new NumericUpDown();
            label2 = new Label();
            NumIdEdit = new NumericUpDown();
            NumCountEdit = new NumericUpDown();
            BtnDelete = new Button();
            BtnEdit = new Button();
            label3 = new Label();
            TxtNameEdit = new TextBox();
            label4 = new Label();
            groupBoxAddProducts = new GroupBox();
            NumProductProfit = new NumericUpDown();
            NumProductBuy = new NumericUpDown();
            NumProductCount = new NumericUpDown();
            TxtProductName = new TextBox();
            BtnAdd = new Button();
            LblProfitProduct = new Label();
            LblBuyProduct = new Label();
            LblCountProduct = new Label();
            LblNameProduct = new Label();
            tabPage2 = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton = new ToolStripDropDownButton();
            خروجToolStripMenuItem = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            TapPageProdouct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBoxAmont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumProfitEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumPriceEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumIdEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumCountEdit).BeginInit();
            groupBoxAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumProductProfit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumProductBuy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumProductCount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(TapPageProdouct);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Bottom;
            tabControl.Location = new Point(0, 28);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(869, 473);
            tabControl.TabIndex = 3;
            // 
            // TapPageProdouct
            // 
            TapPageProdouct.Controls.Add(dgvProducts);
            TapPageProdouct.Controls.Add(groupBoxAmont);
            TapPageProdouct.Controls.Add(groupBoxAddProducts);
            TapPageProdouct.Location = new Point(4, 24);
            TapPageProdouct.Name = "TapPageProdouct";
            TapPageProdouct.Padding = new Padding(3);
            TapPageProdouct.Size = new Size(861, 445);
            TapPageProdouct.TabIndex = 0;
            TapPageProdouct.Text = "محصولات";
            TapPageProdouct.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ID, nameProduct, countPoduct, priceProduct, profitProduct });
            dgvProducts.Location = new Point(8, 238);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(845, 201);
            dgvProducts.TabIndex = 2;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ردیف";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 58;
            // 
            // nameProduct
            // 
            nameProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameProduct.DataPropertyName = "nameProduct";
            nameProduct.HeaderText = "نام کالا";
            nameProduct.Name = "nameProduct";
            nameProduct.ReadOnly = true;
            // 
            // countPoduct
            // 
            countPoduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            countPoduct.DataPropertyName = "countPoduct";
            countPoduct.HeaderText = "تعداد کالا";
            countPoduct.Name = "countPoduct";
            countPoduct.ReadOnly = true;
            // 
            // priceProduct
            // 
            priceProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceProduct.DataPropertyName = "priceProduct";
            priceProduct.HeaderText = "قیمت خرید کالا";
            priceProduct.Name = "priceProduct";
            priceProduct.ReadOnly = true;
            // 
            // profitProduct
            // 
            profitProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            profitProduct.DataPropertyName = "profitProduct";
            profitProduct.HeaderText = "درصد سود کالا";
            profitProduct.Name = "profitProduct";
            profitProduct.ReadOnly = true;
            // 
            // groupBoxAmont
            // 
            groupBoxAmont.Controls.Add(NumProfitEdit);
            groupBoxAmont.Controls.Add(label5);
            groupBoxAmont.Controls.Add(label1);
            groupBoxAmont.Controls.Add(NumPriceEdit);
            groupBoxAmont.Controls.Add(label2);
            groupBoxAmont.Controls.Add(NumIdEdit);
            groupBoxAmont.Controls.Add(NumCountEdit);
            groupBoxAmont.Controls.Add(BtnDelete);
            groupBoxAmont.Controls.Add(BtnEdit);
            groupBoxAmont.Controls.Add(label3);
            groupBoxAmont.Controls.Add(TxtNameEdit);
            groupBoxAmont.Controls.Add(label4);
            groupBoxAmont.Location = new Point(345, 6);
            groupBoxAmont.Name = "groupBoxAmont";
            groupBoxAmont.Size = new Size(508, 226);
            groupBoxAmont.TabIndex = 1;
            groupBoxAmont.TabStop = false;
            groupBoxAmont.Text = "Mini انبار";
            // 
            // NumProfitEdit
            // 
            NumProfitEdit.Location = new Point(208, 146);
            NumProfitEdit.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumProfitEdit.Name = "NumProfitEdit";
            NumProfitEdit.Size = new Size(204, 23);
            NumProfitEdit.TabIndex = 10;
            NumProfitEdit.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 154);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 0;
            label5.Text = "ردیف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "نام کالا";
            // 
            // NumPriceEdit
            // 
            NumPriceEdit.Location = new Point(208, 108);
            NumPriceEdit.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumPriceEdit.Name = "NumPriceEdit";
            NumPriceEdit.Size = new Size(204, 23);
            NumPriceEdit.TabIndex = 9;
            NumPriceEdit.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 69);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "تعداد";
            // 
            // NumIdEdit
            // 
            NumIdEdit.Location = new Point(31, 152);
            NumIdEdit.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumIdEdit.Name = "NumIdEdit";
            NumIdEdit.Size = new Size(75, 23);
            NumIdEdit.TabIndex = 8;
            NumIdEdit.ThousandsSeparator = true;
            // 
            // NumCountEdit
            // 
            NumCountEdit.Location = new Point(208, 67);
            NumCountEdit.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumCountEdit.Name = "NumCountEdit";
            NumCountEdit.Size = new Size(204, 23);
            NumCountEdit.TabIndex = 8;
            NumCountEdit.ThousandsSeparator = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(31, 187);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(124, 28);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "حذف";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(208, 187);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(204, 28);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "ویرایش";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 110);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "قیمت خرید";
            // 
            // TxtNameEdit
            // 
            TxtNameEdit.Location = new Point(208, 28);
            TxtNameEdit.Name = "TxtNameEdit";
            TxtNameEdit.Size = new Size(204, 23);
            TxtNameEdit.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 146);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "درصد سود";
            // 
            // groupBoxAddProducts
            // 
            groupBoxAddProducts.Controls.Add(NumProductProfit);
            groupBoxAddProducts.Controls.Add(NumProductBuy);
            groupBoxAddProducts.Controls.Add(NumProductCount);
            groupBoxAddProducts.Controls.Add(TxtProductName);
            groupBoxAddProducts.Controls.Add(BtnAdd);
            groupBoxAddProducts.Controls.Add(LblProfitProduct);
            groupBoxAddProducts.Controls.Add(LblBuyProduct);
            groupBoxAddProducts.Controls.Add(LblCountProduct);
            groupBoxAddProducts.Controls.Add(LblNameProduct);
            groupBoxAddProducts.Location = new Point(8, 6);
            groupBoxAddProducts.Name = "groupBoxAddProducts";
            groupBoxAddProducts.Size = new Size(320, 226);
            groupBoxAddProducts.TabIndex = 0;
            groupBoxAddProducts.TabStop = false;
            groupBoxAddProducts.Text = "افزودن کالا";
            // 
            // NumProductProfit
            // 
            NumProductProfit.Location = new Point(20, 146);
            NumProductProfit.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumProductProfit.Name = "NumProductProfit";
            NumProductProfit.Size = new Size(204, 23);
            NumProductProfit.TabIndex = 10;
            NumProductProfit.ThousandsSeparator = true;
            // 
            // NumProductBuy
            // 
            NumProductBuy.Location = new Point(20, 108);
            NumProductBuy.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumProductBuy.Name = "NumProductBuy";
            NumProductBuy.Size = new Size(204, 23);
            NumProductBuy.TabIndex = 9;
            NumProductBuy.ThousandsSeparator = true;
            // 
            // NumProductCount
            // 
            NumProductCount.Location = new Point(20, 67);
            NumProductCount.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NumProductCount.Name = "NumProductCount";
            NumProductCount.Size = new Size(204, 23);
            NumProductCount.TabIndex = 8;
            NumProductCount.ThousandsSeparator = true;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(20, 28);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(204, 23);
            TxtProductName.TabIndex = 7;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(20, 187);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(204, 28);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "افزودن";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LblProfitProduct
            // 
            LblProfitProduct.AutoSize = true;
            LblProfitProduct.Location = new Point(253, 146);
            LblProfitProduct.Name = "LblProfitProduct";
            LblProfitProduct.Size = new Size(60, 15);
            LblProfitProduct.TabIndex = 3;
            LblProfitProduct.Text = "درصد سود";
            // 
            // LblBuyProduct
            // 
            LblBuyProduct.AutoSize = true;
            LblBuyProduct.Location = new Point(253, 110);
            LblBuyProduct.Name = "LblBuyProduct";
            LblBuyProduct.Size = new Size(61, 15);
            LblBuyProduct.TabIndex = 2;
            LblBuyProduct.Text = "قیمت خرید";
            // 
            // LblCountProduct
            // 
            LblCountProduct.AutoSize = true;
            LblCountProduct.Location = new Point(280, 69);
            LblCountProduct.Name = "LblCountProduct";
            LblCountProduct.Size = new Size(33, 15);
            LblCountProduct.TabIndex = 1;
            LblCountProduct.Text = "تعداد";
            // 
            // LblNameProduct
            // 
            LblNameProduct.AutoSize = true;
            LblNameProduct.Location = new Point(274, 31);
            LblNameProduct.Name = "LblNameProduct";
            LblNameProduct.Size = new Size(40, 15);
            LblNameProduct.TabIndex = 0;
            LblNameProduct.Text = "نام کالا";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(861, 445);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(869, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton
            // 
            toolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { خروجToolStripMenuItem });
            toolStripDropDownButton.Image = (Image)resources.GetObject("toolStripDropDownButton.Image");
            toolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton.Name = "toolStripDropDownButton";
            toolStripDropDownButton.Size = new Size(37, 22);
            toolStripDropDownButton.Text = "منو";
            // 
            // خروجToolStripMenuItem
            // 
            خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            خروجToolStripMenuItem.Size = new Size(99, 22);
            خروجToolStripMenuItem.Text = "خروج";
            خروجToolStripMenuItem.Click += خروجToolStripMenuItem_Click;
            // 
            // FrmPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 501);
            Controls.Add(toolStrip1);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPanel";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "داشبورد";
            Load += FrmPanel_Load;
            tabControl.ResumeLayout(false);
            TapPageProdouct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBoxAmont.ResumeLayout(false);
            groupBoxAmont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumProfitEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumPriceEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumIdEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumCountEdit).EndInit();
            groupBoxAddProducts.ResumeLayout(false);
            groupBoxAddProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumProductProfit).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumProductBuy).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumProductCount).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage TapPageProdouct;
        private TabPage tabPage2;
        private DataGridView dgvProducts;
        private GroupBox groupBoxAmont;
        private GroupBox groupBoxAddProducts;
        private Label LblProfitProduct;
        private Label LblBuyProduct;
        private Label LblCountProduct;
        private Label LblNameProduct;
        private NumericUpDown NumProductProfit;
        private NumericUpDown NumProductBuy;
        private NumericUpDown NumProductCount;
        private TextBox TxtProductName;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn countPoduct;
        private DataGridViewTextBoxColumn priceProduct;
        private DataGridViewTextBoxColumn profitProduct;
        private NumericUpDown NumProfitEdit;
        private Label label1;
        private NumericUpDown NumPriceEdit;
        private Label label2;
        private NumericUpDown NumCountEdit;
        private Label label3;
        private TextBox TxtNameEdit;
        private Label label4;
        private Label label5;
        private NumericUpDown NumIdEdit;
    }
}