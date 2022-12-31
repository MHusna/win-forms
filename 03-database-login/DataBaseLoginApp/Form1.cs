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

namespace DataBaseLoginApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbLogin;Persist Security Info=True;");
            connection.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userCode = tbxUserCode.Text;
            string userPassword = tbxUserPassword.Text;

            if (userCode != String.Empty && userPassword != String.Empty)
            {
                //User code ve password değişkenlerini tek tırnak içerisine aldık.
                string query = $"select * from tblUser where usr='{userCode}' and pwd='{userPassword}'";

                sqlCommand = new SqlCommand(query, connection);
                dataReader =  sqlCommand.ExecuteReader();

                if (dataReader.Read())
                    dgvUser.Rows.Add(dataReader["usr"], dataReader["name"]);
                
                else
                    MessageBox.Show("Böyle bir kayıt bulunamadı !");
            }
            else
                MessageBox.Show("Kullanıcı kodu ve şifre alanı boş bırakılamaz !!!");

            dataReader.Close();
        }
    }
}
