using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Services.Contracts;
using OnlineStore.Services.Contracts.Orders;
using OnlineStore.Services.Interfaces;

namespace OnlineStore.Infrastructure.Business
{
    class OrderService : RestService<Order>,IOrderService
    {
        public void MakeOrder(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IndexOrderViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
