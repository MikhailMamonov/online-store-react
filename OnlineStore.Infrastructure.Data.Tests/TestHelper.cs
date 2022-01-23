using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories.Base;
using OnlineStore.Infrastructure.Data.Repositories;

namespace OnlineStore.Infrastructure.Data.Tests
{
    public class TestHelper
    {
        private readonly EfDbContext efDbContext;
        private readonly ILoggerFactory loggerFactory;

        public const string sid = "{CA761232-ED42-11CE-BACD-00AA0057B223}";

        public TestHelper()
        {
            var builder = new DbContextOptionsBuilder<EfDbContext>();
            builder.UseInMemoryDatabase(databaseName: "OnlineStoreDatabase");

            var dbContextOptions = builder.Options;
            efDbContext = new EfDbContext(dbContextOptions);
            // Delete existing db before creating a new one
            efDbContext.Database.EnsureDeleted();
            efDbContext.Database.EnsureCreated();

            loggerFactory =  new NullLoggerFactory();
        }
        
        public IUnitOfWork GetInMemoryUnitOfWork()
        {
            return new UnitOfWork(efDbContext, loggerFactory);
        }

        public IEnumerable<Order> GetMockOrders()
        {
            List<Order> output = new List<Order>
            {
                new Order
                {
                    ZipCode = "150051",
                    City = "Yar",
                    Address = "Papanina street 12 hihu",
                    Country = "RF",
                    Id = 1,
                    OrderPlaced = DateTime.Now,
                    OrderTotal = 56.45M
                },
                new Order
                {
                    ZipCode = "150052",
                    City = "Yar",
                    Address = "Papanina street 12 hihu",
                    Country = "RF",
                    Id = 2,
                    OrderPlaced = DateTime.Now,
                    OrderTotal = 56.45M
                },
                new Order
                {
                    ZipCode = "150053",
                    City = "Yar",
                    Address = "Papanina street 12 hihu",
                    Country = "RF",
                    Id = 3,
                    OrderPlaced = DateTime.Now,
                    OrderTotal = 56.45M
                }
            };

            return output;
        }

        public Order GetSingleMockOrder()
        {
            Order order = new Order()
            {
                ZipCode = "150051",
                City = "Yar",
                Address = "Papanina street 12 hihu",
                Country = "RF",
                Id = 1,
                OrderPlaced = DateTime.Now,
                OrderTotal = 56.45M,
                User = new User() { Id = 1, Email = "bhjbhj@mail.com" }
            };

            return order;
        }

        
    }
}
