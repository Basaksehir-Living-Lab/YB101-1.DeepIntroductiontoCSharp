using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] harflerim = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

        string[] iller = { "İSTANBUL", "ADANA", "ANKARA", "ERZURUM", "İZMİR", "MALATYA" };

        string[] secilenIller = new string[1];

        int oyunHakki;
        string secilenKelime;
        private void btnStart_Click(object sender, EventArgs e)
        {
            dogruSayisi = 0;
            DogruGuncelle();

            //Tüm harfleri aktif et:
            foreach (var item in flwHarfler.Controls)
            {
                Button btn = (Button)item;
                btn.Enabled = true;
            }

            //1-Dizinin içerisinden random olarak bir seçim yapalım.
            RandomOlarakBirIlSec();

            //2-Kelimedeki harf sayısı kadar buton ekleyelim.
            ButonlariAyarla();

        }

        private void ButonlariAyarla()
        {
            grpKelime.Controls.Clear();

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(40 + (i * 100), 60);
                btn.Text = "-";
                btn.Tag = i;
                btn.BackColor = Color.White;
                grpKelime.Controls.Add(btn);
            }
        }

        private void RandomOlarakBirIlSec()
        {
            int sayac = 0;
            do
            {

                if (secilenIller.Length == iller.Length)
                {
                    secilenIller = new string[1];
                    sayac = 0;
                }

                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(0, iller.Length);
                secilenKelime = iller[rastgeleSayi];

                //oyunHakkı tanımlayalım.
                oyunHakki = secilenKelime.Length / 2 + 1;

                HakGuncelle();

            } while (secilenIller.Contains(secilenKelime));

            secilenIller[sayac] = secilenKelime;
            sayac++;
            Array.Resize(ref secilenIller, secilenIller.Length + 1);
        }

        private void HakGuncelle()
        {
            lblHak.Text = $"Hak: {oyunHakki}";
        }

        private void AlfabeOlustur()
        {
            //Tüm harfler flowLayoutPanel'e bir buton olarak eklenecektir.

            for (int i = 0; i < harflerim.Length; i++)
            {
                Button btn = new Button();
                btn.Text = harflerim[i].ToString();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(60 + (i * 100), 60);
                btn.Name = "btn_" + i;
                btn.Tag = i;
                btn.Click += Btn_Click;
                flwHarfler.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            if (oyunHakki == 0)
            {
               DialogResult cvp= MessageBox.Show("Yeniden Oynamak İster Misiniz?", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (cvp==DialogResult.No)
                {
                    return;
                }
                else
                {
                    btnStart.PerformClick();
                    return;
                }
            }
            OyunuOynat(sender);
        }

        int dogruSayisi = 0;
        private void OyunuOynat(object sender)
        {
            Button secilenButon = (Button)sender;
            bool buldunMu = false;

            secilenButon.Enabled = false;
            string secilenHarf = secilenButon.Text;

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i].ToString() == secilenButon.Text)
                {
                    grpKelime.Controls[i].Text = secilenButon.Text;
                    dogruSayisi++;


                    DogruGuncelle();
                    buldunMu = true;
                    
                    if (secilenKelime.Length==dogruSayisi)
                    {
                        MessageBox.Show("Kazandınız");
                        break;
                    }
                }
            }

            if (!buldunMu)
            {
                oyunHakki--;
                HakGuncelle();
            }

        }

        private void DogruGuncelle()
        {
            lblDogru.Text = $"Doğru: {dogruSayisi}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlfabeOlustur();
        }
    }
}
