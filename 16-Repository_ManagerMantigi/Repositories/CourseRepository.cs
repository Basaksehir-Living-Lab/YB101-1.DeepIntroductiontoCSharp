using _16_Repository_ManagerMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Repository_ManagerMantigi.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private static List<Course> CourseList = new List<Course>();

        public void Add(Course entity)
        {
            CourseList.Add(entity);
        }

        public void Delete(string id)
        {
            CourseList.Remove(GetByID(id));
        }

        public List<Course> GetAll()
        {
            return CourseList;
        }

        public Course? GetByID(string id)
        {
            return CourseList.FirstOrDefault(c => c.ID == id);
        }

        public void Update(Course entity)
        {
            var c = CourseList.FirstOrDefault(c => c.ID == entity.ID);

            if (c != null)
            {
                c.CourseName = entity.CourseName;
                c.StartDate = entity.StartDate;
                c.EndDate = entity.EndDate;
                c.IsActive = entity.IsActive;
            }
        }


    }
}
