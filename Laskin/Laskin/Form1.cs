using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            try
            {
                float luku1 = float.Parse(LukuYksiTB.Text);
                float luku2 = float.Parse(LukuKaksiTB.Text);
                float vastaus = 0;
                string merkki = LaskutoimitusCB.Text;

                switch (merkki)
                {
                    case "+":
                        vastaus = luku1 + luku2;
                        break;

                    case "-":
                        vastaus = luku1 - luku2;
                        break;

                    case "*":
                        vastaus = luku1 * luku2;
                        break;

                    case "/":
                        if (luku2 != 0)
                        {
                            vastaus = luku1 / luku2;
                        }
                        else
                        {
                            MessageBox.Show("Nollalla ei voi jakaa!");
                            return;
                        }
                        break;

                    default:
                        MessageBox.Show("Tapahtui virhe!");
                        return;
                }

                VastausLB.Text = vastaus.ToString();
                VastausLB.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Virheellinen syöte! Tarkista antamasi luvut.");
            }
        }
    }
}
