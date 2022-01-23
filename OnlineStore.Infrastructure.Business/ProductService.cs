using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Services.Interfaces;

namespace OnlineStore.Infrastructure.Business
{
    public class ProductService : RestService<Product>,IProductService
    {
    }
}
