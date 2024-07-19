namespace YB_1_OgrenciTakipUygulama
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(22, 373);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(631, 70);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Not Ortalaması Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(22, 61);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(631, 44);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 37;
            this.lstListe.Location = new System.Drawing.Point(22, 215);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(629, 152);
            this.lstListe.TabIndex = 3;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(22, 152);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(301, 44);
            this.txtVize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vize Notu";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(350, 152);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(301, 44);
            this.txtFinal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Notu";
            // 
            // lblHata
            // 
            this.lblHata.Location = new System.Drawing.Point(25, 456);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(626, 49);
            this.lblHata.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 522);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnHesapla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHata;
    }
}

