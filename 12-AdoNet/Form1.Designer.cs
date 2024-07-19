namespace _12_AdoNet
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(19, 18);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(391, 69);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Ürünleri Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 39;
            this.lstListe.Location = new System.Drawing.Point(19, 183);
            this.lstListe.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(715, 316);
            this.lstListe.TabIndex = 1;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(423, 18);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(311, 69);
            this.btnKategori.TabIndex = 2;
            this.btnKategori.Text = "Kategorileri Getir";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(763, 18);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(361, 81);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürün Ekleme (Insert)";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 86);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ürün Sil (Delete)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(361, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ürün Güncelle (Update)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(763, 115);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(361, 47);
            this.txtUrunID.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(763, 168);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(361, 47);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(715, 47);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 524);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnGetir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

