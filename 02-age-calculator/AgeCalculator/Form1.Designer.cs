namespace AgeCalculator
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
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblAgeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(12, 28);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(103, 13);
            this.lblBirthDay.TabIndex = 0;
            this.lblBirthDay.Text = "Doğum Tarihi Seçin:";
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Location = new System.Drawing.Point(121, 22);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(200, 20);
            this.dtpCalendar.TabIndex = 1;
            this.dtpCalendar.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(87, 65);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(28, 13);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "Yaş:";
            // 
            // lblAgeOutput
            // 
            this.lblAgeOutput.AutoSize = true;
            this.lblAgeOutput.Location = new System.Drawing.Point(121, 65);
            this.lblAgeOutput.Name = "lblAgeOutput";
            this.lblAgeOutput.Size = new System.Drawing.Size(61, 13);
            this.lblAgeOutput.TabIndex = 3;
            this.lblAgeOutput.Text = "_________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 154);
            this.Controls.Add(this.lblAgeOutput);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.lblBirthDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblAgeOutput;
    }
}

