using _18_CourseAppEF.Abstractions;
using _18_CourseAppEF.Entities;
using _18_CourseAppEF.Repositories;
using _18_CourseAppEF.Validator;
using FluentValidation.Results;

namespace _18_CourseAppEF.Services
{
    public class StudentService : IService<Student>
    {
        private readonly StudentRepository _studentRepository;
        public StudentService(StudentRepository sRep)
        {
            _studentRepository = sRep;
        }
        public void Add(Student entity)
        {
            StudentValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _studentRepository.Add(entity);
        }

        public void DeleteByID(Guid id)
        {
            throw new Exception();
        }

        public IEnumerable<Student>? GetAll()
        {
            throw new Exception();

        }

        public Student? GetByID(Guid id)
        {
            throw new Exception();

        }

        public void Update(Student entity)
        {
            throw new Exception();

        }
    }
}
