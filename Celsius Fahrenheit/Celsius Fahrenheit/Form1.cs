﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus; 
            double asteet = Convert.ToDouble(AsteetTB.Text);

            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;

                VastausLB.Text = asteet + " Fahrenheitia on: " + vastaus + " Celsius astetta ";
                VastausLB.Visible = true; 
            }

            else if(FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;

                VastausLB.Text = asteet + " Celsiusta on: " + vastaus + " Fahrenheit astetta "; 
                VastausLB.Visible = true;

            }

            else
            {
                VastausLB.Text = " Et valinnut astetta tai antanut oikeaa lukua mitä muuntaa! "; 
                VastausLB.Visible = true;
            }
        }
    }
}
