﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime dtpPicker = dtpCalendar.Value;

            int year, month, day;


            if(now.Day >= dtpPicker.Day)
            {
                day = now.Day - dtpPicker.Day;

                if(now.Month >= dtpPicker.Month)
                {
                    month = now.Month - dtpPicker.Month;
                    year = now.Year - dtpPicker.Year;
                }
                else
                {
                    month = (now.Month - dtpPicker.Month) + 12;
                    year = (now.Year - dtpPicker.Year) - 1;
                }
            }
            else
            {
                day = (now.Day - dtpPicker.Day) + DateTime.DaysInMonth(now.Year, (now.Month + 1));
                if (now.Month >= dtpPicker.Month)
                {
                    month = (now.Month - dtpPicker.Month) - 1;
                    year = now.Year - dtpPicker.Year;
                }
                else
                {
                    month = (now.Month - dtpPicker.Month) + 11;
                    year = (now.Year - dtpPicker.Year) - 1;
                }
            }

            lblAgeOutput.Text = Convert.ToString("Yıl: " + year +
                                                 " Ay: " + month +
                                                 " Gün: " + day);
        }
    }
}
