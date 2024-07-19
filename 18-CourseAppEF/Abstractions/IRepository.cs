using _18_CourseAppEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_CourseAppEF.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void DeleteByID(Guid id);
        T? GetByID(Guid id);
        IEnumerable<T>? GetAll();
    }
}
