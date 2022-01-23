using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories;

namespace OnlineStore.Infrastructure.Data.Repositories
{
    public class ShoppingCartItemsRepository : BaseRepository<CartItem>, IShoppingCartItemsRepository
    {
        public ShoppingCartItemsRepository(EfDbContext context, ILogger logger) : base(context, logger)
        {
            
        }
        public Task<bool> CreateAsync(CartItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(IEnumerable<CartItem> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> FindAsync(Expression<Func<CartItem, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CartItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
