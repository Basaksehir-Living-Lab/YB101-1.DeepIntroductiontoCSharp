namespace WindowsFormsApp1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.grpKelime = new System.Windows.Forms.GroupBox();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.flwHarfler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(646, 103);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Kelime Seç ve Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpKelime
            // 
            this.grpKelime.Location = new System.Drawing.Point(12, 152);
            this.grpKelime.Name = "grpKelime";
            this.grpKelime.Size = new System.Drawing.Size(1176, 228);
            this.grpKelime.TabIndex = 7;
            this.grpKelime.TabStop = false;
            this.grpKelime.Text = "Harf Tahmin Oyunu";
            // 
            // lblHak
            // 
            this.lblHak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHak.Location = new System.Drawing.Point(675, 24);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(247, 103);
            this.lblHak.TabIndex = 10;
            this.lblHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDogru
            // 
            this.lblDogru.BackColor = System.Drawing.Color.YellowGreen;
            this.lblDogru.Location = new System.Drawing.Point(928, 24);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(260, 103);
            this.lblDogru.TabIndex = 10;
            this.lblDogru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwHarfler
            // 
            this.flwHarfler.Location = new System.Drawing.Point(12, 386);
            this.flwHarfler.Name = "flwHarfler";
            this.flwHarfler.Size = new System.Drawing.Size(1176, 284);
            this.flwHarfler.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 713);
            this.Controls.Add(this.flwHarfler);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpKelime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpKelime;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.FlowLayoutPanel flwHarfler;
    }
}

