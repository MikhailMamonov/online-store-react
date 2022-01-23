using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Services.Contracts;
using OnlineStore.Services.Contracts.Products;

namespace OnlineStore.Services.Interfaces
{
    public interface IProductService : IRestService<Product>
    {
    }
}
