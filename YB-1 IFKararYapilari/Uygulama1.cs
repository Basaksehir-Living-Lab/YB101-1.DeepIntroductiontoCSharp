using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_IFKararYapilari
{
    public partial class Uygulama1 : Form
    {
        public Uygulama1()
        {
            InitializeComponent();
        }
        private void btnBulDegistir_Click(object sender, EventArgs e)
        {
            //Her string ifade aslında bir karakter dizisidir.

            char aranan = Convert.ToChar(txtAranan.Text.ToLower());
            string metin = txtCumle.Text.ToLower();

            char[] dizi = metin.ToCharArray();

            //Metin içerisinde bulunan bütün aranan harfleri X ile değiştirelim:

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan)
                {
                    dizi[i] = 'X';
                }
            }

            txtCumle.Text = new string(dizi);
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {


        }

        private void btnDizideAra_Click(object sender, EventArgs e)
        {
            //contains, index of metodları

            //Index Of metodu bulamazsa -1 döner.
            string[] kursListesi = { "C#", ".NET CORE", "ENTITY FRAMEWORK", "SQL" };

            int index=Array.IndexOf(kursListesi, "SQL");
            int index1=Array.IndexOf(kursListesi, "CODE FIRST");

            lblAdet.Text = $"Bulunan index no:{index}";

            if (index!=-1) //eğer bulunan bir index varsa:
            {
                kursListesi[index] = "Oracle";
            }

            //Contains ile dizi içerisinde aranan değerin bulunup bulunmadığını kontrol edebiliriz. Geriye true, false döner.

            bool sonuc = kursListesi.Contains(".NET CORE");


        }
    }
}
