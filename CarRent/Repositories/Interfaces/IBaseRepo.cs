using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRent.Repositories.Interfaces
{
    public interface IBaseRepo<T>
    {
        Task<bool> SaveChangesAsync();
        Task CreateAsync(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate = null);
    }
}
