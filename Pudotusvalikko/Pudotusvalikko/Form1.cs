using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pudotusvalikko
{

    DataTable oppilaitos = new DataTable();
    DataTable vastuuhenkilot = new DataTable();
    DataTable yhteys = new DataTable();



    public partial class OppilaitosForm : Form
    {
        public OppilaitosForm()
        {
            InitializeComponent();
        }

        private void OppilaitosForm_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            OppilaitoksetCB.DataSource = oppilaitos;
            OppilaitoksetCB.DisplayMember = "Onimi";
            taytaVastuuHenkilotTaulukko(); 
        }

        private void OppilaitoksetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[OppilaitoksetCB.SelectedIndex]["OID"].ToString();

        }
    }
}
