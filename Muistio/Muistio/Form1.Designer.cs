namespace Muistio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TekstiTB = new System.Windows.Forms.RichTextBox();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muotoileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TekstiTB
            // 
            this.TekstiTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekstiTB.Location = new System.Drawing.Point(0, 24);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(558, 453);
            this.TekstiTB.TabIndex = 0;
            this.TekstiTB.Text = "";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.muotoileToolStripMenuItem.Text = "Muotoile";
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
            // MuistioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 477);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.RichTextBox TekstiTB;
    }
}

