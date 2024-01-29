﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Muistio
{
    public partial class MuistioForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;


        public MuistioForm()
        {
            InitializeComponent();
        }

        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    MessageBox.Show("Sinun pitää tallentaa ensin!");
                }
                else
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }

            catch (Exception ex)
            { 
                MessageBox.Show("Virhe: " + ex);
            } 
          }

        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*txt) | *.txt|Rikastekstiformaatti (*.rtf) | *.rtf"; 
                    if(saveFileDialog.ShowDialog() == DialogResult.OK) 
                    {
                        File.WriteAllText(saveFileDialog.FileName, TekstiTB.Text); 
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void MuistioForm_Load(object sender, EventArgs e)
        {

        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
