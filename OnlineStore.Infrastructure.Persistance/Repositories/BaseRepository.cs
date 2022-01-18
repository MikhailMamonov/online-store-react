using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Core.Entities.Base;
using OnlineStore.Domain.Core.Interfaces.Base;

namespace OnlineStore.Infrastructure.Persistance.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {
        private readonly DbSet<T> _dbSet;

        public BaseRepository(EfDbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
        }
        public T Create(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            return true;
        }

        public ICollection<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }
    }
}
