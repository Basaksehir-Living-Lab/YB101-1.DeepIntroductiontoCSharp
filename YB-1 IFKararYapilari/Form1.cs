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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             IF KARAR YAPILARI

            Operatörler:
            Karşılaştırma Operatörleri  : <,>,<=,>=,==,!=
            Mantıksal Operatörler       : ve (&,&&) veya (|,||)
            Aritmetik Operatörler       : +, -, *, /, %(mod)
            Aktarma Operatörleri        : =, +=, -=, /=, *=
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //&, && Mantıksal Operatörü

            //Ahmet'in sınıfını geçebilmesi için devamsızlık sayısının 10 günün altında ve not ortalamasının 70'e eşitve üzerinde olması gerekmektedir.


            //int a = 5;

            //if (a>=600 && a%2==0 && a<=6)
            //{
            //    MessageBox.Show("Test");
            //}

            byte devamsizlik = 5;
            byte notOrtalamasi = 89;

            if (devamsizlik < 10 && notOrtalamasi >= 70)
            {
                MessageBox.Show("Sınıfınızı geçtiniz.");
            }
            else
            {
                MessageBox.Show("Kaldınız.");
            }

            //&,&& (ve) operatörü kullanıldığında:
            /*
             true,true > true
             false,true > false
             true, false > false
             false, false > false
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //|, || veya Mantıksal Operatörü

            //Ahmet'in sınıfını geçebilmesi için devamsızlık sayısının 10 günün altında veya not ortalamasının 70'e eşit ve üzerinde olması gerekmektedir.

            //True bloğunun çalışabilmesini için, koşullardan herhangi bir tanesinin gerçekleşmesi (true olması) yeterlidir.
            byte devamsizlik = 5;
            byte notOrtalamasi = 89;

            if (devamsizlik < 10 || notOrtalamasi >= 70)
            {
                MessageBox.Show("Sınıfınızı geçtiniz.");
            }
            else
            {
                MessageBox.Show("Kaldınız.");
            }

            /*
             |,|| veya operatörü:
            true, true > true
            true, false> true
            false,true > true
            false,false> false
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             SWITCH CASE YAPISI
            Belirli bir değişkenin ya da ifadenin farklı değerlerine bağlı olarak farklı işlemler yapılmasını sağlayan bir kontrol yapısıdır.
             */

            int sayi = 100;

            switch (sayi)
            {
                case 100:
                    MessageBox.Show("Sayi 100'e eşittir");
                    break;
                case 500:
                    MessageBox.Show("Sayi 500'e eşittir");
                    break;
                case 50:
                    MessageBox.Show("Sayi 50'e eşittir");
                    break;
                default:
                    MessageBox.Show("Sayı Bulunamadı.");
                    break;

            }
        }
    }
}
