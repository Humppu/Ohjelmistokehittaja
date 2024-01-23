using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Kysymyst
{
    public partial class VastauslomakeForm : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10]; 


        public VastauslomakeForm()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radioButton_ChekedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radioButton_ChekedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radioButton_ChekedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radioButton_ChekedChanged);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_ChekedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;

                vastaukset[laskuri] = radioButton.Text;
                laskuri++; 

                KysymysLB.Text = "Vastaus " + laskuri + " . kysymykseen: ";


            }


            else
            {
                VastausLB.Text = ""; 
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;

                for (int a = 0; a < 10; a++)
                {
                    if (vastaukset[a] == oikeatVastaukset[a])
                    {
                        oikein++; 
                    }
                }


                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true; 
            }


            TyhjaaVastaus(); 


        }

        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;

                laskuri--; 
            }

            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;

                laskuri--;
            }

            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;

                laskuri--;
            }

            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;

                laskuri--;
            }
        }

    }
}
