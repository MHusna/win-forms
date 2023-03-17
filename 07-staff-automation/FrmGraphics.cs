using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }

        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-927L7FU\\SQLEXPRESS;Database=PersonelVeriTabani;Integrated Security=True;");

            connection.Open();

            SqlCommand cityGraph = new SqlCommand("select sehir, count(*) from Personel group by sehir", connection);
            SqlDataReader data = cityGraph.ExecuteReader();

            while(data.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(data[0], data[1]);
            }

            data.Close();

            SqlCommand jobSalaryGraph = new SqlCommand("select meslek, avg(maas) from Personel group by meslek ", connection);           
            data = jobSalaryGraph.ExecuteReader();

            while (data.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(data[0], data[1]);
            }

            connection.Close();
        }
    }
}
