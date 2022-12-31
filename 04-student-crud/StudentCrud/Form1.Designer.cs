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
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.lblOgrenciAd = new System.Windows.Forms.Label();
            this.lblOgrenciSoyad = new System.Windows.Forms.Label();
            this.lblOgrenciSehir = new System.Windows.Forms.Label();
            this.tbxOgrenciNo = new System.Windows.Forms.TextBox();
            this.tbxOgrenciAd = new System.Windows.Forms.TextBox();
            this.tbxOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.tbxOgrenciSehir = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.dgvOgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOgrAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOgrSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOgrSehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMehmetHusnaKisla = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Location = new System.Drawing.Point(49, 33);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(64, 13);
            this.lblOgrenci.TabIndex = 0;
            this.lblOgrenci.Text = "Öğrenci No:";
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Location = new System.Drawing.Point(50, 62);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(63, 13);
            this.lblOgrenciAd.TabIndex = 1;
            this.lblOgrenciAd.Text = "Öğrenci Ad:";
            // 
            // lblOgrenciSoyad
            // 
            this.lblOgrenciSoyad.AutoSize = true;
            this.lblOgrenciSoyad.Location = new System.Drawing.Point(33, 90);
            this.lblOgrenciSoyad.Name = "lblOgrenciSoyad";
            this.lblOgrenciSoyad.Size = new System.Drawing.Size(80, 13);
            this.lblOgrenciSoyad.TabIndex = 2;
            this.lblOgrenciSoyad.Text = "Öğrenci Soyad:";
            // 
            // lblOgrenciSehir
            // 
            this.lblOgrenciSehir.AutoSize = true;
            this.lblOgrenciSehir.Location = new System.Drawing.Point(79, 116);
            this.lblOgrenciSehir.Name = "lblOgrenciSehir";
            this.lblOgrenciSehir.Size = new System.Drawing.Size(34, 13);
            this.lblOgrenciSehir.TabIndex = 3;
            this.lblOgrenciSehir.Text = "Şehir:";
            // 
            // tbxOgrenciNo
            // 
            this.tbxOgrenciNo.Location = new System.Drawing.Point(119, 30);
            this.tbxOgrenciNo.Name = "tbxOgrenciNo";
            this.tbxOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrenciNo.TabIndex = 4;
            // 
            // tbxOgrenciAd
            // 
            this.tbxOgrenciAd.Location = new System.Drawing.Point(119, 59);
            this.tbxOgrenciAd.Name = "tbxOgrenciAd";
            this.tbxOgrenciAd.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrenciAd.TabIndex = 5;
            // 
            // tbxOgrenciSoyad
            // 
            this.tbxOgrenciSoyad.Location = new System.Drawing.Point(119, 87);
            this.tbxOgrenciSoyad.Name = "tbxOgrenciSoyad";
            this.tbxOgrenciSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrenciSoyad.TabIndex = 6;
            // 
            // tbxOgrenciSehir
            // 
            this.tbxOgrenciSehir.Location = new System.Drawing.Point(119, 113);
            this.tbxOgrenciSehir.Name = "tbxOgrenciSehir";
            this.tbxOgrenciSehir.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrenciSehir.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(225, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "&Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(225, 57);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "&Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(225, 85);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(225, 111);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "&Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.AllowUserToAddRows = false;
            this.dgvOgrenci.AllowUserToDeleteRows = false;
            this.dgvOgrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOgrNo,
            this.dgvOgrAd,
            this.dgvOgrSoyad,
            this.dgvOgrSehir});
            this.dgvOgrenci.Location = new System.Drawing.Point(12, 159);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.Size = new System.Drawing.Size(776, 303);
            this.dgvOgrenci.TabIndex = 12;
            // 
            // dgvOgrNo
            // 
            this.dgvOgrNo.HeaderText = "Öğrenci No";
            this.dgvOgrNo.Name = "dgvOgrNo";
            this.dgvOgrNo.ReadOnly = true;
            // 
            // dgvOgrAd
            // 
            this.dgvOgrAd.HeaderText = "Öğrenci Ad";
            this.dgvOgrAd.Name = "dgvOgrAd";
            this.dgvOgrAd.ReadOnly = true;
            // 
            // dgvOgrSoyad
            // 
            this.dgvOgrSoyad.HeaderText = "Öğrenci Soyad";
            this.dgvOgrSoyad.Name = "dgvOgrSoyad";
            this.dgvOgrSoyad.ReadOnly = true;
            // 
            // dgvOgrSehir
            // 
            this.dgvOgrSehir.HeaderText = "Şehir";
            this.dgvOgrSehir.Name = "dgvOgrSehir";
            this.dgvOgrSehir.ReadOnly = true;
            // 
            // lblMehmetHusnaKisla
            // 
            this.lblMehmetHusnaKisla.AutoSize = true;
            this.lblMehmetHusnaKisla.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMehmetHusnaKisla.Location = new System.Drawing.Point(410, 69);
            this.lblMehmetHusnaKisla.Name = "lblMehmetHusnaKisla";
            this.lblMehmetHusnaKisla.Size = new System.Drawing.Size(347, 46);
            this.lblMehmetHusnaKisla.TabIndex = 13;
            this.lblMehmetHusnaKisla.TabStop = true;
            this.lblMehmetHusnaKisla.Text = "Mehmet Hüsna Kısla";
            this.lblMehmetHusnaKisla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMehmetHusnaKisla.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(334, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "coded by..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMehmetHusnaKisla);
            this.Controls.Add(this.dgvOgrenci);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxOgrenciSehir);
            this.Controls.Add(this.tbxOgrenciSoyad);
            this.Controls.Add(this.tbxOgrenciAd);
            this.Controls.Add(this.tbxOgrenciNo);
            this.Controls.Add(this.lblOgrenciSehir);
            this.Controls.Add(this.lblOgrenciSoyad);
            this.Controls.Add(this.lblOgrenciAd);
            this.Controls.Add(this.lblOgrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.Label lblOgrenciAd;
        private System.Windows.Forms.Label lblOgrenciSoyad;
        private System.Windows.Forms.Label lblOgrenciSehir;
        private System.Windows.Forms.TextBox tbxOgrenciNo;
        private System.Windows.Forms.TextBox tbxOgrenciAd;
        private System.Windows.Forms.TextBox tbxOgrenciSoyad;
        private System.Windows.Forms.TextBox tbxOgrenciSehir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvOgrenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOgrAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOgrSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOgrSehir;
        private System.Windows.Forms.LinkLabel lblMehmetHusnaKisla;
        private System.Windows.Forms.Label label1;
    }
}

