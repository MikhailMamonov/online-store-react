using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Services.Interfaces;

namespace OnlineStore.Infrastructure.Business
{
    public class ServiceManager : IServiceManager
    {
        public IOrderService OrderService { get; }
        public IProductService ProductService { get; }

    }
}
