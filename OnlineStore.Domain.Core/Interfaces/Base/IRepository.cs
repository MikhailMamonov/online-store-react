using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OnlineStore.Domain.Core.Entities.Base;

namespace OnlineStore.Domain.Core.Interfaces.Base
{
    public interface IRepository<T> where T : Entity
    {
        public ICollection<T> FindAll();

        public T FindById(int id);

        public T Create(T entity);

        public T Update(T entity);

        public bool Delete(T entity);
    }
}