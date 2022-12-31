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

        //İşlem tipi ?
        string operandPerformed;

        //İşlem sonucu tutuyoruz.
        private double result = 0;

        //Butonun text'ini tutucak.
        private string button;

        //Çıkartma için kaçıncı sayı girildiğini tutucak.
        private int count = 1;

        //Bölme için kaçıncı sayı girildiğini tutucak.
        private int count2 = 1;

        //Girilen sayıyı tutucak.
        private double entry, entry2;

        private void btnEvents_Click(object sender, EventArgs e)
        {
            
            button = ((Button)sender).Text;
            lblProcess.Text += (tbxEntry.Text + (button));
            entry = Convert.ToDouble(tbxEntry.Text);
            count = 1;
            switch (((Button)sender).Text)
            { 
                case "-":
                    if (count == 1)
                    {
                        result = entry;
                        operandPerformed = "-";
                    }
                        
                    else
                    {
                        result -= entry;
                        MessageBox.Show(tbxEntry.Text);
                    }
                    break;

                case "+":
                    if (count == 1)
                    {
                        operandPerformed = "+";
                    }
                    result += entry;
                    break;

                case "*":
                    if (result == 0)
                        result = 1;
                    if (count == 1)
                        operandPerformed = "*";
                    result *= entry;
                    break;

                case "/":
                    if (count == 1)
                    {
                        result = entry; 
                        operandPerformed = "/";
                    }
                    break;
            }
            count++;
            tbxEntry.Clear();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            tbxEntry.Text += ((Button)sender).Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            entry2 = Convert.ToDouble(tbxEntry.Text);
            lblProcess.Text += (tbxEntry.Text);
            if (count == 2 )
            {
                if (operandPerformed == "-")
                    result -= entry2;
                else if (operandPerformed == "+")
                    result += entry2;
                else if (operandPerformed == "*")
                    result *= entry2;
                else
                {
                    try { result /= entry2; }
                    catch (Exception exception) { MessageBox.Show(exception.Message); }
                }
            }
            tbxEntry.Text = result.ToString();
            lblProcess.Text += (" =" + result.ToString());
            result = 0;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEntry.Clear();
        }
    }
}
