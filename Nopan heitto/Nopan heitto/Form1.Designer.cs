namespace Nopan_heitto
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
            this.label1 = new System.Windows.Forms.Label();
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.NoppaBT = new System.Windows.Forms.Button();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nopan heitto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::Nopan_heitto.Properties.Resources.dice01;
            this.Noppa01PB.Location = new System.Drawing.Point(12, 94);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(110, 87);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 1;
            this.Noppa01PB.TabStop = false;
            // 
            // NoppaBT
            // 
            this.NoppaBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NoppaBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NoppaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoppaBT.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoppaBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NoppaBT.Location = new System.Drawing.Point(12, 210);
            this.NoppaBT.Name = "NoppaBT";
            this.NoppaBT.Size = new System.Drawing.Size(252, 46);
            this.NoppaBT.TabIndex = 3;
            this.NoppaBT.Text = "Heitä";
            this.NoppaBT.UseVisualStyleBackColor = false;
            this.NoppaBT.Click += new System.EventHandler(this.NoppaBT_Click);
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Nopan_heitto.Properties.Resources.dice01;
            this.Noppa02PB.Location = new System.Drawing.Point(154, 94);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(110, 87);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 4;
            this.Noppa02PB.TabStop = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(291, 304);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.NoppaBT);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Noppa01PB;
        private System.Windows.Forms.Button NoppaBT;
        private System.Windows.Forms.PictureBox Noppa02PB;
        private System.Diagnostics.Process process1;
    }
}

