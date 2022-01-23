using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories.Base;
using OnlineStore.Infrastructure.Data;
using OnlineStore.Services.Interfaces;

namespace OnlineStore.Infrastructure.Business
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly ILogger<IShoppingCartService> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public const string CartSessionKey = "CartId";

        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public ShoppingCartService(EfDbContext context, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork, ILogger<IShoppingCartService> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public string ShoppingCartId { get; set; }

        public async Task AddToCartAsync(int productId)
        {
            ShoppingCartId = GetCartId();
            var cartItem = _unitOfWork.ShoppingCartItems.FindAsync(c => c.CartId == ShoppingCartId
                                                                               && c.ProductId == productId).Result.SingleOrDefault();

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItem
                {
                    ProductId = productId,
                    CartId = ShoppingCartId,
                    Product = await _unitOfWork.Products.FindByIdAsync(productId),
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };

                await _unitOfWork.ShoppingCartItems.CreateAsync(cartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                cartItem.Quantity++;
            }

            await _unitOfWork.CompleteAsync();

        }

        public async Task RemoveFromCartAsync(int cartItemId)
        {
            ShoppingCartId = GetCartId();
            var cartItem =await _unitOfWork.ShoppingCartItems.FindByIdAsync(cartItemId);

            if (cartItem == null)
            {
                _logger.LogInformation("RemoveFromCartAsync method : cartItem with id {cartItemId} not found ", cartItemId);
            }
            else
            {
                await _unitOfWork.ShoppingCartItems.DeleteAsync(cartItemId);
                await _unitOfWork.CompleteAsync();
            }
        }

        //public Task RemoveFromCartAsync(int cartItemId)
        //{
        //    ShoppingCartId = GetCartId();

        //    var cartItem = _unitOfWork.ShoppingCartItems.FindAsync(c => c.CartId == ShoppingCartId
        //                                                                && c.ProductId == cartItemId).Result.SingleOrDefault();

        //    if (cartItem == null)
        //    {
        //        _logger.LogError("{Service} RemoveFromCartAsync method error, cartItem with ProductId {cartItemId} not found", typeof(ShoppingCartService), cartItemId);
        //    }
        //    else
        //    {
        //        _unitOfWork.ShoppingCartItems.
        //    }

        //}

        public async Task<IEnumerable<CartItem>> GetCartItems()
        {
            ShoppingCartId = GetCartId();

            return await _unitOfWork.ShoppingCartItems.FindAsync(
                c => c.CartId == ShoppingCartId);
        }

        public string GetCartId()
        {
            if (_session.GetString(CartSessionKey) == null)
            {
                if (_httpContextAccessor.HttpContext.User.Identity != null && !string.IsNullOrWhiteSpace(_httpContextAccessor.HttpContext.User.Identity.Name))
                {
                    _session.SetString(CartSessionKey, _httpContextAccessor.HttpContext.User.Identity.Name);
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    _session.SetString(CartSessionKey, tempCartId.ToString());
                }
            }
            return _session.Get(CartSessionKey).ToString();
        }

    }
}
