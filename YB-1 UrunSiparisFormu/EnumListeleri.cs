using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB_1_UrunSiparisFormu
{
    /*
     Enumaration (enum) bir türdür ve genelikle gruplandırılması veya birbirine bağlı olması gereken durumlar için kullanılır. Kod okunabilirliğini artırır.

    1-Durumları Belirlerken: (beklemede, tamamlandı, iptal edildi)
    2-Seçeneklerde          : kadın, erkek
    3-Sabitler              : Aylar, haftanın günleri
     */
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum Kategoriler:byte
    {
        Elektronik=1,
        Ev_Eşyaları=2
    }


}
