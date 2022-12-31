using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string birinciSayiInput;
        string ikinciSayiInput;
        double result;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            birinciSayiInput = tbxBirinciSayi.Text;
            ikinciSayiInput = tbxIkinciSayi.Text;

            if (KontrolEt(birinciSayiInput, ikinciSayiInput))
            {
                result = IslemYap(birinciSayiInput, ikinciSayiInput, "+");
                lblSonucOutput.Text = Convert.ToString(result);
            }            
            else
                MessageBox.Show("Sayı girişleri boş olamaz !!!");
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            birinciSayiInput = tbxBirinciSayi.Text;
            ikinciSayiInput = tbxIkinciSayi.Text;

            if (KontrolEt(birinciSayiInput, ikinciSayiInput))
            {
                result = IslemYap(birinciSayiInput, ikinciSayiInput, "-");
                lblSonucOutput.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Sayı girişleri boş olamaz !!!");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            birinciSayiInput = tbxBirinciSayi.Text;
            ikinciSayiInput = tbxIkinciSayi.Text;

            if (KontrolEt(birinciSayiInput, ikinciSayiInput))
            {
                result = IslemYap(birinciSayiInput, ikinciSayiInput, "*");
                lblSonucOutput.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Sayı girişleri boş olamaz !!!");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            birinciSayiInput = tbxBirinciSayi.Text;
            ikinciSayiInput = tbxIkinciSayi.Text;

            if (KontrolEt(birinciSayiInput, ikinciSayiInput))
            {
                result = IslemYap(birinciSayiInput, ikinciSayiInput, "/");
                lblSonucOutput.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Sayı girişleri boş olamaz !!!");
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            birinciSayiInput = tbxBirinciSayi.Text;
            ikinciSayiInput = tbxIkinciSayi.Text;

            if (KontrolEt(birinciSayiInput, ikinciSayiInput))
            {
                result = IslemYap(birinciSayiInput, ikinciSayiInput, "A");
                lblAlanOutput.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Sayı girişleri boş olamaz !!!");
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            birinciSayiInput = tbxBirinciSayi.Text;
            ikinciSayiInput = tbxIkinciSayi.Text;

            if (KontrolEt(birinciSayiInput, ikinciSayiInput))
            {
                result = IslemYap(birinciSayiInput, ikinciSayiInput, "C");
                lblCevreOutput.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Sayı girişleri boş olamaz !!!");
        }

        private bool KontrolEt(string sayi1, string sayi2)
        {
            if (sayi1 != "" && sayi2 != "")
                return true;
            else
                return false;
        }

        private double IslemYap(string sayi1, string sayi2, string islem)
        {
            double birinciSayi = Convert.ToDouble(sayi1);
            double ikinciSayi = Convert.ToDouble(sayi2);
            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = birinciSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = birinciSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = birinciSayi * ikinciSayi;
                    break;
                case "/":
                    sonuc = birinciSayi / ikinciSayi;
                    break;
                case "A":
                    sonuc = birinciSayi*ikinciSayi;
                    break;
                case "C":
                    sonuc = 2* (birinciSayi + ikinciSayi);
                    break;
                default:
                    MessageBox.Show("Yanlış işlem girildi !!!");
                    break;
            }

            return sonuc;
        }
    }
}
