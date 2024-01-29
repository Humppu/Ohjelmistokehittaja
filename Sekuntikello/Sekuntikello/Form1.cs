using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekkari
{
    public partial class sekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();


        public sekkariFM()
        {
            InitializeComponent();
        }


        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start(); 
        }

        private void pysaytaBT_Click_1(object sender, EventArgs e)
        {

        }

        private void nollaaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }


        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            kelloLB.Text = String.Format("{00:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}
