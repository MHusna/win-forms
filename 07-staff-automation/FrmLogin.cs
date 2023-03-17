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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-927L7FU\\SQLEXPRESS;Database=PersonelVeriTabani;Integrated Security=True;");
            SqlCommand command = new SqlCommand("Select Count(*) from Admin where Ad=@ad and Sifre=@sifre", connection);

            command.Parameters.AddWithValue("@ad", tbxUserName.Text);
            command.Parameters.AddWithValue("@sifre", tbxPassword.Text);

            connection.Open();

            int result = (int)command.ExecuteScalar();

            if (result > 0)
            {
                this.Hide();
                FrmMainPage frmMainPage = new FrmMainPage();
                frmMainPage.Show();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre yanlış !");

            connection.Close();
        }
    }
}
