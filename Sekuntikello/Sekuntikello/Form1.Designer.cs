namespace Sekkari
{
    partial class sekkariFM
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
            this.components = new System.ComponentModel.Container();
            this.kelloLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.pysaytaBT = new System.Windows.Forms.Button();
            this.nollaaBT = new System.Windows.Forms.Button();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kelloLB
            // 
            this.kelloLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelloLB.Location = new System.Drawing.Point(97, 33);
            this.kelloLB.Name = "kelloLB";
            this.kelloLB.Size = new System.Drawing.Size(460, 145);
            this.kelloLB.TabIndex = 0;
            this.kelloLB.Visible = false;
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kaynnistaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaynnistaBT.Location = new System.Drawing.Point(97, 213);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(75, 23);
            this.kaynnistaBT.TabIndex = 1;
            this.kaynnistaBT.Text = "Start";
            this.kaynnistaBT.UseVisualStyleBackColor = false;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // pysaytaBT
            // 
            this.pysaytaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pysaytaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pysaytaBT.Location = new System.Drawing.Point(297, 213);
            this.pysaytaBT.Name = "pysaytaBT";
            this.pysaytaBT.Size = new System.Drawing.Size(75, 23);
            this.pysaytaBT.TabIndex = 2;
            this.pysaytaBT.Text = "Stop";
            this.pysaytaBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.pysaytaBT.UseVisualStyleBackColor = false;
            this.pysaytaBT.Click += new System.EventHandler(this.pysaytaBT_Click_1);
            // 
            // nollaaBT
            // 
            this.nollaaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nollaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nollaaBT.Location = new System.Drawing.Point(482, 213);
            this.nollaaBT.Name = "nollaaBT";
            this.nollaaBT.Size = new System.Drawing.Size(75, 23);
            this.nollaaBT.TabIndex = 3;
            this.nollaaBT.Text = "Reset";
            this.nollaaBT.UseVisualStyleBackColor = false;
            this.nollaaBT.Click += new System.EventHandler(this.nollaaBT_Click);
            // 
            // ajastinTM
            // 
            this.ajastinTM.Enabled = true;
            // 
            // sekkariFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 322);
            this.Controls.Add(this.kelloLB);
            this.Controls.Add(this.nollaaBT);
            this.Controls.Add(this.pysaytaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Name = "sekkariFM";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label kelloLB;
        private System.Windows.Forms.Button kaynnistaBT;
        private System.Windows.Forms.Button pysaytaBT;
        private System.Windows.Forms.Button nollaaBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}

