using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenJärjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();

        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int parsedNumber = Int32.Parse(uusiLukuTB.Text);

                    if (parsedNumber == -999)
                    {
                        VastausLB.Text = "";
                        int[] taulukko = jono.ToArray();
                        Array.Sort(taulukko);
                        foreach (var jasen in taulukko)
                        {
                            VastausLB.Text += jasen + " ";
                        }
                        VastausLB.ForeColor = Color.Black;
                        VastausLB.Visible = true;
                    }
                    else
                    {
                        VastausLB.Text = "";
                        VastausLB.Visible = false;
                        jono.Add(parsedNumber);
                        uusiLukuTB.Text = "";
                    }
                }
                catch
                {
                    VastausLB.Text = "Virhe!";
                    VastausLB.Visible = true;
                    VastausLB.ForeColor = Color.Red;
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }

        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
}