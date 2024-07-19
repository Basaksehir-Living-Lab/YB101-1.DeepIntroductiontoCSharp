using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPTemelPrensipler.Entities2
{
    public class Sepet
    {
        public Sepet()
        {
            UrunListesi = new();
        }
        public List<Urun> UrunListesi { get; set; }

        public void UrunEkle(Urun yeniUrun)
        {
            //urun var mı bak,
            //yoksa ekle,
            //varsa adet güncelle

            #region İlkYöntem
            //bool durum = false;

            //foreach (var item in UrunListesi)
            //{
            //    if (item.ProductName == yeniUrun.ProductName)
            //    {
            //        item.Quantity += yeniUrun.Quantity;
            //        durum = true;
            //    }
            //}

            //if (!durum)
            //{
            //    UrunListesi.Add(yeniUrun);
            //}
            #endregion

            #region İkinciYöntem
            var bulunan = UrunListesi.FirstOrDefault(x => x.ProductName == yeniUrun.ProductName);

            if (bulunan != null)
            {
                //adet güncelle
                bulunan.Quantity += yeniUrun.Quantity;
            }
            else
            {
                //ürün yok demektir, ekle
                UrunListesi.Add(yeniUrun);
            }
            #endregion


        }

        public List<Urun> TumUrunleriGetir()
        {
            return UrunListesi;
        }
    }
}
