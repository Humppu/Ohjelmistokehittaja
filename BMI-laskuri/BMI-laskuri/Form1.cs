using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BMIBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0; 
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus),2); 

            if(bmi < 18.5) {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Aqua;
                BmiLB.Visible = true;
                KuvausLB.ForeColor = Color.Aqua;
                KuvausLB.Text = "Alipaino"; 
                KuvausLB.Visible = true;

            }

            else if(bmi < 25)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Green; 
                BmiLB.Visible = true;
                KuvausLB.Text = "Normaalipaino"; 
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;    
            }

            else if (bmi < 40){

                BmiLB.Text = "Painoindeksisi on: " + bmi; 
                BmiLB.ForeColor = Color.Gold; 
                BmiLB.Visible = true;
                KuvausLB.Text = "Ylipaino"; 
                KuvausLB.ForeColor= Color.Gold;
                KuvausLB.Visible = true;    
            }

            else
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi; 
                BmiLB.ForeColor = Color.Red;
                BmiLB.Visible = true;
                KuvausLB.Text = "Huomattava ylipaino"; 
                KuvausLB.ForeColor =Color.Red;
                KuvausLB.Visible = true;
            }

        }
    }
}
