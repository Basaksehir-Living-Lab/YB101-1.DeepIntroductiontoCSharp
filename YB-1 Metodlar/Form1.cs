using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             METODLAR:
            Program içerisinde aynı işi yapan satırları belirli bir düzende bir araya getirdiğimiz yapılardır. Gerektiğinde çağırarak tekrar tekrar kullanabiliriz. Metodlar sayesinde kod tekrarı yapmadan daha anlaşılır bir şekilde kodlama yapılabilir. 

            Direkt olarak çalışmazlar, program içerisinde çağrılarak çalışırlar. 

            Metod Türleri:

            1-Geri Değer Dönmeyen Metodlar
                a-Parametreli Metodlar
                b-Parametresiz Metodlar

            2-Geri Değer Dönen Metodlar
                a-Parametreli Metodlar
                b-Parametresiz Metodlar
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //void metod
            //geriye değer dönmez
            MesajVer();
        }

        private void MesajVer()
        {
            MessageBox.Show("Merhaba, Hoş geldiniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SendMessage("İstanbul Egitim Akademi");
            SendMessage("Yetenek Başakşehir Projesi", "İstanbul Eğitim");
        }

        private void SendMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void SendMessage(string mesaj,string baslik)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //burada this keyword'u şuan üzerinde bulunduğumuz formu (Form1) ifade eder. Dolayısı ile bu keyword üzerinden bütün form özellik (property) ve metodlarına ulaşabiliriz.

            RenkDegistir();
        }

        private void RenkDegistir()
        {
            this.BackColor = Color.Coral;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool[] dizi = { true, false, true, false, true, false, true, false, true };

            ResetBoolArray(dizi, false);


        }

        /// <summary>
        /// Diziyi verilen değer kapsamında değerlerle doldurur.
        /// </summary>
        /// <param name="d">Dışarıdan bool bir dizi gönderebilirsiniz.</param>
        /// <param name="deger">true , false değer gönderebilirsiniz.</param>
        private void ResetBoolArray(bool[] d, bool deger)
        {
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = deger;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gelen = MesajGetir();
            string gelenMesaj = MesajGetir("Caner Mollaoğlu");
        }

        private string MesajGetir()
        {
            return "Merhaba, Hoş geldiniz.";
        }

        private string MesajGetir(string adSoyad)
        {
            return $"Merhaba {adSoyad}";
        }
    }
}
