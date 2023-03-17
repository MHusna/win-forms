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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-927L7FU\\SQLEXPRESS;Database=PersonelVeriTabani;Integrated Security=True;");
            
            SqlCommand totalPersonel = new SqlCommand("Select count(*) from Personel", connection);
            SqlCommand marriedPersonel = new SqlCommand("Select count(*) from Personel where Durum=1", connection);
            SqlCommand singlePersonel = new SqlCommand("Select count(*) from Personel where Durum=0", connection);
            SqlCommand totalCity = new SqlCommand("Select count(Distinct Sehir) from Personel", connection);
            SqlCommand totalSalary = new SqlCommand("Select sum(Maas) from Personel", connection);
            SqlCommand avgSalary = new SqlCommand("Select avg(Maas) from Personel", connection);

            connection.Open();

            lblCountPersonel.Text = totalPersonel.ExecuteScalar().ToString();
            lblMarried.Text = marriedPersonel.ExecuteScalar().ToString();
            lblSingle.Text = singlePersonel.ExecuteScalar().ToString();
            lblCity.Text = totalCity.ExecuteScalar().ToString();
            lblTotalSalary.Text = totalSalary.ExecuteScalar().ToString();
            lblAvgSalary.Text = avgSalary.ExecuteScalar().ToString();

            connection.Close();
        }
    }
}
