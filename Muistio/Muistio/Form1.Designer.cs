﻿namespace Muistio
{
    partial class MuistioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuistioForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tulostuksenEsikatseluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorostusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.kopioiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leikkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TekstiRTB = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.muokkaaToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.lopetaToolStripMenuItem,
            this.tallennaNimellaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tulostuksenEsikatseluToolStripMenuItem,
            this.tulostaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // tallennaNimellaToolStripMenuItem
            // 
            this.tallennaNimellaToolStripMenuItem.Name = "tallennaNimellaToolStripMenuItem";
            this.tallennaNimellaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tallennaNimellaToolStripMenuItem.Text = "Tallenna nimellä...";
            this.tallennaNimellaToolStripMenuItem.Click += new System.EventHandler(this.tallennaNimellaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            this.tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            this.tulostuksenEsikatseluToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            this.tulostuksenEsikatseluToolStripMenuItem.Click += new System.EventHandler(this.tulostuksenEsikatseluToolStripMenuItem_Click);
            // 
            // tulostaToolStripMenuItem
            // 
            this.tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            this.tulostaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tulostaToolStripMenuItem.Text = "Tulosta";
            this.tulostaToolStripMenuItem.Click += new System.EventHandler(this.tulostaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(188, 6);
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem,
            this.tekstinKorostusToolStripMenuItem,
            this.tekstinRivitysToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.muotoileToolStripMenuItem.Text = "&Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            this.kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            this.kirjasinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.kirjasinToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kirjasinToolStripMenuItem.Text = "Kirjasin";
            this.kirjasinToolStripMenuItem.Click += new System.EventHandler(this.kirjasinToolStripMenuItem_Click);
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            this.tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            this.tekstinKorostusToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            this.tekstinKorostusToolStripMenuItem.Click += new System.EventHandler(this.tekstinKorostusToolStripMenuItem_Click);
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            this.tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            this.tekstinRivitysToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            this.tekstinRivitysToolStripMenuItem.Click += new System.EventHandler(this.tekstinRivitysToolStripMenuItem_Click);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.kopioiToolStripMenuItem,
            this.leikkaaToolStripMenuItem,
            this.liitaToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.valitseKaikkiToolStripMenuItem});
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.muokkaaToolStripMenuItem.Text = "&Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            this.kopioiToolStripMenuItem.Enabled = false;
            this.kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            this.kopioiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kopioiToolStripMenuItem.Text = "Kopioi";
            this.kopioiToolStripMenuItem.Click += new System.EventHandler(this.kopioiToolStripMenuItem_Click);
            // 
            // leikkaaToolStripMenuItem
            // 
            this.leikkaaToolStripMenuItem.Enabled = false;
            this.leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            this.leikkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.leikkaaToolStripMenuItem.Text = "Leikkaa";
            this.leikkaaToolStripMenuItem.Click += new System.EventHandler(this.leikkaaToolStripMenuItem_Click);
            // 
            // liitaToolStripMenuItem
            // 
            this.liitaToolStripMenuItem.Name = "liitaToolStripMenuItem";
            this.liitaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.liitaToolStripMenuItem.Text = "Liitä";
            this.liitaToolStripMenuItem.Click += new System.EventHandler(this.liitaToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.poistaToolStripMenuItem.Text = "Poista";
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            this.valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            this.valitseKaikkiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            this.valitseKaikkiToolStripMenuItem.Click += new System.EventHandler(this.valitseKaikkiToolStripMenuItem_Click);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.apuaToolStripMenuItem.Text = "&Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tietoaToolStripMenuItem.Text = "Tietoa";
            this.tietoaToolStripMenuItem.Click += new System.EventHandler(this.tietoaToolStripMenuItem_Click);
            // 
            // TekstiRTB
            // 
            this.TekstiRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekstiRTB.Location = new System.Drawing.Point(0, 24);
            this.TekstiRTB.Name = "TekstiRTB";
            this.TekstiRTB.Size = new System.Drawing.Size(558, 453);
            this.TekstiRTB.TabIndex = 0;
            this.TekstiRTB.Text = "";
            this.TekstiRTB.WordWrap = false;
            this.TekstiRTB.TextChanged += new System.EventHandler(this.TekstiRTB_TextChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MuistioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 477);
            this.Controls.Add(this.TekstiRTB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MuistioForm";
            this.Text = "Muistio";
            this.Load += new System.EventHandler(this.MuistioForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muotoileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirjasinToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TekstiRTB;
        private System.Windows.Forms.ToolStripMenuItem tallennaNimellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tulostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muokkaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopioiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leikkaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

