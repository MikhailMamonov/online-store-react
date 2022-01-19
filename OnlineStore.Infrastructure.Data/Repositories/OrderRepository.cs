using Microsoft.Extensions.Logging;
using OnlineShop.Domain.Services.Interfaces;
using OnlineStore.Domain.Core.Entities;

namespace OnlineStore.Infrastructure.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(EfDbContext dbContext, ILogger logger) :base(dbContext, logger)
        {
            
        }
    }
}
