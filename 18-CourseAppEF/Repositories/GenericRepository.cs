using _18_CourseAppEF.Abstractions;
using _18_CourseAppEF.Context;
using _18_CourseAppEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace _18_CourseAppEF.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteByID(Guid id)
        {
            _dbSet.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetByID(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
