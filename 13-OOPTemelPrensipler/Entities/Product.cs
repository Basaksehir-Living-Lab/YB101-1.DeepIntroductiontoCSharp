namespace _13_OOPTemelPrensipler.Entities
{
    //public: Access Modifier(Erişim Belirleyici)
    //Her yerden bu sınıfa erişilebilir. 
    //Bulunduğumuz sınıf içerisinden,
    //Aynı assembly(proje) içerisinden,
    //Diğer assemblylerden (projelerden) erişilebilir.

    //public, private, internal, protected, protected internal
    public class Product
    {
        //field (alan)
        private string deger;
        private int stok;

        //property (özellik)
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }

        //method (metod)
        public void GetAllProducts()
        {

        }

        public string SellProduct(int productID)
        {
            return "";
        }

        public void UpdatePrice(int id, double newPrice)
        {

        }
    }
}
