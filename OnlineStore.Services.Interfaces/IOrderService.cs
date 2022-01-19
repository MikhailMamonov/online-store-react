using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;

namespace OnlineStore.Services.Interfaces
{
    public interface IOrderService
    {
        public void MakeOrder(Product product);

        Task<IEnumerable<OrderViewModel>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
