using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using OnlineStore.Domain.Core.Entities;
using OnlineStore.Infrastructure.Persistance.Configurations;

namespace OnlineStore.Infrastructure.Persistance
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
    }
}
