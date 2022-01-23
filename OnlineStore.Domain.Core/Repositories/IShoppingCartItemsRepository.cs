using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories.Base;

namespace OnlineStore.Domain.Core.Repositories
{
    public interface IShoppingCartItemsRepository: IRepository<CartItem>
    {
    }
}
