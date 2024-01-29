using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajastin 
{

    public partial class LaskuriForm : Form
    {

        private int kokonaisaika;

        public LaskuriForm()
        {
            InitializeComponent();

            StopBT.Enabled= false;

            for(int l = 0; l < 60; l++)
            {
                MinuutitCB.Items.Add(l.ToString()); 
                SekunnitCB.Items.Add(l.ToString());

            }
            MinuutitCB.SelectedIndex = 30; 
            SekunnitCB.SelectedIndex = 0;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;

            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString());

            kokonaisaika = (minuutit * 60) + sekunnit;

            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; 
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60; 
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();

            }

            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!"); 
            }
        }
    }
}
