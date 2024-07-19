using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_KelimeOyunuVersion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "--";
            btn.Size = new Size(90, 90);
            btn.Location = new Point(60, 60);
            btn.Name = "btn0";
            btn.Click += Btn_Click;

            Button btn1 = new Button();
            btn1.Text = "--";
            btn1.Size = new Size(90, 90);
            btn1.Location = new Point(170, 60);
            btn1.Name = "btn1";
            btn1.Click += Btn_Click;

            grpHarfler.Controls.Add(btn);
            grpHarfler.Controls.Add(btn1);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Hangi buton click'lendi?
            Button secilenButon = (Button)sender;
            //secilenButon.BackColor = Color.Green;
            secilenButon.Enabled = false;
            MessageBox.Show("Secilen Buton: " + secilenButon.Name);
        }

        string[] kelimeDizisi = new string[1];
        int sayac = 0;
        string girilenKelime;
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Oyna butonuna bastığımızda textbox'a girilen kelimenin harfleri kadar buton oluşturularak groupbox'a eklenecektir. Aynı zamanda tüm kelimeler string bir dizi içerisinde tutulacaktır.

            try
            {
                if (string.IsNullOrEmpty(txtKelime.Text))
                {
                    throw new Exception("Lütfen bir kelime giriniz.");
                }

                if (Regex.IsMatch(txtKelime.Text, "[^A-Za-z]"))
                {
                    throw new Exception("Lütfen sayısal değerler girmeyiniz.");
                }

                girilenKelime = txtKelime.Text;
                kelimeDizisi[sayac] = girilenKelime;
                sayac++;

                Array.Resize(ref kelimeDizisi, kelimeDizisi.Length + 1);

                ButonlariOlustur(txtKelime.TextLength);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButonlariOlustur(int textLength)
        {
            grpHarfler.Controls.Clear();

            for (int i = 0; i < textLength; i++)
            {
                Button btn = new Button();
                btn.Text = "--";
                btn.Size = new Size(90, 90);
                btn.Location = new Point(60 + (i * 100), 60);
                btn.Name = "btn_" + i;
                btn.Tag = i;
                btn.Click += Btn_Click1;
                grpHarfler.Controls.Add(btn);
            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int hangiIndex = (int)btn.Tag;

            btn.Text = girilenKelime[hangiIndex].ToString().ToUpper();
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
            btn.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
