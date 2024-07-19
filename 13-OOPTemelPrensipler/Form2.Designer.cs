namespace _13_OOPTemelPrensipler
{
    partial class Form2
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
            label1 = new Label();
            cmbKategori = new ComboBox();
            lstListe = new ListBox();
            btnEkle = new Button();
            txtUrunAdi = new TextBox();
            label2 = new Label();
            nmrAdet = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kategorisi";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(39, 49);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(454, 45);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(499, 49);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(454, 263);
            lstListe.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(39, 235);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(454, 69);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Sepete Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(39, 137);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(454, 43);
            txtUrunAdi.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 97);
            label2.Name = "label2";
            label2.Size = new Size(122, 37);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adı";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(317, 186);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(176, 43);
            nmrAdet.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 329);
            Controls.Add(nmrAdet);
            Controls.Add(txtUrunAdi);
            Controls.Add(btnEkle);
            Controls.Add(lstListe);
            Controls.Add(cmbKategori);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKategori;
        private ListBox lstListe;
        private Button btnEkle;
        private TextBox txtUrunAdi;
        private Label label2;
        private NumericUpDown nmrAdet;
    }
}