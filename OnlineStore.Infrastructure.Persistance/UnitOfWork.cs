using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Interfaces.Base;

namespace OnlineStore.Infrastructure.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfDbContext _dbContext;

        public UnitOfWork(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
