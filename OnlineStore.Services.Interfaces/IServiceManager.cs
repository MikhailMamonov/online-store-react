using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Services.Interfaces
{
    public interface IServiceManager
    {
        IOrderService OrderService { get; }

        IProductService ProductService { get; }
    }
}
