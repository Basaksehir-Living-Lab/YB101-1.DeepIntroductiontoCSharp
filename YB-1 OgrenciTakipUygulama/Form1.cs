using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_OgrenciTakipUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Collection 
        //Array (dizi)

        //Dictionary Koleksiyon Yapısı
        //Key (anahtar) ve Value(deger) olarak çalışan bir koleksiyon yapısıdır.
        //key   : string
        //value : double

        //vizenin %40'ı ve final notunun %60 olacak şekilde not ortalaması hesaplayan bir metod yapınız.

        Dictionary<string, double> ogrenciListesi = new Dictionary<string, double>();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //ogrenciListesi["Caner Mollaoğlu"] = 78;

            /*
             Try Catch: Hata kontrol mekanizması olarak kullanılır.
            Try     : tüm islemlerimizi bu blok içerisinde yaparız.
            Catch   : herhangi bir hata meydana gelirse, bu blok çalışır. Burada exception sınıfı üzerinden hata ile ilgili bilgilere ulaşabiliriz.
             */

            try
            {
                if (string.IsNullOrEmpty(txtVize.Text) || string.IsNullOrEmpty(txtFinal.Text) || string.IsNullOrEmpty(txtAdSoyad.Text))
                {
                    throw new Exception("Lütfen tüm alanları doldurunuz.");
                }
                else
                {
                    double vizeNotu = Convert.ToDouble(txtVize.Text);
                    double finalNotu = Convert.ToDouble(txtFinal.Text);
                    string adSoyad = txtAdSoyad.Text;

                    //Ortalamayı Metod ile Hesaplıyoruz:
                    double ortalamaPuan = OrtalamaHesapla(vizeNotu, finalNotu);

                    //Dictionary Yapısına Ekleyelim:
                    ogrenciListesi[adSoyad] = ortalamaPuan;
                    //ogrenciListesi.Add(adSoyad, ortalamaPuan);

                    //Tüm Veriyi Listeye Ekleyelim:
                    ListeyiGuncelle();
                }

                lblHata.Text = "";
                lblHata.BackColor = Control.DefaultBackColor;
            }
            catch (Exception ex)
            {
                lblHata.Text = ex.Message;
                lblHata.BackColor = Color.Coral;
            }
            finally {
                FormuTemizle();
            }
        }

        private void FormuTemizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    //TextBox t = item as TextBox;
                    t.Text = "";
                }
            }
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();

            foreach (var item in ogrenciListesi)
            {
                lstListe.Items.Add($"{item.Key}-{item.Value}");
            }
        }

        private double OrtalamaHesapla(double vizeNotu, double finalNotu)
        {
            return vizeNotu * 0.40 + finalNotu * 0.60;
        }
    }
}
