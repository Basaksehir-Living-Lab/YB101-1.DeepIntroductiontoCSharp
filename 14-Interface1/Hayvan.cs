using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface1
{
    //Base Class
    public class Hayvan
    {
        public byte Yas { get; set; }
        public string Renk { get; set; }
        public virtual string HareketEt()
        {
            return "Hareket Edebilirim";
        }
    }

    //Child Class
    public class Kopek : Hayvan
    {
        public string Isim { get; set; }

        public override string HareketEt()
        {
            return "Koşabilirim";
        }
    }

    //Child Class
    public class Kartal : Hayvan, IUcabilir
    {
        public byte KanatBoyu { get; set; }
        public byte UcusHizi { get ; set ; }

        public string Uc()
        {
            return "Gündüz ve çok yüksekten uçabilirim.";
        }
    }

    //Child Class
    public class Yarasa : Hayvan,IUcabilir
    {
        public byte GeceGorusMesafesi { get; set; }
        public byte UcusHizi { get ; set ; }

        public string Uc()
        {
            return "Gece Uçabilirim.";
        }
    }


    public interface IUcabilir
    {
        byte UcusHizi { get; set; }
        string Uc();
    }
}
