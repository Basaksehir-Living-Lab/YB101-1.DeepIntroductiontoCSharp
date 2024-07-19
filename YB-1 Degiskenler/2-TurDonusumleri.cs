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
    public partial class _2_TurDonusumleri : Form
    {
        public _2_TurDonusumleri()
        {
            InitializeComponent();
        }

        private void _2_TurDonusumleri_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Tür Dönüşümleri
            string stokMiktari = txtStokMiktari.Text;

            //string to int
            //int yeniStok = Convert.ToInt32(txtStokMiktari.Text);
            int yeniStok1 = Convert.ToInt32(stokMiktari);
            yeniStok1 += 10;

            //int to string
            lblMesaj.Text = $"Yeni Stok Miktarı: {yeniStok1}";
        }
    }
}
