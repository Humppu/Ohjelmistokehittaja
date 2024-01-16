using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void SalasanaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Homam" && SalasanaTB.Text == "Salasana")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }

            else
            {
                VirheviestiLB.Text = "Käyttäjäntunnus tai salasana on virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
