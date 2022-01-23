using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Core.Entities;

namespace OnlineStore.Services.Interfaces
{
    public interface IShoppingCartService  {
        public string ShoppingCartId { get; set; }

        Task AddToCartAsync(int productId);
        Task RemoveFromCartAsync(int cartItemId);

        public Task<IEnumerable<CartItem>> GetCartItems();

    }
}
