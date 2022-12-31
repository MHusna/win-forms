namespace DataBaseLoginApp
{
    partial class Form1
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
            this.lblUserCode = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUserCode = new System.Windows.Forms.TextBox();
            this.tbxUserPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.userCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Cursor = System.Windows.Forms.Cursors.No;
            this.lblUserCode.Location = new System.Drawing.Point(34, 44);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(77, 13);
            this.lblUserCode.TabIndex = 0;
            this.lblUserCode.Text = "Kullanıcı Kodu:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(80, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre:";
            // 
            // tbxUserCode
            // 
            this.tbxUserCode.Location = new System.Drawing.Point(117, 37);
            this.tbxUserCode.Name = "tbxUserCode";
            this.tbxUserCode.Size = new System.Drawing.Size(100, 20);
            this.tbxUserCode.TabIndex = 2;
            // 
            // tbxUserPassword
            // 
            this.tbxUserPassword.Location = new System.Drawing.Point(117, 63);
            this.tbxUserPassword.Name = "tbxUserPassword";
            this.tbxUserPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxUserPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(117, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userCode,
            this.userName});
            this.dgvUser.Location = new System.Drawing.Point(12, 217);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(672, 224);
            this.dgvUser.TabIndex = 5;
            // 
            // userCode
            // 
            this.userCode.HeaderText = "Kullanıcı Kodu";
            this.userCode.Name = "userCode";
            this.userCode.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "Kullanıcı Adı";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 453);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxUserPassword);
            this.Controls.Add(this.tbxUserCode);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUserCode;
        private System.Windows.Forms.TextBox tbxUserPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
    }
}

