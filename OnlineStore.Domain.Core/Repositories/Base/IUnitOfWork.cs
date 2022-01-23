using System.Threading.Tasks;

namespace OnlineStore.Domain.Core.Repositories.Base
{
    public interface IUnitOfWork
    {
        IProductsRepository Products { get; }

        IOrdersRepository Orders { get; }

        IShoppingCartItemsRepository ShoppingCartItems { get; }

        Task CompleteAsync();
    }
}
