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
            groupBoxAmont = new GroupBox();
            groupBoxAddProducts = new GroupBox();
            NumProductProfit = new NumericUpDown();
            NumProductBuy = new NumericUpDown();
            NumProductCount = new NumericUpDown();
            TxtProductName = new TextBox();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            LblProfitProduct = new Label();
            LblBuyProduct = new Label();
            LblCountProduct = new Label();
            LblNameProduct = new Label();
            tabPage2 = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton = new ToolStripDropDownButton();
            خروجToolStripMenuItem = new ToolStripMenuItem();
            LblNameMini = new Label();
            comboBoxProducts = new ComboBox();
            label1 = new Label();
            tabControl.SuspendLayout();
            TapPageProdouct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBoxAmont.SuspendLayout();
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
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(8, 238);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(845, 201);
            dgvProducts.TabIndex = 2;
            // 
            // groupBoxAmont
            // 
            groupBoxAmont.Controls.Add(label1);
            groupBoxAmont.Controls.Add(comboBoxProducts);
            groupBoxAmont.Controls.Add(LblNameMini);
            groupBoxAmont.Location = new Point(345, 6);
            groupBoxAmont.Name = "groupBoxAmont";
            groupBoxAmont.Size = new Size(508, 226);
            groupBoxAmont.TabIndex = 1;
            groupBoxAmont.TabStop = false;
            groupBoxAmont.Text = "Mini انبار";
            // 
            // groupBoxAddProducts
            // 
            groupBoxAddProducts.Controls.Add(NumProductProfit);
            groupBoxAddProducts.Controls.Add(NumProductBuy);
            groupBoxAddProducts.Controls.Add(NumProductCount);
            groupBoxAddProducts.Controls.Add(TxtProductName);
            groupBoxAddProducts.Controls.Add(BtnAdd);
            groupBoxAddProducts.Controls.Add(BtnEdit);
            groupBoxAddProducts.Controls.Add(BtnDelete);
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
            BtnAdd.Size = new Size(74, 28);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "افزودن";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(129, 187);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(71, 28);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "ویرایش";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(238, 187);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 28);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "حذف";
            BtnDelete.UseVisualStyleBackColor = true;
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
            خروجToolStripMenuItem.Size = new Size(180, 22);
            خروجToolStripMenuItem.Text = "خروج";
            خروجToolStripMenuItem.Click += خروجToolStripMenuItem_Click;
            // 
            // LblNameMini
            // 
            LblNameMini.AutoSize = true;
            LblNameMini.Location = new Point(455, 36);
            LblNameMini.Name = "LblNameMini";
            LblNameMini.Size = new Size(40, 15);
            LblNameMini.TabIndex = 0;
            LblNameMini.Text = "نام کالا";
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(267, 33);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(169, 23);
            comboBoxProducts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 88);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "تعداد کل خرید";
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
        private Label label1;
        private ComboBox comboBoxProducts;
        private Label LblNameMini;
    }
}