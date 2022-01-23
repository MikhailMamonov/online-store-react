using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Services.Interfaces
{
    public interface IRestService<T> where T : class
    {

        public Task<T> CreateAsync(T model);


        public Task UpdateAsync(T model);


        public Task<T> GetByIdAsync(int id);


        public Task<IEnumerable<T>> GetAllAsync();

        public Task DeleteAsync(int id);


    }
}
