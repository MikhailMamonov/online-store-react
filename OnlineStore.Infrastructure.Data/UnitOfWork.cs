using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnlineShop.Domain.Services.Interfaces;
using OnlineShop.Domain.Services.Interfaces.Base;
using OnlineStore.Infrastructure.Data.Repositories;

namespace OnlineStore.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly EfDbContext _dbContext;

        private readonly ILogger _logger;

        public IProductRepository Products { get; }

        public IOrderRepository Orders { get; }

        public UnitOfWork(EfDbContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _logger = loggerFactory.CreateLogger("logs");
            Products = new ProductRepository(_dbContext, _logger);
            Orders = new OrderRepository(_dbContext, _logger);
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
