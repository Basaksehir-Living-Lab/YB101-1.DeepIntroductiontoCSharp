using _18_CourseAppEF.Context;
using _18_CourseAppEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_CourseAppEF.Repositories
{
    public class ExamRepository : GenericRepository<Exam>
    {
        public ExamRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
