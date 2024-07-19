using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_Degiskenler
{
    public partial class _3_Uygulama1 : Form
    {
        public _3_Uygulama1()
        {
            InitializeComponent();
        }

        private void _3_Uygulama1_Load(object sender, EventArgs e)
        {

            //Tarih İşlemleri
            DateTime tarih = DateTime.Now;

            int year = tarih.Year;
            int month = tarih.Month;
            int day = tarih.Day;

            DateTime yeniTarih = tarih.AddDays(50);
            DateTime newDate= yeniTarih.AddMonths(78);

            lblTarih.Text = tarih.ToString();
            lblTarih.Text = tarih.ToLongDateString();
            lblTarih.Text = tarih.ToShortDateString();

            //Tarih Format Örnekleri:
            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

            lblTarih.Text = tarih.ToString("dddd, dd MMMM yyyy");






        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*
             Form üzerindeki ilgili alanları alarak aşağıdaki şekilde label içerisinde görüntüleyiniz:
            Iphone 14 Pro Max adlı üründen stokta 45 adet bulunmaktadır. Ürün Fiyatı: 78.500 TL dir.
             */

            string urunAdi = txtAd.Text;
            int urunAdedi = Convert.ToInt32(txtAdet.Text);
            double urunFiyati = Convert.ToDouble(txtFiyat.Text);

            lblMesaj.Text = $"{urunAdi} adlı üründen stokta {urunAdedi} adet bulunmaktadır. Ürün Fiyatı: {urunFiyati} TL dir.";
        }
    }
}
