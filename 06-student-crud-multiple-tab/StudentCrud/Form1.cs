using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace StudentCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;
        private DataTable dataTableOgr;
        private string sorgu;

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Db_Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            OgrenciListUpdate();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_OgrenciEkle", connection);

            //'command' nesnesinin varsayılan yapısı String yani Text yapısıdır, ancak biz önceden oluşturduğumuz
            //'Stored Procedur'ü kullanmak istediğimizden CommandType özelliğini Stored Procedure olarak değiştirdik.
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ad", tbxAd.Text);
            command.Parameters.AddWithValue("@soyad", tbxSoyad.Text);
            command.Parameters.AddWithValue("@telefon", tbxTel.Text);
            command.Parameters.AddWithValue("@tc", tbxTc.Text);

            DbConnect();

            //ExecuteNonQuery, çalışan sorgumuzdan kaç satır etkilendi ise onu döndürür.
            int etkilenen = command.ExecuteNonQuery();

            if (etkilenen > 0)
                MessageBox.Show(tbxAd.Text + " isimli öğrenci başarıyla eklendi.");
            
            else
                MessageBox.Show("Öğrenci eklenemedi !");

            command = null;

            OgrenciListUpdate();
            DbDisconnect();

        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekId = Convert.ToInt32(cmbSilOgrenciler.SelectedValue.ToString());

            sorgu = "delete from tb_ogrenci where ID=@ogrId";
            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@ogrId", silinecekId);

            string adSoyad = cmbSilOgrenciler.SelectedItem.ToString();
            DialogResult result = MessageBox.Show(adSoyad+" isimli kişiyi silmek istediğinizden emin misiniz ?", 
                                               "Silme Onayı",
                                                       MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DbConnect();
                int etkilenen = command.ExecuteNonQuery();
                if (etkilenen > 0)
                    MessageBox.Show(adSoyad + " isimli öğrenci başarıyla silindi.");
                else
                    MessageBox.Show(adSoyad + " isimli kullanıcı silinemedi");
                DbDisconnect();
            }
            OgrenciListUpdate();
        }

        private void DbConnect()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DbDisconnect()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OgrenciListUpdate()
        {

            sorgu = "select ID, CONCAT(ad,' ',soyad) as [Ad Soyad], telefon as Telefon, tc as [TC.K.No], ad, soyad" +
                           " FROM tb_ogrenci ORDER BY ad, soyad";

            dataTableOgr = new DataTable();

            //Veritabanına bağlandık.
            DbConnect();

            //Sorgumuzu çalıştırdık ve gelen veriler dataAdapter içerisinde.
            dataAdapter = new SqlDataAdapter(sorgu, connection);

            //dataAdapter.Fill ile verileri dataTableOgr'ye atıyoruz.
            dataAdapter.Fill(dataTableOgr);

            //Sil ekranındaki combobox'a datatable içerisindeki verileri atıyoruz.
            cmbSilOgrenciler.DataSource = dataTableOgr;
            cmbSilOgrenciler.DisplayMember = "Ad Soyad";
            cmbSilOgrenciler.ValueMember = "ID";

            //Güncelle ekranındaki combobox'a datatable içerisindeki verileri atıyoruz.
            cmbGuncelleOgrenciler.DataSource = dataTableOgr;
            cmbGuncelleOgrenciler.DisplayMember = "Ad Soyad";
            cmbGuncelleOgrenciler.ValueMember = "ID";
            

            dgvOgrenci.DataSource = dataTableOgr;
            dgvOgrenci.Columns["ID"].Visible = false;
            dgvOgrenci.Columns["ad"].Visible = false;
            dgvOgrenci.Columns["soyad"].Visible = false;

            DbDisconnect();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //DataRowView item = (DataRowView)comboBox_Güncelle.SelectedItem;
            //int ID = int.Parse(item[0].ToString());

            //combobox'tan silinecek isimin id'sini aldık.
            //int guncellenecekId = int.Parse(cmbGuncelleOgrenciler.SelectedValue.ToString());
            string guncellenecekId = cmbGuncelleOgrenciler.SelectedValue.ToString();

            sorgu = "update tb_ogrenci set ad=@ogrAd, soyad=@ogrSoyad, telefon=@ogrTel, tc=@ogrTc where ID=@ogrId";
            command = new SqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@ogrAd", tbxAdGuncelle.Text);
            command.Parameters.AddWithValue("@ogrSoyad", tbxSoyadGuncelle.Text);
            command.Parameters.AddWithValue("@ogrTel", tbxTelefonGuncelle.Text);
            command.Parameters.AddWithValue("@ogrTc", tbxTcGuncelle.Text);
            //command.Parameters.AddWithValue("@ogrId", guncellenecekId.ToString());
            command.Parameters.AddWithValue("@ogrId", guncellenecekId);

            DbConnect();

            int etkilenen = command.ExecuteNonQuery();
            if (etkilenen > 0)
                MessageBox.Show("Güncelleme başarılı.");
            else
                MessageBox.Show("Güncelleme başarısız !");

            OgrenciListUpdate();
            command = null;
            DbDisconnect();
        }

        private void cmbGuncelleOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView item = (DataRowView)cmbGuncelleOgrenciler.SelectedItem;
            int guncellenecekId = int.Parse(item[0].ToString());

            List<string> data = new List<string>();
            GetOgrenci(guncellenecekId, data);

            tbxAdGuncelle.Text = data.ElementAt(0);
            tbxSoyadGuncelle.Text = data.ElementAt(1);
            tbxTelefonGuncelle.Text = data.ElementAt(2);
            tbxTcGuncelle.Text = data.ElementAt(3);
        }

        private void GetOgrenci(int id, List<string> data)
        {
            sorgu = "select ID, ad, soyad, telefon, tc from tb_ogrenci where ID=@ogrId";
            
            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@ogrId", id.ToString());

            DbConnect();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                data.Add(!string.IsNullOrEmpty(dataReader.GetString(1)) ? dataReader.GetString(1) : "");
                data.Add(!string.IsNullOrEmpty(dataReader.GetString(2)) ? dataReader.GetString(2) : "");
                data.Add(!string.IsNullOrEmpty(dataReader.GetString(3)) ? dataReader.GetString(3) : "");
                data.Add(!string.IsNullOrEmpty(dataReader.GetString(4)) ? dataReader.GetString(4) : "");
            }
            DbDisconnect();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
        }
    }
}
