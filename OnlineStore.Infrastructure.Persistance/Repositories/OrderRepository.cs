using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Interfaces.Base;

namespace OnlineStore.Infrastructure.Persistance.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(EfDbContext dbContext) :base(dbContext)
        {
            
        }
    }
}
