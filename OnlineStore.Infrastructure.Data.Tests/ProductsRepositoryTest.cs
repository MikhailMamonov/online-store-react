using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories.Base;
using Xunit;

namespace OnlineStore.Infrastructure.Data.Tests
{
    public class ProductsRepositoryTest
    {
        private readonly IUnitOfWork inMemoryUnitOfWork;
        private readonly TestHelper helper;

        public ProductsRepositoryTest()
        {
            helper = new TestHelper();
            inMemoryUnitOfWork = helper.GetInMemoryUnitOfWork();
        }

        [Fact]
        public void CreateAsync_RightRecord()
        {
            var mockOrder = helper.GetSingleMockOrder();
            inMemoryUnitOfWork.Orders.CreateAsync(mockOrder).GetAwaiter();
            inMemoryUnitOfWork.CompleteAsync().GetAwaiter();

            var result = inMemoryUnitOfWork.Orders.FindAllAsync().Result.ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);

        }

        [Fact]
        public void CreateAsync_NullCategoryId()
        {
            //Arrange
            Product product = new Product()
            {
                CategoryId = 0,
                Name = "Some name", 
                Description = "kljklm",

            };

            inMemoryUnitOfWork.Products.CreateAsync(product).GetAwaiter();
            inMemoryUnitOfWork.CompleteAsync().GetAwaiter();

            var result = inMemoryUnitOfWork.Products.FindAllAsync().Result.ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Count);

        }

        [Fact]
        public async void CreateAsync_CategoryIdNotExists()
        {
            //Arrange
            Product product = new Product()
            {
                CategoryId = 1,
                Name = "Some name",
                Description = "kljklm",

            };

            await inMemoryUnitOfWork.Products.CreateAsync(product);
            await inMemoryUnitOfWork.CompleteAsync();

            var result = inMemoryUnitOfWork.Products.FindAllAsync().Result.ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Count);

        }


        [Fact]
        public void FindAllAsync_Count()
        {

            ArrangeFillingOrdersDataSet();
            var result = inMemoryUnitOfWork.Orders.FindAllAsync().Result.ToList();

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void FindAsync_Find()
        {
            ArrangeFillingOrdersDataSet();

            var res = inMemoryUnitOfWork.Orders.FindAsync(order => order.ZipCode == "150051").Result.FirstOrDefault();
            Assert.Equal("Yar", res.City);

        }

        [Fact]
        public void FindByIdAsync_RightZipCode()
        {
            ArrangeFillingOrdersDataSet();

            var result = inMemoryUnitOfWork.Orders.FindByIdAsync(2).Result;
            Assert.Contains("150052", result.ZipCode);
        }


        private void ArrangeFillingOrdersDataSet()
        {
            var orders = helper.GetMockOrders();

            inMemoryUnitOfWork.Orders.CreateAsync(orders).GetAwaiter();
            inMemoryUnitOfWork.CompleteAsync().GetAwaiter();
        }
    }
}
