namespace YB_1_UrunSiparisFormu
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdKurumsal = new System.Windows.Forms.RadioButton();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lblSepetToplami = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 60);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(552, 45);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 37;
            this.lstListe.Location = new System.Drawing.Point(12, 161);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(552, 189);
            this.lstListe.TabIndex = 2;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Listesi";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(12, 400);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 44);
            this.nmrAdet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adet";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(178, 400);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(386, 44);
            this.txtBirimFiyat.TabIndex = 4;
            this.txtBirimFiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBirimFiyat_KeyDown);
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyat_KeyPress);
            this.txtBirimFiyat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBirimFiyat_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birim Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(19, 496);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(545, 44);
            this.txtToplamTutar.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBireysel);
            this.groupBox1.Controls.Add(this.rdKurumsal);
            this.groupBox1.Location = new System.Drawing.Point(583, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Tipleri";
            // 
            // rdKurumsal
            // 
            this.rdKurumsal.AutoSize = true;
            this.rdKurumsal.Location = new System.Drawing.Point(28, 60);
            this.rdKurumsal.Name = "rdKurumsal";
            this.rdKurumsal.Size = new System.Drawing.Size(274, 41);
            this.rdKurumsal.TabIndex = 0;
            this.rdKurumsal.TabStop = true;
            this.rdKurumsal.Text = "Kurumsal Fatura";
            this.rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(28, 107);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(249, 41);
            this.rbBireysel.TabIndex = 0;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel Fatura";
            this.rbBireysel.UseVisualStyleBackColor = true;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 37;
            this.lstSepet.Location = new System.Drawing.Point(583, 60);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(595, 263);
            this.lstSepet.TabIndex = 2;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(19, 546);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(545, 71);
            this.btnAktar.TabIndex = 6;
            this.btnAktar.Text = "Sepete Ekle >>";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lblSepetToplami
            // 
            this.lblSepetToplami.Location = new System.Drawing.Point(583, 326);
            this.lblSepetToplami.Name = "lblSepetToplami";
            this.lblSepetToplami.Size = new System.Drawing.Size(595, 37);
            this.lblSepetToplami.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 638);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.lblSepetToplami);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.RadioButton rdKurumsal;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label lblSepetToplami;
    }
}

