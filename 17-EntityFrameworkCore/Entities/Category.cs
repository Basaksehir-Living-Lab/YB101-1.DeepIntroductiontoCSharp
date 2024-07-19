using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_EntityFrameworkCore.Entities
{
    public class Category
    {
        public Guid CategoryID { get; set; } = Guid.NewGuid();
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        //Navigation Property
        public ICollection<Product>? Products { get; set; }
    }
}
