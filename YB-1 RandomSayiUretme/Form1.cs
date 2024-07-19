using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_RandomSayiUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayiListesi = new int[6];
        private void btnOyna_Click(object sender, EventArgs e)
        {
            lstKupon.Items.Clear();

            for (int i = 0; i < sayiListesi.Length; i++)
            {
                //Random rnd = new Random();
                //int rastgeleSayi = rnd.Next(6, 50);

                //random sayıyı üret
                Random rnd = new Random();
                int sayi;
                //dizide olup olmadığı kontrol et
                do
                {
                    sayi = rnd.Next(6, 50);
                    //dizide yoksa diziye ekle
                    //dizide varsa yeni bir random daha yap
                } while (sayiListesi.Contains(sayi));

                sayiListesi[i] = sayi;            
            }

            //tüm sayıları listbox'a ekleyerek göster.
            foreach (var item in sayiListesi)
                lstKupon.Items.Add(item);

        }
    }
}
