using _18_CourseAppEF.Context;
using _18_CourseAppEF.Entities;

namespace _18_CourseAppEF.Repositories
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
