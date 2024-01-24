using Onko_nimesi_suosittujen_joukossa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onko_nimesi_suosittujen_joukossa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible= false;

            string[] pojat = File.ReadAllLines("C:/Users/homam.al-mehsen/source/repos/Ohjelmistokehittaja/Onko nimesi suosittujen joukossa/Onko nimesi suosittujen joukossa/Resourses/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/homam.al-mehsen/source/repos/Ohjelmistokehittaja/Onko nimesi suosittujen joukossa/Onko nimesi suosittujen joukossa/Resourses/tytot.txt");

            string nimi = NimiTB.Text;

            int laskurip = 1;
            int laskurit = 1; 

            foreach (string poika in pojat) { 
            
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + " suosituin pojan nimi vuonna 2022";
                    VastausLB.Visible = true;

                }
                laskurip++; 

            }


            foreach (string tytto in tytot)
            {
                if ( nimi == tytto) {

                    VastausLB.Text = "Nimesi on " + laskurit + " suosituin tytön nimi vuonna 2022";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }

            if (VastausLB.Visible == false) {

                VastausLB.Text = "Nimesi ei ole suosituimpien nimien joukossa! :/ "; 
                VastausLB.Visible = true;
            
            }

        }
    }
}
