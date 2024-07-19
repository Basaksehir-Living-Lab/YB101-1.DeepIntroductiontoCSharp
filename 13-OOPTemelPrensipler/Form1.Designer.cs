namespace _13_OOPTemelPrensipler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 31);
            button1.Name = "button1";
            button1.Size = new Size(239, 100);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 137);
            button2.Name = "button2";
            button2.Size = new Size(239, 100);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(293, 31);
            button3.Name = "button3";
            button3.Size = new Size(426, 58);
            button3.TabIndex = 1;
            button3.Text = "Product'ın Değerlerini Oku";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(293, 103);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(426, 43);
            txtProductName.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(293, 152);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(426, 43);
            txtUnitPrice.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(293, 201);
            button4.Name = "button4";
            button4.Size = new Size(426, 78);
            button4.TabIndex = 4;
            button4.Text = "Customer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 520);
            Controls.Add(button4);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private Button button4;
    }
}
