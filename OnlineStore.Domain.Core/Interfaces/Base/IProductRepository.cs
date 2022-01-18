using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Core.Entities;

namespace OnlineStore.Domain.Core.Interfaces.Base
{
    public interface IProductRepository : IRepository<Product> 
    {
    }
}
