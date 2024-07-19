namespace _13_OOPTemelPrensipler.Entities2
{
    public class Gomlek : Urun
    {
        public string Beden { get; set; }
        public string KumasTuru { get; set; }

        //Polymorphism (Çok Biçimlilik)
        //Base class'ta bulunan KdvHesapla metodu virtual olarak  işaretlendiği için burada override edilerek Gomlek sınıfına göre özelleştirildi.
        public override double KdvHesapla()
        {
            return UnitPrice * 1.20;
        }
    }
}
