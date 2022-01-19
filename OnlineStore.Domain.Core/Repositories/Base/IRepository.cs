using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineShop.Domain.Services.Interfaces.Base
{
    public interface IRepository<T>  where T : Entity
    {
        public Task<IEnumerable<T>> FindAll();

        public Task<T> FindById(int id);

        public Task<bool> Create(T entity);

        public Task<bool> Update(T entity);

        public Task<bool> Delete(int id);

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    }
}