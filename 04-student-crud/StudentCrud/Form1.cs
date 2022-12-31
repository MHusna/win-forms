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

namespace StudentCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Db_Test;");
            connection.Open();
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into ogrenci (ogrenci_no, ogrenci_ad, ogrenci_soyad, ogrenci_sehir)" +
                "values (@ogrNo, @ogrAd, @ogrSoyad,@ogrSehir);";

            command = new SqlCommand(sorgu,connection);
            command.Parameters.AddWithValue("@ogrNo", tbxOgrenciNo.Text);
            command.Parameters.AddWithValue("@ogrAd", tbxOgrenciAd.Text);
            command.Parameters.AddWithValue("@ogrSoyad", tbxOgrenciSoyad.Text);
            command.Parameters.AddWithValue("@ogrSehir", tbxOgrenciSehir.Text);

            command.ExecuteNonQuery();
            Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update ogrenci set ogrenci_no=@ogrNo, ogrenci_ad=@ogrAd, ogrenci_soyad=@ogrSoyad, " +
                "ogrenci_sehir=@ogrSehir where ogrenci_no=@selectedOgrNo";

            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@ogrNo", tbxOgrenciNo.Text);
            command.Parameters.AddWithValue("@ogrAd", tbxOgrenciAd.Text);
            command.Parameters.AddWithValue("@ogrSoyad", tbxOgrenciSoyad.Text);
            command.Parameters.AddWithValue("@ogrSehir", tbxOgrenciSehir.Text);
            command.Parameters.AddWithValue("@selectedOgrNo", dgvOgrenci.SelectedCells[0].Value.ToString());

            command.ExecuteNonQuery();
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from ogrenci where ogrenci_no=@ogrNo";

            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@ogrNo", tbxOgrenciNo.Text);

            command.ExecuteNonQuery();
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dgvOgrenci.Rows.Clear();
            dgvOgrenci.DataSource = null;

            string sorgu = "select * from ogrenci";
            command = new SqlCommand(sorgu, connection);
            dataReader = command.ExecuteReader();

            if (dataReader.FieldCount != 0)
            {
                while (dataReader.Read())
                {
                    dgvOgrenci.Rows.Add(dataReader["ogrenci_no"], dataReader["ogrenci_ad"]
                        , dataReader["ogrenci_soyad"], dataReader["ogrenci_sehir"]);
                }
            }
            else
                MessageBox.Show("Veri tabanında kayıt bulunmamaktadır.");

            dataReader.Close();
        }
    }
}
