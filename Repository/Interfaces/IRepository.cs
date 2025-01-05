using System.Linq.Expressions;

namespace BarberManagement.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T,bool>> predicate = null);

        T? Get(Expression<Func<T,bool>> predicate);

        T? Create(T entity);

        T Update(T entity);
    }
}