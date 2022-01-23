using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Repositories.Base
{
    public interface IRepository<T>  where T : Entity
    {
        Task<IEnumerable<T>> FindAllAsync();

        Task<T> FindByIdAsync(int id);

        Task<bool> CreateAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);

        Task<bool> CreateAsync(IEnumerable<T> entities);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    }
}