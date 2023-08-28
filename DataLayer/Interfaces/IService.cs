using System.Linq.Expressions;

namespace DataLayer.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

    }
}
