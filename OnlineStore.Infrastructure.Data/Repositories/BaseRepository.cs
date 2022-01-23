using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineStore.Domain.Core.Entities.Base;
using OnlineStore.Domain.Core.Repositories.Base;

namespace OnlineStore.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {
        protected EfDbContext context;

        internal DbSet<T> _dbSet;

        public readonly ILogger _logger;

        public BaseRepository(EfDbContext dbContext, ILogger logger)
        {
            _dbSet = dbContext.Set<T>();
            this.context = dbContext;
            this._logger = logger;
        }


        public virtual Task<IEnumerable<T>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> FindByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<bool> CreateAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            return true;
        }

        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
