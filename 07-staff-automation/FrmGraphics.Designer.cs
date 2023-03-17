namespace PersonelOtomasyon
{
    partial class FrmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(12, 12);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sehirler";
            chart1.Series.Add(series3);
            chart1.Size = new Size(489, 417);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart2.Legends.Add(legend4);
            chart2.Location = new Point(507, 12);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Meslek-Maas";
            chart2.Series.Add(series4);
            chart2.Size = new Size(489, 417);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // FrmGraphics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 441);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Name = "FrmGraphics";
            Text = "FrmGraphics";
            Load += FrmGraphics_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}