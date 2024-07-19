using _16_Repository_ManagerMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Repository_ManagerMantigi.Repositories
{
    public class CourseManager : IRepository<Course>
    {
        //readonly _courseRepository adlı fielda sadece bu sınıfın constructor'ı içerisinde atama yapılabilmesi sağlar. Bu sayede field güvenli hale getirilerek korunmuş oluş.
        private readonly CourseRepository _courseRepository;
        public CourseManager(CourseRepository crepo)
        {
            _courseRepository = crepo;
        }


        public void Add(Course entity)
        {
            if (entity == null)
            {
                throw new Exception("Kurs null olmamalıdır.");
            }
            _courseRepository.Add(entity);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id değeri boş veya null olamaz");
            }
            _courseRepository.Delete(id);
        }

        public List<Course>? GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course? GetByID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id değeri boş veya null olamaz");
            }
            return _courseRepository.GetByID(id);
        }

        public void Update(Course entity)
        {
            if (entity != null)
            {
                _courseRepository.Update(entity);
            }
        }
    }
}
