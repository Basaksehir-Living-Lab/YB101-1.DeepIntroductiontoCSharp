using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YB_1_UrunSiparisFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal[] tutarDizisi = new decimal[1];
        int tutarIndex = 0;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (FaturaTipiSecildiMi())
            {
                //TERNARY IF
                bool hangiFatura = rdKurumsal.Checked ? true : false;
                decimal kdvliTutar;

                if (hangiFatura)
                {
                    //kurumsal fatura
                    kdvliTutar = sonuc * 1.20m;
                }
                else
                {
                    //bireysel fatura
                    kdvliTutar = sonuc * 1.18m;
                }

                //Sepete ekleyelim:
                lstSepet.Items.Add($"{secilenUrunAdi}-{nmrAdet.Value}-{txtBirimFiyat.Text}-{kdvliTutar}");

                tutarDizisi[tutarIndex] = kdvliTutar;
                tutarIndex++;

                lblSepetToplami.Text = ToplamGuncelle().ToString();

                Array.Resize(ref tutarDizisi, tutarDizisi.Length + 1);
            }
            else
            {
                MessageBox.Show("Lütfen fatura tipi seçiniz.");
            }
        }

        private decimal ToplamGuncelle()
        {
            decimal tutar = 0;

            foreach (var item in tutarDizisi)
            {
                tutar += item;
            }

            return tutar;
        }

        private bool FaturaTipiSecildiMi()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rd = item as RadioButton;
                    if (rd.Checked)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //3 satır, 2 sutunluk 2 boyutlu bir bizi yapmış olduk.
        string[,] urunListesi = new string[3, 2];

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriHazirla();
            //KategorileriGetir_GetNames();
            KategorileriGetir_GetValues();
        }

        private void KategorileriGetir_GetValues()
        {
            //byte[] kategoriler = (byte[])Enum.GetValues(typeof(Kategoriler));
            Array kategoriListem = Enum.GetValues(typeof(Kategoriler));

            foreach (var item in kategoriListem)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void KategorileriGetir_GetNames()
        {
            string[] tumKategoriler = Enum.GetNames(typeof(Kategoriler));
            //cmbKategori.DataSource = tumKategoriler;
            foreach (var item in tumKategoriler)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void UrunleriHazirla()
        {
            urunListesi[0, 0] = "1";
            urunListesi[0, 1] = "Cep Telefonu";
            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "Laptop";
            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "Oturma Grubu";
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte secilenID = (byte)cmbKategori.SelectedItem;

            UrunleriListeyeDoldur(secilenID);


        }

        private void UrunleriListeyeDoldur(byte secilenID)
        {
            lstListe.Items.Clear();

            int satirSayisi = urunListesi.GetLength(0); //3 satır
            int sutunSayisi = urunListesi.GetLength(1); //2 sutun


            for (int i = 0; i < satirSayisi; i++)
            {
                if (urunListesi[i, 0] == secilenID.ToString())
                {
                    lstListe.Items.Add(urunListesi[i, 1]);
                }
            }
        }

        decimal sonuc;
        private void txtBirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstListe.SelectedIndex != -1 && nmrAdet.Value != 0 && !string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    sonuc = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text);
                    txtToplamTutar.Text = sonuc.ToString();
                }
            }
        }

        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBirimFiyat_KeyUp(object sender, KeyEventArgs e)
        {

        }

        string secilenUrunAdi;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenUrunAdi = lstListe.SelectedItem.ToString();
            }
        }
    }
}
