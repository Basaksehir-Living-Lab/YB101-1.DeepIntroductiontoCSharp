namespace _16_Repository_ManagerMantigi.Forms
{
    partial class StudentOpt
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
            grpOgrenciBilgileri = new GroupBox();
            chkAktifPasif = new CheckBox();
            btnKaydet = new Button();
            txtDTarihi = new MaskedTextBox();
            txtSoyad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtTC = new TextBox();
            label1 = new Label();
            lstListe = new ListBox();
            btnSil = new Button();
            grpOgrenciBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciBilgileri
            // 
            grpOgrenciBilgileri.Controls.Add(chkAktifPasif);
            grpOgrenciBilgileri.Controls.Add(btnKaydet);
            grpOgrenciBilgileri.Controls.Add(txtDTarihi);
            grpOgrenciBilgileri.Controls.Add(txtSoyad);
            grpOgrenciBilgileri.Controls.Add(label4);
            grpOgrenciBilgileri.Controls.Add(label3);
            grpOgrenciBilgileri.Controls.Add(txtAd);
            grpOgrenciBilgileri.Controls.Add(label2);
            grpOgrenciBilgileri.Controls.Add(txtTC);
            grpOgrenciBilgileri.Controls.Add(label1);
            grpOgrenciBilgileri.Location = new Point(16, 16);
            grpOgrenciBilgileri.Margin = new Padding(4);
            grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            grpOgrenciBilgileri.Padding = new Padding(4);
            grpOgrenciBilgileri.Size = new Size(949, 396);
            grpOgrenciBilgileri.TabIndex = 0;
            grpOgrenciBilgileri.TabStop = false;
            grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // chkAktifPasif
            // 
            chkAktifPasif.AutoSize = true;
            chkAktifPasif.Location = new Point(367, 320);
            chkAktifPasif.Name = "chkAktifPasif";
            chkAktifPasif.Size = new Size(185, 45);
            chkAktifPasif.TabIndex = 5;
            chkAktifPasif.Text = "Aktif / Pasif";
            chkAktifPasif.UseVisualStyleBackColor = true;
            chkAktifPasif.CheckedChanged += chkAktifPasif_CheckedChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(663, 320);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(259, 60);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtDTarihi
            // 
            txtDTarihi.Location = new Point(367, 255);
            txtDTarihi.Margin = new Padding(4);
            txtDTarihi.Mask = "00/00/0000";
            txtDTarihi.Name = "txtDTarihi";
            txtDTarihi.Size = new Size(555, 47);
            txtDTarihi.TabIndex = 2;
            txtDTarihi.ValidatingType = typeof(DateTime);
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(367, 199);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(555, 47);
            txtSoyad.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 261);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 41);
            label4.TabIndex = 0;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 199);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 41);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(367, 143);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(555, 47);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 41);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(367, 87);
            txtTC.Margin = new Padding(4);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(555, 47);
            txtTC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(16, 419);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(922, 204);
            lstListe.TabIndex = 4;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(679, 629);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(259, 60);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // StudentOpt
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(988, 701);
            Controls.Add(btnSil);
            Controls.Add(lstListe);
            Controls.Add(grpOgrenciBilgileri);
            Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            Name = "StudentOpt";
            Text = "StudentOpt";
            Load += StudentOpt_Load;
            grpOgrenciBilgileri.ResumeLayout(false);
            grpOgrenciBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenciBilgileri;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtTC;
        private Label label1;
        private Button btnKaydet;
        private MaskedTextBox txtDTarihi;
        private ListBox lstListe;
        private Label label4;
        private Button btnSil;
        private CheckBox chkAktifPasif;
    }
}