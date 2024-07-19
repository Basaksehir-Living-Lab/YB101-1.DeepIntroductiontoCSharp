namespace YB_1_IFKararYapilari
{
    partial class Uygulama1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.txtCumle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBulDegistir = new System.Windows.Forms.Button();
            this.btnDizideAra = new System.Windows.Forms.Button();
            this.lblAdet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan Harf";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(35, 64);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(211, 44);
            this.txtAranan.TabIndex = 1;
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 37;
            this.lstListe.Location = new System.Drawing.Point(640, 12);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(199, 337);
            this.lstListe.TabIndex = 2;
            // 
            // txtCumle
            // 
            this.txtCumle.Location = new System.Drawing.Point(35, 179);
            this.txtCumle.Name = "txtCumle";
            this.txtCumle.Size = new System.Drawing.Size(567, 44);
            this.txtCumle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cümle";
            // 
            // btnBulDegistir
            // 
            this.btnBulDegistir.Location = new System.Drawing.Point(35, 238);
            this.btnBulDegistir.Name = "btnBulDegistir";
            this.btnBulDegistir.Size = new System.Drawing.Size(285, 48);
            this.btnBulDegistir.TabIndex = 5;
            this.btnBulDegistir.Text = "Bu ve Değiştir";
            this.btnBulDegistir.UseVisualStyleBackColor = true;
            this.btnBulDegistir.Click += new System.EventHandler(this.btnBulDegistir_Click);
            // 
            // btnDizideAra
            // 
            this.btnDizideAra.Location = new System.Drawing.Point(35, 292);
            this.btnDizideAra.Name = "btnDizideAra";
            this.btnDizideAra.Size = new System.Drawing.Size(567, 48);
            this.btnDizideAra.TabIndex = 6;
            this.btnDizideAra.Text = "Dizide Arama Yap";
            this.btnDizideAra.UseVisualStyleBackColor = true;
            this.btnDizideAra.Click += new System.EventHandler(this.btnDizideAra_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.Location = new System.Drawing.Point(272, 64);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(330, 44);
            this.lblAdet.TabIndex = 0;
            // 
            // Uygulama1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 366);
            this.Controls.Add(this.btnDizideAra);
            this.Controls.Add(this.btnBulDegistir);
            this.Controls.Add(this.txtCumle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Uygulama1";
            this.Text = "Uygulama1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.TextBox txtCumle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBulDegistir;
        private System.Windows.Forms.Button btnDizideAra;
        private System.Windows.Forms.Label lblAdet;
    }
}