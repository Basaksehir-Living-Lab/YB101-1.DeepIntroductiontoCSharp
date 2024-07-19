using _16_Repository_ManagerMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Repository_ManagerMantigi.Repositories
{
    //where T : class   >>T bir class olmalıdır.
    //where T : BaseEntity >> T BaseEntity türünde bir class olmalıdır.
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        T? GetByID(string id);
        List<T>? GetAll();
    }
}
