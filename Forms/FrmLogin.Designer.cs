namespace MiniShop.Forms
{
    partial class FrmLogin
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
            LblUsername = new Label();
            LblUserPassword = new Label();
            TxtUserName = new TextBox();
            TxtUserPassword = new TextBox();
            BtnLogin = new Button();
            Btnexit = new Button();
            SuspendLayout();
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Location = new Point(26, 40);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(55, 15);
            LblUsername.TabIndex = 3;
            LblUsername.Text = "نام کاربری";
            // 
            // LblUserPassword
            // 
            LblUserPassword.AutoSize = true;
            LblUserPassword.Location = new Point(26, 99);
            LblUserPassword.Name = "LblUserPassword";
            LblUserPassword.Size = new Size(48, 15);
            LblUserPassword.TabIndex = 4;
            LblUserPassword.Text = "رمز عبور";
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(87, 37);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(120, 23);
            TxtUserName.TabIndex = 0;
            // 
            // TxtUserPassword
            // 
            TxtUserPassword.Location = new Point(87, 96);
            TxtUserPassword.Name = "TxtUserPassword";
            TxtUserPassword.Size = new Size(120, 23);
            TxtUserPassword.TabIndex = 1;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(134, 151);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(73, 27);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "ورود";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // Btnexit
            // 
            Btnexit.Location = new Point(26, 151);
            Btnexit.Name = "Btnexit";
            Btnexit.Size = new Size(73, 27);
            Btnexit.TabIndex = 2;
            Btnexit.Text = "خروج";
            Btnexit.UseVisualStyleBackColor = true;
            Btnexit.Click += Btnexit_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 225);
            Controls.Add(Btnexit);
            Controls.Add(BtnLogin);
            Controls.Add(TxtUserPassword);
            Controls.Add(TxtUserName);
            Controls.Add(LblUserPassword);
            Controls.Add(LblUsername);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUsername;
        private Label LblUserPassword;
        private TextBox TxtUserName;
        private TextBox TxtUserPassword;
        private Button BtnLogin;
        private Button Btnexit;
    }
}