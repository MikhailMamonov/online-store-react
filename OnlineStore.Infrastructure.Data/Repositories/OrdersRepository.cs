using System;
using Microsoft.Extensions.Logging;
using OnlineStore.Domain.Core.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Core.Repositories;

namespace OnlineStore.Infrastructure.Data.Repositories
{
    public class OrdersRepository : BaseRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(EfDbContext dbContext, ILogger logger) :base(dbContext, logger)
        {
            
        }

        public override async Task<IEnumerable<Order>> FindAllAsync()
        {
            try
            {
                return await this._dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} FindAll method error", typeof(OrdersRepository));
                return new List<Order>();
            }
        }

        public override async Task<bool> UpdateAsync(Order entity)
        {
            try
            {
                var existedOrder = await _dbSet.Where(Order => Order.Id == entity.Id)
                    .FirstOrDefaultAsync();
                if (existedOrder == null)
                    return await CreateAsync(entity);

                existedOrder.ZipCode = entity.ZipCode;
                existedOrder.Address = entity.Address;
                existedOrder.City = entity.City;
                existedOrder.Country = entity.Country;
                existedOrder.OrderPlaced = entity.OrderPlaced;
                existedOrder.User = entity.User;
                existedOrder.UserId = entity.UserId;

                return true;

            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} UpdateAsync method error", typeof(OrdersRepository));
                return false;
            }
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var exist = await _dbSet.Where(x => x.Id == id)
                    .FirstOrDefaultAsync();

                if (exist == null) return false;

                _dbSet.Remove(exist);

                return true;

            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} Delete method error", typeof(OrdersRepository));
                return false;
            }
        }
    }
}
