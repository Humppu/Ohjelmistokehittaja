using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokululaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilometriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, muut, polttoaine, pesut, huollot, renkaat, kilometrit, yhteensa;
            
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutuksetTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            polttoaine = Convert.ToDouble(PolttonesteTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometriCB.Text);
          
            yhteensa = (laina + nesteet + vakuutus + muut + polttoaine + pesut + huollot + renkaat) / (kilometrit / 12);

            VastausLB.Text = "Kustannukset kilometriä kohti on: " + yhteensa; 

        }
    }
}
