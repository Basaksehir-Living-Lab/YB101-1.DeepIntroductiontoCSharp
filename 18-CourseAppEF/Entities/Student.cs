using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_CourseAppEF.Entities
{
    public class Student : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        //public string? FullName => Name + " " + Surname;
        public DateOnly BirthDate { get; set; }
        public string? TCNo { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }
    }
}
