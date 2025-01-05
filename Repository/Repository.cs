using System.Linq.Expressions;
using BarberManagement.data;
using BarberManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberManagement.Repository
{
    public class Repository<T>(AppDbContext context) : IRepository<T> where T : class 
    {
        protected readonly AppDbContext _context = context;

        public IEnumerable<T> GetAll(Expression<Func<T,bool>>? predicate = null){

            if(predicate != null)
            {
                return _context.Set<T>().AsNoTracking().Where(predicate).ToList();
            }

            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T? Get(Expression<Func<T,bool>> predicate){
            return _context.Set<T>().AsNoTracking().FirstOrDefault(predicate);
        }
        
        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}