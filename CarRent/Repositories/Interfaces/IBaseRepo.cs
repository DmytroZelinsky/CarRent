using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRent.Repositories.Interfaces
{
    public interface IBaseRepo<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate = null);
    }
}
