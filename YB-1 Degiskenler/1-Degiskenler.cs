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
    public partial class _1_Degiskenler : Form
    {
        public _1_Degiskenler()
        {
            InitializeComponent();
        }

        private void _1_Degiskenler_Load(object sender, EventArgs e)
        {
            /*
             Değişkenler (Variables)
            Bilgisayar belleğinde bazı değerleri tutmaya yarayan yapılardır. 
             */

            byte stokMiktari = 34;
            int sayi = 5;
            //constant olarak değer döner. Bu değişkenin max ve min değerlerine ulaşabiliriz.
            const short minimumDeger = short.MinValue;
            const short maximumDeger = short.MinValue;

            float ondalikSayi = 434.34f;
            double sayi2 = 565.34;
            decimal sayi3 = 434.32m;

            bool cevap = true;

            string adSoyad = "Ahmet Duman";
            char cvp = 'E';


            //İsimlendirme standartı olarak camelCase kullanıyoruz.
            //C# Case Sensitive bir dildir. Yani büyük küçük harf duyarlıdır.

            string adresBilgisiDegeri = "Beşiktaş";
            string adresbilgisiDegeri = "İstanbul";




        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Value Type / Reference Type (Değer Tip , Referans Tip)

            C# ta değişkenler iki guruba ayrılır:

            Değer tipli değişkenler (Value Type) : Ram'in stack adlı bölümünde tutulurlar. int, long, double, decimal, char, bool, byte, short
            Referans Tipli Değişkenler (Reference Type): Ram'in Heap adlı bölümünde tutulurlar: string, object, class, interface, array, delegate
            test ediyoruz.
             */


            //Value Type:
            int sayi1 = 45;
            int sayi2 = sayi1;
            sayi1 = 50;

            //Reference Type:
            int[] aDizisi = { 5, 6, 7, 8, 9 };
            int[] bDizisi = aDizisi;
            aDizisi[0] = 123;


        }
    }
}
