using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Muistio
{
    public partial class MuistioForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        string tiedostopolku = "";

        public MuistioForm()
        {
            
            InitializeComponent();
        }

        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiRTB.Text))
                {
                    MessageBox.Show("Sinun pitää tallentaa ensin!");
                }
                else
                {
                    TekstiRTB.Text = string.Empty;
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
                if (!string.IsNullOrEmpty(TekstiRTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "TextDocument | *.txt | Rich Text Format | *.rtf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                    {
                        File.WriteAllText(saveFileDialog.FileName, TekstiRTB.Text); 

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TekstiRTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa!: " + ex);
            }
        }

        private void MuistioForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstiRTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstiRTB.Text = ""; 
            }
            else
            {
                TekstiRTB.Text = "";

            }
            UusiTiedosto();
        }


        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
            using (OpenFileDialog atk = new OpenFileDialog()
            {
                Filter = "Rikastekstiformaatti|*.rtf",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if(atk.ShowDialog() == DialogResult.OK)
                {
                    using(StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        TekstiRTB.Rtf = teksti.Result;
                    }
                }
            }


        }


        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
            {
                if (string.IsNullOrEmpty(tiedostopolku))
                {
                    using(SaveFileDialog ttk = new SaveFileDialog()
                    {
                        Filter = "TextDocument | *.txt |Rich Text Format|*.rtf", ValidateNames= true
                    })
                    {
                        if (ttk.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                            tiedosto.WriteLine(this.TekstiRTB.Rtf);
                            tiedosto.Close();
                           
                        }

                        else
                        {
                            using(StreamWriter vk = new StreamWriter(tiedostopolku))
                            {
                                vk.WriteLineAsync(TekstiRTB.Rtf); 
                            }
                        }

                    }
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            {
                Filter = "TextDocument | *.txt |Rich Text Format|*.rtf",
                ValidateNames = true
            })

            if (ttk.ShowDialog() == DialogResult.OK)
            {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstiRTB.Rtf);
                    }
                
            }
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiRTB.Text))
                {
                    TallennaTiedosto();
                }

                else
                {
                    this.Close(); 
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Virhe!: " + ex);
            }


        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstiRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);

        }



        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstiRTB.Text, TekstiRTB.Font, Brushes.Black, 12, 10); 
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Undo();
            TekstiRTB.Redo();
            TekstiRTB.Copy();
            TekstiRTB.Cut();
            TekstiRTB.Paste();
            TekstiRTB.SelectedText = "";
            TekstiRTB.SelectAll();

        }

        private void TekstiRTB_TextChanged(object sender, EventArgs e)
        {

            if(TekstiRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true; 
                leikkaaToolStripMenuItem.Enabled = true;
            }

            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false; 
            }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstiRTB.WordWrap= false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked= true;
                TekstiRTB.WordWrap= true;
            }
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectionBackColor = Color.Yellow;
        }
    }
}
