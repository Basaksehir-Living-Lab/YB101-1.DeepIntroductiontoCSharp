using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPTemelPrensipler.Entities
{
    public class Customer
    {
        //ctor tab tab

        //CONSTRUCTOR (Yapıcı Metod)

        //public Customer()
        //{
            
        //}
        public Customer(string cname, string phn)
        {
            CustomerName = cname;
            Phone = phn;
            IsActive = true;
        }

        public string CustomerID { get; } = Guid.NewGuid().ToString();
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Country { get; } = "Türkiye";
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }
}
