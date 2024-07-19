using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_RegularExpressions
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
             Regular Expressions (Düzenli İfadeler) RegEx
            Düzenli ifadeler metinler içerisinde belirli kalıpları bulmak ve değiştirmek için kullanılan dizelerdir. Bir metin içerisindeki örüntüleri tanımlamak için kullanılan özel karakterler ve sembollerin kombinasyonudur.

            https://en.wikipedia.org/wiki/Regular_expression
            https://regexr.com/80bmr

            [0-9]   rakamsal degerler girilsin
            [^0-9]  rakamsal değerler girilmesin
            [a-z]   sadece kucuk harfler
            [A-Z]   sadece buyuk harfler
            [A-Za-z0-9]   alfabetik + sayısal
            [^A-Za-z0-9]   alfabetik + sayısal değerler girilemez
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sadece 0-9 aralığına değerler girilsin.
            //0-9 dışında bir değer girildi ise uyarı ver.

            try
            {
                if (string.IsNullOrEmpty(txtDeger.Text))
                {
                    throw new Exception("Lütfen boş bırakmayınız.");
                }


                if (Regex.IsMatch(txtDeger.Text, "[^0-9]"))
                {
                    throw new Exception("Uygun değer girilmedi.");
                }

                double d=Convert.ToDouble(txtDeger.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtDeger.Text, "[^A-Za-zöşçğiÜÖŞĞİÇ]"))
            //{
            //    MessageBox.Show("Lütfen alfabetik bir değer giriniz.");
            //}

            if (Regex.IsMatch(txtDeger.Text, "[^A-Za-z]"))
            {
                MessageBox.Show("Lütfen türkçe karakter kullanmayınız");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string pattern1 = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string pattern2 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(co|com|org|net|edu|gov|biz|info|io|name{2,})$";


            if (Regex.IsMatch(txtEmail.Text,pattern2))
            {
                MessageBox.Show("Geçerli email adresi");
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi");
            }
        }
    }
}

//11:45 devam ediyoruz.