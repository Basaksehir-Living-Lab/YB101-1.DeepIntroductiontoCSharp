using _16_Repository_ManagerMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Repository_ManagerMantigi.Repositories
{
    //StudentManager sınıfı uygulama üzerinden gönderilen StudentRepository nesnesini kendi içerisinde bulunan _studentRepository'ye atayarak kullanır.
    public class StudentManager : IRepository<Student>
    {
        private StudentRepository _studentRepository;
        public StudentManager(StudentRepository sRepo)
        {
            _studentRepository = sRepo;
        }

        public void Add(Student entity)
        {
            if (string.IsNullOrEmpty(entity.Name) && string.IsNullOrEmpty(entity.Surname))
            {
                throw new Exception("Lütfen ad ve soyad alanlarını doldurunuz.");
            }

            if (_studentRepository.IfStudentExists(entity.TC))
            {
                throw new Exception("Bu öğrenci daha önce kayıt edilmiştir.");
            }

            _studentRepository.Add(entity);
        }

        public void Delete(string id)
        {
            var std = _studentRepository.GetByID(id);

            if (std.IsActive)
            {
                throw new Exception("Aktif bir öğrenci silinemez.");
            }

            _studentRepository.Delete(id);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetByID(string id)
        {
            return _studentRepository.GetByID(id);
        }

        public void Update(Student entity)
        {
            if (entity != null)
            {
                _studentRepository.Update(entity);
            }
        }
    }
}
