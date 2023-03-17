namespace PersonelOtomasyon
{
    partial class FrmMainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            label1 = new Label();
            groupBox1 = new GroupBox();
            mbxSalary = new MaskedTextBox();
            label8 = new Label();
            radSingle = new RadioButton();
            radMarried = new RadioButton();
            cmbCity = new ComboBox();
            tbxLastName = new TextBox();
            tbxJob = new TextBox();
            tbxFirstName = new TextBox();
            lblId = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnGraphics = new Button();
            btnStatistic = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnList = new Button();
            groupBox3 = new GroupBox();
            dgvTable = new DataGridView();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Kayıt Numarası:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mbxSalary);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(radSingle);
            groupBox1.Controls.Add(radMarried);
            groupBox1.Controls.Add(cmbCity);
            groupBox1.Controls.Add(tbxLastName);
            groupBox1.Controls.Add(tbxJob);
            groupBox1.Controls.Add(tbxFirstName);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(291, 304);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt";
            // 
            // mbxSalary
            // 
            mbxSalary.Location = new Point(135, 230);
            mbxSalary.Mask = "00000";
            mbxSalary.Name = "mbxSalary";
            mbxSalary.Size = new Size(100, 26);
            mbxSalary.TabIndex = 7;
            mbxSalary.ValidatingType = typeof(int);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 236);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 9;
            label8.Text = "Maaş:";
            // 
            // radSingle
            // 
            radSingle.AutoSize = true;
            radSingle.Location = new Point(192, 160);
            radSingle.Name = "radSingle";
            radSingle.Size = new Size(69, 24);
            radSingle.TabIndex = 5;
            radSingle.TabStop = true;
            radSingle.Text = "Bekar";
            radSingle.UseVisualStyleBackColor = true;
            // 
            // radMarried
            // 
            radMarried.AutoSize = true;
            radMarried.Location = new Point(135, 160);
            radMarried.Name = "radMarried";
            radMarried.Size = new Size(51, 24);
            radMarried.TabIndex = 4;
            radMarried.TabStop = true;
            radMarried.Text = "Evli";
            radMarried.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(133, 124);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(128, 28);
            cmbCity.TabIndex = 3;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(133, 92);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(128, 26);
            tbxLastName.TabIndex = 2;
            // 
            // tbxJob
            // 
            tbxJob.Location = new Point(135, 198);
            tbxJob.Name = "tbxJob";
            tbxJob.Size = new Size(126, 26);
            tbxJob.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(133, 60);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(128, 26);
            tbxFirstName.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(130, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(45, 20);
            lblId.TabIndex = 5;
            lblId.Text = "____";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 201);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 4;
            label7.Text = "Meslek:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 162);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Durum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 127);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Şehir:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 95);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 63);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGraphics);
            groupBox2.Controls.Add(btnStatistic);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnList);
            groupBox2.Location = new Point(315, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 304);
            groupBox2.TabIndex = 100;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // btnGraphics
            // 
            btnGraphics.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGraphics.Location = new Point(68, 235);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Size = new Size(130, 28);
            btnGraphics.TabIndex = 7;
            btnGraphics.Text = "Grafikler";
            btnGraphics.UseVisualStyleBackColor = true;
            btnGraphics.Click += btnGraphics_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatistic.Location = new Point(68, 201);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(130, 28);
            btnStatistic.TabIndex = 6;
            btnStatistic.Text = "İstatistik";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(68, 167);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 28);
            btnClear.TabIndex = 5;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(68, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 28);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(68, 99);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(68, 65);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 28);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnList
            // 
            btnList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnList.Location = new Point(68, 30);
            btnList.Name = "btnList";
            btnList.Size = new Size(130, 28);
            btnList.TabIndex = 1;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvTable);
            groupBox3.Location = new Point(17, 327);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(810, 159);
            groupBox3.TabIndex = 101;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personeller";
            // 
            // dgvTable
            // 
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(9, 25);
            dgvTable.Name = "dgvTable";
            dgvTable.RowTemplate.Height = 25;
            dgvTable.Size = new Size(795, 128);
            dgvTable.TabIndex = 0;
            dgvTable.CellContentDoubleClick += dgvTable_CellContentDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(574, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmMainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(839, 498);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmMainPage";
            Text = "Personel Otomasyon";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radSingle;
        private RadioButton radMarried;
        private ComboBox cmbCity;
        private TextBox tbxLastName;
        private TextBox tbxJob;
        private TextBox tbxFirstName;
        private Label lblId;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnList;
        private Button btnGraphics;
        private Button btnStatistic;
        private Button btnClear;
        private GroupBox groupBox3;
        private DataGridView dgvTable;
        private MaskedTextBox mbxSalary;
        private Label label8;
        private PictureBox pictureBox1;
    }
}