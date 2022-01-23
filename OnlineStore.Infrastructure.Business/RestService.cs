using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Services.Interfaces;

namespace OnlineStore.Infrastructure.Business
{
    public class RestService<T> : IRestService<T> where T : class
    {
        public Task<T> CreateAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
