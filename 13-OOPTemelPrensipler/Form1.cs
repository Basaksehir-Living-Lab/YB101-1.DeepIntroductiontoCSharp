using _13_OOPTemelPrensipler.Entities;

namespace _13_OOPTemelPrensipler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product p;
        private void Form1_Load(object sender, EventArgs e)
        {
            //string productName = "HP Laptop";
            //double unitPrice = 544545.43;
            //string description = "Güzel ibr ürün";


            //Projemizde bulunan Product adlý sýnýfýn bir instance'ýný (örnek) alalým:
            //Product adlý sýnýftan urun1 isimli bir nesne oluþturuyoruz:

            Product urun1 = new Product();
            urun1.ProductID = 1;
            urun1.ProductName = "Dell Laptop";
            urun1.UnitPrice = 56000.45;
            urun1.Description = "Dell Precision 1 TB SSD Laptop";
            urun1.UnitsInStock = 100;

            urun1.GetAllProducts();
            urun1.UpdatePrice(1, 67000);
            string deger = urun1.SellProduct(1);

            p = new Product()
            {
                ProductID = 2,
                Description = "Açýklama",
                ProductName = "Tost Makinesi",
                UnitsInStock = 1000,
                UnitPrice = 15000
            };

            //GET
            MessageBox.Show(p.ProductName);

            //SET
            p.UnitPrice = 89000;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = "HP Laptop";
            double unitPrice = 544545.43;
            string description = "Güzel ibr ürün";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urunAdi = "Iphone";
            int birimFiyat = 44334;
            string aciklama = "Güzel ürün";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtProductName.Text = p.ProductName;
            txtUnitPrice.Text = p.UnitPrice.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Customer c = new Customer()
            //{
            //    CustomerName = "Ahmet Aksakal",
            //    Email = "a.aksakal@gmail.com",
            //    Phone = "5074344049"
            //};

            Customer c2 = new Customer("Mehmet Uzun", "507435343");
            c2.IsActive = false;
            c2.Email = "m.uzun@gmail.com";
        }
    }
}
