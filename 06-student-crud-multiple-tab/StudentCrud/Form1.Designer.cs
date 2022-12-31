namespace StudentCrud
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.cmbSilOgrenciler = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.tbxTelefonGuncelle = new System.Windows.Forms.TextBox();
            this.tbxSoyadGuncelle = new System.Windows.Forms.TextBox();
            this.tbxAdGuncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblTc3 = new System.Windows.Forms.Label();
            this.tbxTcGuncelle = new System.Windows.Forms.TextBox();
            this.tabListele = new System.Windows.Forms.TabPage();
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGuncelleOgrenciler = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabSil.SuspendLayout();
            this.tabGuncelle.SuspendLayout();
            this.tabListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabSil);
            this.tabControl1.Controls.Add(this.tabGuncelle);
            this.tabControl1.Controls.Add(this.tabListele);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEkle
            // 
            this.tabEkle.Controls.Add(this.btnEkle);
            this.tabEkle.Controls.Add(this.tbxTc);
            this.tabEkle.Controls.Add(this.tbxTel);
            this.tabEkle.Controls.Add(this.tbxSoyad);
            this.tabEkle.Controls.Add(this.tbxAd);
            this.tabEkle.Controls.Add(this.lblTc);
            this.tabEkle.Controls.Add(this.lblTelefon);
            this.tabEkle.Controls.Add(this.lblSoyad);
            this.tabEkle.Controls.Add(this.lblAd);
            this.tabEkle.Location = new System.Drawing.Point(4, 22);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(497, 205);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekle";
            this.tabEkle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(189, 129);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxTc
            // 
            this.tbxTc.Location = new System.Drawing.Point(189, 103);
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(100, 20);
            this.tbxTc.TabIndex = 7;
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(189, 79);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(100, 20);
            this.tbxTel.TabIndex = 6;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(189, 53);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyad.TabIndex = 5;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(189, 30);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(100, 20);
            this.tbxAd.TabIndex = 4;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(159, 106);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(24, 13);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "TC:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(137, 86);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(143, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(160, 37);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // tabSil
            // 
            this.tabSil.Controls.Add(this.cmbSilOgrenciler);
            this.tabSil.Controls.Add(this.btnSil);
            this.tabSil.Location = new System.Drawing.Point(4, 22);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabSil.Size = new System.Drawing.Size(497, 205);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "Sil";
            this.tabSil.UseVisualStyleBackColor = true;
            // 
            // cmbSilOgrenciler
            // 
            this.cmbSilOgrenciler.FormattingEnabled = true;
            this.cmbSilOgrenciler.Location = new System.Drawing.Point(140, 71);
            this.cmbSilOgrenciler.Name = "cmbSilOgrenciler";
            this.cmbSilOgrenciler.Size = new System.Drawing.Size(191, 21);
            this.cmbSilOgrenciler.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(178, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.Controls.Add(this.cmbGuncelleOgrenciler);
            this.tabGuncelle.Controls.Add(this.tbxTelefonGuncelle);
            this.tabGuncelle.Controls.Add(this.tbxSoyadGuncelle);
            this.tabGuncelle.Controls.Add(this.tbxAdGuncelle);
            this.tabGuncelle.Controls.Add(this.label4);
            this.tabGuncelle.Controls.Add(this.label3);
            this.tabGuncelle.Controls.Add(this.label2);
            this.tabGuncelle.Controls.Add(this.btnGuncelle);
            this.tabGuncelle.Controls.Add(this.lblTc3);
            this.tabGuncelle.Controls.Add(this.tbxTcGuncelle);
            this.tabGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuncelle.Size = new System.Drawing.Size(497, 205);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelle";
            this.tabGuncelle.UseVisualStyleBackColor = true;
            // 
            // tbxTelefonGuncelle
            // 
            this.tbxTelefonGuncelle.Location = new System.Drawing.Point(89, 100);
            this.tbxTelefonGuncelle.Name = "tbxTelefonGuncelle";
            this.tbxTelefonGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefonGuncelle.TabIndex = 8;
            // 
            // tbxSoyadGuncelle
            // 
            this.tbxSoyadGuncelle.Location = new System.Drawing.Point(89, 74);
            this.tbxSoyadGuncelle.Name = "tbxSoyadGuncelle";
            this.tbxSoyadGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyadGuncelle.TabIndex = 7;
            // 
            // tbxAdGuncelle
            // 
            this.tbxAdGuncelle.Location = new System.Drawing.Point(89, 48);
            this.tbxAdGuncelle.Name = "tbxAdGuncelle";
            this.tbxAdGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxAdGuncelle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(89, 152);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblTc3
            // 
            this.lblTc3.AutoSize = true;
            this.lblTc3.Location = new System.Drawing.Point(59, 133);
            this.lblTc3.Name = "lblTc3";
            this.lblTc3.Size = new System.Drawing.Size(24, 13);
            this.lblTc3.TabIndex = 1;
            this.lblTc3.Text = "TC:";
            // 
            // tbxTcGuncelle
            // 
            this.tbxTcGuncelle.Location = new System.Drawing.Point(89, 126);
            this.tbxTcGuncelle.Name = "tbxTcGuncelle";
            this.tbxTcGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxTcGuncelle.TabIndex = 0;
            // 
            // tabListele
            // 
            this.tabListele.Controls.Add(this.btnExcel);
            this.tabListele.Controls.Add(this.dgvOgrenci);
            this.tabListele.Location = new System.Drawing.Point(4, 22);
            this.tabListele.Name = "tabListele";
            this.tabListele.Padding = new System.Windows.Forms.Padding(3);
            this.tabListele.Size = new System.Drawing.Size(546, 253);
            this.tabListele.TabIndex = 3;
            this.tabListele.Text = "Listele";
            this.tabListele.UseVisualStyleBackColor = true;
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Location = new System.Drawing.Point(6, 6);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.Size = new System.Drawing.Size(537, 218);
            this.dgvOgrenci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cmbGuncelleOgrenciler
            // 
            this.cmbGuncelleOgrenciler.FormattingEnabled = true;
            this.cmbGuncelleOgrenciler.Location = new System.Drawing.Point(62, 21);
            this.cmbGuncelleOgrenciler.Name = "cmbGuncelleOgrenciler";
            this.cmbGuncelleOgrenciler.Size = new System.Drawing.Size(149, 21);
            this.cmbGuncelleOgrenciler.TabIndex = 9;
            this.cmbGuncelleOgrenciler.SelectedIndexChanged += new System.EventHandler(this.cmbGuncelleOgrenciler_SelectedIndexChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(441, 227);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(99, 23);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabSil.ResumeLayout(false);
            this.tabGuncelle.ResumeLayout(false);
            this.tabGuncelle.PerformLayout();
            this.tabListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.TabPage tabSil;
        private System.Windows.Forms.TabPage tabGuncelle;
        private System.Windows.Forms.TabPage tabListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxTc;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dgvOgrenci;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox tbxTelefonGuncelle;
        private System.Windows.Forms.TextBox tbxSoyadGuncelle;
        private System.Windows.Forms.TextBox tbxAdGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblTc3;
        private System.Windows.Forms.TextBox tbxTcGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSilOgrenciler;
        private System.Windows.Forms.ComboBox cmbGuncelleOgrenciler;
        private System.Windows.Forms.Button btnExcel;
    }
}

