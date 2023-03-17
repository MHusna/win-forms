using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace PersonelOtomasyon
{
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        //Database  bağlantısı tanımı
        SqlConnection connection = new SqlConnection("Server=DESKTOP-927L7FU\\SQLEXPRESS;Database=PersonelVeriTabani;Integrated Security=True;");
        SqlCommand command;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnList_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Insert into Personel (Ad, Soyad, Sehir, Maas, Durum, Meslek) values (@ad, @soyad, @sehir, @maas, @durum, @meslek)", connection);
            command.Parameters.AddWithValue("@ad", tbxFirstName.Text);
            command.Parameters.AddWithValue("@soyad", tbxLastName.Text);
            command.Parameters.AddWithValue("@sehir", cmbCity.Text);
            command.Parameters.AddWithValue("@maas", mbxSalary.Text);
            command.Parameters.AddWithValue("@durum", radSingle.Checked ? false : true);
            command.Parameters.AddWithValue("@meslek", tbxJob.Text);
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //Komut tanımı
            command = new SqlCommand("select * from Personel", connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Personel> personeller = new List<Personel>();
            while (reader.Read())
            {
                personeller.Add(new Personel(Convert.ToInt32(reader["ID"]),
                                            Convert.ToString(reader["Ad"]),
                                            Convert.ToString(reader["Soyad"]),
                                            Convert.ToString(reader["Sehir"]),
                                            Convert.ToInt32(reader["Maas"]),
                                            Convert.ToBoolean(reader["Durum"]),
                                            Convert.ToString(reader["Meslek"])
                    ));
            }

            connection.Close();
            dgvTable.DataSource = personeller;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Delete From Personel where Id = @id", connection);
            command.Parameters.AddWithValue("@id", lblId.Text);

            connection.Open();

            var result = command.ExecuteNonQuery() > 0 ? true : false;

            if (result)
                MessageBox.Show("Kayıt başarı ile silindi.");
            else
                MessageBox.Show("Kayıt silinemedi.");

            connection.Close();

            btnList_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            cmbCity.Text = string.Empty;
            radMarried.Checked = false;
            radSingle.Checked = false;
            tbxJob.Text = string.Empty;
        }

        private void dgvTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dgvTable.SelectedCells[0].RowIndex;

            lblId.Text = dgvTable.Rows[chosen].Cells[0].Value.ToString();
            tbxFirstName.Text = dgvTable.Rows[chosen].Cells[1].Value.ToString();
            tbxLastName.Text = dgvTable.Rows[chosen].Cells[2].Value.ToString();
            cmbCity.Text = dgvTable.Rows[chosen].Cells[3].Value.ToString();
            mbxSalary.Text = dgvTable.Rows[chosen].Cells[4].Value.ToString();

            if ((bool)dgvTable.Rows[chosen].Cells[5].Value)
                radMarried.Checked = true;
            else
                radSingle.Checked = true;

            tbxJob.Text = dgvTable.Rows[chosen].Cells[6].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Personel set Ad=@ad, Soyad=@soyad, Sehir=@sehir, Maas=@maas, Durum=@durum, Meslek=@meslek where Id=@id", connection);
            command.Parameters.AddWithValue("@id", lblId.Text);
            command.Parameters.AddWithValue("@ad", tbxFirstName.Text);
            command.Parameters.AddWithValue("@soyad", tbxLastName.Text);
            command.Parameters.AddWithValue("@sehir", cmbCity.Text);
            command.Parameters.AddWithValue("@maas", mbxSalary.Text);
            command.Parameters.AddWithValue("@durum", radMarried.Checked == true ? true : false);
            command.Parameters.AddWithValue("@meslek", tbxJob.Text);

            connection.Open();

            var result = command.ExecuteNonQuery() > 0 ? true : false;

            if (result)
                MessageBox.Show("Kayıt başarı ile güncellendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kayıt güncellemesi başarısız oldu.", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            connection.Close();

            Clear();
            btnList_Click(sender, e);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();

        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            FrmGraphics frmGraphics = new FrmGraphics();
            frmGraphics.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
        }
    }
}