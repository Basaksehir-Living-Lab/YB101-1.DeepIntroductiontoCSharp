using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Repository_ManagerMantigi.Entities
{
    public class Instructor : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Profession { get; set; }
        public string? PhoneNumber { get; set; }

        //Navigation Property
        public ICollection<Course>? Courses { get; set; }
    }
}
