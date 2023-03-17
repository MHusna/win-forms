namespace PersonelOtomasyon
{
    partial class FrmStatistics
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
            label4 = new Label();
            lblCountPersonel = new Label();
            lblMarried = new Label();
            lblSingle = new Label();
            lblCity = new Label();
            lblTotalSalary = new Label();
            label10 = new Label();
            label11 = new Label();
            lblAvgSalary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 59);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 0;
            label2.Text = "Evli Personel Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 87);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 0;
            label3.Text = "Bekar Personel Sayısı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 113);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 0;
            label4.Text = "Şehir Sayısı:";
            // 
            // lblCountPersonel
            // 
            lblCountPersonel.AutoSize = true;
            lblCountPersonel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountPersonel.Location = new Point(178, 32);
            lblCountPersonel.Name = "lblCountPersonel";
            lblCountPersonel.Size = new Size(15, 17);
            lblCountPersonel.TabIndex = 0;
            lblCountPersonel.Text = "0";
            // 
            // lblMarried
            // 
            lblMarried.AutoSize = true;
            lblMarried.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarried.Location = new Point(178, 59);
            lblMarried.Name = "lblMarried";
            lblMarried.Size = new Size(15, 17);
            lblMarried.TabIndex = 0;
            lblMarried.Text = "0";
            // 
            // lblSingle
            // 
            lblSingle.AutoSize = true;
            lblSingle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSingle.Location = new Point(178, 87);
            lblSingle.Name = "lblSingle";
            lblSingle.Size = new Size(15, 17);
            lblSingle.TabIndex = 0;
            lblSingle.Text = "0";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.Location = new Point(178, 113);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(15, 17);
            lblCity.TabIndex = 0;
            lblCity.Text = "0";
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.AutoSize = true;
            lblTotalSalary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSalary.Location = new Point(178, 140);
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(15, 17);
            lblTotalSalary.TabIndex = 1;
            lblTotalSalary.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(92, 142);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 2;
            label10.Text = "Toplam Maaş:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 169);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 2;
            label11.Text = "Ortalama Maaş:";
            // 
            // lblAvgSalary
            // 
            lblAvgSalary.AutoSize = true;
            lblAvgSalary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvgSalary.Location = new Point(178, 167);
            lblAvgSalary.Name = "lblAvgSalary";
            lblAvgSalary.Size = new Size(15, 17);
            lblAvgSalary.TabIndex = 1;
            lblAvgSalary.Text = "0";
            // 
            // FrmStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 206);
            Controls.Add(lblAvgSalary);
            Controls.Add(lblTotalSalary);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lblCity);
            Controls.Add(lblSingle);
            Controls.Add(lblMarried);
            Controls.Add(lblCountPersonel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmStatistics";
            Text = "FrmStatistics";
            Load += FrmStatistics_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCountPersonel;
        private Label lblMarried;
        private Label lblSingle;
        private Label lblCity;
        private Label lblTotalSalary;
        private Label label10;
        private Label label11;
        private Label lblAvgSalary;
    }
}