namespace _16_Repository_ManagerMantigi.Forms
{
    partial class CourseOpt
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
            grpKursBilgi = new GroupBox();
            chkAktifPasif = new CheckBox();
            btnKaydet = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtKursAdi = new TextBox();
            dtBaslangic = new DateTimePicker();
            dtBitis = new DateTimePicker();
            lstListe = new ListBox();
            grpKursBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // grpKursBilgi
            // 
            grpKursBilgi.Controls.Add(chkAktifPasif);
            grpKursBilgi.Controls.Add(btnKaydet);
            grpKursBilgi.Controls.Add(label3);
            grpKursBilgi.Controls.Add(label2);
            grpKursBilgi.Controls.Add(label1);
            grpKursBilgi.Controls.Add(txtKursAdi);
            grpKursBilgi.Controls.Add(dtBaslangic);
            grpKursBilgi.Controls.Add(dtBitis);
            grpKursBilgi.Location = new Point(0, 0);
            grpKursBilgi.Name = "grpKursBilgi";
            grpKursBilgi.Size = new Size(830, 316);
            grpKursBilgi.TabIndex = 0;
            grpKursBilgi.TabStop = false;
            grpKursBilgi.Text = "Kurs Bilgileri";
            // 
            // chkAktifPasif
            // 
            chkAktifPasif.AutoSize = true;
            chkAktifPasif.Location = new Point(279, 257);
            chkAktifPasif.Name = "chkAktifPasif";
            chkAktifPasif.Size = new Size(185, 45);
            chkAktifPasif.TabIndex = 6;
            chkAktifPasif.Text = "Aktif / Pasif";
            chkAktifPasif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(621, 247);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(203, 63);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 189);
            label3.Name = "label3";
            label3.Size = new Size(149, 41);
            label3.TabIndex = 1;
            label3.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 131);
            label2.Name = "label2";
            label2.Size = new Size(218, 41);
            label2.TabIndex = 1;
            label2.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 70);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 1;
            label1.Text = "Kurs Adı";
            // 
            // txtKursAdi
            // 
            txtKursAdi.Location = new Point(279, 70);
            txtKursAdi.Name = "txtKursAdi";
            txtKursAdi.Size = new Size(545, 47);
            txtKursAdi.TabIndex = 2;
            // 
            // dtBaslangic
            // 
            dtBaslangic.Location = new Point(279, 131);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.Size = new Size(545, 47);
            dtBaslangic.TabIndex = 3;
            dtBaslangic.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtBitis
            // 
            dtBitis.Location = new Point(279, 184);
            dtBitis.Name = "dtBitis";
            dtBitis.Size = new Size(545, 47);
            dtBitis.TabIndex = 3;
            dtBitis.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(2, 322);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(828, 204);
            lstListe.TabIndex = 1;
            // 
            // CourseOpt
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(842, 534);
            Controls.Add(lstListe);
            Controls.Add(grpKursBilgi);
            Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            Name = "CourseOpt";
            Text = "CourseOpt";
            Load += CourseOpt_Load;
            grpKursBilgi.ResumeLayout(false);
            grpKursBilgi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKursBilgi;
        private Label label1;
        private TextBox txtKursAdi;
        private DateTimePicker dtBitis;
        private Button btnKaydet;
        private Label label3;
        private Label label2;
        private DateTimePicker dtBaslangic;
        private ListBox lstListe;
        private CheckBox chkAktifPasif;
    }
}