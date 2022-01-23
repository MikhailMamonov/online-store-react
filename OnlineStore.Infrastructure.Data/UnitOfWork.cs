using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnlineStore.Domain.Core.Repositories;
using OnlineStore.Domain.Core.Repositories.Base;
using OnlineStore.Infrastructure.Data.Repositories;

namespace OnlineStore.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly EfDbContext _dbContext;

        private readonly ILogger _logger;

        public IProductsRepository Products { get; }

        public IOrdersRepository Orders { get; }

        public IShoppingCartItemsRepository ShoppingCartItems { get; }

        public UnitOfWork(EfDbContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _logger = loggerFactory.CreateLogger("logs");
            Products = new ProductsRepository(_dbContext, _logger);
            Orders = new OrdersRepository(_dbContext, _logger);
            ShoppingCartItems = new ShoppingCartItemsRepository(_dbContext, _logger);
        }

        public async Task CompleteAsync()
        {
           await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
        
    }
}
