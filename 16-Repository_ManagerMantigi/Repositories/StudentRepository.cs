using _16_Repository_ManagerMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Repository_ManagerMantigi.Repositories
{
    //Veritabanına bağlanarak tüm CRUD işlemlerimizi yapacak olan sınıf Repository sınıfıdır.
    //StudentRepository sınıfı IRepository interfaceini Student entitysi için implemente etmiştir.
    public class StudentRepository : IRepository<Student>
    {
        private static List<Student> StudentList { get; set; } = new();

        public void Add(Student entity)
        {
            StudentList.Add(entity);
        }

        public void Delete(string id)
        {
            var student = StudentList.FirstOrDefault(s => s.ID == id);
            if (student == null)
                throw new Exception("Öğrenci Bulunamadı.");

            StudentList.Remove(student);
        }

        public List<Student> GetAll()
        {
            return StudentList;
        }

        public Student GetByID(string id)
        {
            var std = StudentList.FirstOrDefault(x => x.ID == id);
            return std ?? throw new Exception("Öğrenci Bulunamadı.");
        }

        public void Update(Student entity)
        {
            var std = StudentList.FirstOrDefault(x => x.ID == entity.ID);
            //std.TC=entity.TC;
            //std.Name=entity.Name;
        }

        public bool IfStudentExists(string TC)
        {
            //any bulursa true, bulamazsa false döner
            return StudentList.Any(s=>s.TC == TC);
        }
    }
}
