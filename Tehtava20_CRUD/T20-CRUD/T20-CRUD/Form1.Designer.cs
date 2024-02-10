namespace T20_CRUD
{
    partial class Form1
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
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBt = new System.Windows.Forms.Button();
            this.OpiskelijaNumTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(15, 352);
            this.TietotauluDG.Margin = new System.Windows.Forms.Padding(6);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1191, 458);
            this.TietotauluDG.TabIndex = 0;
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SUKUNIMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "PUHELIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "OPISKELIJANRO:";
            // 
            // IdTB
            // 
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTB.Location = new System.Drawing.Point(162, 52);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(232, 33);
            this.IdTB.TabIndex = 10;
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EtunimiTB.Location = new System.Drawing.Point(162, 108);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(233, 33);
            this.EtunimiTB.TabIndex = 11;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SukunimiTB.Location = new System.Drawing.Point(162, 174);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(233, 33);
            this.SukunimiTB.TabIndex = 12;
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TyhjennaBT.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.TyhjennaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TyhjennaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaBT.Location = new System.Drawing.Point(44, 266);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(143, 41);
            this.TyhjennaBT.TabIndex = 13;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = false;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TallennaBT.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.TallennaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TallennaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennaBT.Location = new System.Drawing.Point(252, 266);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(143, 41);
            this.TallennaBT.TabIndex = 14;
            this.TallennaBT.Text = "Tallenna";
            this.TallennaBT.UseVisualStyleBackColor = false;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PaivitaBT.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PaivitaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaivitaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivitaBT.Location = new System.Drawing.Point(466, 266);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(143, 41);
            this.PaivitaBT.TabIndex = 15;
            this.PaivitaBT.Text = "Päivitä";
            this.PaivitaBT.UseVisualStyleBackColor = false;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBt
            // 
            this.PoistaBt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PoistaBt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PoistaBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoistaBt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBt.Location = new System.Drawing.Point(671, 266);
            this.PoistaBt.Name = "PoistaBt";
            this.PoistaBt.Size = new System.Drawing.Size(143, 41);
            this.PoistaBt.TabIndex = 16;
            this.PoistaBt.Text = "Poista";
            this.PoistaBt.UseVisualStyleBackColor = false;
            this.PoistaBt.Click += new System.EventHandler(this.PoistaBt_Click);
            // 
            // OpiskelijaNumTB
            // 
            this.OpiskelijaNumTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpiskelijaNumTB.Location = new System.Drawing.Point(582, 174);
            this.OpiskelijaNumTB.Name = "OpiskelijaNumTB";
            this.OpiskelijaNumTB.Size = new System.Drawing.Size(232, 33);
            this.OpiskelijaNumTB.TabIndex = 17;
            // 
            // EmailTB
            // 
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTB.Location = new System.Drawing.Point(582, 106);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(232, 33);
            this.EmailTB.TabIndex = 18;
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PuhelinTB.Location = new System.Drawing.Point(582, 52);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(232, 33);
            this.PuhelinTB.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 823);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.OpiskelijaNumTB);
            this.Controls.Add(this.PoistaBt);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TietotauluDG);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBt;
        private System.Windows.Forms.TextBox OpiskelijaNumTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PuhelinTB;
    }
}

