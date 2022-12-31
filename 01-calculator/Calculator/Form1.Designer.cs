namespace Calculator
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
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.tbxBirinciSayi = new System.Windows.Forms.TextBox();
            this.tbxIkinciSayi = new System.Windows.Forms.TextBox();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.lblAlanOutput = new System.Windows.Forms.Label();
            this.lblCevreOutput = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnAlan = new System.Windows.Forms.Button();
            this.btnCevre = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSonucOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(46, 70);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(61, 13);
            this.lblBirinciSayi.TabIndex = 0;
            this.lblBirinciSayi.Text = "Birinci Sayı:";
            // 
            // lblIkinciSayi
            // 
            this.lblIkinciSayi.AutoSize = true;
            this.lblIkinciSayi.Location = new System.Drawing.Point(49, 106);
            this.lblIkinciSayi.Name = "lblIkinciSayi";
            this.lblIkinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblIkinciSayi.TabIndex = 1;
            this.lblIkinciSayi.Text = "İkinci Sayı:";
            // 
            // tbxBirinciSayi
            // 
            this.tbxBirinciSayi.Location = new System.Drawing.Point(113, 67);
            this.tbxBirinciSayi.Name = "tbxBirinciSayi";
            this.tbxBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.tbxBirinciSayi.TabIndex = 2;
            // 
            // tbxIkinciSayi
            // 
            this.tbxIkinciSayi.Location = new System.Drawing.Point(113, 103);
            this.tbxIkinciSayi.Name = "tbxIkinciSayi";
            this.tbxIkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.tbxIkinciSayi.TabIndex = 3;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(291, 67);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(31, 13);
            this.lblAlan.TabIndex = 4;
            this.lblAlan.Text = "Alan:";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(284, 103);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(38, 13);
            this.lblCevre.TabIndex = 5;
            this.lblCevre.Text = "Çevre:";
            // 
            // lblAlanOutput
            // 
            this.lblAlanOutput.AutoSize = true;
            this.lblAlanOutput.Location = new System.Drawing.Point(328, 67);
            this.lblAlanOutput.Name = "lblAlanOutput";
            this.lblAlanOutput.Size = new System.Drawing.Size(103, 13);
            this.lblAlanOutput.TabIndex = 6;
            this.lblAlanOutput.Text = "________________";
            // 
            // lblCevreOutput
            // 
            this.lblCevreOutput.AutoSize = true;
            this.lblCevreOutput.Location = new System.Drawing.Point(328, 103);
            this.lblCevreOutput.Name = "lblCevreOutput";
            this.lblCevreOutput.Size = new System.Drawing.Size(103, 13);
            this.lblCevreOutput.TabIndex = 7;
            this.lblCevreOutput.Text = "________________";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(154, 187);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 8;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(154, 216);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 9;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(235, 216);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 10;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(235, 187);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(75, 23);
            this.btnCarp.TabIndex = 11;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(316, 187);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(75, 23);
            this.btnAlan.TabIndex = 12;
            this.btnAlan.Text = "Alan";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(316, 216);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(75, 23);
            this.btnCevre.TabIndex = 13;
            this.btnCevre.Text = "Çevre";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(198, 147);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 14;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // lblSonucOutput
            // 
            this.lblSonucOutput.AutoSize = true;
            this.lblSonucOutput.Location = new System.Drawing.Point(245, 147);
            this.lblSonucOutput.Name = "lblSonucOutput";
            this.lblSonucOutput.Size = new System.Drawing.Size(103, 13);
            this.lblSonucOutput.TabIndex = 15;
            this.lblSonucOutput.Text = "________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.lblSonucOutput);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblCevreOutput);
            this.Controls.Add(this.lblAlanOutput);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.tbxIkinciSayi);
            this.Controls.Add(this.tbxBirinciSayi);
            this.Controls.Add(this.lblIkinciSayi);
            this.Controls.Add(this.lblBirinciSayi);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblIkinciSayi;
        private System.Windows.Forms.TextBox tbxBirinciSayi;
        private System.Windows.Forms.TextBox tbxIkinciSayi;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.Label lblAlanOutput;
        private System.Windows.Forms.Label lblCevreOutput;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonucOutput;
    }
}

