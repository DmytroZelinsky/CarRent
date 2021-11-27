using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRent.Repositories.Implementations
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected CarRentDBContext DBContext { get; set; }

        public BaseRepo(CarRentDBContext dbContext)
        {
            DBContext = dbContext;
        }

        public async Task<bool> SaveChangesAsync()
        {
           return  await DBContext.SaveChangesAsync() >= 0;
        }

        public async Task CreateAsync(T entity)
        {
            await DBContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            DBContext.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            DBContext.Set<T>().Update(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await GetQuery(predicate, include).ToListAsync();
        }

        public async Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await GetQuery(predicate, include).FirstAsync();
        }

        private IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            var query = DBContext.Set<T>().AsQueryable();
            if (include != null)
            {
                query = include(query);
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query;
        }
    }
}
