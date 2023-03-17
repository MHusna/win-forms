namespace PersonelOtomasyon
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxUserName = new TextBox();
            btnLogin = new Button();
            tbxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 104);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(42, 25);
            label3.Name = "label3";
            label3.Size = new Size(286, 22);
            label3.TabIndex = 0;
            label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new Point(157, 71);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(100, 23);
            tbxUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(157, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 24);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(157, 101);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(100, 23);
            tbxPassword.TabIndex = 2;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(378, 180);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxUserName;
        private Button btnLogin;
        private TextBox tbxPassword;
    }
}