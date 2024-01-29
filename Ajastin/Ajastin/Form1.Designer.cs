namespace Ajastin
{
    partial class LaskuriForm
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
            this.StopBT = new System.Windows.Forms.Button();
            this.StartBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AikaLB = new System.Windows.Forms.Label();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StopBT
            // 
            this.StopBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StopBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBT.Location = new System.Drawing.Point(114, 197);
            this.StopBT.Margin = new System.Windows.Forms.Padding(6);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(89, 44);
            this.StopBT.TabIndex = 0;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = false;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBT.Location = new System.Drawing.Point(15, 197);
            this.StartBT.Margin = new System.Windows.Forms.Padding(6);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(87, 44);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minuutit:";
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(15, 51);
            this.MinuutitCB.Margin = new System.Windows.Forms.Padding(6);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.Size = new System.Drawing.Size(87, 33);
            this.MinuutitCB.TabIndex = 4;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(114, 51);
            this.SekunnitCB.Margin = new System.Windows.Forms.Padding(6);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.Size = new System.Drawing.Size(89, 33);
            this.SekunnitCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sekunnit: ";
            // 
            // AikaLB
            // 
            this.AikaLB.Location = new System.Drawing.Point(15, 90);
            this.AikaLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(188, 101);
            this.AikaLB.TabIndex = 7;
            // 
            // AjastinTM
            // 
            this.AjastinTM.Enabled = true;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // LaskuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 258);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.StopBT);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LaskuriForm";
            this.Text = "Laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.ComboBox SekunnitCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

