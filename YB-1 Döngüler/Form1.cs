using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_Döngüler
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
             * DRY (don't repeat yourself)
             * 
             DÖNGÜLER
            Program yazarken bazı kodları tekrar tekrar yazıyorsak orada bir hata yapıyoruz demektir. Dolayısı ile bu tarz durumlarda döngü yapılarını kullanıyoruz.

            for, while, do while, foreach
             */


            /*
            FOR DÖNGÜSÜ
            i           : sayac (counter) başlangıc değeri
            i<length    : döngü koşulu
            i++         : sayacın artış değeri (birer birer art)
             */

            //listbox'a ekleme yapmak için:
            //lstListe.Items.Add("1");

            //0,1,2,3,4
            //for (int i = 0; i < 5; i++)
            //{
            //    lstListe.Items.Add(i);
            //}
        }

        string[] kategoriler = new string[] { "Elektronik", "Ev Gereçleri", "Bilgisayar", "Telefon" };
        private void btnDiziOku_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();

            //lstListe.Items.Add(kategoriler[0]);
            //lstListe.Items.Add(kategoriler[1]);
            //lstListe.Items.Add(kategoriler[2]);
            //lstListe.Items.Add(kategoriler[3]);

            int diziUzunlugu = kategoriler.Length;

            for (int i = 0; i < diziUzunlugu; i++)
            {
                lstListe.Items.Add(kategoriler[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;

            while (counter <= 10)
            {
                lstListe.Items.Add(counter);
                counter++;
                //counter = counter + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var tipi atama yapılan tipe dönüşebilen bir değişken türüdür. Karşı taraftan gelecek olan veri türü tam olarak bilinediğinde ya da farklı türler gelebileceği zaman kullanılır.

            int sayac = 1;

            foreach (var item in kategoriler)
            {
                lstListe.Items.Add($"{sayac}.{item}");
                sayac++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DO WHILE
            //Yazdığımız kodlar hiçbir koşul kontrolü yapılmadan önce mutlaka 1 kez çalışır.

            int count = 0;

            do
            {    
                lstListe.Items.Add(count);
                count++;

            } while (count<=10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Continue: Belirli bir koşul çerçevesinde döngüyü bir adım atlatmak için kullanılır.

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==5)
            //    {
            //        continue;
            //    }

            //    lstListe.Items.Add(i);
            //}

            foreach (var item in kategoriler)
            {
                if (item=="Elektronik")
                {
                    continue;
                }
                lstListe.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Break: Belirli bir koşul çerçevesinde döngüyü sonlandırmak için kullanılır.
            for (int i = 0; i < 15; i++)
            {
                if (i==6)
                {
                    break;
                }

                lstListe.Items.Add(i);
            }
        }
    }
}
