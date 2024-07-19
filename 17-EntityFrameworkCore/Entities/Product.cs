namespace _17_EntityFrameworkCore.Entities
{
    public class Product
    {
        public Guid ProductID { get; set; } = Guid.NewGuid();
        public string? ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnistInStock { get; set; }
        public bool Discontinued { get; set; }
        public Guid CategoryID { get; set; }

        //Navigation Property
        public Category? Category { get; set; }

    }
}
