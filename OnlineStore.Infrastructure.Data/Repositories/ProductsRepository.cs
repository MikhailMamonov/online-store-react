using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories;

namespace OnlineStore.Infrastructure.Data.Repositories
{
    public class ProductsRepository : BaseRepository<Product>, IProductsRepository
    {
        public ProductsRepository(EfDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public override async Task<IEnumerable<Product>> FindAllAsync()
        {
            try
            {
                return await this._dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} FindAll method error", typeof(ProductsRepository));
                return new List<Product>();
            }
        }

        public override async Task<bool> UpdateAsync(Product entity)
        {
            try
            {
                var existedProduct =await _dbSet.Where(product => product.Id == entity.Id)
                    .FirstOrDefaultAsync();
                if (existedProduct == null)
                    return await CreateAsync(entity);
                
                existedProduct.Name = entity.Name;
                existedProduct.Image = entity.Image;
                existedProduct.CategoryId = entity.CategoryId;
                existedProduct.Description = entity.Description;
                existedProduct.Price = entity.Price;
                existedProduct.UnitsInStock = entity.UnitsInStock;

                return true;

            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} UpdateAsync method error", typeof(ProductsRepository));
                return false;
            }
        }

        public override async Task<bool>  DeleteAsync(int id)
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
                _logger.LogError(e, "{Repo} Delete method error", typeof(ProductsRepository));
                return false;
            }
        }
    }
}
