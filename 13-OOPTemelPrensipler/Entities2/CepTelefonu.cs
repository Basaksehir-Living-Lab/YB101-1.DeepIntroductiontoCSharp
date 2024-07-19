using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPTemelPrensipler.Entities2
{
    //: (iki nokta ile) CepTelefonu sınıfı Urun sınıfından kalıtım almış oldu. (inheritance)
    public class CepTelefonu : Urun
    {
        public byte BataryaSuresi { get; set; }
        public byte RamKapasitesi { get; set; }

    }
}
