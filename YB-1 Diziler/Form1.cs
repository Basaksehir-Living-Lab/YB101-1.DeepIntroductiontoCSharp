using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_Diziler
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
             Diziler (Arrays) Reference Type

            Dizi içerisinde aynı tipte birden çok değeri tutabilen ve indis(index) numaraları üzerinden bu değerlere ulaşabildiğimiz bir veri yapısıdır. Dizi içerisinde bulunan değerlere o dizinin elemanları denir. 
            Dizi oluşturulduğunda eleman sayısı mutlaka tanımlanmalıdır. 
             */

            //Dizi Oluşturma
            string[] ogrenciBilgisi = new string[5];
            string[] studentInfo = { "Caner", "Kardelen", "Ahmet", "Osman" };

            //Eleman Sayısı : 4
            //İndis Degerleri   : 0, 1, 2, 3 


            //Diziye Değer Atama
            studentInfo[2] = "Kuzey";

            //Diziden Değer Okuma
            int[] ogrenciNotlari = new int[] { 75, 98, 100, 95 };
            int ogrenciNotu = ogrenciNotlari[2];

        }

        string[] ogrenciBilgileri=new string[1];
        int sayac = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
             Her butona basıldığında kullanıcıdan aldığım ad soyad bilgisini diziye ekliyorum.
             */
            string ad = txtName.Text;
            string soyad = txtSurname.Text;
            ogrenciBilgileri[sayac] = $"{ad} {soyad}";
            sayac++;

            //ogrenciBilgileri.Length Length dizinin eleman sayısını geriye integer olarak döner.
            Array.Resize(ref ogrenciBilgileri, ogrenciBilgileri.Length+1);
        }
    }
}
