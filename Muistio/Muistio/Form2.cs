﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Muistio
{
    public partial class tietoa : Form
    {
        public tietoa()
        {
            InitializeComponent();
        }

        private void TietoaForm_Load(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();   
            this.ShowDialog();
        }
    }
}
