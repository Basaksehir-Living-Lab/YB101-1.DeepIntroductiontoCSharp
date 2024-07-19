using _13_OOPTemelPrensipler.Entities2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_OOPTemelPrensipler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Add("Cep Telefonu");
            cmbKategori.Items.Add("Gomlek");
        }

        Sepet s = new Sepet();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (secilen == 0)
            {
                //cep telefonu
                CepTelefonu c = new CepTelefonu()
                {
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    RamKapasitesi = 64,
                    BataryaSuresi = 18,
                    Description = "Yeni bir ürün",
                    UnitPrice = 65000
                };

                s.UrunEkle(c);
            }
            else
            {
                //gomlek
                Gomlek g = new Gomlek()
                {
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    Description = "Yeni bir ürün",
                    Beden = "XL",
                    KumasTuru = "Keten",
                    UnitPrice = 4500
                };

                s.UrunEkle(g);
            }

            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();

           var gelenListe= s.TumUrunleriGetir();
           gelenListe.ForEach(x=>lstListe.Items.Add(x));
            
        }

        int secilen;
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cmbKategori.SelectedIndex;
        }
    }
}
