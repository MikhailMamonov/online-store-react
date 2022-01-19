using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineShop.Domain.Services.Interfaces.Base;
using OnlineStore.Domain.Core.Entities.Base;

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


        public virtual Task<IEnumerable<T>> FindAll()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> FindById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Create(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
