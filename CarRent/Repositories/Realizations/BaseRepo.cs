using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRent.Repositories.Realizations
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {

        protected CarRentDBContext DBContext { get; set; }
        
        public BaseRepo(CarRentDBContext dbContext)
        {
            DBContext = dbContext;
        }

        public Task<List<T>> GetAllAsync()
        {
            return DBContext.Set<T>().ToListAsync();
        }

        public Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate)
        {
            return DBContext.Set<T>().FirstAsync(predicate);
            
        }
    }
}
