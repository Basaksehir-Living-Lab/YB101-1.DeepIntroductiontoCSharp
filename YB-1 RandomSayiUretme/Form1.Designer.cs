namespace YB_1_RandomSayiUretme
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.lstKupon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(12, 290);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(190, 59);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lstKupon
            // 
            this.lstKupon.FormattingEnabled = true;
            this.lstKupon.ItemHeight = 37;
            this.lstKupon.Location = new System.Drawing.Point(12, 12);
            this.lstKupon.Name = "lstKupon";
            this.lstKupon.Size = new System.Drawing.Size(190, 263);
            this.lstKupon.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 364);
            this.Controls.Add(this.lstKupon);
            this.Controls.Add(this.btnOyna);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.ListBox lstKupon;
    }
}

