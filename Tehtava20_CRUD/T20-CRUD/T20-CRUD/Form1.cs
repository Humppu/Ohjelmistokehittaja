using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T20_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = Opiskelija.HaeOpiskelijat();
        }


        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            EmailTB.Text = "";
            PuhelinTB.Text = "";
            OpiskelijaNumTB.Text = "";
        }


        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String email = EmailTB.Text;
            String puhelin = PuhelinTB.Text;

            int oNro = Int32.Parse(OpiskelijaNumTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || puhelin.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Boolean lisaaAsiakas = Opiskelija.LisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija lisätty onnistuneesti!", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Opiskelijaa ei voitu lisätä", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TietotauluDG.DataSource = Opiskelija.HaeOpiskelijat();
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String email = EmailTB.Text;
            String puhelin = PuhelinTB.Text;

            int oNro = Int32.Parse(OpiskelijaNumTB.Text);
            int oid = Int32.Parse(IdTB.Text);


            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || puhelin.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                Boolean lisaaAsiakas = Opiskelija.MuokkaaOpiskelijaa(oid, oNro, enimi, snimi, puhelin, email);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty tietokantaan onnistuneesti!", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    MessageBox.Show("Opiskelija ei voitu päivittää tietokantaan!", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = Opiskelija.HaeOpiskelijat();
        }


        private void PoistaBt_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if (Opiskelija.PoistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = Opiskelija.HaeOpiskelijat();

                MessageBox.Show("Opiskelija poistettu!", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Opiskelijaa ei saatu poistettua!", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }




        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            EmailTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            PuhelinTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            OpiskelijaNumTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();

        }
       

      
    }
}
