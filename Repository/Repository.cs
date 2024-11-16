using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberManagement.Repository.Interfaces;
using BarberManagement.data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BarberManagement.Repository
{
    public class Repository<T>(AppDbContext context) : IRepository<T> where T : class 
    {
        protected readonly AppDbContext _context = context;

        public IEnumerable<T> GetAll(){
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T? Get(Expression<Func<T,bool>> predicate){
            return _context.Set<T>().AsNoTracking().FirstOrDefault(predicate);
        }
        
    }
}