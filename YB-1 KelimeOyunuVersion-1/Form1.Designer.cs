namespace YB_1_KelimeOyunuVersion_1
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
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnOyna = new System.Windows.Forms.Button();
            this.grpHarfler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(19, 66);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(622, 47);
            this.txtKelime.TabIndex = 0;
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(431, 119);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(210, 72);
            this.btnOyna.TabIndex = 1;
            this.btnOyna.Text = "AÇIKLAMA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // grpHarfler
            // 
            this.grpHarfler.Location = new System.Drawing.Point(12, 226);
            this.grpHarfler.Name = "grpHarfler";
            this.grpHarfler.Size = new System.Drawing.Size(1071, 329);
            this.grpHarfler.TabIndex = 2;
            this.grpHarfler.TabStop = false;
            this.grpHarfler.Text = "Harf Tahmini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen bir kelime giriniz.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(189, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(236, 72);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 626);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpHarfler);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.txtKelime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.GroupBox grpHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
    }
}

