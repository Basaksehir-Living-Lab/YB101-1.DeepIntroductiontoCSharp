using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPTemelPrensipler.Entities2
{
    //BASE CLASS
    public class Urun
    {
        public Urun()
        {
            ProductID = Guid.NewGuid().ToString();
        }

        public string ProductID { get; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }

        public virtual double KdvHesapla()
        {
            return UnitPrice * 1.18;
        }

        public override string ToString()
        {
            return $"{ProductName} / {UnitPrice} - {Quantity}";
        }
    }
}
