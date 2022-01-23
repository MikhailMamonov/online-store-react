using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Services.Contracts;

namespace OnlineStore.Services.Interfaces
{
    public interface IOrderService : IRestService<Order>
    {
        public void MakeOrder(Product product);
    }
}
