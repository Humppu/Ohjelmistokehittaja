using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roomalaiset_numerot
{
    public partial class Form1 : Form
    {
        private readonly string[] ykkosetTaulukko = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        private readonly string[] kympitTaulukko = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private readonly string[] satasetTaulukko = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            string teksti = TekstiTB.Text;

            if (string.IsNullOrEmpty(teksti))
            {
                VastausLB.Text = "";
                VastausLB.Visible = false;
                return;
            }

            int pituus = teksti.Length;
            int[] luvut = new int[pituus];

            for (int i = 0; i < pituus; i++)
            {
                luvut[i] = Convert.ToInt32(teksti.Substring(i, 1));
            }

            string vastaus = "";
            vastaus += sataset(luvut[0]);
            vastaus += kympit(luvut[1]);
            vastaus += ykkoset(luvut[2]);

            if (pituus == 4)
            {
                vastaus += ykkoset(luvut[3]);
            }

            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }

        private string sataset(int luku)
        {
            return satasetTaulukko[luku];
        }

        private string kympit(int luku)
        {
            return kympitTaulukko[luku];
        }

        private string ykkoset(int luku)
        {
            return ykkosetTaulukko[luku];
        }
    }
}