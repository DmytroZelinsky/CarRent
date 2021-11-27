using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
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
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
