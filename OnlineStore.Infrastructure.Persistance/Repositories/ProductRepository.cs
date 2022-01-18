using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Interfaces.Base;

namespace OnlineStore.Infrastructure.Persistance.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(EfDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
